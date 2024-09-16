using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int target = rnd.Next(1, 101);
        
        Console.WriteLine("Menga o'ylangan sonni toping (1 dan 100 gacha):");

        int guess = 0;
        int attempts = 0;

        while(guess != target)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if(guess < target)
            {
                Console.WriteLine("Katta son kiriting");
            }
            else if(guess > target)
            {
                Console.WriteLine("Kichik son kiriting");
            }
            else
            {
                Console.WriteLine($"Tabriklayman, {target} sonini topdingiz! {attempts} ta urinish bilan");
            }
        }
    }
}

