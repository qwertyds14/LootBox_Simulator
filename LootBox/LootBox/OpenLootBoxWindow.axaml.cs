using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using LootBox.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace LootBox;

public partial class OpenLootBoxWindow : Window
{
    public OpenLootBoxWindow()
    {
        InitializeComponent();

        LootListBox.ItemsSource = StaticInfo.LootBoxes;
    }
    private void Back_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        AuthWindow authWindow = new AuthWindow();
        authWindow.Show();
        this.Close();
    }
    public ObservableCollection<LootBoxes> LootBoxes { get; set; }
    public LootBoxes SelectedLootBox { get; set; }

    private void OpenLootBox_Click(object sender, RoutedEventArgs e)
    {
        string idText = IdInputTextBox.Text.Trim();

        if (string.IsNullOrEmpty(idText))
        {
            ResultTextBlock.Text = "Пожалуйста, введите ID бокса";
            return;
        }

        if (!int.TryParse(idText, out int id))
        {
            ResultTextBlock.Text = "ID должен быть числом";
            return;
        }

        var lootBox = StaticInfo.LootBoxes.FirstOrDefault(lb => lb.Id == id);
        if (lootBox == null)
        {
            ResultTextBlock.Text = "Бокс с таким ID не найден";
            return;
        }

        var item = LootBoxService.OpenLootBox(lootBox);
        if (item != null)
        {
            ResultTextBlock.Text = $"Выпал предмет: {item.Name}";
        }
        else
        {
            ResultTextBlock.Text = "Предмет не найден или бокc пуст";
        }
    }


}