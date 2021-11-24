using System;
using System.Collections.Generic;
using System.Linq;

namespace learningCSharp //program name
{
    class Program //where code goes
    {
        static void Main(string[] args) //main gets read first
        {
            IfStatement();

            //Console.WriteLine(Cube(5)); //prints the value being returned from the function

            //SayHi("Mike", 10); //calls a method/function with two paramaters

            //LearningArrays();

            //UserPoem();

            //SimpleCalculator();

            //UserInput();

            //Numbers();

            //ExampleStings();

            //DataTypes();

            Console.ReadLine();
        }
        static void IfStatement()
        {
            bool isMale = true; //creates a boolean
            bool isTall = true;

            if (isMale && isTall) { //if statement to check value of both variables
                Console.WriteLine("you are male and tall");
            } else if (!isMale && isTall) {
                Console.WriteLine("you are a tall female");
            } else if (isMale && !isTall) {
                Console.WriteLine("you are a small male");
            } else { //else statement to be run if, IF statement doesnt run
                Console.WriteLine("you are a small female");
            }
        }
        static int Cube(int num) //function that returns an integer
        {
            int result = num * num * num;
            return result; //returns the result vale
        }
        static void SayHi(String name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
        static void LearningArrays()
        {
            int[] luckyNumbers = { 2, 4, 6, 8, 10 }; //create array method 1
            luckyNumbers[0] = 900; //changes the index postion 0 to 900

            Console.WriteLine(luckyNumbers[0]); //prints out a number from the index postion designated

            string[] friends = new string[10]; //creates array while giving it a max length of 10 
            //adding variables to the new array
            friends[0] = "max";
            friends[1] = "jane";
            friends[2] = "kelly";

            Console.ReadLine();
        }
        static void UserPoem()
        {
            string color, noun, feeling; //another way to declare variables

            Console.Write("enter a color: ");
            color = Console.ReadLine();

            Console.Write("enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("enter a feeling: ");
            feeling = Console.ReadLine();

            Console.WriteLine("roses are " + color);
            Console.WriteLine(noun + " are blue");
            Console.WriteLine("I " + feeling + " you");

            Console.ReadLine();
        }
        static void SimpleCalculator()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
        static void UserInput()
        {
            Console.Write("Enter your name: "); //prints text on screen but not ending the line
            string name = Console.ReadLine(); //stores user input
            Console.WriteLine("Hello " + name + " It's nice to meet you"); //displays user input with a greeting
            Console.Write("What is your age: "); //prints text on screen but not ending the line
            string age = Console.ReadLine(); //stores user input
            Console.WriteLine("Hello " + name + " so you are " + age + " old"); //displays user input with a greeting

            Console.ReadLine(); //Reads user input
        }
        static void Numbers()
        {
            int num = 0;
            int num2 = Convert.ToInt32("45"); //converts string to integer

            num++; //increases number by 1
            Console.WriteLine(num);
            num--; //decreases number by 1
            Console.WriteLine(num);

            Console.WriteLine(5 % 2); //prints remainder which is 1
            Console.WriteLine(Math.Abs(-40)); //prints value so 40
            Console.WriteLine(Math.Pow(3.8, 2)); //to the power of
            Console.WriteLine(Math.Sqrt(36)); //square root
            Console.WriteLine(Math.Max(5, 3)); //prints bigger number
            Console.WriteLine(Math.Min(5, 3)); //prints lower number
            Console.WriteLine(Math.Round(4.6)); //round the number

            Console.ReadLine(); //Reads user input
        }
        static void ExampleStings()
        {
            string response = "sincerly \n Adam Kemp";

            Console.WriteLine(response); //writes value of string
            Console.WriteLine("sincerly \n Adam Kemp"); //writes value to console on seperate lines
            Console.WriteLine(response.Length); //responds with characters in string
            Console.WriteLine(response.ToUpper()); //calls method to print string in uppercase
            Console.WriteLine(response.Contains("Adam")); //checks to see if "Adam" is contained in the string
            Console.WriteLine(response[0]); //Prints out first character in string
            Console.WriteLine(response.IndexOf("Adam")); //where does it start in the string e.g. 13 and -1 means its not in the string
            Console.WriteLine(response.Substring(4,3)); //Starts string at a specific character, while second number is how many characters after you want to grab
            
            Console.ReadLine(); //Reads user input
        }
        static void DataTypes()
        {
            //data types
            string name = "Hello"; //string 
            char grade = 'A'; //1 character
            int age = 50; //whole number
            double number = 3.3; //decimal
            bool answer = false; //boolean for true or false answer
        }
    }
}