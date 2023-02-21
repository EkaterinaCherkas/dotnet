Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("YYYYHY , its Masha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}