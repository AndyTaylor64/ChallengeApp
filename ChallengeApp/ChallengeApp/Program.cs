//Deklaruję zmienne
var name = 0;
var sex1 = "Pan";
var sex2 = "Pani";
int lesson = 21; //na podstawie Wyxwanie 21 dni
// Pokazuj nazwę ankety
Console.WriteLine("Określenie poziomu wiedzy na podstawie Wyzwanie 21 dni");
Console.WriteLine("-------------------------");
Console.WriteLine(" ");
Console.WriteLine("1.Andrei\n");
Console.WriteLine("2.Ewa\r");
Console.WriteLine(" ");
//Poproś o wybranie imienia

Console.WriteLine("Wybierz nazwisko i naciśnij Enter");
name = Convert.ToInt32(Console.ReadLine());
//name = Convert.ToInt32(Console.ReadLine());

// Poproś o podanie numeru lekcji, której się uczy
Console.WriteLine("Podaj numer lekcji, której się uczysz i naciśnij Enter");
lesson = Convert.ToInt32(Console.ReadLine());

if (name == 1 && lesson <= 21)
{
    Console.WriteLine((sex1) + "Andrei jest początkującym programistą");
}
else if (name == 1 && lesson >= 21)
{
    Console.WriteLine((sex1) + "Andrei jest zaawansowanym programistą");
}
else if (name == 2 && lesson <= 21)
{
    Console.WriteLine((sex2) + "Ewa jest początkującą programistą");
}
else 
{
    Console.WriteLine((sex2) + "Ewa jest zaawansowaną programistą");
}