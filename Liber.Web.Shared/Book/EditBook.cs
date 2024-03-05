namespace Liber.Web.Shared.Book;

public class EditBook
{
    public string name { get; set; }
    public string? description { get; set; }
    public int category_id { get; set; }
    public int subject_id { get; set; }
    public string file { get; set; }
    public int image { get; set; }
}