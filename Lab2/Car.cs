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

        public virtual void Print()
        {
            Console.WriteLine("Марка автомобиля: {0}", Manufacturer);
            Console.WriteLine("Количество цилиндров двигателя: {0}", CylinderCount);
            Console.WriteLine("Мощность двигателя: {0}", Power);
        }
    }

    class Lorry : Car
    {
        public int Carrying { get; set; }

        public Lorry()
        {
            Carrying = 0;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Грузоподъёмность: {0}", Carrying);
        }

    }

    class Test
    {
        private static void Main()
        {
            Console.Title = "Лабораторная работа №2";
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
                        CarMenuLogic(car);
                        break;
                    case "2":
                        Console.Clear();
                        LorryMenuLogic(lorry);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный пункт меню.");
                        break;
                }
            } while (userInput != "3");
        }

        private static void SetManufacturer(Car car)
        {
            try
            {
                car.Manufacturer = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите марку автомобиля заново");
            }
        }

        private static void SetManufacturer(Lorry lorry)
        {
            try
            {
                lorry.Manufacturer = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите марку грузовика заново.");
            }
        }

        private static void SetCylinderCount(Car car)
        {
            try
            {
                car.CylinderCount = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите количество цилиндров двигателя заново.");
            }
        }

        private static void SetCylinderCount(Lorry lorry)
        {
            try
            {
                lorry.CylinderCount = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите количество цилиндров двигателя заново.");
            }
        }

        private static void SetPower(Car car)
        {
            try
            {
                car.Power = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите мощность двигателя заново.");
            }
        }

        private static void SetPower(Lorry lorry)
        {
            try
            {
                lorry.Power = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите мощность двигателя заново.");
            }
        }

        private static void SetCarrying(Lorry lorry)
        {
            try
            {
                lorry.Carrying = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите грузоподъёмность заново.");
            }
        }

        private static void CarMenuLogic(Car car)
        {
            string userInput;
            do
            {
                userInput = DisplayCarMenu();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        SetManufacturer(car);
                        break;
                    case "2":
                        Console.Clear();
                        SetCylinderCount(car);
                        break;
                    case "3":
                        Console.Clear();
                        SetPower(car);
                        break;
                    case "4":
                        Console.Clear();
                        car.Print();
                        break;
                    case "5":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный пункт меню.");
                        break;
                }
            } while (userInput != "5");
        }

        private static void LorryMenuLogic(Lorry lorry)
        {
            string userInput;
            do
            {
                userInput = DisplayLorryMenu();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        SetManufacturer(lorry);
                        break;
                    case "2":
                        Console.Clear();
                        SetCylinderCount(lorry);
                        break;
                    case "3":
                        Console.Clear();
                        SetPower(lorry);
                        break;
                    case "4":
                        Console.Clear();
                        SetCarrying(lorry);
                        break;
                    case "5":
                        Console.Clear();
                        lorry.Print();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный пункт меню.");
                        break;
                }
            } while (userInput != "6");
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
            Console.WriteLine("4. Ввод грузоподъёмности.");
            Console.WriteLine("5. Вывод показателей грузовика.");
            Console.WriteLine("6. Возврат к предыдущему меню.");

            var cki = Console.ReadKey(false);
            return cki.KeyChar.ToString();
        }
    }
}
