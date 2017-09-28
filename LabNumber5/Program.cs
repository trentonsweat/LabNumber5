using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            bool RollAgain = true;



            int NumofSidesdice; //declare variables




            string UserChoice;
            Console.WriteLine("Welcome to the Grand Circus Casino! Do you want  (N/No/y/yes)");
            UserChoice = Console.ReadLine();
            if (UserChoice == "N" || UserChoice == "No")
            {
                ProgramContinue = false;
            }

            else
            {
                ProgramContinue = true;


            }

            while (RollAgain == true)
            {

                Console.WriteLine("How many sides should each die have?");
                NumofSidesdice = int.Parse(Console.ReadLine());

                DiceRolls(1, NumofSidesdice);

                Console.WriteLine("Do you want to play again?");

                string userinput = Console.ReadLine();

                if (userinput == "Yes" || userinput == "yes" || userinput == "y" || userinput == "Y")
                {
                    RollAgain = true;
                }

                else if (userinput == "No" || userinput == "no" || userinput == "n" || userinput == "N")
                {
                    RollAgain = false;
                }
            }



            
        }
        static void DiceRolls(int rollOne, int rollTwo)
        {
            Random rnd = new Random();
            int x = rnd.Next(rollOne, rollTwo);
            int y = rnd.Next(rollOne, rollTwo);

            Console.WriteLine("This is your first roll" + rollOne);
            Console.WriteLine("This is your second roll" + rollTwo);
        }



    }
}
