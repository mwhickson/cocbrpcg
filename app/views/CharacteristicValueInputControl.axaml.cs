using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace cocbrpcg.Views;

public class CharacteristicValueInputControl : TemplatedControl
{
    public static readonly StyledProperty<string> CharacteristicLabelProperty =
        AvaloniaProperty.Register<CharacteristicValueInputControl, string>(nameof(CharacteristicLabel), "XYZ");

    public static readonly StyledProperty<int> CharacteristicValueProperty =
        AvaloniaProperty.Register<CharacteristicValueInputControl, int>(nameof(CharacteristicValue), 0);

    public static readonly StyledProperty<int> CharacteristicValueHardProperty =
        AvaloniaProperty.Register<CharacteristicValueInputControl, int>(nameof(CharacteristicValueHard), 0);

    public static readonly StyledProperty<int> CharacteristicValueExtremeProperty =
        AvaloniaProperty.Register<CharacteristicValueInputControl, int>(nameof(CharacteristicValueExtreme), 0);

    public string CharacteristicLabel
    {
       get => this.GetValue(CharacteristicLabelProperty);
       set => SetValue(CharacteristicLabelProperty, value);
    }

    public int CharacteristicValue
    {
       get => this.GetValue(CharacteristicValueProperty);
       set => SetValue(CharacteristicValueProperty, value);
    }

    public int CharacteristicValueHard // usually half
    {
       get => this.GetValue(CharacteristicValueHardProperty);
       set => SetValue(CharacteristicValueHardProperty, value);
    }

    public int CharacteristicValueExtreme // usually a fifth
    {
       get => this.GetValue(CharacteristicValueExtremeProperty);
       set => SetValue(CharacteristicValueExtremeProperty, value);
    }
}
