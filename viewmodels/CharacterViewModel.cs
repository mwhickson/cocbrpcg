using cocbrpcg.Entities;

namespace cocbrpcg.ViewModels;

public class CharacterViewModel
{
    private readonly Character character;

    CharacterViewModel(Character character)
    {
        this.character = character;
    }

    public Character Character {
        get { return this.character; }
    }

    // TODO: Combat Quick Reference...
}