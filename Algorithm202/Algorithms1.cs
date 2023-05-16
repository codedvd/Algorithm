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

}