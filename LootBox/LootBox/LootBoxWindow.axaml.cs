using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using LootBox.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox;

public partial class LootBoxWindow : Window
{
    public LootBoxWindow()
    {
        InitializeComponent();

        LootListBox.ItemsSource = StaticInfo.LootBoxes;

    }

    private void Back_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow menuWindow = new MainWindow();
        menuWindow.Show();
        this.Close();
    }
    private void Add_LootBox_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AddLootBoxWindow addLootBoxWindow = new AddLootBoxWindow();
        addLootBoxWindow.Show();
        this.Close();
    }
    public static bool RemoveItemFromLootBox(int lootBoxId, string itemName)
    {
        var lootBox = StaticInfo.LootBoxes.FirstOrDefault(lb => lb.Id == lootBoxId);
        if (lootBox == null)
            return false;

        var itemToRemove = lootBox.Items.FirstOrDefault(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
        if (itemToRemove == null)
            return false;

        lootBox.Items.Remove(itemToRemove);
        return true;
    }
    private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
    {
        int lootBoxId;
        if (!int.TryParse(LootBoxIdTextBox.Text, out lootBoxId))
            return;

        string itemName = ItemNameTextBox.Text.Trim();

        bool result = RemoveItemFromLootBox(lootBoxId, itemName);
    }

    public static bool AddItemToLootBox(int lootBoxId, string newItemName)
    {
        var lootBox = StaticInfo.LootBoxes.FirstOrDefault(lb => lb.Id == lootBoxId);
        if (lootBox == null)
            return false;

        if (lootBox.Items.Any(i => i.Name.Equals(newItemName, StringComparison.OrdinalIgnoreCase)))
            return false;

        var newItem = new Item { Name = newItemName };
        lootBox.Items.Add(newItem);
        return true;
    }
    private void AddItemButton_Click(object sender, RoutedEventArgs e)
    {
        int lootBoxId;
        if (!int.TryParse(LootBoxIdTextBox.Text, out lootBoxId))
            return;

        string newItemName = ItemNameTextBox.Text.Trim();

        bool result = AddItemToLootBox(lootBoxId, newItemName);
    }

}