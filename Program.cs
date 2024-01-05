Console.Write("Qalesan : ");
string name = Console.ReadLine();
string greeting = $"Hi, {name}";
Console.WriteLine(greeting);

Console.Write(" Hozir nech yoshdasan: ");
string ageAsString =  Console.ReadLine();
Console.WriteLine("Davom etyapdi...");
int age = Convert.ToInt32(ageAsString);
Console.WriteLine($"Tushunarli demak  {age}");


int test3Age = 5;
int ageDiccerence =  age - test3Age;
Console.WriteLine($"O'zing bilan test 3 ni  farqini korsat {ageDiccerence}");
