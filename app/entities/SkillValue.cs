using System;

namespace cocbrpcg.Entities;

public class SkillValue: IScaledValue
{
    private readonly Skill skill;
    private readonly int value;
    private readonly string? specialization;

    public SkillValue(Skill skill, int value = 0, string? specialization = null)
    {
        this.skill = skill;
        this.value = value;
        this.specialization = specialization;
    }

    public Skill Skill
    {
        get { return this.skill; }
    }

    public int Value
    {
        get { return this.value; }
    }

    public int Half
    {
        get { return (int)Math.Floor(this.value / 2.0d); }
    }

    public int Fifth
    {
        get { return (int)Math.Floor(this.value / 5.0d); }
    }

    public string? Specialization
    {
        get { return this.specialization; }
    }
}
