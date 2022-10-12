Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "горох")
{
    Console.WriteLine("Ура, это же ТОЛСТЫЙ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}