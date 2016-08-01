using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class MyVirtualPet
    {
        private string name;
        private double hunger;
        private double activeness;
        private double obedience;

        public MyVirtualPet(string newName, double newHunger, double newActiveness, double newObedience)
        {
            name = newName;
            hunger = newHunger;
            activeness = newActiveness;
            obedience = newObedience;
        }

        public void setName(string newName)
        {
            name = newName;
        }
        public string getName()
        {
            return name;
        }

        public void setHunger(double newHunger)
        {
            hunger = newHunger;
        }
        public double getHunger()
        {
            return hunger;
        }
        public void setActiveness(double newActiveness)
        {
            activeness = newActiveness;
        }
        public double getActiveness()
        {
            return activeness;
        }
        public void setObedience(double newObedience)
        {
            obedience = newObedience;
        }
        public double getObedience()
        {
            return obedience;
        }


        public void printDetails()
        {
            StringBuilder virtpetinfo = new StringBuilder();
            virtpetinfo.Append("Name: " + name);
            virtpetinfo.Append("\nHunger: " + hunger);
            virtpetinfo.Append("\nActiveness: " + activeness);
            virtpetinfo.Append("\nObedience: " + obedience);
            Console.WriteLine(virtpetinfo.ToString());
        }




        public void Feed()
        {
            string secondFeedAnswer;
            Console.WriteLine("Would you like to feed Dug? (YES/NO)");
            string feedAnswer = Console.ReadLine().ToUpper();
            if (feedAnswer == "YES")
            {
                do
                {
                    Console.WriteLine("What would you like to feed dug? (Steak or Dog food)");
                    string foodChoice = Console.ReadLine().ToUpper();
                    switch (foodChoice)
                    {
                        case "STEAK":
                            hunger = hunger + 25;
                            break;
                        case "DOG FOOD":
                            hunger = hunger + 15;
                            break;
                    }
                    Console.WriteLine("Would you like to feed him anything else (YES/NO)?");
                    secondFeedAnswer = Console.ReadLine().ToUpper();
                }
                while (secondFeedAnswer == "YES");
            }
            else if (feedAnswer == "NO")
            {
                hunger = hunger - 20;
            }
        }






        public void activePup()
        {
            string secondActivityAnswer;
            Console.WriteLine("Dug wants to go do something fun! What do ya say? (YES/NO)");
            string activityAnswer = Console.ReadLine().ToUpper();
            if (activityAnswer == "YES")
            {
                do
                {
                    Console.WriteLine("What fun activities would you like to choose? \nChoose from one of the following: Walk or fetch");
                    string activityChoice = Console.ReadLine().ToUpper();
                    switch (activityChoice)
                    {
                        case "WALK":
                            activeness = activeness + 15;
                            break;
                        case "FETCH":
                            activeness = activeness + 25;
                            break;
                    }
                    Console.WriteLine("Would you like to partake in another walk or game of fetch? (YES/NO)");
                    secondActivityAnswer = Console.ReadLine().ToUpper();
                }
                while (secondActivityAnswer == "YES");
            }
            else if (activityAnswer == "NO")
            {
                activeness = activeness - 20;
            }
        }






        public void training()
        {
            string secondTrainingAnswer;
            Console.WriteLine("Would you like to take some time to train Dug? (YES/NO)");
            string trainingAnswer = Console.ReadLine().ToUpper();
            if (trainingAnswer == "YES")
            {
                do
                {
                    Console.WriteLine("What would you and Dug like to spend your time training on? \n Choose from one of the following: Sit or Roll Over");
                    string trainingChoice = Console.ReadLine().ToUpper();
                    switch (trainingChoice)
                    {
                        case "SIT":
                            obedience = obedience + 15;
                            break;
                        case "ROLL OVER":
                            obedience = obedience + 25;
                            break;
                    }
                    Console.WriteLine("Would you and Dug like to work on any other skills? (YES/NO)");
                    secondTrainingAnswer = Console.ReadLine().ToUpper();
                }
                while (secondTrainingAnswer == "YES");
           }
            else if (trainingAnswer == "NO")
            {
                obedience = obedience - 20;
            }
        }





        public void Tick()
        {
            hunger = hunger - 10;
            activeness = activeness - 7;
            obedience = obedience - 4;
        }










    }
}
