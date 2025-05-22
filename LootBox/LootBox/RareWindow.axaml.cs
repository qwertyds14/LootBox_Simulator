using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LootBox.models;
using System.Collections.Generic;

namespace LootBox;

public partial class RareWindow : Window
{
    public RareWindow()
    {
        InitializeComponent();

        RareListBox.ItemsSource = StaticInfo.Rarity;
    }
    private void Back_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow menuWindow = new MainWindow();
        menuWindow.Show();
        this.Close();
    }
    private void Add_Rare_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AddRareWindow addRareWindow = new AddRareWindow();
        addRareWindow.Show();
        this.Close();
    }

    private void Remove(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var selected = RareListBox.SelectedItem as Rare;
        if (selected != null)
        {

        };
    }

    }