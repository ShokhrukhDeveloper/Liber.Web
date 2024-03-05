// using System.Linq;
// using Liber.Api.Data;
// using Liber.Api.Entities;
// using Liber.Web.Shared.Book;
// using Microsoft.EntityFrameworkCore;
//
// namespace Liber.Api.Services;
//
// public class BookService : IBookService
// {
//   private readonly ApplicationDbContext _dbContext;
//     private ILogger<BookService> _logger;
//     private readonly IFileService _fileService;
//     private IFormFile _formFile;
//     public BookService(ApplicationDbContext context,ILogger<BookService> logger,IFileService fileService)
//     {
//         _dbContext=context;
//         _logger=logger;
//         _fileService=fileService;
//     }
//     public ValueTask<Result<Entities.Book>> DeleteById(int Id)
//     {
//         throw new NotImplementedException();
//     }
//
//     public async ValueTask<Result<string>> DownloadById(int BookId, int StudentId)
//     {
//         try
//         {   
//             var book = await _dbContext.Books.FirstOrDefaultAsync(d=>d.id==BookId);
//             if (book==null)
//             {
//                 return new(false)
//                 {
//                     ErrorMessage="ma'lumot topilmadi yoki o'chib ketgan"
//                 };
//             }
//             book.downloads++;
//             _ = _dbContext.Books.Update(book);
//             _ = _dbContext.SaveChanges();
//             return new(true)
//             {
//                 Data=book.file
//             };
//             
//
//
//         }
//         catch (Exception e)
//         {
//             _logger.LogError($"Eror occured at {nameof(BookService)} nameof method {nameof(GetById)}\n Error={e}");
//             return new(false){ ErrorMessage = $"Error occured at {nameof(GetById)}" };
//         }
//     }
//
//     public ValueTask<Result<Entities.Book>> EditById(int Id, EditBook book)
//     {
//         throw new NotImplementedException();
//     }
//
//     public async ValueTask<Result<Entities.Book>> GetById(int Id)
//     {
//         try
//         {
//             var result = await _dbContext.Books.Include(i=>i.Images).FirstOrDefaultAsync(e=>e.id==Id);
//             if (result==null)
//             {
//                 return new(false)
//                 {
//                     ErrorMessage="Berilgan Id raqamidagiki kitob toplimadi"
//                 };
//             }
//             result.views++;
//             _ = _dbContext.Books.Update(result);
//             _ = _dbContext.SaveChanges();
//             return new(true)
//             {
//                 Data=result
//             };
//         }
//         catch (Exception e)
//         {
//             _logger.LogError($"Eror occured at {nameof(BookService)} nameof method {nameof(GetById)}\n Error={e}");
//             return new(false){ ErrorMessage = $"Error occured at {nameof(GetById)}" };
//         }
//     }
//
//     public async ValueTask<Result<Entities.Book>> Create(int StudentId, NewBook book)
//     {
//         try
//         {
//             throw new Exception();
//
//             // var subject = await _dbContext.Subjects.Include(i=>i.Category).FirstOrDefaultAsync(e=>e.id==book.subject_id);
//             // if (subject==null)
//             // {
//             //     return new(false)
//             //     {
//             //         ErrorMessage="Berilgan fan bo'yicha ma'lumot topilmadi"
//             //     };   
//             // }
//             // FileResult fr=null; 
//             // if(book.file!=null) fr = await  _fileService.SaveFile(subject.Category!.name+"/"+ subject.name,book.file); 
//             // var result = await _dbContext.Books.AddAsync(
//             //     new Book()
//             // {
//             //     Name=book.Name,
//             //     Description=book.Description,
//             //     category_id=subject.category_id,
//             //     subject_id=subject.id,
//             //     file = fr?.file_path??"#",
//             //     image ="null",
//             //     language_id=book.language_id,
//             //     file_size=fr?.file_size??0,
//             //     file_type=fr?.file_extension??"*",
//             //     user_id=StudentId,
//             //     is_accepted=false,
//             //     views=0,
//             //     downloads=0,
//             //     created_at=DateTime.Now,
//             //     updated_at=null,
//             //     keywords=book.keyword,
//             //     price=book.price
//             //     
//             // });
//             // _dbContext.SaveChanges();
//             // var imges=fr.Images.Select(e=>new Images{BookId=result.Entity.id,Url=e}).ToList();
//             // _dbContext.Images.AddRange(imges);
//             // _dbContext.SaveChanges();
//             //
//             // return new(true)
//             // {
//             //     Data=result.Entity
//             // };
//         }
//         catch (Exception e)
//         {
//             _logger.LogError($"Eror occured at {nameof(BookService)} nameof method {nameof(Create)}\n Error={e}");
//             return new(false){ ErrorMessage = $"Eror occured at {nameof(BookService)} nameof method {nameof(Create)}\n Error={e}"};
//         }
//     }
//
//     public async ValueTask<Result<IEnumerable<Entities.Book>>> Search(string text,int Limit=10,int Page=1)
//     {
//         try
//         {
//             var casvalue = text.ToLower();
//             var query =  _dbContext.Books.Where(s=>s.case_sensitive.Contains(casvalue));
//             var count = query.Count();
//             var total_page = (int)Math.Ceiling(count/(double)Limit);
//             if (!string.IsNullOrEmpty(text))
//             {
//                  var result = await query.Skip((Page-1)*Limit).Take(Limit).ToListAsync();
//                  return new(true)
//                  {
//                     CurrentPageIndex=Page,
//                     PageCount=total_page,
//                     Data=result
//                  };
//             }
//            return new(false)
//            {
//             ErrorMessage="Empty string"
//            };
//             
//         }
//         catch (Exception e)
//         {
//             _logger.LogError($"Eror occured at {nameof(BookService)} nameof method {nameof(Search)}\n Error={e}");
//             return new(false){ ErrorMessage = $"Eror occured at {nameof(BookService)} nameof method {nameof(Create)}\n Error={e}"};
//         }
//     }
//
//     public async ValueTask<Result<IEnumerable<object>>> GetLastAdded(int Limit = 10)
//     {
//         try
//         {
//             var result = await _dbContext.Books.OrderByDescending(o=>o.created_at).Take(Limit).Select(s=>new{
//                 name=s.name,
//                 id=s.id,
//                 category_id=s.category_id,
//                 image=s.image
//             }).ToListAsync();
//             return new(true)
//             {
//                 Data=result
//             };
//         }
//         catch (Exception e)
//         {
//             _logger.LogError($"Eror occured at {nameof(BookService)} nameof method {nameof(GetLastAdded)}\n Error={e}");
//             return new(false){ ErrorMessage = $"Eror occured at {nameof(BookService)} nameof method {nameof(GetLastAdded)}\n Error={e}"};
//         }
//     }
//
//     public async ValueTask<Result<IEnumerable<Entities.Book>>> SearchByCategoryId(int category_id, string text, int Limit = 10, int Page = 1)
//     {
//         try
//         {
//             var casvalue = text.ToLower();
//             var query =  _dbContext.Books.Where(s=>s.case_sensitive.Contains(casvalue)&&category_id==s.category_id);
//             var count = query.Count();
//             var total_page = (int)Math.Ceiling(count/(double)Limit);
//             if (!string.IsNullOrEmpty(text))
//             {
//                  var result = await query.Skip((Page-1)*Limit).Take(Limit).ToListAsync();
//                  return new(true)
//                  {
//                     CurrentPageIndex=Page,
//                     PageCount=total_page,
//                     Data=result
//                  };
//             }
//            return new(false)
//            {
//             ErrorMessage="Empty string"
//            };
//             
//         }
//         catch (Exception e)
//         {
//             _logger.LogError($"Eror occured at {nameof(BookService)} nameof method {nameof(Search)}\n Error={e}");
//             return new(false){ ErrorMessage = $"Eror occured at {nameof(BookService)} nameof method {nameof(SearchByCategoryId)}\n Error={e}"};
//         }
//     }
//
//     public async ValueTask<Result<IEnumerable<Entities.Book>>> SearchBySubjectId(int subject_id, string text, int Limit = 10, int Page = 1)
//     {
//         try
//         {
//             var casvalue = text.ToLower();
//             var query =  _dbContext.Books.Where(s=>s.case_sensitive.Contains(casvalue)&&subject_id==s.subject_id);
//             var count = query.Count();
//             var total_page = (int)Math.Ceiling(count/(double)Limit);
//             if (!string.IsNullOrEmpty(text))
//             {
//                  var result = await query.Skip((Page-1)*Limit).Take(Limit).ToListAsync();
//                  return new(true)
//                  {
//                     CurrentPageIndex=Page,
//                     PageCount=total_page,
//                     Data=result
//                  };
//             }
//            return new(false)
//            {
//             ErrorMessage="Empty string"
//            };
//             
//         }
//         catch (Exception e)
//         {
//             _logger.LogError($"Eror occured at {nameof(BookService)} nameof method {nameof(Search)}\n Error={e}");
//             return new(false){ ErrorMessage = $"Eror occured at {nameof(BookService)} nameof method {nameof(SearchBySubjectId)}\n Error={e}"};
//         }
//     }
//
//     public async ValueTask<Result<IEnumerable<Entities.Book>>> GetLastAddedByCategoryId(int categoryId, int limit = 10, int page = 1)
//     {
//         try
//         {
//             var result = await _dbContext.Books.Where(e=>e.category_id==categoryId).OrderByDescending(o=>o.created_at).Skip((page - 1) * limit).Take(limit).ToListAsync();
//             return new(true)
//             {
//                 CurrentPageIndex=page,
//                 Data=result
//             };
//         }
//         catch (Exception e)
//         {
//             _logger.LogError($"Eror occured at {nameof(BookService)} nameof method {nameof(GetLastAdded)}\n Error={e}");
//             return new(false){ ErrorMessage = $"Eror occured at {nameof(BookService)} nameof method {nameof(GetLastAddedByCategoryId)}\n Error={e}"};
//         }
//     }
//
// }