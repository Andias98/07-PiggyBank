/*--------------------------------------------------------------
 *      HTBLA-Leonding / Class 3ACIFT
 *--------------------------------------------------------------
 *      Mathias Anderl
 *--------------------------------------------------------------
 * Description:
 * Das Programm erfasst die Anzahlen verschiedener Münzen 
 * (int) über die Konsole und gibt den insgesamt 
 * angesparten Betrag (double) aus.
 *--------------------------------------------------------------
 */

using System;

namespace Sparschwein
{
    class Program
    {
        public static void Main(string[] args)
        {
            int tenCents, twentyCents, fiftyCents, oneEuros, twoEuros, fiveEuros, tenEuros;
            double savings;
            string organizedSavings;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Output (Header)
            Console.WriteLine("Sparschwein-Rechner --> Nikolaus");
            Console.WriteLine("::::::::::::::::::::::::::::::::");
            Console.WriteLine();
			
			// Input

            Console.Write("Wie viele 10cent-Münzen haben Sie angesammelt: ");
            tenCents = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie viele 20cent-Münzen haben Sie angesammelt: ");
            twentyCents = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie viele 50cent-Münzen haben Sie angesammelt: ");
            fiftyCents = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Wie viele 1€-Münzen haben Sie angesammelt: ");
            oneEuros = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Wie viele 2€-Münzen haben Sie angesammelt: ");
            twoEuros = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie viele 5€-Scheine haben Sie angesammelt: ");
            fiveEuros = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie viele 10€-Scheine haben Sie angesammelt: ");
            tenEuros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::");

            // Processing (Verarbeitung)

            savings = (tenCents * 0.1) + (twentyCents * 0.2) + (fiftyCents * 0.5) + (oneEuros * 1) + (twoEuros * 2) + (fiveEuros * 5) + (tenEuros * 10);

            // Output
            organizedSavings = savings.ToString("0.00");

            Console.WriteLine($"Sie haben {organizedSavings} € angesammelt.");

            // Output ends
            Console.WriteLine("Eine beliebige Taste zum Beenden drücken...");
            Console.ReadKey();
        }
    }
}