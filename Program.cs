using GameValues;

// Objects
DROFSNAR player = new DROFSNAR();
BirdTypes birdTypes = new BirdTypes();
BirdHunters birdHunters = new BirdHunters();

// Reading the text file and adding it to a list
string filePath = @"C:\Users\samso\Documents\CodingProjects\ElevenFiftyProjects\codingFoundations\assignments\DrofsnarChallenge\assets\game-sequence.txt";
List<string> lines = File.ReadAllLines(filePath).ToList();

foreach (string line in lines)
{
    // line.Split(',');
    Console.WriteLine(line);
}

// Loop that checks each list item and applys the correct object as its value and writes it to the console
foreach (string line in lines)
    {
        if (line == "Bird")
        {
            Console.WriteLine(birdTypes.Bird);
        }
        else if (line == "CrestedIbis")
        {
            Console.WriteLine(birdTypes.CrestedIbis);
        }
        else if (line == "GreatKiskudee")
        {
            Console.WriteLine(birdTypes.GreatKiskudee);
        }
        else if (line == "RedCrossbill")
        {
            Console.WriteLine(birdTypes.RedCrossbill);
        }
        else if (line == "RedNeckedPhalarope")
        {
            Console.WriteLine(birdTypes.RedNeckedPhalarope);
        }
        else if (line == "EveningGrosbeak")
        {
            Console.WriteLine(birdTypes.EveningGrosbeak);
        }
        else if (line == "GreaterPrairieChicken")
        {
            Console.WriteLine(birdTypes.GreaterPrairieChicken);
        }
        else if (line == "IcelandGull")
        {
            Console.WriteLine(birdTypes.IcelandGull);
        }
        else if (line == "GreaterPrairieChicken")
        {
            Console.WriteLine(birdTypes.GreaterPrairieChicken);
        }
        else if (line == "OrangeBelliedParrot")
        {
            Console.WriteLine(birdTypes.OrangeBelliedParrot);
        }
        else if (line == "InvincibleBirdHunter")
        {
            Console.WriteLine(birdHunters.InvincibleBirdHunter);
        }
        else if (line == "VulnerableBirdHunter")
        {
            Console.WriteLine(birdHunters.VulnerableBirdHunter);
        }
        else
        {
            Console.WriteLine("oops");
        }
    };

// Classes setup to assign values to each character type
namespace GameValues
{
    class DROFSNAR
    {
        public int StartingPoints { get; set; } = 5000;
        public int StartingLives { get; set; } = 3;

    }

    class BirdHunters
    {
        public int InvincibleBirdHunter { get; set; } = -1;
        public int VulnerableBirdHunter { get; set; } = 1;
    }

    class BirdTypes
    {
        public int Bird { get; set; } = 10;
        public int CrestedIbis { get; set; } = 100;
        public int GreatKiskudee { get; set; } = 300;
        public int RedCrossbill { get; set; } = 500;
        public int RedNeckedPhalarope { get; set; } = 700;
        public int EveningGrosbeak { get; set; } = 1000;
        public int GreaterPrairieChicken { get; set; } = 2000;
        public int IcelandGull { get; set; } = 3000;
        public int OrangeBelliedParrot { get; set; } = 5000;
    }
}