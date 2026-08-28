using System;

namespace cocbrpcg;

public static class DefaultHelper
{
    public const int DefaultMoveRate = 8;
    public static readonly int[] DefaultCharacteristicValueArray = [ 40, 50, 50, 50, 60, 60, 70, 80 ];
    public static readonly int[] DefaultPersonalInterestSkillBonusArray = [ 20, 20 , 20, 20 ];

    public static int? CalculateBuild(int strength, int size)
    {
        int total = strength + size;

        int? result = total switch
        {
            (> 1) and (< 65) => -2,
            (> 64) and (< 85) => -1,
            (> 84) and (< 125) => 0,
            (> 124) and (< 165) => 1,
            (> 164) and (< 205) => 2,
            _ => null
        };

        return result;
    }

    public static string? CalculateDamageBonus(int strength, int size)
    {
        int total = strength + size;

        string? result = total switch
        {
            (> 1) and (< 65) => "-2",
            (> 64) and (< 85) => "-1",
            (> 84) and (< 125) => "None",
            (> 124) and (< 165) => "1d4",
            (> 164) and (< 205) => "1d6",
            _ => null
        };

        return result;
    }

    public static int CalculateDefaultDodge(int dexterity)
    {
        return (int)Math.Floor(dexterity / 2.0d);
    }
    public static int CalculateDefaultLanguageOwn(int education)
    {
        return education;
    }

    public static int CalculateHitPoints(int size, int constitution)
    {
        double hp = (double)((size + constitution) / 10.0d);
        return (int)Math.Floor(hp);
    }

    public static int CalculateLuck()
    {
        int total = 0;

        int sides = 6;
        int dice = 3;

        Random r = new();
        for (int i = 0; i < dice; i++)
        {
            total += r.Next(1, sides + 1);
        }

        return total * 5;
    }

    public static int CalculateMagicPoints(int power)
    {
        double mp = (double)((power) / 5.0d);
        return (int)Math.Floor(mp);
    }

    public static int CalculateMoveRate()
    {
        return DefaultHelper.DefaultMoveRate;
    }

    public static int CalculateSanityPoints(int power)
    {
        return power;
    }

    // TODO: set this stuff up somewhere/somehow...

    // NOTE: these could be tailored by genre
    // new Skill("Credit Rating", 0, false), // reskin: "Wealth"
    // new Skill("Custom", null, true), // WARN: Custom catch-all
    // new Skill("Dodge", null, false), // SkillValue.CalculateDefaultDodge()
    // new Skill("Fighting (Brawl)", 25, false),
    // new Skill("Firearms (Handgun)", 20, false),
    // new Skill("Firearms (Rifle/Shotgun)", 25, false),
    // new Skill("Language, Other", 1, true),
    // new Skill("Language (Own)", null, false), // SkillValue.CalculateDefaultLanguageOwn()
    // new Skill("Library Use", 20, false), // reskin: "Research"
    // new Skill("Spot Hidden", 25, false), // reskin: "Notice" / "Search" ?

    // new Occupation("Antiquarian", []), // Appraise, Art/Craft, History, Library Use, Other Language, one interpersonal skill (Charm, Fast Talk, Intimidate or Persuade), Spot Hidden, any one other skill
    // new Occupation("Author", []), // Art (literature), History, Library Use, Natural World or Occult, Other Language, Own Language, Psychology, any one other skill
    // new Occupation("Dilettante", []), // Art/Craft, Firearms, Other Language, Ride, one interpersonal skill (Charm, Fast Talk, Intimidate or Persuade), any three other skills
    // new Occupation("Doctor of Medicine", []), // First Aid, Other Language (Latin), Medicine, Psychology, Science (Biology), Science (Pharmacy), any two other skills as acadmeic or personal specialties
    // new Occupation("Journalist", []), // Art/Craft (Photography), History, Library Use, Own Language, one interpersonal skill (Charm, Fast Talk, Intimidate or Persuade), Psychology, any two other skills
    // new Occupation("Police Detective", []), // Art/Craft (Acting) or Disguise, Firearms, Law, Listen, one interpersonal skill (Charm, Fast Talk, Intimidate or Persuade), Psychology, any two other skills
    // new Occupation("Private Investigator", []), // Art/Craft (Photography), Disguise, Law, Library Use, one interpersonal skill (Charm, Fast Talk, Initimidate or Persuade), Psychology, Spot Hidden, and any one other skill
    // new Occupation("Professor", []), // Library Use, Language, Own Language, Psychology, any four other skills as academic or personal specialties
}
