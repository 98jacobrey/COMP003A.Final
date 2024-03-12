using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*
* Author:  Jacob Autrey
* Course:  COMP-003A-L01
* Purpose: Final - Dating app that takes user input and prints it into the console
*/

// TODO: missing exception handling
// I don't know what that means^
namespace COMP003A.Final
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: what is the purpose of this variable?
            //The List<string> profile, List<string> questions, and List<string> answers variables are all here to initialize them so they can be passed through the methods later in the code
            List<string> profile = new List<string>();
            List<string> questions = new List<string> { "Do you have kids?", "What are your hobbies?", "What is your favorite food?", "What is your favorite color?", "What are you looking for?", "What is your love language?", "What languages do you speak?", "What would you pick as a theme song?", "Can you cook?", "Do you play Tekken?" };
            List<string> answers = new List<string>();

            Title("Dating App");

            Console.WriteLine("Please type your first name");
            Name(profile);

            Console.WriteLine("Please type your last name");
            Name(profile);

            Console.WriteLine("Please type your birth year");
            Age(profile);

            Console.WriteLine("Please enter your gender: M - male, F - female, O - other");
            Gender(profile);

            Questionare(questions, answers);

            Title("Profile");
            ProfilePrint(profile);
            QuestionarePrint(questions, answers);

        }

        // TODO: why is this method accepting List<string> profile as a parameter?
        // TODO: why is this approach acceptable?
        // TODO: is the parameter passed by value or by reference?
        //This method takes the List<string> profile parameter as a reference in order to add in the results after the code has been ran
        /// <summary>
        /// Method takes in a list for parameter then checks if the user input is a string with only letters before adding it to the list
        /// </summary>
        /// <param name="profile"></param>
        static void Name(List<string> profile)
        {
            string answer = new string("");
            // TODO: refactor this variable into a boolean
            bool check = false;
            do
            {
                answer = Console.ReadLine();
                // TODO: what is the purpose of the code block below?
                // TODO: what does Regex.IsMatch(answer, @"^[a-zA-Z]+$") do?
                //the code below checks the user input and runs it through Regex.IsMatch(answer, @"^[a-zA-Z]+$") to ensure their answer has the following characters present
                if (Regex.IsMatch(answer, @"^[a-zA-Z]+$"))
                {
                    profile.Add(answer);
                    check = true;

                }
                else
                {
                    Console.WriteLine("Answer can not contain numbers or special characters");
                }

            } while (check == false);
        }

        // TODO: why is this method accepting List<string> profile as a parameter?
        // TODO: why is this approach acceptable?
        // TODO: is the parameter passed by value or by reference?
        //This method takes the List<string> profile parameter as a reference in order to add in the results after the code has been ran
        /// <summary>
        /// Method takes in a list for a parameter then checks if the user input is an int that is in between 1900 and 2024 before subtracting it from 2024 and adding it to the list
        /// </summary>
        /// <param name="profile"></param>
        static void Age(List<string> profile)
        {
            int tempAnswer = new int();
            string answer = new string("");
            // TODO: refactor this variable into a boolean
            bool check = false;
            do
            {
                answer = Console.ReadLine();
                // TODO: what is the purpose of the code block below?
                // TODO: what does Regex.IsMatch(answer, @"^[0-9]+$") do?
                //the code below checks the user input and runs it through Regex.IsMatch(answer, @"^[0-9]+$") to ensure their answer has the following characters present
                if (Regex.IsMatch(answer, @"^[0-9]+$"))
                {
                    // TODO: consider adding exception handling for these conversions
                    // Unsure how to do that^
                    tempAnswer = Convert.ToInt32(answer);
                    if (tempAnswer >= 1900 && tempAnswer <= 2024)
                    {
                        answer = Convert.ToString(2024 - tempAnswer);
                        profile.Add("Age: " + answer);
                        check = true;

                    }
                    else
                    {
                        Console.WriteLine("Answer must be a number between 1900 and 2024");
                    }
                }
                else
                {
                    Console.WriteLine("Answer must be a number");
                }
            } while (check == false);
        }

        // TODO: why is this method accepting List<string> profile as a parameter?
        // TODO: why is this approach acceptable?
        // TODO: is the parameter passed by value or by reference?
        //This method takes the List<string> profile parameter as a reference in order to add in the results after the code has been ran
        /// <summary>
        /// Method takes in a list and checks if the user input is either an M, F, or O and converts it to a gender before adding it to the list 
        /// </summary>
        /// <param name="profile"></param>
        static void Gender(List<string> profile)
        {
            string answer = new string("");
            // TODO: refactor this variable into a boolean
            bool check = false;
            do
            {
                answer = Console.ReadLine();
                // TODO: what is the purpose of the code block below?
                // TODO: what does Regex.IsMatch(answer, @"^[mfoMFO]+$") do?
                //the code below checks the user input and runs it through Regex.IsMatch(answer, @"^[mfoMFO]+$") to ensure their answer has the following characters present
                if (Regex.IsMatch(answer, @"^[mfoMFO]+$"))
                {
                    if (Regex.IsMatch(answer, @"^[mM]"))
                    {
                        answer = "Male";
                    }
                    else if (Regex.IsMatch(answer, @"^[fF]"))
                    {
                        answer = "Female";
                    }
                    else
                    {
                        answer = "other";
                    }
                    profile.Add("Gender: " + answer);
                    check = true;

                }
                else
                {
                    Console.WriteLine("Answer was not m, f or o");
                }

            } while (check == false);
        }

        /// <summary>
        /// Method goes through list of questions and stores the answers in a seperate list
        /// </summary>
        /// <param name="questions"></param>
        /// <param name="answers"></param>
        static void Questionare(List<string> questions, List<string> answers)
        {
            string answer = new string("");
            // TODO: refactor this variable into a boolean
            bool check = false;
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                do
                {
                    check = false;
                    answer = Console.ReadLine();
                    // TODO: add validation here to ensure the answer is ALSO not whitespaces
                    //Could not figure out how to do this^
                    // TODO: what is the purpose of the code block below?
                    // TODO: what does Regex.IsMatch(answer, @"^[\sa-zA-ZO0-9_]+$") do?
                    //the code below checks the user input and runs it through Regex.IsMatch(answer, @"^[\sa-zA-ZO0-9_]+$") to ensure their answer has the following characters present
                    if (Regex.IsMatch(answer, @"^[\sa-zA-ZO0-9_]+$"))
                    {
                        answers.Add(answer);
                        check = true;

                    }
                    else
                    {
                        Console.WriteLine("Answer can not be left blank");
                    }

                } while (check == false);
            }
        }


        /// <summary>
        /// Method prints list of questions and answers in an alternating pattern so the two are coresponding to each other
        /// </summary>
        /// <param name="questions"></param>
        /// <param name="answers"></param>
        static void QuestionarePrint(List<string> questions, List<string> answers)
        {
            for (int i = 0; i <= questions.Count - 1; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine(answers[i]);
            }
        }

        // TODO: why is this method accepting List<string> profile as a parameter?
        // TODO: why is this approach acceptable?
        // TODO: is the parameter passed by value or by reference?
        //This method takes the List<string> profile parameter as a reference in order to add in the results after the code has been ran
        /// <summary>
        /// Method itterates through a list and prints each instance
        /// </summary>
        /// <param name="profile"></param>
        static void ProfilePrint(List<string> profile)
        {
            // TODO: what is profile here?
            // TODO: what is answers here?
            //answer here are each index fromt the initial passed down list from the parameters of this method
            foreach (string answers in profile)
            {
                Console.WriteLine(answers);
            }
        }

        /// <summary>
        /// Creates a cool title
        /// </summary>
        /// <param name="title"></param>
        static void Title(string title)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t{title}  \n" + "".PadRight(50, '*'));
        }
    }
}
