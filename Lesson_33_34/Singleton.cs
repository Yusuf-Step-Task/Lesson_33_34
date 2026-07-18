using System;
class Singleton
{
    private static Singleton instance;
    private Singleton()
    {
        Console.WriteLine("Singleton obyekti yaraddi m");
    }
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
    public void ShowMessage()
    {
        Console.WriteLine("Singleton pattern");
    }
}



