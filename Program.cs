Console.WriteLine("Program to Check Whether an Alphabet is Vowel or Consonant");
Console.Write("Enter an Alphabet : ");
char ch = Convert.ToChar(Console.ReadLine().ToLower());
switch (ch)
{
    case 'a':
        Console.WriteLine("The Alphabet is vowel");
        break;
    case 'e':
        Console.WriteLine("The Alphabet is vowel");
        break;
    case 'i':
        Console.WriteLine("The Alphabet is vowel");
        break;
    case 'o':
        Console.WriteLine("The Alphabet is vowel");
        break;
    case 'u':
        Console.WriteLine("The Alphabet is vowel");
        break;
    default:
        Console.WriteLine("The Alphabet is consonant");
        break;
}