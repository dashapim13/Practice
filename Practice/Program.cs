namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Person David = new Person();  //creating object from class Person
            David.Print();    //name: Dan, age: 35
        }

        class Person
        {
            public string name;
            public int age;

            public Person()
            {
                Console.WriteLine("Creation of object Person");
                name = "David";
                age = 35;
            }

            public void Print()
            {
                Console.WriteLine($"Name: {name} Age: {age}");
            }
        }
    }
}
