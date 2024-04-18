 using System;
using System.Linq;

class Program
{
    static void Main()
     {
        Console.WriteLine("Welcome to my Hangman game.");
        // I'll put a word array here. 
       string [] arr = {"cat","dog","car","bird","girl","boy"};
        //This is how the array will be used.
        Random random = new Random();
        //This will randomize a three or four-lettered word for the game.

         
         
        {
         //   Console.WriteLine("" + random.Next);
        }
    //This will make a simplified picture of the stages of the 
    // Hangman when a player gets a letter wrong.
    static void DisplayHangManStatus (int attempts)
        { string array @"
               
            ==========
            ||       |
            ||     
            ||       
            ||       
            ||      
            ||
            ========== ",      

            @"
               
            ==========
            ||       |
            ||       O 
            ||       
            ||       
            ||      
            ||
            ========== ",    

             @"
               
            ==========
            ||       |
            ||     \ O 
            ||       
            ||       
            ||       
            ||
            ========== ",    

              @"
               
            ==========
            ||       |
            ||     \ O /
            ||       
            ||       
            ||        
            ||
            ========== ",    

             @"
               
            ==========
            ||       |
            ||     \ O /
            ||       |
            ||       |
            ||       
            ||
            ========== ",    

             @"
               
            ==========
            ||       |
            ||     \ O /
            ||       |
            ||       |
            ||        \ 
            ||
            ========== ",  

             @"
               
            ==========
            ||       |
            ||     \ O /
            ||       |
            ||       |
            ||      / \ 
            ||
            ========== ",     
         }
     }
}



 
