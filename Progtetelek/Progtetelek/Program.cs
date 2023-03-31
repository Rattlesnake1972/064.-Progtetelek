using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progtetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tömb deklarálása

            int[] sebessegtomb = new int[10];

            // feltöltés random értékekkel

            Random r = new Random();
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                sebessegtomb[i] = r.Next(0, 200);
                Console.Write(sebessegtomb[i]+" ");
            }

            Console.WriteLine();


            // Ez a progi gyakorlatilag azt csinálja röviden elmondva, hogy 10 darab véletlen számot generál 0-tól 200-as tartományban és csak 10 darabot ír ki véletlenszerűen.

            //Console.ReadLine();

            // 1. Összegzés tétele: összegezzük a tömb elemeit!

            int osszeg = 0;
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                osszeg += sebessegtomb[i];
            }

            Console.WriteLine("A tömb elemeinek összege: " +osszeg);

            // A fentebb generált véletlen számokat összeadja ez a progi.

            // 2. Feltételes összegzés

            int osszegf = 0;
            for (int i = 0; i < sebessegtomb.Length; i++)
            { 
                if(sebessegtomb[i]>100)
                {
                    osszegf += sebessegtomb[i];
                }

            }

            Console.WriteLine("A 100-nál gyorsabb kocsik sebességösszegei: " +osszegf);

            // 3. Megszámlálás tétele

            int db = 0;
            
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                if(sebessegtomb[i]%2==0)
                {
                    db++;
                }
            }

            Console.WriteLine("A páros számok száma a tömbben: " +db+ " db.");

            // 4. Eldöntés tétele

            bool vane = false;
            for (int i = 0; i <sebessegtomb.Length; i++)
            {
                if(sebessegtomb[i]>180)
                {
                    vane = true;
                    //break
                }

            }

            Console.WriteLine("Van benne 180-nál nagyobb? " +vane);

            // 5. A tömb legkisebb eleme, minimuma.

            int min = sebessegtomb[0];
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                if (sebessegtomb[i]<min)
                {
                    min = sebessegtomb[i];
                }
            }

            Console.WriteLine("A tömb elemeinek minimuma: " +min);

            // 6. A tömb legnagyobb eleme, maximuma.

            int max = sebessegtomb[0];
            for (int i = 0; i < sebessegtomb.Length; i++)
            {
                if (sebessegtomb[i]>max)
                {
                    max = sebessegtomb[i];
                }
            }

            Console.WriteLine("A tömb elemeinek maximuma: " +max);

            // 7. Csere

            int a = 4;
            int b = 7;
            Console.WriteLine("a: " +a+ " b: " +b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a: " +a+ " b: " +b);

            Console.ReadLine();

        }
    }
}
