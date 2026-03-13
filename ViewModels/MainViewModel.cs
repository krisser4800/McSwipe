using ReactiveUI;
using System.Collections.ObjectModel;

namespace McSwipe.ViewModels;

public class MainViewModel : ReactiveObject
{
    public ObservableCollection<Burger> Burgers { get; } = new()
    {
        new Burger
        {
            Name = "Big Mac",
            Description = "Classic beef burger",
            Price = 39,
            Image = "avares://McSwipe/Assets/bigmac.png?assembly=McSwipe"
        },
        new Burger
        {
            Name = "McChicken",
            Description = "Crispy chicken with mayo",
            Price = 35,
            Image = "avares://McSwipe/Assets/mcchicken.png?assembly=McSwipe"
        },
        new Burger
        {
            Name = "McPlant",
            Description = "Plant-based deliciousness",
            Price = 42,
            Image = "avares://McSwipe/Assets/mcplant.png?assembly=McSwipe"
        }
    };

    private int _index = 0;

    public Burger Current => Burgers[_index];

    public void SwipeLeft() => Next();
    public void SwipeRight() => Next();

    private void Next()
    {
        _index = (_index + 1) % Burgers.Count;
        this.RaisePropertyChanged(nameof(Current));
    }
}