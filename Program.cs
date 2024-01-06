Console.Write("Qalesan: ");
string name = Console.ReadLine();
string greeting = $"Hi, {name}";
Console.WriteLine(greeting);

Console.Write("Hozir nech yoshdasan: ");
string ageAsString = Console.ReadLine();
Console.WriteLine("Davom etyapdi...");
int age = Convert.ToInt32(ageAsString);
Console.WriteLine($"Tushunarli demak {age}");

int test3Age = 5;
int ageDifference = age - test3Age;
Console.WriteLine($"O'zing bilan test 3 ni farqini korsat {ageDifference}");

System.Console.WriteLine($"Kescha bilan tengmisan: {age >= test3Age }");
System.Console.WriteLine($"Keschadan yoshmidan:{age < test3Age }");
System.Console.WriteLine($"Kescha bian teng emasmisan: {age != test3Age}");
System.Console.WriteLine($"Kescha sendan kattami: {age > test3Age}");
System.Console.WriteLine($"Kescha sendan kichik yoki tengmi: {age <= test3Age}");
System.Console.WriteLine($"Kescha sen bilan tengmi: {age == test3Age}");