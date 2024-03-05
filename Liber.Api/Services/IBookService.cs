using Liber.Web.Shared.Book;

namespace Liber.Api.Services;

public interface IBookService
{
    ValueTask<Result<Entities.Book>> Create(int studentId,NewBook book);
    ValueTask<Result<Entities.Book>> EditById(int id,EditBook book);
    ValueTask<Result<Entities.Book>> DeleteById(int id);
    ValueTask<Result<Entities.Book>> GetById(int id);
    ValueTask<Result<IEnumerable<Entities.Book>>> Search(string text,int limit=10,int lage=1);
    ValueTask<Result<IEnumerable<Entities.Book>>> SearchByCategoryId(int categoryId,string text,int limit=10,int page=1);
    ValueTask<Result<IEnumerable<Entities.Book>>> SearchBySubjectId(int subjectId,string text,int limit=10,int Page=1);
    ValueTask<Result<IEnumerable<Entities.Book>>> GetLastAddedByCategoryId(int categoryId, int limit=10,int page=1);
    ValueTask<Result<IEnumerable<object>>> GetLastAdded(int limit=10);
    ValueTask<Result<string>> DownloadById(int bookId,int studentId);
}