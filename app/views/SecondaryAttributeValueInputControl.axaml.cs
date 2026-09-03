using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace cocbrpcg.Views;

public class SecondaryAttributeValueInputControl : TemplatedControl
{
    public static readonly StyledProperty<string> SecondaryAttributeLabelProperty =
        AvaloniaProperty.Register<SecondaryAttributeValueInputControl, string>(nameof(SecondaryAttributeLabel), "XYZ");

    public static readonly StyledProperty<int> SecondaryAttributeValueProperty =
        AvaloniaProperty.Register<SecondaryAttributeValueInputControl, int>(nameof(SecondaryAttributeValue), 0);

    public static readonly StyledProperty<int> SecondaryAttributeValueCurrentProperty =
        AvaloniaProperty.Register<SecondaryAttributeValueInputControl, int>(nameof(SecondaryAttributeValueCurrent), 0);

    public string SecondaryAttributeLabel
    {
       get => this.GetValue(SecondaryAttributeLabelProperty);
       set => SetValue(SecondaryAttributeLabelProperty, value);
    }

    public int SecondaryAttributeValue
    {
       get => this.GetValue(SecondaryAttributeValueProperty);
       set => SetValue(SecondaryAttributeValueProperty, value);
    }

    public int SecondaryAttributeValueCurrent
    {
       get => this.GetValue(SecondaryAttributeValueCurrentProperty);
       set => SetValue(SecondaryAttributeValueCurrentProperty, value);
    }
}
