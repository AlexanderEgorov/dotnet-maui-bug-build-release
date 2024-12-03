using System.ComponentModel;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace DXMauiApp;

public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
    }
}

public class MyControl : Border {
    public static readonly BindableProperty NullableGridLengthProperty = 
        BindableProperty.Create(nameof(NullableGridLength), typeof(GridLength?), typeof(MyControl), null);
    [TypeConverter(typeof(GridLengthTypeConverter))]
    public GridLength? NullableGridLength { get => (GridLength?)GetValue(NullableGridLengthProperty); set => SetValue(NullableGridLengthProperty, value); }  
}