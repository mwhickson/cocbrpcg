namespace cocbrpcg.Entities;

public class Condition
{
    private readonly string name;

    public Condition(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return this.name; }
    }
}