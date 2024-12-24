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
            else if (isNum)
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

        Console.WriteLine("Are you done for today?", "/n");
        done = Console.ReadLine()!;

        if (done == "yes" || done == "Yes")
        {
            isDone = true;
            
        }

    }

    static void Division()
    {
        float initalNum;
        float inputNum;
        float quotient = 0;
        bool done = false;
        bool isNum;
        string input;
        

        Console.WriteLine("Enter your number. Type 'x' (or 'X') when you're done:");

        input = Console.ReadLine()!;
        isNum = float.TryParse(input, out initalNum);

        if (isNum)
        {
            initalNum = Convert.ToSingle(input);
        }
        else if (input.ToLower() == "x")
        {
            Console.WriteLine($"Your quotient is {quotient}!");
            done = true;
        }
        else
        {
            Console.WriteLine("Error. Try again.");
            Division();

        }

        while (!done)
        {
            input = Console.ReadLine()!;
            isNum = float.TryParse(input, out inputNum);

            if (input.ToLower() == "x")
            {
                Console.WriteLine($"Your quotient is {quotient}!");
                done = true;
            }
            else if (inputNum == 0)
            {
                Console.WriteLine("Divide by 0 error. Please enter a valid number or 'x' to finish.");
            }
            else if (isNum)
            {
                inputNum = Convert.ToSingle(input);
                quotient = initalNum / inputNum;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'x' to finish.");
            }
            initalNum = quotient;
        }

        Complete();
    }

    static void Input()
    {
        Console.WriteLine("Welcome to the Calculator! Here are some options you can do!");
        Console.Write("Select the following options. Random (Rand) Additon (+) Subtraction (-) Mutliplication (*) Division (/) Quit (Q): ");
        string inputChoice = Console.ReadLine()!;

        if (inputChoice == "Rand" || inputChoice == "rand")
        {
            Random();
        }
        else if (inputChoice == "+")
        {
            Addition();
        }
        else if (inputChoice == "-")
        {
            Subtraction();
        }
        else if (inputChoice == "*")
        {
            Mutliplication();
        }
        else if (inputChoice == "/")
        {
            Division();
        }
        else if (inputChoice == "Q" || inputChoice == "q")
        {
            isDone = true;
        }
        else
        {
            Console.WriteLine("Input invalid, try agian.");
            Input();
        }

    }

    static void Mutliplication()
    {
        float inputNum;
        float product = 1;
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
                Console.WriteLine($"Your product is {product}!");
                done = true;
            }
            else if (isNum)
            {
                inputNum = Convert.ToSingle(input);
                product = product * inputNum;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'x' to finish.");
            }

        }

        Complete();
    }

    static void Random()
    {
        Random rand = new Random();
        int randInt = rand.Next(1,6);

        Console.WriteLine($"Your dice rolled a {randInt}!");
        
        Complete();

    }

    static void Subtraction()
    {
        float inputNum = 0;
        float initalNum = 0;
        float difference = 0;
        bool done = false;
        bool isNum;
        string input;
        

        Console.WriteLine("Enter your number. Type 'x' (or 'X') when you're done:");

        input = Console.ReadLine()!;
        isNum = float.TryParse(input, out initalNum);

        if (isNum)
        {
            initalNum = Convert.ToSingle(input);
        }
        else if (input.ToLower() == "x")
        {
            Console.WriteLine($"Your difference is {difference}!");
            done = true;
        }
        else
        {
            Console.WriteLine("Error. Try again.");
            Subtraction();

        }

        while (!done)
        {

            input = Console.ReadLine()!;
            isNum = float.TryParse(input, out inputNum);

            if (input.ToLower() == "x")
            {
                Console.WriteLine($"Your difference is {difference}!");
                done = true;
            }
            else if (isNum)
            {   
                inputNum = Convert.ToSingle(input);
                difference = initalNum - inputNum;   
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'x' to finish.");
            }
            initalNum = difference;

        }

        Complete();
    }
}

