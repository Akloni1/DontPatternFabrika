using System;

namespace PaternFabrika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название оружия: ");
            String arms = Console.ReadLine();

            Glock18 glock18 = new Glock18();
            Ak47 ak47 = new Ak47();
            Brt92FS brt92FS = new Brt92FS();
            Arms arms1 = ak47;// по умолчанию ак47
                              //   Factory factory = new Factory();

            switch (arms)
            {
                case "Brt92FS":
                    {
                        arms1 = brt92FS;
                        // Arms brt92FS = factory.create(arms);
                        //   brt92FS.Shooting();

                        break;
                    }
                case "Glock18":
                    {
                        arms1 = glock18;
                        /* Arms glock18 = factory.create(arms);
                         glock18.Shooting();*/
                        break;
                    }

                case "Ak47":
                    {
                        arms1 = ak47;
                        /*Arms ak47 = factory.create(arms);
                        ak47.Shooting();*/
                        break;
                    }

            }
            arms1.Shooting();

        }
    }
}
