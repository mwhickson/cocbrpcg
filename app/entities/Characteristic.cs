namespace cocbrpcg.Entities;

public class Characteristic : ICodedName
{
    private readonly string name;
    private readonly string code;

    public Characteristic(string name, string code)
    {
        this.name = name;
        this.code = code;
    }

    public string Name
    {
        get { return this.name; }
    }

    public string Code
    {
        get { return this.code; }
    }
}
