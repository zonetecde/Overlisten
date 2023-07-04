namespace OverlistenClassLibrary
{
    public class Data
    {
        public List<Hero> Heroes { get; set; }
        public List<Npc> Npcs { get; set; }
    }

    public class Npc
    {
        public string Name { get; set; }
        public List<Sound> Sounds { get; set; }
    }

    public class Sound
    {
        public string Path { get; set; }
        public string Subtitle { get; set; }
    }

    public class Hero
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; }

        public List<Conversation> Conversations { get; set; }
    }

    public class Conversation
    {
        public List<Dialogue> Dialogues { get; set; }
    }

    public class Dialogue
    {
        public string HeroTalking { get; set; }
        public Sound Sound { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
        public List<Sound> Sounds { get; set; }
    }
}