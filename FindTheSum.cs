using System;

public class SumOfCommAlp
{
    public static void Main(string[] args)
    {
        char[] arr = { 'A', 'B', 'C' };
        char[] brr = { 'B', 'C' };

        int k = findTheSum(arr, brr);
        Console.WriteLine(k);
    }

    public static int findTheSum(char[] input1, char[] input2)
    {
        char[] ch = new char[input1.Length + input2.Length];
        int k = 0;
        for (int i = 0, j = 0; i < input1.Length || j < input2.Length; i++, j++)
        {
            if (i < input1.Length)
            {
                ch[k] = input1[i];
                k++;
            }
            if (j < input2.Length)
            {
                ch[k] = input2[j];
                k++;
            }
        }
        int sum = 0;
        int count = 0;
        for (int i = 0; i < ch.Length; i++)
        {
            for (int j = 0; j < ch.Length; j++)
            {
                if (i != j && ch[i] == ch[j])
                    count++;
            }
            if (count == 0)
                sum += ch[i];
            count = 0;
        }
       if (sum % 9 == 0)
            return 9;
        int num = 0;
        while (sum != 0 || num > 9)
        {
            num += sum % 10;
            sum /= 10;
            if (sum == 0 && num > 9)
            {
                sum = num;
                num = 0;
            }
        }
        return num;
    }
}
