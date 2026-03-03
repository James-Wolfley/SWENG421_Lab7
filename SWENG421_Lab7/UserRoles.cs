namespace SWENG421_Lab7;

public class Administrator
{
    public void Invoke(IComponent c, string method)
    {
        switch (method)
        {
            case "save":     c.Save();     break;
            case "retrieve": c.Retrieve(); break;
            case "view":     c.View();     break;
            case "edit":     c.Edit();     break;
            case "delete":   c.Delete();   break;
            default: Console.WriteLine("Unknown method."); break;
        }
    }
}

public class Editor
{
    public void Invoke(IComponent c, string method)
    {
        switch (method)
        {
            case "save":     c.Save();     break;
            case "retrieve": c.Retrieve(); break;
            case "delete":   c.Delete();   break;
            default: Console.WriteLine("Editor cannot invoke: " + method); break;
        }
    }
}

public class Writer
{
    public void Invoke(IComponent c, string method)
    {
        switch (method)
        {
            case "view": c.View(); break;
            case "edit": c.Edit(); break;
            default: Console.WriteLine("Writer cannot invoke: " + method); break;
        }
    }
}