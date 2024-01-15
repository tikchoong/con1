bool exit = false;
int i = 1;
while (!exit)
{

    if (Console.KeyAvailable)
    {
        var c = Console.ReadKey().KeyChar;
        if ((c == 'q') || (c == 'Q'))
        {
            exit = true;
        }



    }

    Console.WriteLine($"Line {i++}");
    Thread.Sleep(1000);

}

Console.WriteLine("Program exiting......");
Console.ReadLine();