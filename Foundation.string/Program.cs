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

Console.Write("Raqam ayting(0 dan siz kiritgan raqamgacha sonlar yig'indisi):");
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
Console.Write("Raqam kiriting (Juftlikga tekshirish) : ");
oddEven = Convert.ToInt32(Console.ReadLine());
if (oddEven % 2 == 0)
    Console.WriteLine("Juft");
if (oddEven % 2 == 1)
    Console.WriteLine("Toq");
Console.ReadKey();
Console.Clear();

// 3 vazifa 1 mashq tub songa tekshirish
Console.Write("Tub sonlikka tekshiriladigan son kiriting:");
int tubSon = int.Parse(Console.ReadLine());


if (Tubmi(tubSon))
    Console.WriteLine($"{tubSon} tub son!");
else
    Console.WriteLine($"{tubSon} tub son emas!");



    static bool Tubmi(int son)
    {
        if (son <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(son); i++)
        {
            if (son % i == 0)
                return false;
        }

        return true;
    }
Console.ReadLine();
Console.Clear();

//3 vazifa 2 mashq "Bo'luvchisiz sonlar "
Console.WriteLine("1 dan 10 gacha " +
    "bo'luvchilarini aniqlanadigan sonni kiriting");
int sonBolinuvchi = int.Parse(Console.ReadLine());
Console.Write("1 dan 10 gacha bo'linadigan sonlar:");
for (int i = 2; i <= 10; i++)
{
   if(sonBolinuvchi % i == 0)
        Console.Write($" {i}");
}
Console.ReadKey();
Console.Clear();


// 3 vazifa 3 mashq darajaga oshirish
int sonAsos;
int kopaytma = 1;
Console.Write("Darajaga oshiriladigan son kiriting:");
sonAsos = int.Parse(Console.ReadLine());
Console.Write("Darajani kiriting:");
int sonDaraja = int.Parse(Console.ReadLine());
for (int i = 1; i <= sonDaraja; i++)
{
    kopaytma = kopaytma * sonAsos;
}
Console.WriteLine($"Javob: {kopaytma}");
Console.ReadLine();
Console.Clear();

//3 vazifa 4 mashq xarajatlar

Console.WriteLine("Xarajatlaringizni (,)(vergul) bilan ajratib yozing: ");
string input = Console.ReadLine();
int[] xarajatInput = input.Split(',')
    .Select(int.Parse)
    .ToArray();
int outputXarajat = xarajatInput.Sum();
Console.WriteLine($"Xarajatlar yig'indisi: {outputXarajat}");
Console.ReadLine();

// 3 vazifa 5 mashq Armstrong son
//Armstrong soni
Console.Write("Armstrongga tekshiriladigan sonni kiriting:");
string inputStringArmstrong = Console.ReadLine();
double inpSon = Convert.ToDouble(inputStringArmstrong);
double e = inputStringArmstrong.Length;
double[] inputArray = inputStringArmstrong
    .ToCharArray()
    .Select(ch => double.Parse(ch.ToString()))
    .ToArray();
double armYigindi = 0;
foreach (double n in inputArray)
{
    armYigindi = armYigindi + Math.Pow(n, e);
}
if (Math.Abs(armYigindi - inpSon) < 0.0001)
    Console.WriteLine($"{armYigindi} soni Armstrong son!");
else
    Console.WriteLine($"{inpSon} soni Armstrong son emas!");
Console.ReadLine();

//3 Vazifa 6 mashq
Console.Write("Sonni kiriting: ");
int son = int.Parse(Console.ReadLine());

int sifatliBoluvchilarSoni = 0;
Console.Write("Sifatli bo'luvchilar: ");

// Bo'luvchilarni tekshiramiz
for (int i = 1; i < son; i++)
{
    if (son % i == 0) // Agar `son` i ga bo'linsa
    {
        Console.Write(i + " "); // Sifatli bo'luvchini chiqaramiz
        sifatliBoluvchilarSoni++;
    }
}

Console.WriteLine($"\n{son} sonining sifatli bo'luvchilari soni:" +
    $" {sifatliBoluvchilarSoni}");




//2 bo'lim 1 vazifa 1 mashq so'z uznligiga taqqoslanib katta kichik qilish

Console.Write("So'z kiriting:");
string stringText = Console.ReadLine();
Console.Write("So'zga taqqoslanadigan son kiriting: ");
int numberString = int.Parse(Console.ReadLine());
int stringLight = stringText.Length;
if (numberString >= stringLight)
{
    Console.WriteLine($"{stringText.ToUpper()} Kiritgan soninggiz text " +
        $"uzunligidan katta shu uchun katta harflarda so'z chiqdi.");
}
else
    Console.WriteLine($"{stringText.ToLower()} Kiritgan soninggiz text " +
        $"uzunligidan kichik shu uchun, kichik harflarda so'z chiqdi.");
Console.ReadLine();
Console.Clear();

// 2 bo'lim 1 vazifa 2 mashq  ternary ni if elsega almashtirish.
int x1 = 15;
int y1 = 10;
if (x1 > y1)
    Console.WriteLine("x soni y sonidan katta.");

else
{
    if (x1 < y1)
        Console.WriteLine("x soni y sonidan kichik.");

    else
    {
        if (x1 == y1)
            Console.WriteLine("x soni y soni bilan teng.");

        else
            Console.WriteLine("x va y soni bog'liq emas.");
    }
}
Console.ReadLine();
Console.Clear();

// 2 bo'lim 1 vazifa 3 mashq
Console.Write("Hafta kunini kiriting: ");
string daysName = Console.ReadLine().ToLower();

string resultWeak = daysName switch
{
    "dushanba" => "Monday",
    "seshanba" => "Tuesday",
    "chorshanba" => "Wednesday",
    "payshanba" => "Thursday",
    "juma" => "Friday",
    "shanba" => "Saturday",
    "yakshanba" => "Sunday",
    _ => "Xato so'z kiritdingiz."

};
Console.WriteLine($"{daysName} ingliz tilida: {resultWeak}");
Console.ReadLine();
Console.Clear();

//2 bo'lim 2 vazifa 1 misol
Console.Write("Soniyalarni kiriting: ");
int sekundInput = int.Parse(Console.ReadLine());
if (sekundInput < 3600)
{
    int butunDaqiqa1 = sekundInput / 60;
    int qoldiqSoniya1 = sekundInput % 60;
    Console.WriteLine(butunDaqiqa1 + ":" + qoldiqSoniya1);
}
if (sekundInput >= 3600)
{
    int butunSoat2 = sekundInput / 3600;
    int butunDaqiqa2 = sekundInput % 3600 / 60;
    int butunSoniya2 = sekundInput % 60;
    if (butunSoniya2 < 10)
    {
        Console.WriteLine(butunSoat2 + ":" + butunDaqiqa2 + ":" + "0" + butunSoniya2);
    }
    else
        Console.WriteLine(butunSoat2 + ":" + butunDaqiqa2 + ":" + butunSoniya2);
}
Console.ReadLine();
Console.Clear();

// 2 bo'lim 2 vazifa 2 misol Yosh toifasini aniqlash:
Console.Write("Yoshingizni kiriting:");
int ageUser = int.Parse(Console.ReadLine());

string resultAge = (ageUser >= 0 && ageUser <= 12) ? "Siz yosh bolasiz" :
    (ageUser >= 13 && ageUser <= 19) ? "Siz o'smirsiz" :
    (ageUser >= 20 && ageUser <= 59) ? "Siz kattasiz" :
    (ageUser >= 60 && ageUser <= 130) ? "Siz keksasiz"
    : "Ertak aytmang unday yosh yo'q.";
Console.WriteLine($"{resultAge}.");
Console.ReadLine();
Console.Clear();

// 2 bo'lim 2 vazifa 3 misol  O'rtacha ballni hisoblash:

Console.Write("1 fandan olgan balingizni kiriting:");
int firstScience = int.Parse(Console.ReadLine());

Console.Write("2 fandan olgan balingizni kiriting:");
int secondScience = int.Parse(Console.ReadLine());

Console.Write("3 fandan olgan balingizni kiriting:");
int threetScience = int.Parse(Console.ReadLine());

int averageScore = Math.Abs((firstScience +
    secondScience + threetScience) / 3);

string resultScore = (averageScore >= 80 && averageScore <= 100) ? "A'lo ball." :
    (averageScore >= 60 && averageScore <= 79) ? "Yaxshi ball." :
    (averageScore >= 40 && averageScore <= 59) ? "Qoniqarli ball." :
    (averageScore >= 0 && averageScore <= 39) ? "Qoniqarsiz ball."
    : "Ball 0 va 100 oralig'ida bo'lsin.";
Console.WriteLine($"{resultScore}.");
Console.ReadLine();
Console.Clear();


// 2 bo'lim 2 vazifa 3 misol  "Raqamni toping" o'yini
// 1 dan 100 gacha tasodifiy son yaratish

Console.ReadLine();















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














