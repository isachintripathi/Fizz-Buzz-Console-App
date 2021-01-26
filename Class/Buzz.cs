using LinkGroup.FizzBuzzHandler;

namespace LinkGroup.Buzz
{
    public class DisplayBuzz : IFizzBuzz
    {
        /// <summary>
        /// This Method will display Buzz if Input provided is Divisors by 5.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string methodCommon(int num)
        {
            if (num % 5 == 0)
                return "Buzz";

            return num.ToString();
        }
    }
}
