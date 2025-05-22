using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LootBox;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
    }
    private void Admin_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow menuWindow = new MainWindow();
        menuWindow.Show();
        this.Close();
    }

    private void Open_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        OpenLootBoxWindow openLootBoxWindow = new OpenLootBoxWindow();
        openLootBoxWindow.Show();
        this.Close();
    }
}