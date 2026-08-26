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
            (> 164) and (< 204) => 2,
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
            (> 84) and (< 125) => "auto",
            (> 124) and (< 165) => "1d4",
            (> 164) and (< 204) => "1d6",
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

        return total;
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

    // const Characteristics = [
    //     new Characteristic("Strength", "STR"),
    //     new Characteristic("Constitution", "CON"),
    //     new Characteristic("Power", "POW"),
    //     new Characteristic("Dexterity", "DEX"),
    //     new Characteristic("Appearance", "APP"),
    //     new Characteristic("Size", "SIZ"),
    //     new Characteristic("Intelligence", "INT"),
    //     new Characteristic("Education", "EDU"),
    // ];

    // const SecondaryAttributes = [
    //     new SecondaryAttribute("Damage Bonus", "Damage Bonus"),
    //     new SecondaryAttribute("Build", "Build"),
    //     new SecondaryAttribute("Hit Points", "HP"),
    //     new SecondaryAttribute("Move Rate", "MOV"),
    //     new SecondaryAttribute("Sanity Points", "SAN"),
    //     new SecondaryAttribute("Magic Points", "MP"),
    //     new SecondaryAttribute("Luck", "Luck"),
    // ];

    // // NOTE: these could be tailored by genre
    // const Skills = [
    //     new Skill("Accounting", 5, false),
    //     new Skill("Anthropology", 1, false),
    //     new Skill("Appraise", 5, false),
    //     new Skill("Archaeology", 1, false),
    //     new Skill("Art/Craft", 5, true), // "Art and Craft"
    //     new Skill("Charm", 15, false),
    //     new Skill("Climb", 20, false),
    //     new Skill("Credit Rating", 0, false), // reskin: "Wealth"
    //     new Skill("Cthulhu Mythos", 0, false), // genre-specific
    //     new Skill("Custom", null, true), // WARN: Custom catch-all
    //     new Skill("Disguise", 5, false),
    //     new Skill("Dodge", null, false), // SkillValue.CalculateDefaultDodge()
    //     new Skill("Drive Auto", 20, false), // genre-specific
    //     new Skill("Electrical Repair", 10, false), // genre-specific
    //     new Skill("Fast Talk", 5, false),
    //     new Skill("Fighting", null, true),
    //     // new Skill("Fighting (Brawl)", 25, false),
    //     new Skill("Firearms", null, true), // genre-specific
    //     // new Skill("Firearms (Handgun)", 20, false),
    //     // new Skill("Firearms (Rifle/Shotgun)", 25, false),
    //     new Skill("First Aid", 30, false),
    //     new Skill("History", 5, false),
    //     new Skill("Intimidate", 15, false),
    //     new Skill("Jump", 20, false),
    //     new Skill("Language, Other", 1, true),
    //     // new Skill("Language (Own)", null, false), // SkillValue.CalculateDefaultLanguageOwn()
    //     new Skill("Law", 5, false),
    //     new Skill("Library Use", 20, false), // reskin: "Research"
    //     new Skill("Listen", 20, false),
    //     new Skill("Locksmith", 1, false),
    //     new Skill("Mechanical Repair", 10, false), // genre-specific (sort of)
    //     new Skill("Medicine", 1, false),
    //     new Skill("Natural World", 10, false),
    //     new Skill("Navigate", 10, false),
    //     new Skill("Occult", 5, false), // genre-specific
    //     new Skill("Operate Heavy Machinery", null, false), // genre-specific // NOTE: does not appear on character sheet
    //     new Skill("Persuade", 10, false),
    //     new Skill("Pilot", 1, true),
    //     new Skill("Psychoanalysis", 1, false), // genre-specific
    //     new Skill("Pyschology", 10, false),
    //     new Skill("Ride", 5, false),
    //     new Skill("Science", 1, true),
    //     new Skill("Sleight of Hand", 10, false),
    //     new Skill("Spot Hidden", 25, false), // reskin: "Notice" / "Search" ?
    //     new Skill("Stealth", 20, false),
    //     new Skill("Survival", 10, true),
    //     new Skill("Swim", 20, false),
    //     new Skill("Throw", 20, false),
    //     new Skill("Track", 10, false),
    // ];

    // const Occupations = [
    //     new Occupation("Antiquarian", []), // Appraise, Art/Craft, History, Library Use, Other Language, one interpersonal skill (Charm, Fast Talk, Intimidate or Persuade), Spot Hidden, any one other skill
    //     new Occupation("Author", []), // Art (literature), History, Library Use, Natural World or Occult, Other Language, Own Language, Psychology, any one other skill
    //     new Occupation("Dilettante", []), // Art/Craft, Firearms, Other Language, Ride, one interpersonal skill (Charm, Fast Talk, Intimidate or Persuade), any three other skills
    //     new Occupation("Doctor of Medicine", []), // First Aid, Other Language (Latin), Medicine, Psychology, Science (Biology), Science (Pharmacy), any two other skills as acadmeic or personal specialties
    //     new Occupation("Journalist", []), // Art/Craft (Photography), History, Library Use, Own Language, one interpersonal skill (Charm, Fast Talk, Intimidate or Persuade), Psychology, any two other skills
    //     new Occupation("Police Detective", []), // Art/Craft (Acting) or Disguise, Firearms, Law, Listen, one interpersonal skill (Charm, Fast Talk, Intimidate or Persuade), Psychology, any two other skills
    //     new Occupation("Private Investigator", []), // Art/Craft (Photography), Disguise, Law, Library Use, one interpersonal skill (Charm, Fast Talk, Initimidate or Persuade), Psychology, Spot Hidden, and any one other skill
    //     new Occupation("Professor", []), // Library Use, Language, Own Language, Psychology, any four other skills as academic or personal specialties
    // ];

    // const Conditions = [
    //     new Condition("Temporary Insanity"),
    //     new Condition("Indefinite Insanity"),
    //     new Condition("Major Wound"),
    //     new Condition("Unconscious"),
    //     new Condition("Dying"),
    // ];
}
