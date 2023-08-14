class Ekran
{
    public static void CizgiCiz()
    {
        Console.WriteLine("----------------------");
    }
    public static void BaslikYaz(string baslik)
    {
        CizgiCiz();
        Console.WriteLine(baslik);
        CizgiCiz();
    }

}
class Daire
{
    public double YariCap { get; set; }
    public double PI = 3.14;
    public double AlanHesapla()
    { 
        return PI * YariCap * YariCap;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ekran.CizgiCiz();
        Ekran.BaslikYaz("Başlık");
        Console.WriteLine();

        Daire daire = new Daire();
        daire.YariCap = 10;
        Console.WriteLine(daire.AlanHesapla());
    }
}

//static üyeler sadece static üyeleri çağırabilir.

//özellikleri olanları(instance)oluşturarak çağırırız.
//static olanları tek başına çağırabilirim.