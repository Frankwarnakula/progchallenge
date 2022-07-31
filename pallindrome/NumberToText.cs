namespace pallindrome
{
    public class NumberToText
    {

        // number is grouped as 1 234 567 891
        // each group has a group suffix
        // and the maximum for each grouo=p is 999

        private const string SPACE = " ";
   
        private string getNumberInWords(int number)
        {
            switch (number)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                case 20: return "Twenty";
                case 30: return "Thirty";
                case 40: return "Forty";
                case 50: return "Fifty";
                case 60: return "Sixty";
                case 70: return "Seventy";
                case 80: return "Eighty";
                case 90: return "Ninety";
                case 100: return "Hundred";
                case 1000: return "Thousand";
                case 1000000: return "Million";
                case 1000000000: return "Billion";
            }
            return "";
        }

        private string numberUptoHundredToWord(int number)
        {
            string numberInWords = "";
            if (number <= 20)
            {
                // all the numbers upto 20 are unique
                numberInWords = this.getNumberInWords(number);
            }
            if (number >= 20 && number < 100)
            {
                // all the numbers of 10th fold are unique
                int remainder = number % 10;
                int whole = (number / 10) * 10;
                numberInWords = getNumberInWords(whole);
                numberInWords += remainder > 0 ? SPACE + getNumberInWords(remainder) : "";
            }

            return numberInWords;
        }

        private string numberUptoThousandToWord(int number)
        {
            string numberInWords = "";
            int numberOfHundreds = number / 100;
            int remainder = number % 100;

            if (numberOfHundreds > 0)
            {
                numberInWords = this.getNumberInWords(numberOfHundreds) + SPACE + getNumberInWords(100);

                if (remainder > 0)
                {
                    numberInWords += SPACE + numberUptoHundredToWord(remainder);
                }
            }
            else
            {
                return numberUptoHundredToWord(remainder);
            }

            return numberInWords;
        }

        public string numberToWords(int number)
        {
            int power = 1;
            string inWords = "";
            if (number < 1000)
            {
                return numberUptoThousandToWord(number);
            }
            while (number != 0)
            {
                string currentGroupInWords = "";
                if (number % 1000 > 0 )
                {
                    currentGroupInWords = numberUptoThousandToWord(number % 1000) + (power >= 1000 ? SPACE + getNumberInWords(power) : "");
                }
                inWords = currentGroupInWords + (inWords.Length > 0 ? SPACE : "") + inWords;
                power *= 1000;
                number /= 1000;
            }

            return inWords;
        }
    }
}
