using System;

public class Mathe
{
    public static double Pythagoras(double a, double b)

    {
        // Hypotenuse berechnen
        return Math.Sqrt(a * a + b * b);


    }
    public static double Rechteckflächeberechnen(double seite1, double seite2)

    {
        // Rechteckflächeberechnen
        return seite1 * seite2;

    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Herzlich willkommen zu meinem Programm");
            Console.WriteLine("Was möchten Sie berechnen?");
            Console.WriteLine("1: Pythagoras");
            Console.WriteLine("2: Rechteckfläche");
            Console.WriteLine("3: Programm beenden");

            string Option = Console.ReadLine();

            switch (Option)
            {
                case "1":
                    // Pythagoras
                    Console.WriteLine("Bitte geben Sie die Kathete a ein:");
                    double kathete1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Bitte geben Sie die Kathete b ein:");
                    double kathete2 = Convert.ToDouble(Console.ReadLine());

                    double hypotenuse = Pythagoras(kathete1, kathete2);
                    Console.WriteLine($"Die Hypotenuse ist: {hypotenuse}");
                    Console.WriteLine("--------------------------------------------");
                    break;

                   

                case "2":
                    // Rechteckfläche
                    Console.WriteLine("Bitte geben Sie die Seite 1 ein:");
                    double seite1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Bitte geben Sie die Seite 2 ein:");
                    double seite2 = Convert.ToDouble(Console.ReadLine());

                    double rechteckfläche = Rechteckflächeberechnen(seite1, seite2);
                    Console.WriteLine($"Die Rechteckfläche ist: {rechteckfläche}");
                    Console.WriteLine("--------------------------------------------");

                    break;

                case "3":
                    // Programm beenden
                    Console.WriteLine("Programm wird beendet.");
                    return;

                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}

