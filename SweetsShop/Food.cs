using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SweetsShop
{
    abstract class Food
    {
        public string NameOf { get; private set; }
        public int Mass { get; private set; }
        public string Price { get; private set; }
        public int Stock { get; private set; }
        public Food(string nameof, int mass, string price, int stock)
        {
            NameOf = nameof;
            Mass = mass;
            Price = price;
            Stock = stock;
            
        }
        abstract public void PrintInfo();

    }

    class Chocolate : Food
    {
        public string Stuffing { set; private get; }
        public Chocolate(string nameof, int mass, string price, int stock, string stuffing) : base (nameof, mass, price, stock)
        {
            Stuffing = stuffing;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{NameOf}, {Mass}гр, {Price}р, {Stock}шт");
        }

    }
    class Candy : Food
    {
        public Candy(string nameof, int mass, string price, int stock) : base(nameof, mass, price, stock)
        {
            
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{NameOf}, {Mass}гр, {Price}р, {Stock}шт");
        }

    }
    class Marmalade : Food
    {
        public Marmalade(string nameof, int mass, string price, int stock) : base(nameof, mass, price, stock)
        {

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{NameOf}, {Mass}гр, {Price}р, {Stock}шт");
        }
    }
    class Marshmallow : Food
    {
        public Marshmallow(string nameof, int mass, string price, int stock) : base(nameof, mass, price, stock)
        {

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{NameOf}, {Mass}гр, {Price}р, {Stock}шт");
        }
    }
}
