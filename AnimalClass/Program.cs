namespace AnimalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 1:
            1. Animal, Dog, Bear,Bird classlariniz olur. 
            2. Inheritence alinmali classdan inherit alin.
            3. Butun classlarda Name, Age fieldi ve Eat() adindi bir method olur. Eat() size geri hec ne donmur, sadece console-a “Able to eat” verir. 
            4. Elave olaraq Dog-da HasTail fieldi ve Bark() methodi olur. Method console-a “Dogs are barking” verir.
            5. Bear-de IsWild field-i olur
            6. Bird-de elave CanSwim adinda field ve Fly() olur. Method Console-a sadece Fly verir.*/
            Dog Alabash = new Dog { Name = "Alabash", Age = 3, HasTail = true };
            Console.WriteLine(Alabash.Eat());  
            Console.WriteLine(Alabash.Bark());

            Bear qrizli = new Bear { Name = " qrizli", Age = 5, IsWild = true };
            Console.WriteLine(qrizli.Eat());

            Bird qartal = new Bird { Name = "qara qartal", Age = 2, CanSwim = false };
            Bird serce = new Bird { Name = "agdg", Age = 1, CanSwim = false };
            Console.WriteLine(qartal.Eat());
            Console.WriteLine(serce.Eat());
            Console.WriteLine(qartal.Fly());
            Console.WriteLine(serce.Fly());
            task2(Alabash, qrizli,qartal,serce);

        }
        static void task2(Dog dog1,Bear bear1,Bird brid1,Bird brid2)
        {
            Console.WriteLine($"Heyvanlarin adlari: {dog1.Name} , {bear1.Name} , {brid1.Name} , {brid2.Name} ");
        }
    }
}