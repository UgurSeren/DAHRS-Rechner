using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Wie viel Cent haben Sie die Fischer zu kaufen ? ");
            int cent = Convert.ToInt32(Console.ReadLine());
            Dahrs(cent);
            Console.ReadLine();
        }
        static void Dahrs(int cent)
        {
               // DAHRS-Rechner  D: Steht für Dorsch, A für Aal, H für Hering, R für Rochen, S für Sprotten

            int anzDorsch, anzRochen, anzAal, anzHearing, anzSprotte;
            int rest;
            cent = cent / 10;

            int dorsch = 8;
            int aal = (8 / dorsch);
            int hering = (5 / aal);
            int rochen = (9 * hering) + (7 * aal);
            int sprotten = (11 / aal);

            anzDorsch = cent / dorsch;
            rest = cent % dorsch;
            cent = rest;

            anzRochen = cent / rochen;
            rest = cent % rochen;
            cent = rest;

            anzAal = cent / aal;
            rest = cent % aal;
            cent = rest;

            anzHearing = cent / hering;
            rest = cent % hering;
            cent = rest;

            anzSprotte = cent / sprotten;
            rest = cent % sprotten;
            cent = rest;

            Console.WriteLine($" Die Anzahl von Dorsche : {anzDorsch}\n Die Anzahl von Rochene : {anzRochen}\n Die Anzahl von Aale {anzAal}\n Die Anzahl von  Heringe {anzHearing} \n Die Anzahl von Sprotten: {anzSprotte}");


        }
    }
}
