/*
 * 04/07/2023 18:16
 * 
 * Projet permettant de lister dans un fichier .JSON le chemin d'accès au 
 * fichier audio ainsi que la transcription de ces derniers.
 * 
 * */

using Newtonsoft.Json;
using OverlistenClassLibrary;
using System.Text;

// The path where theses 3 folders are located: BetterHeroVoice, HeroConvo, and NPCVoice
string defaultPath = "E:\\Divers\\overwatch sounds extractor\\data\\overlisten";

// RENOMMER MANUELLEMENT TOUS LES DOSSIERS AVEC DES CARACTERES SPECIAUX (torbjorn et lucio)

// A n'executer que après avoir extrait les sons du jeu  
//RenameFactory(defaultPath);

Data data = new Data();

Console.WriteLine("Starting NPC");
data.Npcs = GetNpcsSound(defaultPath);

Console.WriteLine("Starting HERO");
data.Heroes = GetHeroesSound(defaultPath);

// Ajoute les héros qui ont des conversations mais qui n'était pas dans le dossier \BetterHeroVoice
data.Heroes.AddRange(
    Directory.GetDirectories(defaultPath + "\\HeroConvo")
        .Where(directory => !data.Heroes.Any(x => x.Name == directory.Split('\\').Last()))
        .ToList().ConvertAll(x => new Hero()
        {
            Name = x.Split('\\').Last(),
            Categories = new(),
            Conversations = new()
        })
);

Console.WriteLine("Starting CONVERSATION");
// Conversation
foreach (Hero hero in data.Heroes)
{
    hero.Conversations = GetHeroConversation(defaultPath, hero.Name);
}

// Sauvegarde
File.WriteAllText("data.json", 
    JsonConvert.SerializeObject(data, Formatting.Indented)
        .Replace("\\\\", "/") /* remplace le chemin d'accès vers les fichiers en chemin d'accès url, on le fait maintenant car .Replace() est très long */
        .Replace('ö', 'o')
        .Replace('ú', 'u'),
     Encoding.UTF8
);

static List<Conversation> GetHeroConversation(string defaultPath, string heroName)
{
    string conversationPath = defaultPath + "\\HeroConvo\\" + heroName;

    if (!Directory.Exists(conversationPath))
        return new List<Conversation>();

    var heroesConv = new List<Conversation>();
    string[] conversationFolders = Directory.GetDirectories(conversationPath);

    foreach (string conversationFolder in conversationFolders)
    {
        Conversation conversation = new Conversation()
        {
            Dialogues = new()
        };

        string[] dialogueFiles = Directory.GetFiles(conversationFolder, "*", SearchOption.AllDirectories);
        foreach (string soundFile in dialogueFiles.Where(x => Path.GetExtension(x) != ".txt"))
        {
            string subtitle = "unavailable";

            string subtitleFile = Path.Join(Path.GetDirectoryName(soundFile), Path.GetFileNameWithoutExtension(soundFile) + ".txt");
            if (File.Exists(subtitleFile))
                subtitle = File.ReadAllText(subtitleFile, Encoding.Unicode);

            string heroTalking = "unknown";
            try
            {
                heroTalking = Path.GetFileNameWithoutExtension(soundFile).Split('-')[1];
            }
            catch { }

            conversation.Dialogues.Add(new Dialogue()
            {
                HeroTalking = heroTalking,
                Sound = new Sound()
                {
                    Path = soundFile.Remove(0, defaultPath.Length + 1),
                    Subtitle = subtitle
                }
            });
        }

        heroesConv.Add(conversation);
    }

    return heroesConv;
}

static List<Npc> GetNpcsSound(string defaultPath)
{
    var npcSound = new List<Npc>();

    string npcVoicePath = defaultPath + "\\NPCVoice";
    string[] npcFolders = Directory.GetDirectories(npcVoicePath);

    foreach (string npcFolder in npcFolders)
    {
        Npc npc = new Npc()
        {
            Name = npcFolder.Split('\\').Last(),
            Sounds = new List<Sound>()
        };

        string[] soundFiles = Directory.GetFiles(npcFolder, "*", SearchOption.AllDirectories);
        foreach (string soundFile in soundFiles.Where(x => Path.GetExtension(x) != ".txt"))
        {
            string subtitle = "unavailable";

            string subtitleFile = Path.Join(Path.GetDirectoryName(soundFile), Path.GetFileNameWithoutExtension(soundFile) + ".txt");
            if (File.Exists(subtitleFile))
                subtitle = File.ReadAllText(subtitleFile, Encoding.Unicode);

            npc.Sounds.Add(new Sound()
            {
                Path = soundFile.Remove(0, defaultPath.Length + 1),
                Subtitle = subtitle
            });
        }

        npcSound.Add(npc);
    }

    return npcSound;
}

static List<Hero> GetHeroesSound(string defaultPath)
{
    var heroesSound = new List<Hero>();

    string betterHeroVoicePath = defaultPath + "\\BetterHeroVoice";
    string[] heroesFolders = Directory.GetDirectories(betterHeroVoicePath);

    foreach (string heroFolder in heroesFolders)
    {
        Hero hero = new Hero()
        {
            Name = heroFolder.Split('\\').Last(),
            Categories = new List<Category>()
        };

        string[] heroCategories = Directory.GetDirectories(heroFolder);
        foreach (string categorieFolder in heroCategories)
        {
            Category category = new Category()
            {
                Name = categorieFolder.Split('\\').Last(),
                Sounds = new List<Sound>()
            };

            string[] soundFiles = Directory.GetFiles(categorieFolder, "*", SearchOption.AllDirectories);
            foreach (string soundFile in soundFiles.Where(x => Path.GetExtension(x) != ".txt"))
            {
                string subtitle = "unavailable";

                string subtitleFile = Path.Join(Path.GetDirectoryName(soundFile), Path.GetFileNameWithoutExtension(soundFile) + ".txt");
                if (File.Exists(subtitleFile))
                    subtitle = File.ReadAllText(subtitleFile, Encoding.Unicode);

                category.Sounds.Add(new Sound()
                {
                    Path = soundFile.Remove(0, defaultPath.Length + 1),
                    Subtitle = subtitle
                });
            }

            hero.Categories.Add(category);
        }

        heroesSound.Add(hero);
    }

    return heroesSound;
}

static void RenameFactory(string defaultPath)
{
    // Enlève le nom complet des fichiers car le chemin d'accès est trop grand
    var allFiles = Directory.GetFiles(defaultPath, "*.*", SearchOption.AllDirectories);
    double lastPourcent = -1;

    for (int i = 0; i < allFiles.Length; i++)
    {
        string? file = allFiles[i];
        string fileName = Path.GetFileName(file);

        int lastDashIndex = fileName.LastIndexOf('-');

        if (lastDashIndex != -1 && (fileName.Count(x => x == '-') == 1 || fileName.Count(x => x == '-') >= 3))
        {
            string fileNameWithoutExtraText = fileName.Substring(0, lastDashIndex) + Path.GetExtension(fileName);
            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(file, fileNameWithoutExtraText);
        }


        if (i % 1000 == 0)
        {
            if (lastPourcent != Math.Floor(((double)i / allFiles.Length) * 100))
            {
                lastPourcent = Math.Floor(((double)i / allFiles.Length) * 100);
                Console.Clear();
                Console.WriteLine(lastPourcent + "%");
            }
        }
    }
}