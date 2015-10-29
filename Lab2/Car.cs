using System;

namespace Lab2
{
    class Car
    {
        public string Manufacturer { get; set; }
        public int CylinderCount { get; set; }
        public int Power { get; set; }

        public Car()
        {
            Manufacturer = "N/A";
            CylinderCount = 0;
            Power = 0;
        }
    }

    class Lorry : Car
    {
        public int Carrying { get; set; }

        public Lorry()
        {
            Carrying = 0;
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
                                    Console.WriteLine("Введите марку автомобиля, количество цилиндров двигателя и его мощность.");
                                    try
                                    {
                                        car.Manufacturer = Console.ReadLine();
                                        car.CylinderCount = Convert.ToInt32(Console.ReadLine());
                                        car.Power = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch (FormatException exception)
                                    {
                                        Console.WriteLine(exception.Message);
                                        Console.WriteLine("Введите данные заново.");
                                    }
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
