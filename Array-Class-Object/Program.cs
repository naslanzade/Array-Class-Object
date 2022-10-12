using System;

namespace Array_Class_Object
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Classwork Arrays

            //int[] arr1= { 1, 2, 34, 5, 6, 7, 5 };

            ////int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] nums = new int[5];
            //nums[0] = 2;
            //nums[1] = 3;
            //nums[2] = 17;
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] nums = new int[5];
            //nums[0] = 2;
            //nums[1] = 3;
            //nums[2] = 17;
            //nums[8] = 11;
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] nums = new int[5];
            //nums[0] = 2;
            //nums[1] = 3;
            //nums[2] = 17;
            //Array.Resize(ref nums, 20);
            //nums[8] = 11;
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] array = { 2, 5, 6, 87, 99, 3, 4 };
            //Array.Reverse(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] array = { 2, 5, 6, 87, 99, 3, 4 };
            //Array.Sort(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}


            //int[,] array1 = { { 2, 5, 6 }, { 7, 9, 10 } };
            //Console.WriteLine(array1.Rank);


            //int a = 5;
            //var t = a.ToString();
            //t += "100";
            //Console.WriteLine(t);

            #endregion

            #region Classwork Object

            //string stuName1 = "Qoshqar";
            //string stuSurname1 = "Narimali";
            //int stuAge1 = 29;
            //bool isMarried1 = true;

            //string stuName2 = "Mehemmed";
            //string stuSurname2 = "Mehtiyev";
            //int stuAge2 = 15;
            //bool isMarried2 = false;

            //string stuName3 = "Resul";
            //string stuSurname3 = "Hesenov";
            //int stuAge3 = 15;
            //bool isMarried3 = false;

            //string stuName4 = "Vuqar";
            //string stuSurname4 = "Rustamov";
            //int stuAge4 = 38;
            //bool isMarried4 = true;

            //string stuName5 = "Cavid";
            //string stuSurname5 = "Aliyev";
            //int stuAge5 = 25;
            //bool isMarried5 = false;


            //string married = isMarried3 ? "Evlidir" : "Subaydir";
            //Console.WriteLine($"{stuName3} { stuSurname3} { stuAge3} {married}");

            //    var stu1 = new
            //    {
            //    name = "Qoshqar",
            //    surname = "Narimali",
            //    age = 29,
            //    isMarried = true,
            //};

            //    var stu2 = new
            //    {
            //        name = "Mehemmed",
            //        surname = "Mehtiyev",
            //        age = 15,
            //        isMarried = false,
            //    };

            //    var stu3 = new
            //    {
            //        name = "Resul",
            //        surname = "Hesenov",
            //        age = 15,
            //        isMarried = false,
            //    };

            //    var stu4 = new
            //    {
            //        name = "Cavid",
            //        surname = "Aliyev",
            //        age = 25,
            //        isMarried = false,
            //    };

            //Console.WriteLine($"{stu4.name} {stu4.surname} {stu4.age}");


            //object[] students = { stu1.name, stu2.name, stu3.name, stu4.name };
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Class


            //Car car1 = new Car();
            //car1.name = "BMW";
            //car1.color = "Red";
            //car1.price = 15000.5;


            //Car car2 = new Car();
            //car2.name = "Toyota";
            //car2.color = "Black";
            //car2.price = 300000.2;

            //Console.WriteLine(car1.name+" "+car1.color);
            //Console.WriteLine(car2.name + " " + car2.color);


            //Employee emp1 = new Employee();

            //Console.WriteLine(emp1.name+ " "+ emp1.surname);

            //Console.WriteLine(emp1.GetFullData());


            //Employee1 emp1 = new Employee1("Cavid", "Bashirov", 29);
            //Console.WriteLine(emp1.name);
            //Console.WriteLine(emp1.age);

            //Employee1 emp1 = new Employee1("Cavid", "Bashirov", 29);
            //Console.WriteLine(emp1.GetFullName());
            //Console.WriteLine(emp1.GetFullData());

            //Employee1 emp1 = new Employee1("Ehmedli");

            //Employee1 emp1 = new Employee1("false");
            #endregion


            #region Homework

            //Task 2-Account

            //Account account = new Account();
            //account.CheckUser("cavid123", "Cavid1993");


            //Task 3-Factorial

            //Factorial factorial = new Factorial();
            //factorial.Factor(5);


            // Task 4-Calculator

            //Calculator calculator = new Calculator();
            //calculator.Calculation(4, 10);















            #endregion





        }

    }


    #region Class
    //class Employee1
    //{
    //    public string name;
    //    public string surname;
    //    public int age;
    //    public string address;
    //    public bool isMarried;

    //    public Employee1():this(33)
    //    {
    //        Console.WriteLine("Hello P414");
    //    }

    //    public Employee1(int number)
    //    {
    //        Console.WriteLine(number);
    //    }

    //    public Employee1(string empName, string empSurname, int empAge)
    //    {
    //        //Console.WriteLine(empName+" "+empSurname+" "+empAge);
    //        age = empAge;
    //        name = empName;
    //        surname = empSurname;
    //        Console.WriteLine(empName + " " + empSurname);

    //    }

    //    public Employee1(string empAddress):this()
    //    {
    //        address = empAddress;
    //        Console.WriteLine(address);
    //    }

    //public Employee1(bool married) : this("Ehmedli")
    //{
    //    isMarried = married;
    //    Console.WriteLine(isMarried);
    //}

    //    public string GetFullName()
    //    {
    //        return name + " " + surname;
    //    }

    //    public string GetFullData()
    //    {
    //        return $"{GetFullName()} {29}";
    //    }
    //}



    //class Employee
    //{
    //    public string name = "Cavid";
    //    public string surname = "Bashirov";
    //    public int age =29;

    //    public string GetFullName()
    //    {
    //       return "Cavid Bashirov";
    //    }

    //    public string GetFullData()
    //    {
    //        return GetFullName() + "-" + "29";
    //    }

    //}

    //class Car
    //{
    //    public string name;
    //    public string color;
    //    public double price;
    //}
    #endregion


}








