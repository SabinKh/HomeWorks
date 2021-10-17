using System;

namespace Person1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj1 = new Person("Aytan", "Aliyeva", 24);
            Person obj2 = new Person("Rasul", "Aliyev",19);
            Person obj3 = new Person("kamran", "Aliyev", 22);
            Person[] arr = { obj1, obj2, obj3 };
            int[] arr1 = { obj1.Age, obj2.Age, obj3.Age };
            Array.Sort(arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
        }
    }
}class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Person(string name,string surname,int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
    public static bool operator >(Person p1, Person p2)
    {
        return p1.Age > p2.Age;
    }
    public static bool operator < (Person p1, Person p2)
    {
        return p1.Age < p2.Age;
    }


}
