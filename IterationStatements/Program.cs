namespace IterationStatements
{


    //EXERCISE 3 Iteration-Statements-Exercise
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i=1000; i<-1000; i--)
            {
                Console.WriteLine($"i");
            }
        }//PrintThousand




        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Printby3()
        {
            for (int i = 3; i >=999; i+=3)
            {
                Console.WriteLine($"i");
            }
        }//Printby3



        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CheckNbrs(int i, int j)
        {
            if ( i == j)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }//CheckNbrs

        //Write a method to check whether a given number is even or odd
        public static void OddEven(int i)
        {
            if ( i%2 == 0 )
            {
                Console.WriteLine("Its even");
            }
            else
            {
                Console.WriteLine("its odd");
            }
        }//OddEven


        //Write a method to check whether a given number is positive or negative
        public static void Positive(int i)
        {
            if (i >  0)
            {
                Console.WriteLine("Its Positive");
            }
            else
            {
                Console.WriteLine("its Negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void Vote()
        {
            string age = "0";
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();
            int ageInt = int.Parse(age);
            if ( ageInt >= 18)
            {
                Console.WriteLine("you can vote");
            }
            else
            {
                Console.WriteLine("Not old enough");
            }
        }//Vote


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            string ranStr = "";
            Console.WriteLine("Enter a number");
            ranStr = Console.ReadLine();
            int ranInt = int.Parse(ranStr);
            if (ranInt >= -10 && ranInt <= 10)
            {
                Console.WriteLine("between -10 and 10");
            }
            else
            {
                Console.WriteLine("Not between - 10 and 10");
            }
        }//Range



        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable(int nbr)
        {

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i * nbr}");
            }
        }//MultTable


                //Call the methods to test them in the Main method below
                static void Main(String[] args)
                {
            //int[] slime = { 1, 2, 3, 4 };
            //for (int i = 0; i < slime.Length; i++;) { Console.WriteLine(slime[i]; }

            PrintThousand();
                    Printby3();
                    CheckNbrs(4, 5);
                    OddEven(9);
                    Positive(8);
                    Vote();
                    Range();
                    MultTable(4);
                }//Main


        }//Program
}//Namespace
