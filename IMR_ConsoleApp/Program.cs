// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

for(int i = 1; i<=100; i++)
{
    if((i % 3) == 0 && (i % 5) == 0)
    {
        Console.WriteLine(string.Format("{0} - FizzBuzz", i));

    }
    else if((i % 3) == 0 && (i % 5) != 0)
    {
        Console.WriteLine(string.Format("{0} - fizz", i));
    }
    else if ((i % 3) != 0 && (i % 5) == 0)
    {
        Console.WriteLine(string.Format("{0} - buzz", i));
    }
}


Console.WriteLine("------2nd Problem Output --------");

Console.WriteLine("Please enter your input string.");

string? input = Console.ReadLine();

string? output = string.Empty;

if(!string.IsNullOrEmpty(input))
{
    Console.WriteLine("Input String: " + input);

    char[] chars = input.ToCharArray();

    for(int i = chars.Length-1; i >= 0; i--)
    {
        output += chars[i];
    }

    Console.WriteLine("OutPut String:" + output);

    Console.Read();
}


