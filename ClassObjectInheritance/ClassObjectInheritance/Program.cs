namespace ClassObjectInheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            InheritClass1 inherit = new(5, 7, 5);
            inherit.Manipulation(inherit.GetValue());

            InheritClass4 pikachu = new InheritClass4(1);
            pikachu.Manipulation();

            InheritClass1 meow = new(5, 7, 5);
            meow.Manipulation(pikachu.GetNum());

            Console.WriteLine($"{nameof(inherit)}  - value : {inherit.value}, num : {inherit.num}, input : {inherit.input}, value2: {inherit.inherit.value}, input2: {inherit.inherit.input}");
            Console.WriteLine($"{nameof(pikachu)}  -  class1 : {pikachu.class1}, class2 : {pikachu.class2}, class3 : {pikachu.class3}, class4 : {pikachu.class4}, value : {pikachu.class0.value}, input : {pikachu.class0.input}");
            Console.WriteLine($"{nameof(meow)}  - value : {meow.value}, num : {inherit.num}, input : {meow.input}, value2: {meow.inherit.value}, input2: {meow.inherit.input}");
        }
    }
}