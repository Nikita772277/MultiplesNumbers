using MultiplesNumbers;

Console.WriteLine($"Введите число");
string enternumber=Console.ReadLine();
bool checknumber=int.TryParse(enternumber, out int resultnumber);
Work work = new();
work.SearchMultiples(resultnumber);