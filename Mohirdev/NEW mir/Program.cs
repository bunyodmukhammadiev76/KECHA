System.Console.Write("Sizning  ismngiz: ");
string name = Console.ReadLine();
string greeting = $"Salom, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Sizning  yoshngiz ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Tekshrlmoqda..");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"aniqlandi! {age}");