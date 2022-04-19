using System;
using System.Collections.Generic;

namespace Little_ERP
{
    internal class Program
    {

        // Initialization
        public static List<string> groc = new List<string>();
        public static List<string> cosm = new List<string>();
        public static List<string> tech = new List<string>();

        public static bool isGroc, isCosm, isTech, isExit;

        static void Main(string[] args)
        {
            // Filling the data tables
            groc.Add("Tomato");
            groc.Add("Potato");
            groc.Add("Brocoli");

            cosm.Add("Eyeliner");
            cosm.Add("Invisiline");
            cosm.Add("Lipstick");

            tech.Add("Smart Phone");
            tech.Add("Laptop");
            tech.Add("Security Camera");

            while (true)
            {
                // Client Input
                Console.Write("(Query) >> Enter the Product name: ");
                string res = Console.ReadLine();

                // Scan groc list
                foreach (string i in groc)
                {
                    if (i == res)
                    {
                        Console.WriteLine("(Query) >> Product is in the 'Groceries' section!");
                        isGroc = true;
                        break;
                    }
                    else
                    {
                        isGroc = false;
                    }
                }

                // Scan cosm list
                foreach (string i in cosm)
                {
                    if (i == res)
                    {
                        Console.WriteLine("(Query) >> Product is in the 'Cosmetic' section!");
                        isCosm = true;
                        break;
                    }
                    else
                    {
                        isCosm = false;
                    }
                }

                // Scan tech list
                foreach (string i in tech)
                {
                    if (i == res)
                    {
                        Console.WriteLine("(Query) >> Product is in the 'Technology' section!");
                        isTech = true;
                        break;
                    }
                    else
                    {
                        isTech = false;
                    }
                }

                //Quit
                if (res == "exit")
                {
                    isExit = true;
                    break;
                }

                // Out of Stock
                if (isGroc == false && isCosm == false && isTech == false && isExit ==false)
                {
                    Console.WriteLine("(Query) >> Product is Out of Stock!");
                }

                

            }

            

        }
    }
}
