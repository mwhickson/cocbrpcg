namespace cocbrpcg.Entities;

public class Possession
{
    private readonly string description;

    public Possession(string description)
    {
        this.description = description;
    }

    public string Description
    {
        get { return this.description; }
    }
}