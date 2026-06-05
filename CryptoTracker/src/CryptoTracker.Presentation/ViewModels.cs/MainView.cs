using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CryptoTracker.Presentation.Commands;

namespace CryptoTracker.Presentation.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private object _currentViewModel;

    public MainViewModel()
    {
        HomeViewModel = new HomeViewModel();
        SearchViewModel = new SearchViewModel();
        CoinDetailsViewModel = new CoinDetailsViewModel();

        _currentViewModel = HomeViewModel;

        NavigateHomeCommand = new RelayCommand(_ => CurrentViewModel = HomeViewModel);
        NavigateSearchCommand = new RelayCommand(_ => CurrentViewModel = SearchViewModel);
        NavigateDetailsCommand = new RelayCommand(_ => CurrentViewModel = CoinDetailsViewModel);
    }

    public HomeViewModel HomeViewModel { get; }

    public SearchViewModel SearchViewModel { get; }

    public CoinDetailsViewModel CoinDetailsViewModel { get; }

    public object CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            if (_currentViewModel == value)
            {
                return;
            }

            _currentViewModel = value;
            OnPropertyChanged();
        }
    }

    public ICommand NavigateHomeCommand { get; }

    public ICommand NavigateSearchCommand { get; }

    public ICommand NavigateDetailsCommand { get; }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}