/*
    Napisz program, który pyta użytkownika o podanie dwóch liczb całkowitej a w wyniku 
    wypisuje komunikat o relacji pomiędzy tymi liczbami (<, <=, =, >=,>, <>). 
    Pamiętaj o przyjaznym interfejsie użytkownika, komunikaty sformatuj.
*/

Console.WriteLine("1. Podaj liczbe calkowita: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("2. Podaj liczbe calkowita: ");
int number2 = int.Parse(Console.ReadLine());

if (number > number2)
{
    Console.WriteLine("Liczba {0} jest większa od liczby {1}.", number, number2);
}
else if(number < number2)
{
    Console.WriteLine("Liczba {0} jest mniejsza od liczby {1}.", number, number2);
}
else if(number == number2)
{
    Console.WriteLine("Liczba {0} jest równa liczbie {1}.", number, number2);
}