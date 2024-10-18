List<string> potential = [
"Shea Zink",
"Chantal Beckwith",
"Lee Wolff",
"Demonte Royer",
"Gissel Erickson",
"Yisroel Huntley",
"Dania Kitchens",
"Donovan Mai",
"Garett Lytle",
"Kristyn White",
];

List<string> current = [];

int i;

while (current.Count < 3) 
{
    Console.WriteLine("=== Potential Recruits ===");

    for (i = 0; i < potential.Count; i++);
    {
        Console.WriteLine($"[{i}] {potential[i]}");
    }

    Console.WriteLine("=== Current Recruits ===");

    for (i = 0; i < current.Count; i++)
    {
        Console.WriteLine($"{current[i]}");
    }

    Console.ReadKey();
    
}
