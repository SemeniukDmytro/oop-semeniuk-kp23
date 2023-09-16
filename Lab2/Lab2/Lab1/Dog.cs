namespace Lab2
{
    internal class Dog : HomePet, IActivity, IHomeProtector, IPet
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

        void IHomeProtector.MakeSound()
        {
            Console.WriteLine("RRRRR");
        }

        public void Attack()
        {
            Console.WriteLine("Dog is biting burglars");
        }

        public void ProtectHost()
        {
            Console.WriteLine($"RRRRR. (2 seconds later) Dog is biting burglars");
        }

        public void Play()
        {
            Console.WriteLine("Dog is playing with ball");
        }

        public void HaveAMeal()
        {
            Console.WriteLine("Only meals that I eat, are those which my host gives me");
        }

        void IActivity.MakeSound()
        {
            Console.WriteLine("Woof-woof");
        }

        public void GetAllInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, QR: {QrCodeNumber}, Owner's phone number: {OwnerPhoneNumber}");
        }
    }
}
