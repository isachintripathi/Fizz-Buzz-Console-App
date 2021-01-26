using LinkGroup.FizzBuzzHandler;

namespace LinkGroup.Fizz
{
    public class DisplayFizz : IFizzBuzz
    {
        private readonly IFizzBuzz _fizzBuzzHandler;

        public DisplayFizz(IFizzBuzz fizzBuzzHandlerService)
        {
            _fizzBuzzHandler = fizzBuzzHandlerService;
        }

        /// <summary>
        /// This Method will display Fizz if Input provided is Divisors by 3.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string methodCommon(int num)
        {
            if (num % 3 == 0)
                return "Fizz";

            return _fizzBuzzHandler.methodCommon(num);
        }

    }
}
