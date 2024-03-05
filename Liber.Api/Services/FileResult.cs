namespace Liber.Api.Services;

public class FileResult
{
    public long FileDize { get; set; }
    public string FileExtension { get; set; }
    public string FilePath { get; set; }
    public ICollection<string> Images { get; set; }
}