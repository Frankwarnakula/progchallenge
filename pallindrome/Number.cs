namespace pallindrome
{
    public class Number
    {

        public bool IsPallindrome(int number)
        {
            if (number < 0)
            {
                return false;
            }
            return (number - this.ReverseNumber(number) == 0) ? true : false;
        }

        private int ReverseNumber(int number)
        {
            int reverseNumber = 0;

            if ((number / 10) == 0)
            {
                return number;
            }

            while (number / 10 > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit > 0)
                {
                    reverseNumber += lastDigit;
                    number -= lastDigit;
                    if (number > 10)
                    {
                        number /= 10;
                        reverseNumber *= 10;
                    }
                }
                if (lastDigit == 0)
                {
                    number /= 10;
                    reverseNumber *= 10;

                    if (number < 10)
                    {
                        reverseNumber += number;
                        number = 0;
                    }
                }
            }
            return reverseNumber + number;
        }
    }
}

