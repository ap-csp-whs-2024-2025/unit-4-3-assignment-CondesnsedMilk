namespace unit_4_3_assignment_CondesnsedMilk;

public class Program
{
    public static bool isDone = false;

    public static void Main()
    {  
        while (!isDone)
        {
            Input();
        }

    }

        static void Addition()
    {
        float inputNum;
        float sum = 0;
        bool done = false;
        bool isNum;
        string input;
        

        Console.WriteLine("Enter your number. Type 'x' (or 'X') when you're done:");

        while (!done)
        {
            input = Console.ReadLine()!;
            isNum = float.TryParse(input, out inputNum);

            if (input.ToLower() == "x")
            {
                Console.WriteLine($"Your sum is {sum}!");
                done = true;
            }

            if (isNum)
            {
                inputNum = Convert.ToSingle(input);
                sum += inputNum;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'x' to finish.");
            }

        }

        Complete();
    }   

        static void Complete()
    {
        string done;

        Console.WriteLine("Are you done for today?");
        done = Console.ReadLine()!;

        if (done == "yes" || done == "Yes")
        {
            isDone = true;
            
        }


    }

    static void Input()
    {
        Console.WriteLine("Welcome to the Calculator! Here are some options you can do!");
        Console.Write("Select the following options. Additon (+) Subtraction (-) Mutliplication (*) Division (/): ");
        string inputChoice = Console.ReadLine()!;
        if (inputChoice == "+" || inputChoice == "-" || inputChoice == "*" || inputChoice == "/")
        {
            Addition();
        }
        else
        {
            Console.WriteLine("Input invalid, try agian.");
            Input();
        }

    }
}

