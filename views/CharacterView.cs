using cocbrpcg.Entities;

namespace cocbrpcg.Views;

public class CharacterView
{
    private readonly Character character;

    CharacterView(Character character)
    {
        this.character = character;
    }

    public Character Character {
        get { return this.character; }
    }

    // TODO: Combat Quick Reference...
}