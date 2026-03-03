namespace SWENG421_Lab7;

public class Column : IComponent
{
    private List<IComponent> _items = new List<IComponent>();

    public void Add(IComponent item) => _items.Add(item);

    public void Save()     => Console.WriteLine("A column has been saved.");
    public void Retrieve() => Console.WriteLine("A column has been retrieved.");
    public void View()     { foreach (var item in _items) item.View(); }
    public void Edit()     => Console.WriteLine("A column has been edited.");
    public void Delete()   => Console.WriteLine("A column has been deleted.");
}