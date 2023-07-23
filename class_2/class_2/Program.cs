namespace oo_programming_class2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person jhon = new Person("Jhon", new DateOnly(1391, 4, 16), "patient");
            Person mia = new Person("Mia", new DateOnly(1391, 4, 16), "doctor");
            Person youssef = new Person("Youssef", new DateOnly(1391, 4, 16), "nurse");


            Console.WriteLine(jhon.ToString());
            //youssef.sayHello();



        }
    }
}