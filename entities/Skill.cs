namespace cocbrpcg.Entities;

public class Skill
{
    private readonly string name;
    private readonly int defaultValue;
    private readonly bool customizable;

    Skill(string name, int defaultValue = 0, bool customizable = false)
    {
        this.name = name;
        this.defaultValue = defaultValue;
        this.customizable = customizable;
    }

    public string Name
    {
        get { return this.name; }
    }

    public int DefaultValue
    {
        get { return this.defaultValue; }
    }

    public bool Customizable
    {
        get { return this.customizable; }
    }
}