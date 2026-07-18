//Singleton Pattern — bir class-dan proqram boyunca yalnız 1 obyekt yaradılmasını təmin edir və həmin obyektə hər yerdən giriş imkanı verir.

class Program
{
    static void Main(string[] args)
    {
        Singleton obj1 = Singleton.Instance;
        Singleton obj2 = Singleton.Instance;

        obj1.ShowMessage();

        Console.WriteLine(Object.ReferenceEquals(obj1, obj2));
    }
}