public class Kisi
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
}

public static class MyExtensions
{
    public static string ToTamAdi(this Kisi kisi)
    {
        return kisi.Adi + " " + kisi.Soyadi.ToUpper();
    }
    public static string ToCapitize(this string yazi)
    {
        var ilkHarf = yazi[0].ToString().ToUpper();
        return ilkHarf + yazi.Substring(1);
    }
}


class Program
{
    static void Main(string[] args)
    {

        string str = "ankara";

        Console.WriteLine(str.ToCapitize());
    }
}


//ilk harfi her zaman büyük yazacak şekilde ayarladık.