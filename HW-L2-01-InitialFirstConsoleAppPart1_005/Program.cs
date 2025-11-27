using System.Collections;


Console.Write("Enter a positive number : ");
int n = Convert.ToInt32(Console.ReadLine());
int oddNumberSum = 0;
if (n >=0)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 != 0)
        {
            oddNumberSum += i;
        }
       
    }
    Console.WriteLine($"Sum of odd numbers between 1 to n = {oddNumberSum}");
}
else
{
    Console.WriteLine("The number is not positive");
}

