Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "таня")
{
    Console.WriteLine("Ура! Это же Таня!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}