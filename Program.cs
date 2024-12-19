namespace unit_4_3_assignment_CondesnsedMilk;

public class Program
{
    public static void Main(string[] args)
    {   
        bool isDone = false;

        while (isDone == false)
        {
            Input(isDone);
        }
    

    }

    static void Input(bool isDone)
    {
        Console.WriteLine("Welcome to the Calculator! Here are some options you can do!");
        Console.Write("Select the following options. Additon (+) Subtraction (-) Mutliplication (*) Division (/)");
        string inputChoice = Console.ReadLine()!;
        if (inputChoice == "+" || inputChoice == "-" || inputChoice == "*" || inputChoice == "/")
        {
            Calculator(isDone);
        }
        else
        {
            Console.WriteLine("Input invalid, try agian.");
            Input(isDone);
        }

    }

    static void Calculator(bool isDone)
    {
        ConsoleKeyInfo cki;
        float sum;
        float inputNum;

        Console.WriteLine("Enter your first number. Press <Shift> when your're fully done");

        do
        {
            cki = Console.ReadKey();
            inputNum = Convert.ToSingle(Console.ReadLine());
        }    while ((cki.Modifiers & ConsoleModifiers.Shift) == 0);
        
        Console.WriteLine("Hi");
        Complete(isDone);
        
            
    }

    static void Complete(bool isDone)
    {
        string done;

        Console.WriteLine("Are you done for today?");
        done = Console.ReadLine()!;
        if (done == "yes")
        {
            isDone = true;
        }
        else
        {
            Input(isDone);
        }

    }
}

