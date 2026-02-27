string welcome = "Hello, world!";

try
{
    int.TryParse(welcome, out int test);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception)
{
    Console.WriteLine("Invalid operation");
}

