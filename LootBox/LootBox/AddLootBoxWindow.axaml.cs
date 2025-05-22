using Avalonia;
using Avalonia.Automation.Provider;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LootBox.models;
using LootBox.Models;
using System.Linq;

namespace LootBox;

public partial class AddLootBoxWindow : Window
{
    public AddLootBoxWindow()
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
        LootBoxes lootBoxes = new LootBoxes()
        {
            Name = LootBoxNameTextBox.Text,
            Id = StaticInfo.LootBoxes.OrderBy(x => x.Id).LastOrDefault().Id + 1,
            Description = DescriptionNameTextBox.Text,
            Amount = int.Parse(AmountTextBox.Text)
        };

        StaticInfo.LootBoxes.Add(lootBoxes);

        LootBoxWindow lootBoxWindow = new LootBoxWindow();
        lootBoxWindow.Show();
        this.Close();
        }
    }