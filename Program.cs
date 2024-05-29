Console.WriteLine("Enter a Number: ");
int a = int.Parse(Console.ReadLine());

string b= a%2==0 ? "Number is Even" : "Number is odd";

Console.WriteLine($"{b}");