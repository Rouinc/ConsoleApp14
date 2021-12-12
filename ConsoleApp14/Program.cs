using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaScroll
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ninja = new List<string>();
            int pilih, ts, pos;
            string cari;

            Ninja.Add("Book of Peace");
            Ninja.Add("Scroll of Swords");
            Ninja.Add("Silence Guide Book");

            while (true)
            {
                Console.WriteLine("1. My scroll list");
                Console.WriteLine("2. Add scroll");
                Console.WriteLine("3. Search scroll");
                Console.WriteLine("4. Remove scroll");
                Console.Write("Choose what to do: ");
                pilih = Convert.ToInt32(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        Console.WriteLine("Scroll to learn list:");
                        for (int x = 0; x < Ninja.Count(); x++)
                        {
                            Console.WriteLine("Scroll " + (x + 1) + ": " + Ninja[x]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("How many scroll to add: ");
                        ts = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("In what number of queue? ");
                        pos = Convert.ToInt32(Console.ReadLine());

                     
                        if (pos > Ninja.Count() + 1)
                        {
                            pos = Ninja.Count() + 1;
                            Console.WriteLine("Posisi melebihi scroll, data diletakkan di bagian akhir");
                        }
                        
                        for (int a = 1; a <= ts; a++)
                        {
                            Console.WriteLine("Scroll " + a + " name: ");
                            Ninja.Insert(--pos, Console.ReadLine());
                            pos++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Insert scroll name: ");
                        cari = Console.ReadLine();
                        bool status = true;
                        for (int x = 0; x < Ninja.Count; x++)
                        {
                            if (cari.Equals(Ninja[x]) == true)
                            {
                                Console.WriteLine("Books found. Queue number: " + (x + 1));
                                status = false;
                                break;
                            }

                        }
                        if (status)
                            Console.WriteLine("Book not found");
                        break;
                    case 4:


                        string pil;
                        int lok;
                        bool hapus;
                        while (true)
                        {
                            Console.WriteLine("Remove from list by scroll name? Y/N: ");
                            pil = Console.ReadLine().ToLower();

                            if (pil.Equals("y") || pil.Equals("n"))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wrong selection. Choose again: ");
                            }
                        }

                        if (pil.Equals("y") == true)
                        {
                            Console.WriteLine("input scroll name? ");
                            cari = Console.ReadLine();
                            hapus = Ninja.Remove(cari);
                            if (hapus)
                                Console.WriteLine("Book removed");
                            else
                                Console.WriteLine("Book not found");
                        }
                        else
                        {
                            while (true)
                            {
                                Console.WriteLine("input scroll queue: ");
                                lok = Convert.ToInt32(Console.ReadLine());
                                lok--;
                                if (lok < Ninja.Count())
                                {
                                    Ninja.RemoveAt(lok);
                                    Console.WriteLine("Book removed!");
                                    break;
                                }
                                else
                                {
                                    Console.Write("Queue not found. ");
                                }
                            }
                        }

                        break;
                }
            }
        }
    }
}
