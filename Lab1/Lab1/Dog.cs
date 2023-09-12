namespace Lab1
{
    internal class Dog : HomePet
    {

        public List<string> Commands { get; set; }
        public string Alias { get; set; }
        private bool isHouseKept { get; set; }
        string[] dogAdjectives = new string[]
        {
            "Loyal",
            "Playful",
            "Energetic",
            "Affectionate",
            "Obedient",
            "Friendly",
            "Intelligent",
            "Devoted",
            "Protective",
            "Curious",
            "Adorable",
            "Faithful",
            "Gentle",
            "Alert",
            "Trustworthy",
            "Social",
            "Agile",
            "Brave",
            "Mischievous",
            "Spirited"
        };

        public Dog(string name, string qrCodeNumber, int age, int ownerPhoneNumber, bool isHouseKept, List<string> commands, string alias)
        : base(name, qrCodeNumber, age, ownerPhoneNumber)
        {
            Alias = alias;
            Commands = commands;
            this.isHouseKept = isHouseKept;
        }

        public void ShowCommands()
        {
            foreach (var command in Commands)
            {
                Console.WriteLine(command);
            }
        }
        public string TeachACommand(string command)
        {
            if (isHouseKept && _age <= 10)
                return "Good job, now dog knows a new command";
            else
                return new Random().Next(1) > 0.5 ? "There were some problems, but dog learned a new command"
                    : "Dog went away";

        }
        public override string GetAlias(string name, int age)
        {
            return $"{dogAdjectives[new Random().Next(dogAdjectives.Length)]} {name}";
        }
    }
}
