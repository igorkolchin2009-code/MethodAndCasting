namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int arv = 67;
            //string arvtekstuna = arv.ToString();
            //Console.WriteLine(arvtekstuna);
            //Console.WriteLine(arv);
            //double arvdouble = 0.00d;
            //int arvdoubleatvint = 0;

            //arvdoubleatvint = (int)arvdouble;

            //double uusdouble = arv;



            //string pikkus = "";
            //Console.WriteLine("sisesta pikkus:");
            //pikkus = Console.ReadLine();
            //float pikkusFm = float.Parse(pikkus);
            //int pikkusCm = (int)(pikkusFm*100);
            //Console.WriteLine($"Sinu pukkus CMides on {pikkusCm}, ja meetrotes{pikkusFm}");





            float arv1 = 0.45f;
            float arv2 = 0.50f;
            Console.WriteLine(arv1);
            Console.WriteLine(arv2);
            Console.WriteLine((int)arv1);
            Console.WriteLine((int)arv2);
            Console.WriteLine((int)Math.Round(arv1));
            Console.WriteLine((int)Math.Round(arv2));


        }
    }
}
