using Easyware.lib.ConsoleApp;


class BenimListem
{
    private List<int> liste = new List<int>();
    public bool Ekle(int sayi, out int siraNumarasi)
    {
        if (liste.Contains(sayi))
        {
            siraNumarasi = -1;
            return false;
        }
        else
        {
            liste.Add(sayi);
            siraNumarasi = liste.Count;
            return true;
        }

    }
    public void Listele()
    {
        Ekran.BaslikYaz("Listem");
        foreach (int i in liste)
        {
            Console.WriteLine(i);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        BenimListem liste = new BenimListem();
        int siraNo = 0;
        if (liste.Ekle(20, out siraNo))
        {
            Console.WriteLine(20 + " sayısı eklendi. sıra=" + siraNo);
        }

        if (liste.Ekle(25, out int index))
        {
            Console.WriteLine(25 + " eklendi sıra =" + index);
        }
        for (int i = 0; i < 3; i++)
        {
            int sayi = Ekran.SayiOku("Sayı");
            if (liste.Ekle(sayi, out int sira))
            {
                Console.WriteLine($"{sayi} eklendi sıra = {sira}");
            }
            else
            {
                Console.WriteLine($"{sayi} zaten var");
            }

        }
        Console.WriteLine();
        liste.Listele();
    }
}
