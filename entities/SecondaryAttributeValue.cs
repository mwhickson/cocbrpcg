using System;

namespace cocbrpcg.Entities;

public class SecondaryAttributeValue: IVariableValue
{
    private readonly SecondaryAttribute attribute;
    private readonly int currentValue;
    private readonly int maximumValue;
    private readonly int minimumValue;

    SecondaryAttributeValue(SecondaryAttribute attribute, int maximumValue, int currentValue, int minimumValue = 0)
    {
        this.attribute = attribute;
        this.currentValue = currentValue;
        this.maximumValue = maximumValue;
        this.minimumValue = minimumValue;
    }

    public SecondaryAttribute Attribute
    {
        get { return this.attribute; }
    }

    public int CurrentValue
    {
        get { return this.currentValue; }
    }

    public int MaximumValue
    {
        get { return this.maximumValue; }
    }

    public int MinimumValue
    {
        get { return this.minimumValue; }
    }
}