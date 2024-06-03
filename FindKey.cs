using System;
using System.Collections.Generic;
using System.Linq;

public class FindKey7
{
    public static void Main(string[] args)
    {
        FindKey7 m = new FindKey7();
        Console.WriteLine("Enter three integers:");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Output:");
        int k = m.FindKey(a, b, c);
        Console.WriteLine(k);
    }

    public int FindKey(int input1, int input2, int input3)
    {
        List<int> l1 = GetDigits(input1);
        List<int> l2 = GetDigits(input2);
        List<int> l3 = GetDigits(input3);
        int sum = (l1.Max() - l1.Min()) + (l2.Max() - l2.Min()) + (l3.Max() - l3.Min());
        return sum;
    }

    private List<int> GetDigits(int number)
    {
        List<int> digits = new List<int>
        {
            (number / 1000) % 10,
            (number / 100) % 10,
            (number / 10) % 10,
            number % 10
        };
        return digits;
    }
}
