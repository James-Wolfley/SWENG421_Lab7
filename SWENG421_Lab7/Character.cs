namespace SWENG421_Lab7;

public class Character : IComponent
{
    private char _letter;

    public Character(char letter)
    {
        _letter = letter;
    }

    public void Save()     => Console.WriteLine("A character has been saved.");
    public void Retrieve() => Console.WriteLine("A character has been retrieved.");
    public void View()     => Console.Write(_letter);
    public void Edit()     => Console.WriteLine("A character has been edited.");
    public void Delete()   => Console.WriteLine("A character has been deleted.");
}