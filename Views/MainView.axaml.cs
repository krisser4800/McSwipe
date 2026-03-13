using Avalonia.Controls;
using McSwipe.ViewModels;

namespace McSwipe.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}