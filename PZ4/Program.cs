// See https://aka.ms/new-console-template for more information

using PZ4;
List<Man> _manList = new List<Man>();
void Read()
{
    string name = Console.ReadLine();
    int age = Convert.ToInt32(Console.ReadLine());
    string floor=Console.ReadLine();
    double weight=Convert.ToDouble(Console.ReadLine());
    _manList.Add(new Man(name, age, floor, weight));
    string str=Console.Read().ToString();
}
void Display()
{
    foreach(Man c in _manList)
    {
        Console.WriteLine(c.Name);
        Console.WriteLine(c.Age);
        Console.WriteLine(c.Floor);
        Console.WriteLine(c.Weight);
    }
    
}
Read();
Display();











Console.ReadKey();
