/*
 * 04/07/2023 18:16
 * 
 * Projet permettant de lister dans un fichier .JSON le chemin d'accès au 
 * fichier audio ainsi que la transcription de ces derniers.
 * 
 * Avant d'executer les 3 commandes dans le CMD, supprimer les dossiers contenant
 * les anciens audios
 * 
 * */

using Newtonsoft.Json;
using OverlistenClassLibrary;
using System.Text;

// The path where theses 3 folders are located: BetterHeroVoice, HeroConvo, and NPCVoice
string defaultPath = "E:\\Divers\\overwatch sounds extractor\\data\\overlisten";

// A n'executer que après avoir extrait les sons du jeu  
RenameFilesAndFolders(defaultPath);
RenameFactory(defaultPath);

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
        .Replace("\\\\", "/"), /* remplace le chemin d'accès vers les fichiers en chemin d'accès url, on le fait maintenant car .Replace() est très long */
     Encoding.UTF8
);

static void RenameFilesAndFolders(string path)
{
    var directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories)
        .Where(directory => directory.Contains('ö') || directory.Contains('ù')|| directory.Contains('ú'));

    foreach(string directory in directories)
    {
        if (directory.Split('\\').Last().Contains('ö') || directory.Split('\\').Last().Contains('ù')|| directory.Split('\\').Last().Contains('ú'))
        {
            string newdirectory = directory.Replace('ö', 'o').Replace('ù', 'u').Replace('ú', 'u');

            Directory.Move(directory, newdirectory);
        }
    }

    // même chose mais pour les fichiers cette fois
    var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories)
        .Where(file => file.Contains('ö') || file.Contains('ù') || file.Contains('ú'));

    foreach (string file in files)
    {
        if (file.Split('\\').Last().Contains('ö') || file.Split('\\').Last().Contains('ù') || file.Split('\\').Last().Contains('ú'))
        {
            string newFileName = file.Replace('ö', 'o').Replace('ù', 'u').Replace('ú', 'u');

            System.IO.File.Move(file, newFileName);
        }
    }
}

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

        int whereCut = fileName.LastIndexOf(".0");
        if (whereCut == -1)
            continue; // already renamed

        string fileNameWithoutExtraText = fileName.Substring(0, whereCut) + Path.GetExtension(fileName);
        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(file, fileNameWithoutExtraText);

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