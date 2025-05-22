using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LootBox.models;
using System.Linq;

namespace LootBox;

public partial class AddRareWindow : Window
{
    public AddRareWindow()
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

        Rare rare = new Rare()
        {
            Name = RareNameTextBox.Text,
            Id = StaticInfo.Rarity.OrderBy(x => x.Id).LastOrDefault().Id + 1,
            Rate = int.Parse(RateTextBox.Text),
            Color = HexColorTextBox.Text,
        };

        StaticInfo.Rarity.Add(rare);

        RareWindow rareWindow = new RareWindow();
        rareWindow.Show();
        this.Close();
    }
}