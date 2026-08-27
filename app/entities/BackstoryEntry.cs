namespace cocbrpcg.Entities;

public class BackstoryEntry
{
    private readonly string detail;

    public BackstoryEntry(string detail)
    {
        this.detail = detail;
    }

    public string Detail
    {
        get { return this.detail; }
    }
}