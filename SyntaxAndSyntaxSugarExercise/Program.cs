namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            Console.WriteLine(answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater or equal to nine");
                
        }
    }
}

/*
 int answer = 4;
   string response;
   if (answer < 9) 
   {
       response = answer + " is less than nine";
   }
   else
   {
       response = answer + " is greater than or equal to nine";
   }
 Inferred Typing: Replace explicit types with var.
   String Interpolation: Refactor the concatenation to use string interpolation.
   Ternary Operator: Replace the if-else statement with a ternary operator.*/
