using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SweetsShop
{
    
    
    class Drinks
    {

    }
    class Coctale : Drinks
    {

    }
    class Soda : Drinks
    {

    }
    class Juice : Drinks
    {

    }
    class Watter : Drinks
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветсвуем вас в магазине 'CandyShop' !!!");
            Console.WriteLine("Выберите раздел интересующий вас\n1 - О людях, 2 - еда, 3 - напитки");
            int choice = Convert.ToInt32(Console.ReadLine());
            Choice(choice);

        }

        public static void Choice(int choice)
        {
            string name, lastname, position, preferences;
            List<Employee> employees = new List<Employee>();
            List<Buyer> buyers = new List<Buyer>();
            if (choice == 1)
            {
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
                        Choice(choice);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели не число\nПожалуйста постарайтесь отличить число от букв и впишите число!!!!");
                    Choice(choice);
                }
            }
        }
        public static void Fuuds(string dirrect)
        {
            string massstr, nameof, stockstr, price;
            int mass, stock;
            List<Food> foods = new List<Food>();
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
                    foods.Add(new Food(nameof, mass, price, stock));
                }
            }
            foreach (var item in foods)
            {
                item.PrintInfo();
            }
        }
        
    }
}
