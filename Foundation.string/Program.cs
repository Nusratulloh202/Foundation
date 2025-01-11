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

Console.WriteLine("Valyuta kursini kiriting:");
int kurs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pul miqdorini kiriting:");
int miqdor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Kurs bo'yicha hisoblangan miqdor: {kurs * miqdor}");
Console.ReadLine();

Console.Write("Radiusni kiriting = ");
decimal radius = Convert.ToDecimal(Console.ReadLine());
const decimal pi = 3.14m;
decimal S = pi * radius * radius;
decimal L = 2 * pi * radius;
Console.WriteLine($"Yuzasi S = {S} \nUzunligi L = {L}");
Console.ReadLine();

Console.WriteLine("Tug'ilgan yilingizni kiriting");
int ageYear = Convert.ToInt32(Console.ReadLine());
int kun = 2025 - ageYear;
Console.WriteLine($"Yoshingiz kunlarda hisoblanganda: {kun*366}");

//2  vazida 1 mashq
Console.Write("1 sonni kiriting : ");
double firsNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Oraliq amalni kiriting (+, -, *, /) : ");
char charOraliq = Convert.ToChar(Console.ReadLine());
Console.Write("2 sonni kiriting : ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
double natija = 0;
if (charOraliq == '+')
    natija = firsNumber + secondNumber;
Console.WriteLine();

if (charOraliq == '-')
    natija = firsNumber - secondNumber;

if (charOraliq == '*')
    natija = firsNumber * secondNumber;

if (charOraliq == '/')
    natija = firsNumber / secondNumber;

else
    Console.WriteLine("Belgilanmagan ishora kiritdingiz ");

Console.WriteLine($"javob :{natija}");
Console.ReadLine();
Console.Clear();

//2 vazifa 2 mashq 0 dan aytilgan raqamgaca sonlar yig'indisi

Console.Write("Raqam ayting:");
int yigindi = 0;
int numberr = Convert.ToInt32(Console.ReadLine());

while (numberr != 0)
{
    yigindi = yigindi + numberr;
    numberr--;
}
Console.Write($"javob : {yigindi}");
Console.ReadLine();
Console.Clear();

// 2 vazifa 3 mashq juft toqlikka tekshirish
int oddEven = 0;
Console.Write("Raqam kiriting : ");
oddEven = Convert.ToInt32(Console.ReadLine());
if (oddEven % 2 == 0)
    Console.WriteLine("Juft");
if (oddEven % 2 == 1)
    Console.WriteLine("Toq");

















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














