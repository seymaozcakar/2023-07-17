﻿using Easyware.lib.ConsoleApp;

namespace Easyware_myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ekran.BaslikYaz("Selamlar");
            //string str = Ekran.Oku("Adınız");
            int yas = Ekran.SayiOku("Yaşınız");
        }
    }
}