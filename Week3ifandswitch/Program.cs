Console.WriteLine("enter a number");
int username = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = username % 2;

Console.WriteLine(result);

if (result != 0) // != ei ole
{
    Console.WriteLine("user number is odd");
}
else
{
    Console.WriteLine("user number is even");
}
