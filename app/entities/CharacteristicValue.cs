using System;

namespace cocbrpcg.Entities;

public class CharacteristicValue: IScaledValue
{
    private readonly Characteristic characteristic;
    private readonly int value;

    public CharacteristicValue(Characteristic characteristic, int value)
    {
        this.characteristic = characteristic;
        this.value = value;
    }

    public Characteristic Characteristic
    {
        get { return this.characteristic; }
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
}
