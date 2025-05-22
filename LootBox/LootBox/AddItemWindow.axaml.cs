using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LootBox.models;
using System.Linq;

namespace LootBox;

public partial class AddItemWindow : Window
{
    public AddItemWindow()
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
        Item item = new Item()
        {
            Name = ItemNameTextBox.Text,
            Id = StaticInfo.Items.OrderBy(x => x.Id).LastOrDefault().Id + 1,
            Description = Description.Text,
            RareId = int.Parse(RareTextBox.Text),
            Cathegory = CathegoryTextBox.Text,
        };

        StaticInfo.Items.Add(item);

        ItemWindow itemWindow = new ItemWindow();
        itemWindow.Show();
        this.Close();
    }
}