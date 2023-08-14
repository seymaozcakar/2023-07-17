

class Program
{
    static void Main(string[] args)
    {

        int sayi = 0;
        bool Basarili = false;
        do
        {
            Console.Write("Sayi Giriniz = ");
            string GirilenSayi = Console.ReadLine();
            Basarili = int.TryParse(GirilenSayi, out sayi);
            if (!Basarili)
            {
                Console.WriteLine("Yanlış Giriş");
            }
        } while (!Basarili);
        Console.WriteLine("Tebrikler " + sayi);






    }
}
//try parse= girilen sayı parse edilebiliyor mu?
//iki çıktı döndürür.