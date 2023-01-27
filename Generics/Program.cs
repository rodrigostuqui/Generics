
//Comparando Metodos com overload
Utils.Compare("a", "a");
Utils.Compare("a", "b");
Utils.Compare(1, 1);
Utils.Compare(1, 2);
Utils.Compare(1.2, 1.2);
Utils.Compare(1.2, 1.3);
//Comparando com Metodo Generico
Utils.CompareGeneric("a", "a");
Utils.CompareGeneric("a", "b");
Utils.CompareGeneric(1, 1);
Utils.CompareGeneric(1, 2);
Utils.CompareGeneric(1.2, 1.2);
Utils.CompareGeneric(1.2, 1.3);
class Utils
{
    public static void Compare(string a, string b)
        => Console.WriteLine(a.Equals(b));
    public static void Compare(int a, int b)
        => Console.WriteLine(a == b);
    public static void Compare(double a, double b) 
        => Console.WriteLine(a == b);
    public static void CompareGeneric<T>(T a, T b) where T : IComparable<T>, IEquatable<T>
        => Console.WriteLine(a.Equals(b));
}
