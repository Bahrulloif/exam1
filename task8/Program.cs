

for (int i = 0; i < 3; i++)
{
    Person person = new Person();
    
    System.Console.WriteLine($"Person {i}");
    person.Name = Console.ReadLine();
    person.Surname = Console.ReadLine();
    person.Age = Convert.ToInt32(Console.ReadLine());
    person.Add();
}





