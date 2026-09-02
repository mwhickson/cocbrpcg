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

    public static readonly StyledProperty<int> CharacteristicValueHalfProperty =
        AvaloniaProperty.Register<CharacteristicValueInputControl, int>(nameof(CharacteristicValueHalf), 0);

    public static readonly StyledProperty<int> CharacteristicValueFifthProperty =
        AvaloniaProperty.Register<CharacteristicValueInputControl, int>(nameof(CharacteristicValueFifth), 0);

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

    public int CharacteristicValueHalf
    {
       get => this.GetValue(CharacteristicValueHalfProperty);
       set => SetValue(CharacteristicValueHalfProperty, value);
    }

    public int CharacteristicValueFifth
    {
       get => this.GetValue(CharacteristicValueFifthProperty);
       set => SetValue(CharacteristicValueFifthProperty, value);
    }
}
