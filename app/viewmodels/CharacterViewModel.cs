using cocbrpcg;
using cocbrpcg.Entities;
using System.Collections.Generic;

namespace cocbrpcg.ViewModels;

public class CharacterViewModel
{
    private readonly Character character;

    public List<int> DefaultCharacteristicValueArray
    {
        get => [.. DefaultHelper.DefaultCharacteristicValueArray];
    }

    public CharacterViewModel(Character character)
    {
        this.character = character;
    }

    public Character Character {
        get { return this.character; }
    }

    // TODO: Combat Quick Reference...
}
