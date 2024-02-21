using GameValues;

// Objects
DROFSNAR player = new DROFSNAR();
BirdTypes birdTypes = new BirdTypes();
BirdHunters birdHunters = new BirdHunters();

// Reading the text file and adding it to a list
string filePath = @"C:\Users\samso\Documents\CodingProjects\ElevenFiftyProjects\codingFoundations\assignments\DrofsnarChallenge\assets\game-sequence.txt";
List<string> lines = File.ReadAllLines(filePath).ToList();

Console.WriteLine("DROFSNAR THE BIRD-MAN\nScore: 5000\nLives: 3\n");

foreach (string line in lines)
{
    string[] parts = line.Split(',');

    bool lifeAdded = false; // Flag to track if life as been added.

    foreach (string part in parts)
    {
        if (player.Lives > 0)
        {
            if (part == "Bird")
            {
                player.Points += birdTypes.Bird;
                Console.Write($"Bird found!\n" + 
                                $"+{birdTypes.Bird} points\n"
                            );
            }
            else if (part == "CrestedIbis")
            {
                player.Points += birdTypes.CrestedIbis;
                Console.Write($"Crested Ibis found!\n" + 
                                $"+{birdTypes.CrestedIbis} points\n"
                            );
            }
            else if (part == "GreatKiskudee")
            {
                player.Points += birdTypes.GreatKiskudee;
                Console.Write($"Great Kiskudee found!\n" + 
                                $"+{birdTypes.GreatKiskudee} points\n"
                            );
            }
            else if (part == "RedCrossbill")
            {
                player.Points += birdTypes.RedCrossbill;
                Console.Write($"Red Cross Bill found!\n" + 
                                $"+{birdTypes.RedCrossbill} points\n"
                            );
            }
            else if (part == "Red-neckedPhalarope")
            {
                player.Points += birdTypes.RedNeckedPhalarope;
                Console.Write($"Red Necked Phalarope found!\n" + 
                                $"+{birdTypes.RedNeckedPhalarope} points\n"
                            );
            }
            else if (part == "EveningGrosbeak")
            {
                player.Points += birdTypes.EveningGrosbeak;
                Console.Write($"Evening Grosbeak found!\n" + 
                                $"+{birdTypes.EveningGrosbeak} points\n" 
                            );
            }
            else if (part == "GreaterPrairieChicken")
            {
                player.Points += birdTypes.GreaterPrairieChicken;
                Console.Write($"Greater Prairie Chicken found!\n" + 
                                $"+{birdTypes.GreaterPrairieChicken} points\n"
                            );
            }
            else if (part == "IcelandGull")
            {
                player.Points += birdTypes.IcelandGull;
                Console.Write($"Iceland Gull found!\n" + 
                                $"+{birdTypes.IcelandGull} points\n"
                            );
            }
            else if (part == "Orange-belliedParrot")
            {
                player.Points += birdTypes.OrangeBelliedParrot;
                Console.Write($"Orange-Bellied Parrot found!\n" + 
                                $"+{birdTypes.OrangeBelliedParrot} points\n"
                            );
            }
            else if (part == "InvincibleBirdHunter")
            {
                player.Lives -= 1;
                Console.Write($"Uh oh!\n" +
                                $"A bird hunter chomped DROFSNAR!\n" +
                                $"{player.Lives} lives remaining.\n"
                            );
            }
            else if (part == "VulnerableBirdHunter")
            {
                int num = birdHunters.VulnerableBirdHunter;
                if (num == 1)
                {
                    player.Points += 200;
                    birdHunters.VulnerableBirdHunter += 1;
                    Console.Write($"Bird hunter defeated!\n" + 
                                    $"+200 points\n"
                                );
                }
                else if (num == 2)
                {
                    player.Points += 400;
                    birdHunters.VulnerableBirdHunter += 1;
                    Console.Write($"Bird hunter defeated!\n" + 
                                    $"+400 points\n"
                                );
                }
                else if (num == 3)
                {
                    player.Points += 800;
                    birdHunters.VulnerableBirdHunter += 1;
                    Console.Write($"Bird hunter defeated!\n" + 
                                    $"+800 points\n"
                                );
                }
                else if (num >= 4)
                {
                    player.Points += 1600;
                    Console.Write($"Bird hunter defeated!\n" + 
                                    $"+1600 points\n"
                                );
                }
                else
                {
                    Console.WriteLine("oops");
                }
            }
            
            if (player.Points > 10000 && !lifeAdded)
            {
                player.Lives += 1;
                lifeAdded = true;
                Console.Write("DROFSNAR has over 10,000 points!\nOne extra life added!\n");
            }

            Console.WriteLine("");
        }
        else
        {
            break;
        }
    }
}

Console.Write($"GAME OVER!\nTotal Score: {player.Points}\n");

// Classes setup to assign values to each character type
namespace GameValues
{
    class DROFSNAR
    {
        public int Points { get; set; } = 5000;
        public int Lives { get; set; } = 3;
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