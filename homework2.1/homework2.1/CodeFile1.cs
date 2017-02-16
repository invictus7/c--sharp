using System;

class homework2
{
    static void Main()
    {
        string subject1 = "Deutsch";
        string subject2 = "English";
        string subject3 = "Latin";

        Console.WriteLine("Deutsch");
        float sb1 = short.Parse(Console.ReadLine());
        Console.WriteLine("English");
        float sb2 = short.Parse(Console.ReadLine());
        Console.WriteLine("Latin");
        float sb3 = short.Parse(Console.ReadLine());

        Console.WriteLine(subject1 + " ist " + "   " + sb1);
        Console.WriteLine(subject2 + " is " + "   " + sb2);
        Console.WriteLine(subject3 + "est" + "   " + sb3);


        float Arithmeticmean = (sb1 + sb2 + sb3) / 3;

        Console.WriteLine("Arithmetic mean =" + Arithmeticmean);
     
    }













}