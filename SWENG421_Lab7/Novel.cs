namespace SWENG421_Lab7;

public class Novel : IComponent
{
    private List<Page> _pages = new List<Page>();

    public void Add(Page page) => _pages.Add(page);

    public void Save()     => Console.WriteLine("A novel has been saved.");
    public void Retrieve() => Console.WriteLine("A novel has been retrieved.");
    public void View()     { foreach (var page in _pages) page.View(); }
    public void Edit()     => Console.WriteLine("A novel has been edited.");
    public void Delete()   => Console.WriteLine("A novel has been deleted.");
}