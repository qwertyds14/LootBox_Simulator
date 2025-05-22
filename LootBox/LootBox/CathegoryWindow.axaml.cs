using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using LootBox.models;
using System.Collections.Generic;

namespace LootBox;

public partial class CathegoryWindow : Window
{
    public CathegoryWindow()
    {
        InitializeComponent();

        CathegoryListBox.ItemsSource = StaticInfo.Cathegorys;
    }
    private void Back_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow menuWindow = new MainWindow();
        menuWindow.Show();
        this.Close();
    }

    private void Add_Cathegory_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AddCathegory addCathegory = new AddCathegory();
        addCathegory.Show();
        this.Close();
    }

    private void Remove_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var selected = CathegoryListBox.SelectedItem as Cathegory;
        if (selected != null)
        {
            //Cathegory.Remove(selected);
        }
        CathegoryWindow cathegoryWindow = new CathegoryWindow();
        cathegoryWindow.Show();
        this.Close();
    }
}