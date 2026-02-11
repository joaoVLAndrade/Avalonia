using Avalonia.Controls;
using System;

namespace Demo.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Teste_Checked(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Console.WriteLine($"Reference: {sender}");
        }
    }
}