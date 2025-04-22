// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




using System.ComponentModel.Design;
using System.Xml;

bool isContinue = true;

while(isContinue is true)
{
    Console.Clear();
    Console.WriteLine("=== Xush kelibsiz ===");
    Console.WriteLine("1.Kalkulyator.");
    Console.WriteLine("2.Valyuta ayri boshlash.");
    Console.WriteLine("3.Yosh hisoblagich");
    Console.WriteLine("4.Geometriya hisob-kitoblari");

    Console.Write("Commanda nomerini kiriting(1, 2 ..)");
    int command = Convert.ToInt32(Console.ReadLine());

    if (command == 1)
    {
        Console.Clear();
        Console.WriteLine("==== Kalkulyatorga ====");
        //Kalkuliyotor ishlashi kerak
        Console.Write("son1: ");
        double son1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("amal: ");
        string amal = Console.ReadLine();
        Console.Write("son2: ");
        double son2 = Convert.ToDouble(Console.ReadLine());
        double natija = 0;

        if (amal == "+")
        {
            natija = son1 + son2;
        }
        else if (amal == "-")
        {
            natija = son1 - son2;
        }
        else if (amal == "*")
        {
            natija = son1 * son2;
        }
        else if (amal == "/")
        {
            natija = son1 / son2;
        }
        else
        {
            Console.WriteLine("Noto'g'ri amal kiritildi!");
        }
        Console.WriteLine("Natija: " + natija);

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
    else if (command == 2)
    {
        //Valyuta ayri boshlashi kerak
        Console.Clear();
        Console.WriteLine("=== Valyuta ayri boshlandi!=== ");
        Console.WriteLine("1. UZS -> USD");
        Console.WriteLine("2. USD -> UZS");
        Console.Write("Commanda nomerini kiriting(1, 2 ..)");
        int valyutaCommand = Convert.ToInt32(Console.ReadLine());

        if (valyutaCommand == 1)
        {
            Console.Write("UZS: ");
            double uzs = Convert.ToDouble(Console.ReadLine());
            double usd = uzs / 12943.45;
            Console.WriteLine("USD: " + Math.Floor(usd) + " $");
        }
        else if (valyutaCommand == 2)
        {
            Console.Write("USD: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            double uzs = usd * 12943.45;
            Console.WriteLine("UZS: " + Math.Floor(uzs) + " so'm");
        }
        else
        {
            Console.WriteLine("Noto'g'ri command kiritildi!");
        }

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
    else if (command == 3)
    {
        //Yosh hisoblagich ishlashi kerak
        Console.Clear();
        Console.WriteLine("=== Yosh hisoblagich ===");
        Console.Write("Tug'ilgan yilingizni kiriting: ");
        int yil = Convert.ToInt32(Console.ReadLine());
        int yosh = DateTime.Now.Year - yil;
        Console.WriteLine("Siz " + yosh + " yoshdasiz");

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
    //command = 4
    if (command == 4)
    {
        Console.Clear();
        Console.WriteLine("=== Geometriya hisob-kitoblari ===");
        Console.WriteLine("1. Aylananing yuzi");
        Console.WriteLine("2. To'gri burchakli uchburchakning yuzi");
        Console.WriteLine("3. To'rtburchakning yuzi");
        Console.Write("Geometrik shakkilardan iborat kommandani kiriting: ");
        int geometriyaCommand = Convert.ToInt32(Console.ReadLine());


        if (geometriyaCommand == 1)
        {
            Console.Write("Aylananing radiusini kiriting: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double aylanaYuzi = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Aylananing yuzi: " + Math.Round(aylanaYuzi, 2));
        }
        else if(geometriyaCommand == 2)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double uchburchakYuzi = (a * b) / 2;
            Console.WriteLine("To'gri burchakli uchburchakning yuzi: " + Math.Round(uchburchakYuzi, 2));
        }
        else if(geometriyaCommand == 3)
        {
            Console.Write("eni = ");
            double eni = Convert.ToDouble(Console.ReadLine());
            Console.Write("buyi = ");
            double buyi = Convert.ToDouble(Console.ReadLine());
            double tortburchakYuzi = eni * buyi;
            Console.WriteLine("To'rtburchakning yuzi: " + Math.Round(tortburchakYuzi, 2));
        }

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
    //Geometriya hisob-kitoblari
    //Aylana, uchburchak, to‘rtburchak va boshqa shakllarning yuzasi va perimetrini hisoblash.
    else
    {
        Console.WriteLine("Noto'g'ri command kiritildi!");

        Console.WriteLine("\nDavom etasizmi?(ha/yuq)");
        string javob = Console.ReadLine();
        if (javob.ToLower().Contains("yuq"))
        {
            isContinue = false;
        }
    }
}

Console.WriteLine("Dastur o'z ishini yakunladi!");

