        Console.WriteLine("What is your grade? ");
        string grade = Console.ReadLine();
         int number = int.Parse(grade); 

      string letter = "";

      if (number>=90)
        {
            letter = "A";
        }

        else if (number>=80)
        {
            letter = "B";
        }

        else if (number>=70)
        {
            letter = "C";
        }

         else if (number>=60)
         {
            letter = "D";
         }

         else 
         {
            letter = "F";
         }

         Console.WriteLine($"Your grade is: {letter} ");
     
      if (number >=70)
      {
         Console.WriteLine("CONGRATS! You passed!");
      }
      else
      {
         Console.WriteLine("Sorry, you didn't passed, try again and make it next time! You can!");
      }