using System.Collections.ObjectModel;
using CryptoTracker.Application.Models;

namespace CryptoTracker.Presentation.ViewModels;

public class HomeViewModel
{
    public ObservableCollection<Coin> Coins { get; } = new();
}