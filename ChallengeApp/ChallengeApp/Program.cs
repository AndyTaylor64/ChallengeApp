long number = 0;
Console.WriteLine("Policz ile jakich cyfr występuje w podanej liczbie");

Console.WriteLine("Proszę wpisać liszbę i naciśnąć Enter");
number = Convert.ToInt64(Console.ReadLine());
string numberInString = number.ToString(); 
char[] digits = numberInString.ToArray(); //

int figure0 = 0;
int figure1 = 0;
int figure2 = 0;
int figure3 = 0;
int figure4 = 0;
int figure5 = 0;
int figure6 = 0;
int figure7 = 0;
int figure8 = 0;
int figure9 = 0;

foreach (var digit in digits)
{
    if (digit == '0')
    {
        figure0++;
    }
    if (digit == '1')
    {
        figure1++;
    }
    if (digit == '2')
    {
        figure2++;
    }
    if (digit == '3')
    {
        figure3++;
    }
    if (digit == '4')
    {
        figure4++;
    }
    if (digit == '5')
    {
        figure5++;
    }
    if (digit == '6')
    {
        figure6++;
    }
    if (digit == '7')
    {
        figure7++;
    }
    if (digit == '8')
    {
        figure8++;
    }
    if (digit == '9')
    {
        figure9++;
    }
}
Console.WriteLine($"Liczba {number} zawiera");
Console.WriteLine($"0 => {figure0}");
Console.WriteLine($"1 => {figure1}");
Console.WriteLine($"2 => {figure2}");
Console.WriteLine($"3 => {figure3}");
Console.WriteLine($"4 => {figure4}");
Console.WriteLine($"5 => {figure5}");
Console.WriteLine($"6 => {figure6}");
Console.WriteLine($"7 => {figure7}");
Console.WriteLine($"8 => {figure8}");
Console.WriteLine($"9 => {figure9}");


