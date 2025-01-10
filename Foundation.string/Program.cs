List<User> users = new List<User>();
string shart;
do
{
User user = new User();
Console.WriteLine("Assalomu alaykum. Ismingizni kiriting: ");
user.Name = Console.ReadLine();
Console.WriteLine($"{user.Name} yoshingizni kiriting: ");
user.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Jinsingizni kiriting (Erkak/Ayol) ");
user.Gender = Console.ReadLine();
Console.WriteLine("Diningizni kiriting: ");
user.Religion = Console.ReadLine();
Console.WriteLine("Yoqtirgan hayvoningizni kiriting: ");
user.FavoriteAnimals = Console.ReadLine();
Console.WriteLine("Yoqtirgan ovqatingizni kiriting: ");
user.FavoriteFood = Console.ReadLine();
Console.WriteLine("Oila azolaringizni sonini kiriting: ");
user.FamilyNumber = Convert.ToInt32(Console.ReadLine());

users.Add(user);
Console.Clear();

Console.WriteLine("Yangi Odam bormi (ha/yoq)");
shart = Console.ReadLine().ToLower();
}
while (shart == "ha");
Console.WriteLine();
Console.WriteLine("\nFoydalanuvchilar ma'lumotlari:");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine("| Ism      | Yosh | Jinsi        | Taom       | Din     | Yoqtirgan hayvon   | Oila azo soni");
Console.WriteLine("----------------------------------------------------------------------------------");

foreach (var user in users)
{
    Console.WriteLine($"| {user.Name,-13} | {user.Age,-4} | {user.Gender,-12} | {user.FavoriteFood,-10} | {user.Religion,-7} | {user.FavoriteAnimals,-6} | {user.FamilyNumber, -5}");
}

Console.WriteLine("----------------------------------------------------------------------------------");
















class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Religion { get; set; }
    public string FavoriteAnimals { get; set; }
    public int FamilyNumber { get; set; }
    public string FavoriteFood { get; set; }
}














