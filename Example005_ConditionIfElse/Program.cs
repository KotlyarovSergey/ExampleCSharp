Console.Write("Ввведите имя пользовтеля: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") 
{
    Console.WriteLine("дУра, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}