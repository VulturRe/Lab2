using System;

namespace Lab2
{
    class Car
    {
        protected string manufacturer;
        protected int cylinderCount;
        protected int power;

        public Car()
        {
            manufacturer = "N/A";
            cylinderCount = 0;
            power = 0;
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                try { manufacturer = value; }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Введите марку заново.");
                }
            }
        }

        public int CylinderCount
        {
            get { return cylinderCount; }
            set
            {
                try { cylinderCount = value; }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Введите количество цилиндров двигателя заново.");
                }
            }
        }

        public int Power
        {
            get { return power; }
            set
            {
                try { power = value; }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Введите мощность двигателя заново.");
                }
            }
        }

        public virtual void Print()
        {
            Console.WriteLine("Марка автомобиля: {0}", manufacturer);
            Console.WriteLine("Количество цилиндров двигателя: {0}", cylinderCount);
            Console.WriteLine("Мощность двигателя: {0}", power);
        }
    }

    class Lorry : Car
    {
        protected int carrying;

        public Lorry()
        {
            carrying = 0;
        }

        public int Carrying
        {
            get { return carrying; }
            set
            {
                try { carrying = value; }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Введите грузоподъемность заново.");
                }
            }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Грузоподъёмность: {0}", carrying);
        }

    }

    class Test
    {
        private static void Main()
        {
            var car = new Car();
            var lorry = new Lorry();

            string userInput;

            do
            {
                userInput = DisplayMenu();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        string userInput1;
                        do
                        {
                            userInput1 = DisplayCarMenu();

                            switch (userInput1)
                            {
                                case "1":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                        } while (userInput1 != "5");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ERROR: unexpected menu number!");
                        break;
                }
            } while (userInput != "3");
        }

        private static string DisplayMenu()
        {
            Console.WriteLine("1. Задать параметры авто.");
            Console.WriteLine("2. Задать параметры грузового авто.");
            Console.WriteLine("3. Выход.");

            var cki = Console.ReadKey(false);
            return cki.KeyChar.ToString();
        }

        private static string DisplayCarMenu()
        {
            Console.WriteLine("1. Ввод марки.");
            Console.WriteLine("2. Ввод количества цилиндров.");
            Console.WriteLine("3. Ввод мощности двигателя.");
            Console.WriteLine("4. Вывод показателей авто.");
            Console.WriteLine("5. Возврат к предыдущему меню.");

            var cki = Console.ReadKey(false);
            return cki.KeyChar.ToString();
        }

        private static string DisplayLorryMenu()
        {
            Console.WriteLine("1. Ввод марки.");
            Console.WriteLine("2. Ввод количества цилиндров.");
            Console.WriteLine("3. Ввод мощности двигателя.");
            Console.WriteLine("4. Вывод показателей авто.");
            Console.WriteLine("5. Ввод грузоподъёмности.");
            Console.WriteLine("6. Возврат к предыдущему меню.");

            var cki = Console.ReadKey(false);
            return cki.KeyChar.ToString();
        }
    }
}
