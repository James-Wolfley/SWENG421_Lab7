namespace SWENG421_Lab7;

public class Image : IComponent {
    public void Save() => Console.WriteLine("An image has been saved.");
    public void Retrieve() => Console.WriteLine("An image has been retrieved.");
    public void View() => Console.WriteLine("An image has been viewed.");
    public void Edit() => Console.WriteLine("An image has been edited.");
    public void Delete() => Console.WriteLine("An image has been deleted.");
}