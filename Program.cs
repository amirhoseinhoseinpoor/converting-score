//amirhosein hoseinpoor tamrin 5;


int number;
ConsoleKeyInfo digit;
do
{
    Console.WriteLine("enter youre grade to give you a rank and youre percent:");
    number = 0;
    do
    {
        do
        {
            digit = Console.ReadKey(true);
        } while (digit.KeyChar.ToString() != "0" && digit.KeyChar.ToString() != "1" && digit.KeyChar.ToString() != "2" &&
                 digit.KeyChar.ToString() != "3" && digit.KeyChar.ToString() != "4" && digit.KeyChar.ToString() != "5" &&
                 digit.KeyChar.ToString() != "6" && digit.KeyChar.ToString() != "7" && digit.KeyChar.ToString() != "8" &&
                 digit.KeyChar.ToString() != "9" && digit.Key.ToString() != "Enter");
        if (digit.Key.ToString() != "Enter")
        {
            number = number * 10 + Convert.ToInt32(digit.KeyChar.ToString());
            Console.Write(digit.KeyChar);
        }

    } while (digit.Key.ToString() != "Enter");
    Console.WriteLine();

    if (number >= 17)
    {
        Console.WriteLine("the rank is A");
    }
    else if (number >= 15)
    {
        Console.WriteLine("the rank is B");
    }
    else if (number >= 10)
    {
        Console.WriteLine("the rank is C");
    }
    else if (number >= 0)
    {
        Console.WriteLine("you are failed");
    }
    Console.WriteLine("and your percent is:");
    Console.WriteLine(number * 5);
    Console.WriteLine("do you want to continue? if so press 'y'otherwise prees 'n':");
    do
    {
        digit = Console.ReadKey(true);
    } while (digit.KeyChar.ToString() != "y" && digit.KeyChar.ToString() != "n");
} while (digit.KeyChar.ToString() == "y");