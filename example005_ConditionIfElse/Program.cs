﻿Console.WriteLine("Введите имя пользователя!");
string username = Console.ReadLine();

if(username.ToLower() == "вика")
{
    Console.WriteLine("Ура Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}