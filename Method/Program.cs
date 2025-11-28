internal class Program
{
    private static void Main(string[] args)
    {
        Random juhuarv = new Random();
        Console.WriteLine("kas sa tahab müti vista, või täringut veeretada?");
        string kasutajaValik = Console.ReadLine();
        if (kasutajaValik == "münti")
        {
            Console.WriteLine(Münt(juhuarv));
        }
        else if (kasutajaValik == "täringut")
        {
            Console.WriteLine(Täring(juhuarv));                   
        }
        else
        {
            Console.WriteLine("ei tea sellist vastust");
        }



        //        NewMessage();
        //        List<string> ostunimekiri = new List<string>();
        //        Console.WriteLine("Sisesta oma tänane poeskäigunimekiri");
        //        string kasutajaSisestus = "";
        //        GetUserInput(kasutajaSisestus, ostunimekiri);
        //        foreach (var söök in ostunimekiri)
        //        {
        //            Console.WriteLine($" -*- {söök}");
        //        }
        //        GetUserInput(kasutajaSisestus, ostunimekiri);
        //    }

        //    static List<string> GetUserInput(string kasutajasisestus, List<string> ostunimekiri)
        //    {
        //        while (kasutajasisestus != "rohkem pole")
        //            {
        //                Console.WriteLine("Kirjuta ükshaaval, sisesta järgmine ost:\nkui rohkem ei ole midagi lisada, siis ütle \"rohkem pole\"");
        //                kasutajasisestus = Console.ReadLine();
        //                if (kasutajasisestus != "" || kasutajasisestus != "rohkem pole")
        //                {
        //                    ostunimekiri.Add(kasutajasisestus);
        //                }
        //                else if (kasutajasisestus == "rohkem pole")
        //                {
        //                    kasutajasisestus = "";
        //                }

        //            }
        //            Console.WriteLine("see sinu nimekiri");
        //        return ostunimekiri;
        //    }

        //    static void NewMessage()
        //    {
        //        Console.WriteLine("this is a message");
        //    }
        //}

    }

    private static int Täring (Random juhuarv)
    {
        return juhuarv.Next(1,6);
    }
   
    static string Münt(Random thing)
    {
        int mündivise = thing.Next(1, 2);
        if (mündivise == 1)
        {
            return "kull";
        }
        else
        {
            return "kiri";
        }
        return "serv";
        
    }
}


