using System;
using System.Collections.Generic;

namespace AssignmentQuestion
{
    public interface IMealPlan
    {
        string GetMealType();
        void DisplayMeal();
    }

    public class VegetarianMeal : IMealPlan
    {
        public string MealName;

        public VegetarianMeal(string mealName)
        {
            MealName = mealName;
        }

        public string GetMealType()
        {
            return "Vegetarian";
        }

        public void DisplayMeal()
        {
            Console.WriteLine($"Meal: {MealName}, Type: {GetMealType()}");
        }
    }

    public class VeganMeal : IMealPlan
    {
        public string MealName;

        public VeganMeal(string mealName)
        {
            MealName = mealName;
        }

        public string GetMealType()
        {
            return "Vegan";
        }

        public void DisplayMeal()
        {
            Console.WriteLine($"Meal: {MealName}, Type: {GetMealType()}");
        }
    }

    public class KetoMeal : IMealPlan
    {
        public string MealName;

        public KetoMeal(string mealName)
        {
            MealName = mealName;
        }

        public string GetMealType()
        {
            return "Keto";
        }

        public void DisplayMeal()
        {
            Console.WriteLine($"Meal: {MealName}, Type: {GetMealType()}");
        }
    }

    public class HighProteinMeal : IMealPlan
    {
        public string MealName;

        public HighProteinMeal(string mealName)
        {
            MealName = mealName;
        }

        public string GetMealType()
        {
            return "High-Protein";
        }

        public void DisplayMeal()
        {
            Console.WriteLine($"Meal: {MealName}, Type: {GetMealType()}");
        }
    }

    public class Meal<T> where T : IMealPlan
    {
        public T MealPlan;

        public Meal(T mealPlan)
        {
            MealPlan = mealPlan;
        }

        public void GenerateMealPlan()
        {
            Console.WriteLine("Meal Plan Generated:");
            MealPlan.DisplayMeal();
        }
    }

    public class MealPlanGenerator
    {
        public static bool ValidateMealPlan<T>(T meal)
            where T : IMealPlan
        {
            return meal != null;
        }
        public static void Generate<T>(T meal)
            where T : IMealPlan
        {
            if (ValidateMealPlan(meal))
            {
                Console.WriteLine("Valid meal plan.");
                meal.DisplayMeal();
            }
            else
            {
                Console.WriteLine("Invalid meal plan.");
            }
        }
    }

    public class Question4
    {
        public static void Run()
        {
            Console.WriteLine("\n===== PERSONALIZED MEAL PLAN GENERATOR =====\n");
            VegetarianMeal vegetarian = new VegetarianMeal("Paneer Rice");
            VeganMeal vegan = new VeganMeal("Vegan Salad");
            KetoMeal keto = new KetoMeal("Egg Avocado Bowl");
            HighProteinMeal protein = new HighProteinMeal("Chicken Protein Bowl");
            Meal<VegetarianMeal> vegetarianPlan = new Meal<VegetarianMeal>(vegetarian);
            Meal<VeganMeal> veganPlan = new Meal<VeganMeal>(vegan);

            Console.WriteLine("--- Personalized Meal Plans ---");
            vegetarianPlan.GenerateMealPlan(); 
            veganPlan.GenerateMealPlan();

            Console.WriteLine("\n--- Validation & Generation ---");
            MealPlanGenerator.Generate(vegetarian); 
            MealPlanGenerator.Generate(vegan); 
            MealPlanGenerator.Generate(keto);
            MealPlanGenerator.Generate(protein);

            Console.WriteLine("\n--- All Meal Plans ---");
            List<IMealPlan> mealPlans = new List<IMealPlan>();
            mealPlans.Add(vegetarian); 
            mealPlans.Add(vegan); 
            mealPlans.Add(keto); 
            mealPlans.Add(protein);
            foreach (IMealPlan meal in mealPlans) 
            { 
                meal.DisplayMeal(); 
            }
        }
    }
}