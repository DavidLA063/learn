Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine ();

if (username.ToLower() == "валера") {
    Console.WriteLine("Ура это Валера !");
}
else {
    Console.Write("Привет ");
    Console.WriteLine(username);
}