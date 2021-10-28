using System;

namespace loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valueFound = false; 
            
            // slumpar ut ett värde och lagrar det i variablen randomValue
            Random rnd = new Random();
            int randomValue  = rnd.Next(0, 101);

            int guessedValue = 0; 

            // deklarerar variablen i som är hur många försök man har gjort
            int i = 1;

            // loopar tills value found = true
            while (!valueFound)

            {
            
                Console.Write("Gissa talet: ");
                // sparar det inskrivna värdet och gör om det till en integer
                guessedValue = int.Parse(Console.ReadLine()); 
                //Om man gissar rätt så skriver den ut 
                if (guessedValue == randomValue)
                {
                    Console.WriteLine("Nice! " + i.ToString() + " försök"); 
                    valueFound = true; 
                }
                else if(guessedValue > randomValue)
                {
                    Console.WriteLine("Talet är mindre. Försök igen!");
                }
                else if(guessedValue < randomValue)
                {
                    Console.WriteLine("Talet är större. Försök igen!");
                }

                i++;


            }
           
        }
    }
}
