using System;
using LinkGroup.Fizz;
using LinkGroup.Buzz;
using LinkGroup.FizzBuzzHandler;
using LinkGroup.InputValidationInterface;

namespace LinkGroup
{
    class Program
    {  
        static void Main(String[] args)
        {

            IFizzBuzz _fizzBuzzHandler = new FizzBuzz.DisaplyFizzBuzz(new DisplayFizz(new DisplayBuzz()));
            IValidation _validateInput = new InputValidation.Validation();

            try
            {
                Console.Write("Enter number : ");
                string input = Console.ReadLine();
                int num = Convert.ToInt32(_validateInput.validateInput(input));
                for (int i = 1; i <= num; i++)
                {
                    string res = _fizzBuzzHandler.methodCommon(i);
                    Console.WriteLine(res);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured because " + e.Message);
            }
        }
    }
}
