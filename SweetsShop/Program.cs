using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SweetsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветсвуем вас в магазине 'CandyShop' !!!");
            string str = "0";
            TryCatch(str);

        }
        public static void TryCatch(string strr)
        {
            Console.WriteLine("Выберите раздел интересующий вас\n1 - О людях, 2 - еда, 3 - напитки");
            strr = Console.ReadLine();
            int choice;
            try
            {
                choice = int.Parse(strr);
                if (choice == 1)
                {
                    Human(choice);
                }
                else if (choice == 2)
                {
                    Food(choice);
                }
                else if (choice == 3)
                {

                }
                else
                {
                    Console.WriteLine("Вы ввели не число\nвведите число");
                    TryCatch(strr);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не число\nПожалуйста впишите требуемые значения");
                TryCatch(strr);

            }
        }

        public static void Human(int choice)
        {
            string name, lastname, position, preferences;
            List<Employee> employees = new List<Employee>();
            List<Buyer> buyers = new List<Buyer>();
            Console.WriteLine("1 - О сотрудниках, 2 - О покупателях\nВыберите раздел");
            string str = Console.ReadLine();
            int choicehum;
            try
            {
                choicehum = int.Parse(str);
                if (choicehum == 1)
                {
                    string dirrect = "persinf.txt";
                    using (StreamReader sr = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), dirrect)))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            name = line.Split(' ')[0];
                            lastname = line.Split(' ')[1];
                            position = line.Split(' ')[2];
                            employees.Add(new Employee(name, lastname, position));
                        }
                    }
                    foreach (var item in employees)
                    {
                        item.DisplayInfo();
                    }

                }
                else if (choicehum == 2)
                {
                    Console.WriteLine();
                    using (StreamReader ssr = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "buyinf.txt")))
                    {
                        string line;
                        while ((line = ssr.ReadLine()) != null)
                        {
                            name = line.Split(' ')[0];
                            lastname = line.Split(' ')[1];
                            preferences = line.Split(' ')[2];
                            buyers.Add(new Buyer(name, lastname, preferences));
                        }
                    }
                    foreach (var item in buyers)
                    {
                        item.DisplayInfo();
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильное число\nПожалуйста введите число от 1 до 2 ");
                    Human(choice);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не число\nПожалуйста постарайтесь отличить число от букв и впишите число!!!!");
                Human(choice);
            }

           

        }
        public static void Food(int choice)
        {
            Console.WriteLine("Шоколад - 1, конфит - 2, мармеладки - 3, маршмелоу - 4\nВыберите категорию товара");
            string chocolat = "chocolats.txt";
            string marmalads = "marmalads.txt";
            string marshmallow = "marshmallow.txt";
            string candy = "candy.txt";
            string str = Console.ReadLine();
            int choicenum;
            FoodChoice foodChoice = new FoodChoice();
            try
            {
                choicenum = int.Parse(str);
                if (choicenum == 1)
                {
                    Fuuds(candy);

                }
                else if (choicenum == 2)
                {
                    Fuuds(chocolat);
                }
                else if (choicenum == 3)
                {
                    Fuuds(marmalads);
                }
                else if (choicenum == 4)
                {
                    Fuuds(marshmallow);
                }
                else
                {
                    Console.WriteLine("Вы ввели не то число\nВведите число в диапазоне количества товаров");
                    Food(choice);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не число\nПожалуйста введите число");
                Food(choice);
            }
            
        }
        public static void Fuuds(string dirrect)
        {
            string massstr, nameof, stockstr, price;
            int mass, stock;
            List<InformationFood> foods = new List<InformationFood>();
            using (StreamReader sr = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), dirrect)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    nameof = line.Split(' ')[0];
                    massstr = line.Split(' ')[1];
                    mass = Convert.ToInt32(massstr);
                    price = line.Split(' ')[2];
                    stockstr = line.Split(' ')[3];
                    stock = Convert.ToInt32(stockstr);
                    foods.Add(new InformationFood(nameof, mass, price, stock));
                }
            }
            foreach (var item in foods)
            {
                item.PrintInfo();
            }
        }

    }
}
