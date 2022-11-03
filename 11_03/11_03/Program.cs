using System;
using System.IO;

namespace _11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Console.WriteLine("************************************");
            Read();
            Console.WriteLine("************************************");
            Search();
        }

        static void Write()
        {
            //irasyti duomenis i faila

            /*string appending = Console.ReadLine();

            if (appending = y OR  )
            {
                Console.ReadLine();
            }
            
            */

            string zodziai = Console.ReadLine();

            Console.WriteLine(zodziai);

            //  await File.WriteAllLinesAsync("failas.txt",zodziai);


            try
            {
                StreamWriter tekstas = new StreamWriter(@"C:\Users\moksleivis\Desktop\Naujas aplankas\failas.txt", true);
                tekstas.WriteLine(zodziai);
                tekstas.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void Read()
        {
            String line;
            try
            {

                StreamReader skaitymas = new StreamReader(@"C:\Users\moksleivis\Desktop\Naujas aplankas\failas.txt");
                line = skaitymas.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = skaitymas.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                ;
            }
        }

        static void Search()
        {
            Console.WriteLine("Enter search");
            string zodis = Console.ReadLine();
            StreamReader ieskojimas = new StreamReader(@"C:\Users\moksleivis\Desktop\Naujas aplankas\failas.txt");
            string esamaEilute;
            bool rastasZodis = false;

            do
            {
                esamaEilute = ieskojimas.ReadLine();
                if (esamaEilute != null)
                {
                    rastasZodis = esamaEilute.Contains(zodis);
                }
            }
            while (esamaEilute != null && !rastasZodis);
            if (rastasZodis == true)
            {
                Console.WriteLine("Zodis rastas");
            }
            else
                Console.WriteLine("Zodzio nera");
        }




        ///methods c#
        //ctrl k d
        ///TODOs
        ///
        //eilutes i masyva

    }
}

