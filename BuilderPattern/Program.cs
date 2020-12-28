using System;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            var vegMeal = mealBuilder.prepareVegMeal();
            vegMeal.showItems();

            var nonMeal = mealBuilder.prepareNonVegMeal();
            nonMeal.showItems();

            Console.ReadKey();
        }
    }
}