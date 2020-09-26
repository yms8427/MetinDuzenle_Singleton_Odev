using System;

namespace Odev.TekNesne
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Sample.Instance;
            a.Number = 10;
            var b = Sample.Instance;
            b.Number += 3;
            var c = Sample.Instance;
            c.Number = 45;

            Console.WriteLine("A: " + a.Number);
            Console.WriteLine("B: " + b.Number);
            Console.WriteLine("C: " + c.Number);
            Console.ReadKey();
        }
    }

    class Sample
    {
        static Sample()
        {
            //Static nesneler class daha oluşmadan önce ayağa kalkar dolayısı ile bir static nesne class oluşmadan hazır halde olur
            //Static neslerin oluşturuldu başlangıç. notası ise static constructır'dur
        }
        private Sample()
        {
        }
        public int Number { get; set; }

        private static Sample instance;
        public static Sample Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sample();
                }
                return instance;
            }
        }
    }
}
