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

string text;
string recruit;

int num;
int i;

bool success;

while (current.Count < 3) 
{
    Console.WriteLine("=== Potential Recruits ===");

    for (i = 0; i < potential.Count; i++)
    {
        Console.WriteLine($"[{i}] {potential[i]}");
    }

    Console.WriteLine("=== Current Recruits ===");

    for (i = 0; i < current.Count; i++)
    {
        Console.WriteLine($"{current[i]}");
    }

    Console.WriteLine("\nChoose a recruit:");
    num = 0;
    success = false;
    
    while (success == false || num < 0 || num >= potential.Count) 
    {
        text = Console.ReadLine();
        success = int.TryParse(text, out num);

        if (success == false) 
        {

            Console.WriteLine("That is not a number, please try again\n");

        }
        else if (num < 0 || num >= potential.Count)
        {
            
            Console.WriteLine("That is not a valid index, please try again\n");

        }

    }

        recruit = potential[num];
        current.Add(recruit);
        potential.RemoveAt(num);

}

Console.WriteLine($"You have recruted a total of {current.Count} soliders.");

Console.WriteLine("Press ENTER to quit the program");
Console.ReadLine();
