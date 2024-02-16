using ChallengeApp;

Employee adam = new Employee("Adam", "Kowalski", 25);
Employee monika = new("Monika", "Tokarczyk", 28);
var damian = new Employee("Damian", "Siewkowski", 30);
//pierwszy tydzien
adam.AddScore(15);
monika.AddScore(2);
damian.AddScore(3);
//drugi tydzien
adam.AddScore(4);
monika.AddScore(3);
damian.AddScore(6);
//trzeci tydzien
adam.AddScore(7);
monika.AddScore(8);
damian.AddScore(9);
//czwarty tydzien
adam.AddScore(4);
monika.AddScore(7);
damian.AddScore(5);

var resultAdam = adam.Result;
var resultMonika = monika.Result;
var resultDamian = damian.Result;

HighResult(adam, monika, damian, resultAdam, resultMonika, resultDamian);

static void HighResult(Employee adam, Employee monika, Employee damian, int resultAdam, int resultMonika, int resultDamian)
{
    List<Employee> employeeList = new List<Employee>()
{
    adam,
    monika,
    damian
};

    int highestResult = -1;
    Employee employeeWithHiestResult = null;

    foreach (var employee in employeeList)
    {
        if (employee.Result > highestResult)
        {
            employeeWithHiestResult = employee;
            highestResult = employee.Result;
        }
    }

    Console.WriteLine("{0} {1}, {2} lat, otrzymal {3} punktow", adam.Name, adam.Surname, adam.Age, resultAdam);
    Console.WriteLine($"{monika.Name} {monika.Surname} otrzymala {resultMonika} punktow");
    Console.WriteLine($"{damian.Name} {damian.Surname} otrzymal " + resultDamian + " punktow");
    Console.WriteLine();
    Console.WriteLine(employeeWithHiestResult.Name + " " + employeeWithHiestResult.Surname + 
                        $" jest pracownikiem miesiaca z wynikem {highestResult}");
}
