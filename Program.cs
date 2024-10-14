using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide 1 number to perform the addition operation");
        double additon1 = double.Parse(Console.ReadLine());


        Console.WriteLine((additon1) + " got it. Provide a number to add to " + (additon1));
        double additon2 = double.Parse(Console.ReadLine());

        Console.WriteLine((additon2) + ", alright! That’s easy " + (additon1) + " + " + (additon2) + " is " + (additon1 + additon2));

        Console.WriteLine("Provide 1 number to perform the subtracton operation");
        double sub1 = double.Parse(Console.ReadLine());


        Console.WriteLine((sub1) + " got it. Provide a number to subtract to " + (sub1));
        double sub2 = double.Parse(Console.ReadLine());

        Console.WriteLine((sub2) + ", alright! That’s easy " + (sub1) + " - " + (sub2) + " is " + (sub1 - sub2));


        Console.WriteLine("Provide 1 number to perform the multiply operation");
        double mult1 = double.Parse(Console.ReadLine());


        Console.WriteLine((mult1) + " got it. Provide a number to multiply to " + (mult1));
        double mult2 = double.Parse(Console.ReadLine());

        Console.WriteLine((mult2) + ", alright! That’s easy " + (mult1) + " * " + (mult2) + " is " + (mult1 * mult2));

        Console.WriteLine("Provide 1 number to perform the divison operation");
        int divis1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine((divis1) + " got it. Provide a number to divide to " + (divis1));
        int divis2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((divis2) + ", alright! That’s easy " + (divis1) + "/" + (divis2) + " is " + (divis1 / divis2));
        int remainder = (divis1 % divis2);
        Console.WriteLine("the remainder is " + (remainder));


        Console.WriteLine("Provide 1 number to perform the decimal divison operation");
        double decdivis1 = double.Parse(Console.ReadLine());


        Console.WriteLine((decdivis1) + " got it. Provide a number to divide to " + (decdivis1));
        double decdivis2 = double.Parse(Console.ReadLine());

        Console.WriteLine((decdivis2) + ", alright! That’s easy " + (decdivis1) + " ÷ " + (decdivis2) + " is " + (decdivis1 / decdivis2));

    }
}