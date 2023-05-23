class DecagonBase
{
    //Week One
    // Write a program to determine if a string contains all 
    // unique characters. Return true if it does and false otherwise.
    // The string man contain any of the 128ASCII characters.
    class Algorithms
    {
        public bool IsUniqe(string word)
        {
            var seenCharacter = new List<char>();
            foreach (char stringChar in word) 
            {
                if (seenCharacter.Contains(stringChar)) 
                {
                    return false;
                }
                seenCharacter.Add(stringChar);
            }
            return true;
        }
    }
    // Day 2 for Week one..n
    //Given an amount of cash between $40 and $10000 (with $10000 includeded)
    //and assuming that the ATM wants to use as few bills as possible,
    //determine the minimal number of 100, 50, 20 dollar bills the
    //ATM machine needs to dispense (in that order)

    public static List<int> withdraw(int n)
    {
        if (n % 100 == 0)
        {
            return new List<int> { n / 100, 0, 0 };
        }
        else if (n % 50 == 0)
        { 
            int modulus100 = n - 50;  // 2550
            int modulus50 = n - modulus100;
            return new List<int> { modulus100 / 100, modulus50 / 50, 0 };
        }
        else if (n % 20 == 0)
        {
            return new List<int> { n / 100, 0, n % 100 / 20 }; // 260
        }
        else
        {
            return new List<int> { (n + 50) / 100 - (1), 1, (n + 50) % 100 / 20 };
        }
    }
    /*
     Task
    Finish the function numberToOrdinal, which should take a number and return it as a string with the correct ordinal indicator suffix (in English). For example, 1 turns into "1st".

    For the purposes of this challenge, you may assume that the function will always be passed a non-negative integer. If the function is given 0 as an argument, it should return the string "0" without a suffix.

    To help you get started, here is an excerpt from Wikipedia's page on Ordinal Indicators:

    st is used with numbers ending in 1 (e.g. 1st, pronounced first)
    nd is used with numbers ending in 2 (e.g. 92nd, pronounced ninety-second)
    rd is used with numbers ending in 3 (e.g. 33rd, pronounced thirty-third)
    As an exception to the above rules, all the "teen" numbers ending with 11, 12 or 13 use -th (e.g. 11th, pronounced eleventh, 112th, pronounced one hundred [and] twelfth)
    th is used for all other numbers (e.g. 9th, pronounced ninth).
    Specification
    Challenge.NumberToOrdinal(number)
    take a number and return it as a string with the correct English ordinal indicator suffix
     */
    public static string ToOrdinal(int number)
    {
        switch (number % 10)
        {
            case 11:
            case 12:
            case 13:
                return number + "th";
        }
        if (number <= 0)
        {
            return "0";
        }
        else if (number.ToString().EndsWith("1"))
        {
            return number + "st";
        }
        else if (number.ToString().EndsWith("2"))
        {
            return number + "nd";
        }
        else if (number.ToString().EndsWith("3"))
        {
            return number + "rd";
        }
        else
        {
            return number + "th";
        }
    }
}