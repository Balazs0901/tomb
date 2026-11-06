using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] lista = { 1, 4, 5, 0, 8 };
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[2]);
            Console.WriteLine(lista.Length);
            Console.ReadLine();
            Console.Clear();

            //2
            int[] lista2 = new int[5];
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Kérek egy számot: ");
                int szam = Convert.ToInt32(Console.ReadLine());
                lista2[i] = szam;
                Console.Clear();

            }
            Console.WriteLine(string.Join(", ", lista2));
            Console.ReadLine();
            Console.Clear();

            //3
            for (int i = lista.Length; i > 0; i--)
            {
                Console.Write($"{lista[i - 1]} ");
            }
            Console.ReadLine();
            Console.Clear();

            //4
            int[] lista4 = { 2, 3, 4, 5, 6 };
            for (int i = 0; i < lista4.Length; i++)
            {
                if (lista4[i] % 2 == 0)
                {
                    Console.WriteLine($"{lista4[i]} páros");
                }
                else
                {
                    Console.WriteLine($"{lista4[i]} páratlan");
                }

            }
            Console.ReadLine();
            Console.Clear();

            //5
            int[] lista5 = { 2, 3, 4, 5, 6 };
            for (int i = 0; i < lista5.Length; i++)
            {
                lista5[i] = lista5[i] * 10;
            }
            Console.WriteLine(string.Join(", ", lista5));
            Console.ReadLine();
            Console.Clear();

            //6
            int[] lista6 = { -2, 3, 1, -5, 7 };
            int x = 0;
            for (int i = 0; i < lista6.Length; i++)
            {

                if (lista6[i] < 0)
                {
                    x += 1;
                }
            }
            Console.WriteLine(string.Join(", ", lista6));
            Console.WriteLine($"A tömbben {x} db negatív szám van");
            Console.ReadLine();
            Console.Clear();

            //7
            int[] lista7 = { 1, 2, 3, 4, 5 };
            int osszeg = 0;
            int atlag = 0;
            for (int i = 0; i < lista7.Length; i++)
            {
                osszeg += lista7[i];
                atlag += lista7[i];
            }
            Console.WriteLine(string.Join(", ", lista7));
            Console.WriteLine($"A tömb elemeinek összege: {osszeg}");
            Console.WriteLine($"A tömb elemeinek átlaga: {atlag / lista7.Length}");
            Console.ReadLine();
            Console.Clear();

            //8
            int[] lista8 = { 1, 2, 3, 4, 5 };
            int max = 0;
            int min = lista8[0];
            ;
            for (int i = 0; i < lista8.Length; i++)
            {
                if (lista8.Length > 0)
                {
                    if (lista8[i] > max)
                    {
                        max = lista8[i];
                    }
                    if (lista8[i] < min)
                    {
                        min = lista8[i];
                    }
                }
                else
                {
                    Console.WriteLine("A tömb üres");
                }
            }
            Console.WriteLine(string.Join(", ", lista8));
            Console.WriteLine($"A maximum: {max}");
            Console.WriteLine($"A minimum: {min}");
            Console.ReadLine();
            Console.Clear();

            //9
            int[] lista9 = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < lista9.Length; i += 2)
            {
                Console.WriteLine(lista9[i]);
            }
            Console.ReadLine();
            Console.Clear();

            //10
            int[] lista10 = { 4, 7, 4 };
            Console.Write("Kérek egy számot: ");
            int keresett = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(lista10, keresett);
            Console.WriteLine($"A szám a tömb {index}. helyén van.");
            Console.ReadLine();
            Console.Clear();

            //11
            int[] lista11 = { 4, 7, 4 };
            Console.Write("Kérek egy számot: ");
            int keresett11 = Convert.ToInt32(Console.ReadLine());
            int index11 = Array.LastIndexOf(lista11, keresett11);
            Console.WriteLine($"A szám a tömb {index11}. helyén van.");
            Console.ReadLine();
            Console.Clear();

            //12
            int[] lista12 = { 1, 2, 50, 52, 60 };
            int db = 0;
            for (int i = 0; i < lista12.Length; i++)
            {
                if (lista12[i] > 50)
                {
                    Console.WriteLine(lista12[i]);
                    db += 1;
                }
            }
            Console.WriteLine($"A tömbben {db} db 50-nél nagyobb szám van.");
            Console.ReadLine();
            Console.Clear();

            //13
            int[] lista13 = { 1, 2, 3, 4, 5 };
            int atlag13 = 0;
            int osszeg13 = 0;
            int db13 = 0;
            for (int i = 0; i < lista13.Length; i++)
            {
                osszeg13 += lista13[i];
            }
            atlag13 = osszeg13 / lista13.Length;
            for (int i = 0; i < lista13.Length; i++)
            {
                if (lista13[i] > atlag13)
                {
                    db13 += 1;
                }
            }
            Console.WriteLine($"A tömbben {db13} db az átlagnál nagyobb szám van.");
            Console.ReadLine();
            Console.Clear();

            //14

            //15
            int[] lista15 = { 7, 7, 3, 2 };
            int max15 = int.MinValue;
            int masodikLegnagyobb15 = int.MinValue;
            for (int i = 0; i < lista15.Length; i++)
            {
                if (lista15[i] > max15)
                {
                    max15 = lista15[i];
                }
            }
            for (int i = 0; i < lista15.Length; i++)
            {
                if (lista15[i] < max15 && lista15[i] > masodikLegnagyobb15)
                {
                    masodikLegnagyobb15 = lista15[i];
                }
            }
            if (masodikLegnagyobb15 == int.MinValue)
            {
                Console.WriteLine("Nincs két különböző elem!");
            }
            else
            {
                Console.WriteLine($"A második legnagyobb érték: {masodikLegnagyobb15}");
            }


        }
    }
}
