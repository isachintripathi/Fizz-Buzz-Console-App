using LinkGroup.FizzBuzzHandler;

namespace LinkGroup.FizzBuzz
{
    public class DisaplyFizzBuzz : IFizzBuzz
    {
        private readonly IFizzBuzz _fizzBuzzHandler;

        public DisaplyFizzBuzz(IFizzBuzz fizzBuzzHandlerService)
        {
            _fizzBuzzHandler = fizzBuzzHandlerService;
        }

        /// <summary>
        /// This Method will display Fizz Buzz if Input provided is Divisors by 15.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string methodCommon(int num)
        {
            if (num % 15 == 0)              // Here, Divisors of 3 and 5 will also be Divisors by 15. To avoid Multiple execution.
                return "Fizz Buzz";

            return _fizzBuzzHandler.methodCommon(num);
        }

    }
}
