using System.Drawing;

namespace G_NET_88_ADV0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment

            #region Q1
            //A generic class is a class that can work with different data types by using a type parameter instead of a specific data type. The type is specified when an object of the class is created.
            #endregion
            #region Q2
            //Container<int> container = new Container<int>();

            //container.Add(5);
            //Console.WriteLine(container.Get());

            //Container<string> container02 = new Container<string>();

            //container02.Add("Ahmed");
            //Console.WriteLine(container02.Get());
            #endregion
            #region Q3
            //Multiple type parameters are when a generic class or method uses more than one type parameter.
            //Pair<int, string> pair = new Pair<int, string>();

            //pair.Add(5, "ALI");

            //Console.WriteLine(pair.ToString());


            #endregion
            #region Q4
            //A generic method is a method that can work with different data types using a type parameter.
            //int a = 10;
            //int b = 20;

            //Swap.swap<int>(ref a, ref b);

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion
            #region Q5
            //FindMax.findmax(15.5, 5);
            #endregion
            #region Q6
            //A generic interface is an interface that uses a type parameter so it can work with different data types.
            //Repository repository = new Repository();
            //repository.Add(15);
            //Console.WriteLine(repository.Get());
            #endregion
            #region Q7
            //The struct constraint means that the generic type must be a value type (such as int, double, or a custom struct).
            //Test<int> obj = new Test<int>();

            //obj.Print(10);
            #endregion
            #region Q8
            //The class constraint means that the generic type must be a reference type.
            //Test2<string> test2 = new Test2<string>();
            //test2.Print("Hello");
            #endregion
            #region Q9
            //The new() constraint means that the generic type must have a public parameterless constructor.
            //Test3<Student> test3 = new Test3<Student>();

            //Student student = test3.Create();
            #endregion
            #endregion



        }
    }

    //class Test3<T> where T : new()
    //{
    //    public T Create()
    //    {
    //        return new T();
    //    }
    //}
    //class Student
    //{
    //}

}
