using Avalonia.Controls;
using AvaloniaApplication3.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication3.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private UserControl? _currentPage;

    public MainViewModel()
    {
       
    }

    [RelayCommand]
    private void GoLogin()
    {
        CurrentPage = new LoginPage();
    }
    
    [RelayCommand]
    private void GoRegister()
    {
        CurrentPage = new RegisterPage();
    }
}