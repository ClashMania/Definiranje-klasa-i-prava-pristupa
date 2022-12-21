using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definiranje_klasa_i_prava_pristupa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(110, foodType);
            System.Console.WriteLine(food.ToString());
            System.Console.WriteLine(food.ToStringInGrams());
            System.Console.ReadKey();
        }
    }

    class FoodType
    {
        private string name;
        private int protein, carbs, fat;
        static int counter = 0;

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter++;
        }

        public override string ToString()
        {
            return this.name + ": p - " + this.protein + "%, c - " + this.carbs + "%, f - " + this.fat + "%";
        }

        static int getNumberOfCreatedInstances()
        {
            return counter;
        }
    }

    class Food
    {
        int weight;
        FoodType type;

        public int Weight { get => weight; set => weight = value; }
        internal FoodType Type { get => type; }

        public Food(int weight, FoodType type)
        {
            this.type = type;
            this.weight = weight;
        }

        public double ProteinG { get => type.Protein; }
        public double CarbsG { get => type.Carbs; }
        public double FatG { get => type.Fat; }

        override public string ToString()
        {
            return this.type + ", w - " + this.weight + "g";
        }

        public string ToStringInGrams()
        {
            return "p - " + (this.ProteinG / 100) * this.weight + "g, c - " + (this.CarbsG / 100) * this.weight + "g, f - " + (this.FatG / 100) * this.weight + "g, w - " + this.weight + "g";
        }
    }
}