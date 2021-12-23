using System;

namespace SyntacSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inferred Typing
            { var answer = 4;
              var response = 9;

                Console.WriteLine($"The (response) will equal the (answer) plus less than 9");
                Console.WriteLine($"The (response) will equal the (answer) plus greater than or equal to nice");
            }
            //String Interpolation
            {
                int answer = 4;
                Console.WriteLine("Guess the number I am thinking of?");
                string usersResponse =(Console.ReadLine());


                if (answer < 9)
                {
                    Console.WriteLine("The number equals to your answer less than nine");
                }

                else if (answer >= 9)
                {
                    Console.WriteLine("The number is the number you guessed plus it is greater than or equal to nine.");
                }

            }
            //Ternary Operator
            {
                var answer = 4;
                
                var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";



            }



            }
            
           

        }
    }
}
