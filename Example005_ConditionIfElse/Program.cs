﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "anna")
{
    Console.WriteLine("Ура, это же АНЯ!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}