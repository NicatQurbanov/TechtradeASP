string pangram = "The quick brown fox jumps over the lazy dog";

char[] chars = pangram.ToCharArray();  

foreach (char s in chars)
{
    Console.WriteLine(s);
}