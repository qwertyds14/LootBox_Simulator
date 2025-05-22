using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LootBox.models;
using System.Collections.Generic;
using System.Linq;

namespace LootBox;

public partial class AddCathegory : Window
{
    public AddCathegory()
    {
        InitializeComponent();

    }
    private void Back_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow menuWindow = new MainWindow();
        menuWindow.Show();
        this.Close();
    }

    private void Save_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Cathegory cathegory = new Cathegory()
        {
            Name = CategoryNameTextBox.Text,
            Id = StaticInfo.Cathegorys.OrderBy(x => x.Id).LastOrDefault().Id + 1
        };

        StaticInfo.Cathegorys.Add(cathegory);

        CathegoryWindow cathegoryWindow = new CathegoryWindow();
        cathegoryWindow.Show();
        this.Close();
    }
}