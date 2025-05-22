using Avalonia.Controls;
using Avalonia.Interactivity;

namespace LootBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cathegory_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CathegoryWindow cathegoryWindow = new CathegoryWindow();
            cathegoryWindow.Show();
            this.Close();
        }
        private void Rare_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            RareWindow rareWindow = new RareWindow();
            rareWindow.Show();
            this.Close();
        }
        private void Item_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ItemWindow itemWindow = new ItemWindow();
            itemWindow.Show();
            this.Close();
        }
        private void LootBox_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            LootBoxWindow lootBoxWindow = new LootBoxWindow();
            lootBoxWindow.Show();
            this.Close();
        }
        private void Back_Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }
    }
}