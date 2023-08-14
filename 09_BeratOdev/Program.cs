using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(6, "Ankara");
        dic.Add(10, "Balıkesir");
        Show(dic);
        Console.WriteLine("Eklemek istediğiniz şehrin plaka kodu nedir?");
        int plaka = int.Parse(Console.ReadLine());
        Console.WriteLine("Eklemek istediğiniz şehrin ismi nedir?");
        string sehir = Console.ReadLine();
        dic.Add(plaka, sehir);
        Show(dic);
        Console.WriteLine($"{sehir} şehri eklendi.");
        Console.WriteLine("Plaka eklemeye devam etmek ister misiniz?");
        Console.WriteLine("Evet için 'E' Hayır için 'H' harfini yazınız.");
        var kullaniciCevap = "";
        kullaniciCevap = Console.ReadLine();


        //for (int i = 0; i < dic.Count; i++)
        //    //{
        //    if (plaka == dic.ContainsKey(i)) ;
        //Console.WriteLine("Zaten kayıtlı");
        //}   Plaka keyi daha önceden girilmişse hata ver. Döngünün içinde de kodu kullan.

        while (kullaniciCevap != "H")
        {
            if (kullaniciCevap == "E")
            {
                Console.WriteLine("Eklemek istediğiniz şehrin plaka kodu nedir?");
                plaka = int.Parse(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz şehrin ismi nedir?");
                sehir = Console.ReadLine();
                dic.Add(plaka, sehir);
                Show(dic);
                Console.WriteLine($"{sehir} şehri eklendi.");
                Console.WriteLine("Plaka eklemeye devam etmek ister misiniz?");
                Console.WriteLine("Evet için 'E' Hayır için 'H' yazınız.");
            }
            else if (kullaniciCevap == "H")
            {
                Console.WriteLine("Listenizdeki mevcut plaka kodları aşağıdaki gibidir.");
                Show(dic);
                break;
            }
            else
            {
                Console.WriteLine("Hatalı bir tercih yaptınız. Hayır için 'H' , Evet için 'E' yazınız.");
            }
        }
    }

    private static void Show(Dictionary<int, string> dic)
    {
        foreach (int key in dic.Keys)
        {
            Console.WriteLine($"{key} - {dic[key]}");
        }
    }
}

// dic.Keys.ElementAt(i)) kullanabilirsin.


//düzeltmesi videoda.2023-07-17