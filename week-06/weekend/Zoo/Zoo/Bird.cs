namespace Zoo
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override string Greet()
        {
            return "Hi, I'm a " + GetName() + "!";
        }

        public override string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}