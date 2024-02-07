using System;
using System.Collections.Generic;
using System.Text;

namespace budgetcalculator
{
    class BudgetClass
    {
        private int budget;
        private int spent;
        private int result;

        public void Budget()
        {
            Console.WriteLine("What is your budget?");
            int newBudget = int.Parse(Console.ReadLine());
            budget = newBudget;

            Console.WriteLine("How much did you spend on groceries?");
            Prompt();

            Console.WriteLine("How much did you spend eating out?");
            Prompt();


            Console.WriteLine("How did you spend on gas?");
            Prompt();

            Console.WriteLine("How much did you spend on shopping for clothes, accessories, beauty products?");
            Prompt();

            Console.WriteLine("How much did you spend on reoccuring bills?");
            Prompt();

            Console.WriteLine("How much did you spend on medical bills?");
            Prompt();

            Console.WriteLine("How much did you spend on other or uncatogrized bills?");
            Prompt();

            string overOrUnder = OverOrUnder(result);
            Console.WriteLine("You spent $" + result + " " + overOrUnder + "your budget.");
            Console.ReadLine();

        }

        public void Prompt()
        {
            spent = int.Parse(Console.ReadLine());
            result = Calculate(spent);
        }

        public int Calculate(int spent)
        {
            budget = budget - spent;
            return budget;
        }

        public string OverOrUnder(int result)
        {
            if (result >= 0) return "under";

            return "over";
        }
    }
}
