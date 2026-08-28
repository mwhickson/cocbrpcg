namespace cocbrpcg.Entities;

public class Character
{
    private string name;
    private string birthplace;
    private string pronouns;
    private Occupation occupation;
    private string residence;
    private string age; // considered int, but "old", "young", "11 and 3/4" seem okay too...
    private object? portrait; // TODO: intended to be image
    private CharacteristicValue[] characteristics;
    private SecondaryAttributeValue[] secondaryAttributes;
    private Condition[] conditions; // FIX: these are toggleable... ConditionValue?
    private SkillValue[] skills;
    private BackstoryEntry[] backstoryEntries;
    private Possession[] possessions; // gear, equipment, etc.

    public Character()
    {
        // TODO:
        this.name = "";
        this.birthplace = "";
        this.pronouns = "";
        this.occupation = new Occupation("", []);
        this.residence = "";
        this.age = "";
        this.portrait = null;
        this.characteristics = [];
        this.secondaryAttributes = [];
        this.conditions = [];
        this.skills = [];
        this.backstoryEntries = [];
        this.possessions = [];
   }

        public string Name { get { return this.name; }}
        public string Birthplace { get { return this.birthplace; }}
        public string Pronouns { get { return this.pronouns; }}
        public Occupation Occupation { get { return this.occupation; }}
        public string Residence { get { return this.residence; }}
        public string Age { get { return this.age; }}
        public object? Portrait { get { return this.portrait; }}
        public CharacteristicValue[] Characteristics { get { return this.characteristics; }}
        public SecondaryAttributeValue[] SecondaryAttributes { get { return this.secondaryAttributes; }}
        public Condition[] Conditions { get { return this.conditions; }}
        public SkillValue[] Skills { get { return this.skills; }}
        public BackstoryEntry[] BackstoryEntries { get { return this.backstoryEntries; }}
        public Possession[] Possessions { get { return this.possessions; }}
}
