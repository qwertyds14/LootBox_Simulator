using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LootBox.models;
using System.Collections.Generic;

namespace LootBox;

public partial class ItemWindow : Window
{
    public ItemWindow()
    {
        InitializeComponent();

        ItemListBox.ItemsSource = StaticInfo.Items;
    }
    private void Back_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow menuWindow = new MainWindow();
        menuWindow.Show();
        this.Close();
    }

    private void Add_Item_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AddItemWindow addItemWindow = new AddItemWindow();
        addItemWindow.Show();
        this.Close();
    }

}