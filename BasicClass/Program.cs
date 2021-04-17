using System;

namespace BasicClass
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat Nero = new Cat();
            kitty.Color = "검은색";
            kitty.Name = "네로";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");
        }
    }
}
