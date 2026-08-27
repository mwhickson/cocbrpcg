namespace cocbrpcg.Entities;

public class Occupation
{
    private readonly string name;
    private readonly Skill[] skills;

    public Occupation(string name, Skill[] skills)
    {
        this.name = name;
        this.skills = skills;
    }

    public string Name
    {
        get { return this.name; }
    }

    public Skill[] Skills
    {
        get { return this.skills; }
    }
}