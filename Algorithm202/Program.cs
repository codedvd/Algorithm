using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Algos
{   //Complete the function so that it finds the average of the three scores passed
    //to it and returns the letter value associated with that grade.
    public static char GetGrade(int s1, int s2, int s3)
    {
        int score = (s1 + s2 + s3) / 3;
        char grade = 90 <= score && score <= 100 ? 'A' : 80 <= score && score < 90 ? 'B' : 70 <= score && score < 80 ? 'C' : 60 <= score && score < 70 ? 'D' : 'F';
        return grade;
    }

    //Write a function which calculates the average of the numbers in a given list.
    public static double FindAverage(double[] array)
    {
        //array = {};
        if (!(array.Length == 0))
        { //{return 0;}
            double avg = array.Sum() / array.Length;
            return avg;
        }
        return 0;  //=!!
    }
    //=!!
    public static double FindAvverage(double[] array) => array.DefaultIfEmpty().Average();

    //Your task is to find the first element of an array that is not consecutive.
    //By not consecutive we mean not exactly 1 larger than the previous element of the array.
    public static int? FirstNonConsecutive(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1] + 1)
            {
                return arr[i];
            }
        }
        return null;
    }

    // A hero is on his way to the castle to complete his mission.
    // However, he's been told that the castle is surrounded with a couple of powerful dragons!
    // each dragon takes 2 bullets to be defeated, our hero has no idea how many bullets he should carry.. 
    public static bool Hero(int bullets, int dragons)
    {
        //Do Some Magic...
        if ((bullets / dragons) > 1)
        {
            return true;
        }
        return false;
    }

    //Complete the method that takes a
    //boolean value and return a "Yes" string for true, or a "No" string for false.
    public static class Kata
    {
        public static string boolToWord(bool word) => word ? "Yes" : "No";
    }

    //This function should test if the factor is a factor of base.
    //Return true if it is a factor or false if it is not.
    public static bool CheckForFactor(int num, int factor) => num % factor == 0 ? true : false;

    //Every day you rent the car costs $40. If you rent the car for 7 or more days,
    //you get $50 off your total. Alternatively, if you rent the car for 3 or more days,
    //you get $20 off your total.
    public static int RentalCarCost(int d)
    {
        // your code
        int t = d * 40;
        if (d >= 3 && d < 7)
        {
            t -= 20;
        }
        else if (d >= 7)
        {
            t -= 50;
        }
        return t;
    }

    //Given a string, you have to return a string in which each character (case-sensitive) is repeated once.
    //Examples(Input -> Output) :
    //"String"      -> "SSttrriinngg"
    public static string DoubleChar(string s)
    {
        string newString = "";
        foreach (char c in s)
        {
            newString += c.ToString() + c.ToString();
        }
        return newString;
    }
    //
    public static string DoubleChare(string s)
    {
        return string.Join("", s.Select(x => "" + x + x));
    }
    //
    public static string DoubleChar4(string s)
    {
        return Regex.Replace(s, ".", "$&$&");
    }

    //Write a function that will take the number of petals of each
    //flower and return true if they are in love and false if they aren't.
    public static bool lovefunc(int f1, int f2)
    {
        bool even1 = (f1 % 2 == 0);
        bool even2 = (f2 % 2 == 0);
        return (even1 != even2);
    }
    public static bool lovefunctn(int flower1, int flower2)
    {
        return flower1 % 2 != flower2 % 2;
    }

    //write a function that removes the space from
    //the string then return the resultant string.
    public static string NoSpace(string input)
    {
        //var noSpace = input.Replace(" ", "");
        //return noSpace;
        return input.Replace(" ", "");
    }

    // Write an algorithm that takes an array and moves all of the zeros to the end,
    // preserving the order of the other elements.

    public int[] shiftZeros(int[] inputArray)
    {
        int[] outputArray = new int[inputArray.Length];

        int nonZeroIndex = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] != 0)
            {
                outputArray[nonZeroIndex] = inputArray[i];
                nonZeroIndex++;
            }
        }
        return outputArray;
    }


}