using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LootBox;

public partial class OpenLootBoxWindow : Window
{
    public OpenLootBoxWindow()
    {
        InitializeComponent();
    }
    private void Back_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AuthWindow authWindow = new AuthWindow();
        authWindow.Show();
        this.Close();
    }
}