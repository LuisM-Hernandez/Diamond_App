using System;

namespace Diamond_App
{
    class Program
    {
        static void Main(string[] args)
        {
              
               var star = 5;


               for (var line=1; line<=star; line++)
               {
                   Console.WriteLine("");

                   for(var space=line; space<=5; space++)
                   {
                       Console.Write("");
                       Console.Write(" ");
                       
                   }

                   for(var num=line; num>0; num--)
                   {
                       Console.Write(" ");
                       Console.Write("*");
                   }
                   
               }
        
                //Bottom Half of the diamond
               
              for (var line = 1; line<=star; line++)
               {
                   Console.WriteLine("");
                   {
                       for (var space = line; space>=star-4; space--)
                       Console.Write(" ");
                   }
                   for (var num = line; num<=star; num++){
                        Console.Write(" ");
                        Console.Write("*");
                   }
                  
               }
              
        }
    }
}

