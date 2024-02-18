

string[] students = new string[3];

students[0] = "Doğukan";
students[1] = "Muhammed";
students[2] = "Esra";

string[] students2 = { "Doğukan", "Muhammed", "Esra" };

foreach (string student in students2)
{
    Console.WriteLine(student);
}

string[,] regions = new string[7, 3]
{
    {"İstanbul","İzmit","Balıkkesir" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Mersin","Adana" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir","Muğla","Manisa" },
    {"Van","Muş","Ağrı" },
    {"Diyarbakır","Gazi Antep","Şanlı Urfa" },
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("**********");

}