//Console.WriteLine("Hello, World!");
/*double sa,volume;
double r = 60.0;
double pi = 3.14;
sa = 4.0 * pi * r * r;
Console.WriteLine("The Surface area of sphere is : " +sa);
volume = 4.0 / 3 * pi * r * r * r;
Console.WriteLine("The Volume of sphere is : " +volume);*/
/*Console.WriteLine("Enter Celsius : ");
int cel = Convert.ToInt32(Console.ReadLine());
double fah = cel * 1.8 + 32;
double kel = cel + 273;
Console.WriteLine("The Fahrenheit is : "+fah);
Console.WriteLine("The Kelvin is : "+kel);*/
/*Console.WriteLine ("Please enter millimeters:");
double millimeters = Convert.ToDouble(Console.ReadLine());
double centimeters = millimeters / 10;
Console.WriteLine(centimeters + " Centimeters");
Console.WriteLine ("Please enter Kilometers:");
double Kilometers = Convert.ToDouble(Console.ReadLine());
double meter = Kilometers * 1000;
Console.WriteLine(meter + " Meters");*/
/*int n,j;
Console.Write("Input the number (Table to be calculated) : ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
for(j=1;j<=10;j++)
{
    Console.Write("{0} X {1} = {2} \n",n,j,n*j);
}*/
/*int n1=0,n2=1,n3,i,number;
Console.Write("Enter the number of elements: ");
number = int.Parse(Console.ReadLine());
Console.Write(n1+" "+n2+" ");
for(i=2;i<number;++i)
{
    n3=n1+n2;
    Console.Write(n3+" ");
    n1=n2;
    n2=n3;
}*/
/*if (num % 2 == 0){
Console.WriteLine(num+" is a even number.");
}4 * 3.14 * r * r
4/3 * 3.14 * r*r*r
else{
Console.WriteLine(num+" is a odd number.");
}*/
/*Console.WriteLine("Enter price of one flower : ");
double flower_rate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter no of flowers : ");
double noof_flower = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter price of sweets : ");
double sweets_rate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter no of sweets : ");
double noof_sweets = Convert.ToDouble(Console.ReadLine());
double total = flower_rate * noof_flower + sweets_rate * noof_sweets;
Console.WriteLine("Enter no of days to find Expenses : ");
double days = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The Total expense of a user is : "+total);
Console.WriteLine("Enter no of users : ");
double users = Convert.ToDouble(Console.ReadLine());
double users_total = users * total;
Console.WriteLine("The Total Amount spend by "+users+" users is : "+users_total * days);*/
/*write an access controlling C# that is
login_id = 12
pass = 1234 or upto maximim 3 attempt*/
/*sbyte a = 127;
Console.WriteLine(a);*/
/*Console.WriteLine("Enter no 1 : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter no 2 : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter no 3 : ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine(a + " is greater.");
}
if (b > c)
{
    Console.WriteLine(b + " is greater.");
}
else
{
    Console.WriteLine(c + " is greater.");
}*/
/*Console.WriteLine("Enter a num : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a width : ");
int w = Convert.ToInt32(Console.ReadLine());
int h = w;
for (int r = 0; r < h; r++)
{
    for (int c = 0; c < w; c++)
    {
        Console.Write(n);
    }
    Console.Write("\n");
    w--;
}*/
//program 7
/*int num1, res, i;
Console.Write("Enter a number : ");
num1 = Convert.ToInt32(Console.ReadLine());
i = 1;
while (i <= 10)
{
    res = num1 * i;
    Console.WriteLine("{0} x {1} = {2}", num1, i, res);
    i++;
}*/
//program 6
/*int a, b, c, result;
Console.Write("Enter Number 1 : ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Number 2 : ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Number 3 : ");
c = Convert.ToInt32(Console.ReadLine());
result = Sum(a, b, c);
Console.Write("Sum : "+result);
static int Sum(int x, int y, int z)
{
    int res;
    res = x + y + z;
    return res;
}*/
//program 5
/*int fact = 1;
Console.Write("\n");
Console.Write("Enter Number : ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    fact = fact * i;
}
Console.WriteLine("Factorial : {0}", fact);
Console.Read();*/
//program 4
/*int x;
Console.Write("\n");
Console.Write("Enter Number : ");
x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine(x + " is an Even Number");
    Console.Write("\n");
}
else
{
    Console.WriteLine(x + " is an Odd Number");
    Console.Write("\n");
}*/
//program 3
/*int x = 5;
if (x % 2 == 0)
{
    Console.Write("\n");
    Console.WriteLine(x + " is an Even Number");
    Console.Write("\n");
}
else
{
    Console.Write("\n");
    Console.WriteLine(x + " is an Odd Number");
    Console.Write("\n");
}*/
//program 2
/*Console.WriteLine();
Console.Write("\t$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.Write("\n\n\tName : Ramesh Tamkuity \n\tDOB : 15/10/1991 \n\tAddress : 4, xyx society,\n\t\t  Kalawad Road \n\tCity : Rajkot \n\tPincode : 360 001 \n\tState : Gujarat \n\tCountry : India \n\tEmail : abc@ymail.com");
Console.Write("\n\n\t$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("\n");*/
//program 1
/*Console.Write("\n\tHello World!\n");
Console.Write("\n\n");*/
/*using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello World");
    }
}*/
/*int[] arr = {8, 5, 4};
Array.Reverse(arr);
double x = Math.Pow(arr[0], 2);
Console.Write(x);*/
//wap vowel or consonant
/*Console.WriteLine("Enter a Character : ");
char lower = Convert.ToChar(Console.Read());
if ((lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u') || (lower == 'A' || lower == 'E' || lower == 'I' || lower == 'O' || lower == 'U'))
{
    Console.WriteLine(lower + " is a vowel.");
}
else
{
    Console.WriteLine(lower + " is not a vowel.");
}*/
//Profit and loss
/*Console.WriteLine("Enter Cost Price : ");
Double cp = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Selling Price : ");
Double sp = Convert.ToDouble(Console.ReadLine());
if (cp > sp)
{
    double amount = cp - sp;
    Console.WriteLine("Your Profit is : "+amount);
}
else
{
    double amount = sp - cp;
    Console.WriteLine("Your Loss is : "+amount);
}*/
//Driver Insurance
/*Console.Write("Enter Martial Status : ");
string m_status = Console.ReadLine();
Console.Write("Enter Gender : ");
string gender = Console.ReadLine();
Console.Write("Enter Age : ");
int age = Convert.ToInt32(Console.ReadLine());
if (m_status == "married" || m_status == "MARRIED")
{
    Console.WriteLine("You are eligible for insurance.");
}
else
{
    if (gender == "male" || gender == "MALE")
    {
        if (age > 30)
        {
            Console.WriteLine("You are eligible for insurance.");
        }
    }
    else
    {
        Console.WriteLine("You are not eligible for insurance.");
    }

    if (gender == "female" || gender == "FEMALE")
    {
        if (age > 25)
        {
            Console.WriteLine("You are eligible for insurance.");
        }
    }
    else
    {
        Console.WriteLine("You are not eligible for insurance.");
    }
}*/
/*Console.Write("Enter Price : ");
Double price = Convert.ToDouble(Console.ReadLine());
if (price <= 1000)
{
    Console.Write("Oops you didn't get any discount.");
}
else if (price > 1000 && price <= 2000)
{
    Double new_price = price - (price * 5 / 100);
    Console.WriteLine("Before discount the price was " + price);
    Console.WriteLine("After discount the price is " + new_price + " with 5% discount.");
}
else if (price > 2000 && price <= 3000)
{
    Double new_price = price - (price * 10 / 100);
    Console.WriteLine("Before discount the price was " + price);
    Console.WriteLine("After discount the price is " + new_price + " with 10% discount.");
}
else if (price > 3000 && price <= 5000)
{
    Double new_price = price - (price * 15 / 100);
    Console.WriteLine("Before discount the price was " + price);
    Console.WriteLine("After discount the price is " + new_price + " with 15% discount.");
}
else if (price > 5000)
{
    Double new_price = price - (price * 25 / 100);
    Console.WriteLine("Before discount the price was " + price);
    Console.WriteLine("After discount the price is " + new_price + " with 25% discount.");
}*/
//Reverse Alphabet
/*char a = 'a';
for (char i = 'Z'; i >= 'A'; --i)
{
    Console.Write(i + " ");
}
for (char i = 'z'; i >= a; --i)
{
    Console.Write(i + " ");
}*/
/*double sum = 0;
Console.Write("Enter a start no : ");
double s_no = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a end no : ");
double e_no = Convert.ToDouble(Console.ReadLine());
for (double i = s_no; i <= e_no; i++)
{
    sum = sum + i;
}
Console.WriteLine("The total sum of no " + s_no + " and " + e_no + " is : " + sum);*/
/*int i, n, sum = 0;
int[] a = new int[100];
Console.Write("Input the value of n : ");
n = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.Write("Element - {0} : ", i);
    a[i] = Convert.ToInt32(Console.ReadLine());
    sum += a[i];
}

Console.Write("Sum of all elements stored in the array is : {0}", sum);*/
/*int[] arr1 = { 11, 22, 9, 1, 23, 8 };
int n = arr1.Length;

int mx = arr1[0];
int mn = arr1[0];

for (int i = 0; i < n; i++)
{
    if (arr1[i] > mx)
    {
        mx = arr1[i];
    }
    if (arr1[i] < mn)
    {
        mn = arr1[i];
    }
}

Console.Write("Maximum is : {0}", mx);
Console.Write("\nMinimum is : {0}", mn);*/
/*static void Change(ref int a, ref int b)
{
    a = 100;
    b = 200;
}

Console.Write("Enter no 1 : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter no 2 : ");
int y = Convert.ToInt32(Console.ReadLine());
Change(ref x, ref y);
Console.WriteLine("After Swap value of a is {0} and b is {1}", x, y);*/
//tt2-1
/*using System;
namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;

            if (a < 20)
            {
                Console.WriteLine("\n\ta is less than 20");
            }
            Console.WriteLine("\tvalue of a is : {0}", a);
            Console.ReadLine();
        }
    }
}*/
//tt2-2
/*using System;
namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            if (a < 20)
            {
                Console.WriteLine("a is less than 20");
            }
            else
            {
                Console.WriteLine("a is not less than 20");
            }
            Console.WriteLine("value of a is : "+a);
            Console.ReadLine();
        }
    }
}*/
//tt2-3
/*using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine("\n\tName : " + firstName + " " + lastName);
            Console.WriteLine("\tPlease enter a new first name : ");
            firstName = Console.ReadLine();
            Console.WriteLine("\tNew name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}*/
//tt2-4
/*using System;
namespace operators_read
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Sum of {0} and {1} is : {2}", a, b, c);
            Console.ReadLine();
        }
    }
}*/
//tt2-5
/*using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.Read();
        }
    }
}*/
//tt2-6
/*using System;
public class Hello3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\tHello, World!");
        Console.WriteLine("\tYou entered the following {0} command line arguments:", args.Length);
        foreach (Object obj in args)
        {
            Console.WriteLine("\t"+obj);
        }
        Console.ReadLine();
    }
}*/
//tt2-7
/*using System;
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
    class TestRef
    {
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            int b = 200;
            Console.WriteLine("\n\tBefore swap, value of a : {0}", a);
            Console.WriteLine("\tBefore swap, value of b : {0}", b);
            n.swap(ref a, ref b);
            Console.WriteLine("\tAfter swap, value of a : {0}", a);
            Console.WriteLine("\tAfter swap, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}*/
//tt2-8
/*using System;
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int getValues(out int x, out int y, out int z)
        {
            Console.Write("\n\tEnter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tEnter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tEnter the third value: ");
            z = Convert.ToInt32(Console.ReadLine());
            int sum = x + y + z;
            return sum;
        }
    }
    class TestOut
    {
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b, c, sum;
            sum = n.getValues(out a, out b, out c);
            Console.WriteLine("\tAfter method call, value of a : {0}", a);
            Console.WriteLine("\tAfter method call, value of b : {0}", b);
            Console.WriteLine("\tAfter method call, value of c : {0}", c);
            Console.WriteLine("\tSum : {0}", sum);
            Console.ReadLine();
        }
    }
}*/
//tt2-9
/*using System;
class tt2_9
{
    static void UniqueNumbers2(int[] arr, int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = (sum ^ arr[i]);
        }
        sum = (sum & -sum);
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i] & sum) > 0)
            {
                sum1 = (sum1 ^ arr[i]);
            }
            else
            {
                sum2 = (sum2 ^ arr[i]);
            }
        }
        Console.Write("\n");
        Console.WriteLine("\t" + sum1 + "," + sum2);
        Console.Write(" ");
    }
    static public void Main()
    {
        int[] arr = { 1, 2, 3, 2, 1, 4 };
        int n = arr.Length;
        UniqueNumbers2(arr, n);
    }
}*/
//tt2-10
/*using System;
class GFG
{
    static int search(int[,] mat, int n, int x)
    {
        if (n == 0)
            return -1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] == x)
                {
                    Console.Write("\t1");
                    Console.Write("\n");
                }
            }
        }
        return 0;
    }
    static public void Main()
    {
        int[,] mat = { { 3, 30, 38 }, { 44, 52, 54 }, { 57, 60, 69 } };
        Console.Write("\n");
        Console.Write("\tEnter value to be searched : ");
        Console.Write(" ");
        int x = Convert.ToInt32(Console.ReadLine());
        search(mat, 3, x);
    }
}*/
//tt2-11
/*using System;
class sum_array
{
    public static void Main()
    {

        int[] arr = { 12, 3, 4, 15 };
        int n = arr.Length;
        int sum = 0;
        for (int i = 0; i < n; i++) { sum += arr[i]; }
        Console.Write("Sum of given array is " + sum);
    }
}*/
//tt2-12
/*using System;
using System.Linq;
public static class Extensions
{
    public static bool find<T>(this T[] array, T target)
    {
        return array.Contains(target);
    }
}

public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.Write("Enter the number to be searched : ");
        int target = Convert.ToInt32(Console.ReadLine());

        bool isExist = array.find(target);
        if (isExist)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}*/
//tt2-13
/*using System;
public class tt2_13
{
    public static void countCurrency(int amount)
    {
        int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 1 };
        int[] noteCounter = new int[9];
        for (int i = 0; i < 9; i++)
        {
            if (amount >= notes[i])
            {
                noteCounter[i] = amount / notes[i];
                amount = amount % notes[i];
            }
        }
        Console.Write("Currency Count -> ");
        for (int i = 0; i < 9; i++)
        {
            if (noteCounter[i] != 0)
            {
                Console.Write(notes[i] + " : " + noteCounter[i] + " ");
            }
        }
    }
    public static void Main()
    {
        Console.Write("Enter amount : ");
        int amount = Convert.ToInt32(Console.ReadLine());
        countCurrency(amount);
    }
}*/
//tt2-14
/*public class tt2_14
{
    private static void Main(string[] args)
    {
        Console.Write("Input the marks obtained in Maths : ");
        int m_sub = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the marks obtained in Physics : ");
        int p_sub = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the marks obtained in Chemistry : ");
        int c_sub = Convert.ToInt32(Console.ReadLine());
        if ((m_sub + p_sub + c_sub >= 180) || (m_sub + p_sub >= 140))
        {
            Console.Write("The candidate is eligible for admission.");
        }
        else
        {
            Console.Write("The candidate is not eligible for admission.");
        }
    }
}*/
//tt2-15
/*using System;
using System.Collections.Generic;
class Demo
{
    public static void Main()
    {
        string line;
        Console.Write("Enter string : ");
        line = Console.ReadLine();
        if (line != null)
        {
            Console.WriteLine(line);
        }
    }
}*/
//practice
/*int b = 0, m;
Console.Write("Enter any number : ");
int a = Convert.ToInt32(Console.ReadLine());
while (a != 0)
{
    m = a % 10;
    b = b * 10 + m;
    a /= 10;
}
Console.Write("The reverse is : " + b);*/
//prime number
/*bool isPrime = true;
int i, j;
Console.Write("Prime Numbers are :");
for (i = 2; i <= 100; i++)
{
    for (j = 2; j <= 100; j++)
    {
        if (i != j && i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.Write(" " + i);
    }
    isPrime = true;
}
Console.ReadLine();
    }
}*/
//Pt
/*class Test
{
    private int x;
    public int X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
}

class Demo
{
    public static void Main()
    {
        Test m = new Test();
        m.X = 10;
        Console.Write(m.X);
    }
}*/
/*class Test
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}

class Demo
{
    public static void Main()
    {
        Test m = new Test();
        m.Name = "Hello";
        Console.Write(m.Name);
    }
}*/
/*class person
{
    public string name;
    public int age;
    public person(int age, string name)
    {
        this.age = age;
        this.name = name;
    }
}
class Employee : person
{
    public int id;
    public Employee(int id, int age, string name) : base(age, name)
    {
        this.id = id;

    }
}
class DailyWage : Employee
{
    public int days;
    public int dwage;
    int salary;
    public DailyWage(int id, int age, string name, int days, int dwage) : base(id, age, name)
    {
        this.days = days;
        this.dwage = dwage;
    }
    public void CalculatorSalary()
    {
        salary = dwage * days;
    }
    public void Display()
    {
        Console.Write("Emp ID : {0}", id);
        Console.Write("\nEmp Name : {0}", name);
        Console.Write("\nEmp Age : {0}", age);
        Console.Write("\nEmp Days : {0}", days);
        Console.Write("\nEmp Daily wage : {0}", dwage);
        Console.Write("\nEmp Salary : {0}", salary);
    }
}
class demo
{
    public static void Main()
    {
        DailyWage d_obj = new DailyWage(1,18,"ABC",50,50);
        d_obj.CalculatorSalary();
        d_obj.Display();
    }
}*/
//tt1-8
/*class tt1_8
{
    private static void Main(string[] args)
    {
        //tt1-8
        string s1;
        Console.Write("\n\tInput : ");
        s1 = Console.ReadLine();
        if (s1 != null)
        {
            Console.WriteLine("\tOUTPUT : {0}",s1.ToUpper());
        }
        Console.ReadLine();
    }
}*/
//tt1-9
/*using System;
class tt1_9
{
    static void toggleChars(char[] str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
                str[i] = (char)(str[i] + 'a' - 'A');
            else if (str[i] >= 'a' && str[i] <= 'z')
                str[i] = (char)(str[i] + 'A' - 'a');
        }
    }
    public static void Main(String[] args)
    {
        char[] str = "JoHn F kEnNedy".ToCharArray();
        toggleChars(str);
        Console.Write("\n\tString after toggle : ");
        Console.WriteLine(String.Join("", str));
        Console.ReadLine();
    }
}*/
//tt1-10
/*class tt1_10
{
    public static void Main(string[] args)
    {
        Console.Write("INPUT : ");
        string value = Console.ReadLine();
        for (int i = 0; i < 5; i++)
        {
            Console.Write(value[i]);
        }
        for (int i = 0; i < 5; i++)
        {
            Console.Write("X");
        }
        Console.ReadLine();
    }
}*/
//tt1-11
/*class tt1_11
{
    private static void Main(string[] args)
    {
        string s1;
        Console.Write("\n\tNAME : ");
        s1 = Console.ReadLine();
        Console.Write("\tGENDER : ");
        char c = Convert.ToChar(Console.ReadLine());
        if (s1 != null)
        {
            if (c == 'F' || c == 'f') { Console.WriteLine("\tMs.{0}", s1); }
            else if (c == 'M' || c == 'm') { Console.WriteLine("\tMr.{0}", s1); }
        }
        Console.ReadLine();
    }
}*/
//tt1-12
/*class tt1_12
{
    private static void Main(string[] args)
    {
        string s1;
        Console.Write("\n\tInput : ");
        s1 = Console.ReadLine();
        if (s1 != null)
        {
            Console.WriteLine("\tOUTPUT : {0}",s1);
        }
        Console.ReadLine();
    }
}*/
//tt1-13
/*using System;
class tt1_13
{
    public static void Main(string[] args)
    {
        int n1 = 0, n2 = 1, n3, i, number;
        Console.Write("Enter the number of elements : ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.Write(n1 + " " + n2 + " ");
        for (i = 2; i < number; ++i)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
}*/
//tt1-14
/*using System;
class tt1_14
{
    static void convert_to_words(char[] num)
    {
        int len = num.Length;
        if (len == 0)
        {
            Console.WriteLine("empty string");
            return;
        }
        if (len > 4)
        {
            Console.WriteLine("Length more than " + "4 is not supported");
            return;
        }
        string[] single_digits = new string[] {
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"
        };
        string[] two_digits = new string[] {
            "",      "ten",  "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen"
        };
        string[] tens_multiple = new string[] {
            "",  "",     "twenty", "thirty", "forty",
            "fifty", "sixty", "seventy", "eighty", "ninety"
        };
        string[] tens_power
            = new string[] { "hundred", "thousand" };
        Console.Write((new string(num)) + " : ");
        if (len == 1)
        {
            Console.WriteLine(single_digits[num[0] - '0']);
            return;
        }
        int x = 0;
        while (x < num.Length)
        {
            if (len >= 3)
            {
                if (num[x] - '0' != 0)
                {
                    Console.Write(single_digits[num[x] - '0'] + " ");
                    Console.Write(tens_power[len - 3] + " ");
                }
                --len;
            }
            else
            {
                if (num[x] - '0' == 1)
                {
                    int sum = num[x] - '0' + num[x + 1] - '0';
                    Console.WriteLine(two_digits[sum]);
                    return;
                }
                else if (num[x] - '0' == 2
                        && num[x + 1] - '0' == 0)
                {
                    Console.WriteLine("twenty");
                    return;
                }
                else
                {
                    int i = (num[x] - '0');
                    if (i > 0)
                        Console.Write(tens_multiple[i] + " ");
                    else
                        Console.Write("");
                    ++x;
                    if (num[x] - '0' != 0)
                        Console.WriteLine(single_digits[num[x] - '0']);
                }
            }
            ++x;
        }
    }
    public static void Main()
    {
        string n;
        Console.Write("Enter no : ");
        n = Console.ReadLine();
        convert_to_words(n.ToCharArray());
    }
}*/
//tt1-15
/*using System;
class tt1_15
{
    public static void Main(string[] args)
    {
        int n, r, sum = 0, temp;
        Console.Write("Enter the number : ");
        n = Convert.ToInt32(Console.ReadLine());
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = sum + (r * r * r);
            n = n / 10;
        }
        if (temp == sum)
            Console.Write("Armstrong Number.");
        else
            Console.Write("Not Armstrong Number.");
    }
}*/
//Array-defination
/*using System;
class Array_def
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 30;

        Console.Write("The array elements are : ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadLine();
    }
}*/
//Call By Value
/*using System;
class Program
{
    static void Change(int a, int b)
    {
        a = 100;
        b = 200;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter no 1 : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter no 2 : ");
        int y = Convert.ToInt32(Console.ReadLine());
        Change(x, y);
        Console.WriteLine("After Swap value of a is {0} and b is {1}", x, y);
    }
}*/
//Call by Refrence
/*using System;
class Program
{
    static void Change(ref int a, ref int b)
    {
        a = 100;
        b = 200;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter no 1 : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter no 2 : ");
        int y = Convert.ToInt32(Console.ReadLine());
        Change(ref x, ref y);
        Console.WriteLine("After Swap value of a is {0} and b is {1}", x, y);
    }
}*/
//Command Line Arguments
/*using System;
class command_arg
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\tHello, World!");
        Console.WriteLine("\tYou entered the following {0} command line arguments:", args.Length);
        foreach (Object obj in args)
        {
            Console.WriteLine("\t" + obj);
        }
        Console.ReadLine();
    }
}*/
//Class and Objects
/*using System;
class A1
{
    private int x;
    public int X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
}

class program
{
    public static void Main()
    {
        A1 obj1 = new A1();
        Console.Write("Enter any number : ");
        obj1.X = Convert.ToInt32(Console.ReadLine());
        Console.Write("You have entered : " + obj1.X);
    }
}*/
//Inheritance
/*using System;
class A1
{
    public string name;
    public int age;
    public void get_info(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class B1 : A1
{
    public void display_info()
    {
        Console.Write("Your name is : {0}", name);
        Console.Write("\nYour age is : {0}", age);
    }
}

class program
{
    public static void Main(string[] args)
    {
        B1 obj1 = new B1();
        Console.Write("Enter your name : ");
        string s = Console.ReadLine();
        Console.Write("Enter your name : ");
        int a = Convert.ToInt32(Console.ReadLine());
        obj1.get_info(s, a);
        obj1.display_info();
    }
}*/
//Method Overriding
/*using System;
class A1
{
    public void show()
    {
        Console.WriteLine("A1 class");
    }
}
class B1 : A1
{
    new public void show()
    {
        Console.WriteLine("B1 class");
    }
}

class program
{
    public static void Main()
    {
        B1 obj = new B1();
        obj.show();
        obj = new A1();
        obj.show();
    }
}*/
//Method Overloading
/*using System;
class A1
{
    public void Area(int l, int b)
    {
        int area = l * b;
        Console.Write("The area of Reactangle is : {0}", area);
    }
}

class B1 : A1
{
    public void Area(float r)
    {
        double pie = 3.14;
        Console.Write("\nThe area of circle is : {0}", (pie * r * r));
    }
}

class program
{
    public static void Main(string[] args)
    {
        B1 obj1 = new B1();
        obj1.Area(5, 6);
        obj1.Area(4);
    }
}*/
//Get and Set
/*class A1
{
    private int x;
    public int X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
}

class program
{
    public static void Main()
    {
        A1 obj1 = new A1();
        Console.Write("Enter any number : ");
        obj1.X = Convert.ToInt32(Console.ReadLine());
        Console.Write("You have entered : " + obj1.X);
    }
}*/
//Base and Sealed
/*using System;
sealed class SealedClass
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SealedClass slc = new SealedClass();
        int total = slc.Add(6, 4);
        Console.WriteLine("Total : " + total.ToString());
    }
}*/

//Static and This
/*using System;
class A1
{
    public string name;
    public int age;
    public void get_info(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class B1 : A1
{
    public void display_info()
    {
        Console.Write("Your name is : {0}", name);
        Console.Write("\nYour age is : {0}", age);
    }
}

class program
{
    public static void Main(string[] args)
    {
        B1 obj1 = new B1();
        Console.Write("Enter your name : ");
        string s = Console.ReadLine();
        Console.Write("Enter your name : ");
        int a = Convert.ToInt32(Console.ReadLine());
        obj1.get_info(s, a);
        obj1.display_info();
    }
}*/

//tt3-1
/*using System;
class A1
{
    public void get_data()
    {
        Console.Write("Enter Length : ");
        int l = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter breadth : ");
        int b = Convert.ToInt32(Console.ReadLine());
        int area = l * b;
        Console.Write("Area of Rectangle : {0}", area);
    }
}

class program
{
    public static void Main(string[] args)
    {
        A1 obj1 = new A1();
        obj1.get_data();
    }
}*/

//tt3-2
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tt3_2
{
    class Clock
    {
        private int hour, min, sec;
        public Clock()
        {
            this.hour = 22;
            this.min = 55;
            this.sec = 58;
        }
        public Clock(int h, int m, int s)
        {
            this.hour = h;
            this.min = m;
            this.sec = s;
        }
        public void inc()
        {
            sec++;
            Console.WriteLine("New time is : " + hour + ":" + min + ":" + sec);
        }
        public void display()
        {
            Console.WriteLine("Time is : " + hour + ":" + min + ":" + sec);
        }
        public int gethour()
        {
            return hour;
        }
        public int getmin()
        {
            return min;
        }
        public int getsec()
        {
            return sec;
        }
    }

    class program
    {
        public static void Main(string[] args)
        {
            Clock obj1 = new Clock(11, 10, 01);
            obj1.display();
            obj1.inc();
        }

    }
}*/

//tt3-3
/*using System;
class Student
{
    public int rollNumber;
    public string? name;
}

class Test
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.rollNumber = 1;
        s.name = "Andrew";
        Console.WriteLine("\nRoll no : {0}",s.rollNumber);
        Console.WriteLine("Name : {0}",s.name);
        Console.ReadLine();
    }
}*/

//tt3-4
/*using System;
class Student
{
    public int rollNumber;
    public string? name;
}

class Test
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.rollNumber = 1;
        s.name = "Andrew";
        Console.WriteLine("\nRoll no : {0}", s.rollNumber);
        Console.WriteLine("Name : {0}", s.name);
        Student s1 = new Student();
        s1.rollNumber = 2;
        s1.name = "John";
        Console.WriteLine("Roll no : {0}", s1.rollNumber);
        Console.WriteLine("Name : {0}", s1.name);
        Student s2 = new Student();
        s2.rollNumber = 3;
        s2.name = "Dove";
        Console.WriteLine("Roll no : {0}", s2.rollNumber);
        Console.WriteLine("Name : {0}", s2.name);
        Student s4 = new Student();
        s4.rollNumber = 4;
        s4.name = "Chris";
        Console.WriteLine("Roll no : {0}", s4.rollNumber);
        Console.WriteLine("Name : {0}", s4.name);
        Student s5 = new Student();
        s5.rollNumber = 5;
        s5.name = "Tom";
        Console.WriteLine("Roll no : {0}", s5.rollNumber);
        Console.WriteLine("Name : {0}", s5.name);
        Console.ReadLine();
    }
}*/

//tt3-5
/*using System;
namespace tt3_5
{
    class Product
    {
        String pname, mname;
        int pcode;
        public Product(int pcd, String pnm, String mnm)
        {
            mname = mnm;
            pcode = pcd;
            pname = pnm;
        }

        public void Display()
        {
            Console.Write("\nProduct Code:= " + pcode);
            Console.Write("\nProduct Name:= " + pname);
            Console.Write("\nManufacturer Name:= " + mname);
        }
    }
    public class TestProduct
    {
        public static void Main(string[] args)
        {
            int n = args.Length;
            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
            }
            else
            {
                int pcd = Convert.ToInt32(args[0]);
                String pnm = args[1];
                String mnm = args[2];
                Product p = new Product(pcd, pnm, mnm);
                p.Display();
                Console.ReadLine();
            }
        }
    }
}*/

//tt3-6
/*using System;
namespace LineApplication
{
    class Line
    {
        private double length;   // Length of a line
        public Line()
        {
            Console.Write("\nObject is being created, Length : ");
            length = Convert.ToDouble(Console.ReadLine());
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
    class TestLine
    {
        static void Main(string[] args)
        {

            Line line = new Line();
            Console.WriteLine("Length of line : {0}", line.getLength());
            line.setLength(6);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadLine();
        }
    }
}*/

//tt3-7
/*class student
{
    String? name, enrol;
    public student()
    {
        Console.Write("\nEnter Name : ");
        name = Console.ReadLine();
        Console.Write("Enter Enrollment : ");
        enrol = Console.ReadLine();
    }
    public void Display()
    {
        Console.Write("Your Name is : {0}", name);
        Console.WriteLine("\nYour Enrollment is : {0}", enrol);
    }
}
class program
{
    public static void Main(string[] args)
    {
        student obj1 = new student();
        obj1.Display();
        Console.ReadLine();
    }
}*/

//pt-15-7
//method over-riding
/*class Shape
{
    private double height, width;
    public Shape(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    public double Height
    {
        get { return height; }
        set { height = value; }
    }
    public double Width
    {
        get { return width; }
        set { width = value; }
    }
    public virtual double getArea()
    {
        return 0;
    }
}

class Reactangle : Shape
{
    public Reactangle(double height, double width) : base(height, width)
    { }

    public override double getArea()
    {
        return Height * Width;
    }
}
class Triangle : Shape
{
    public Triangle(double height, double width) : base(height, width)
    { }

    public override double getArea()
    {
        return (Height * Width) / 2;
    }
}

class program
{
    public static void Main(string[] args)
    {
        Reactangle obj1 = new Reactangle(78, 5);
        Console.Write("Area of Reactangle : " + obj1.getArea());
        Triangle obj2 = new Triangle(34, 3);
        Console.Write("\nArea of Triangle : " + obj2.getArea());
        Console.ReadLine();
    }
}*/

//new program
/*class A1
{
    public void Method1()
    {
        Console.Write("\nMethod 1");
    }
    public void Method2()
    {
        Console.Write("\nMethod 2");
    }
}
class B1 : A1
{
    public void Method2()
    {
        Console.Write("\nDerived Method 2");
    }
}
class program
{
    public static void Main(string[] args)
    {
        A1 obj1 = new A1();
        B1 obj2 = new B1();
        A1 obj3 = new B1();
        obj1.Method1();
        obj1.Method2();
        obj2.Method1();
        obj2.Method2();
        obj3.Method1();
        obj3.Method2();
    }
}*/

/*class A1
{
    public virtual void Method1()
    {
        Console.WriteLine("Method 1");
    }
    public void Method2()
    {
        Console.WriteLine("Method 2");
    }
}
class B1 : A1
{
    public override void Method1()
    {
        Console.WriteLine("Derived Method 1");
    }
    public new void Method2()
    {
        Console.WriteLine("Derived Method 2");
    }
}
class program
{
    public static void Main(string[] args)
    {
        A1 obj1 = new A1();
        B1 obj2 = new B1();
        A1 obj3 = new B1();
        obj1.Method1();
        obj1.Method2();
        obj2.Method1();
        obj2.Method2();
        obj3.Method1();
        obj3.Method2();
    }
}*/

//tt4-1
/*using System;
class program
{
    static int computeSalary(int basic, char grade)
    {
        double allowance;
        double hra, da, pf;

        hra = 0.2 * basic;
        da = 0.5 * basic;
        pf = 0.11 * basic;

        if (grade == 'A')
        {
            allowance = 1700.0;
        }
        else if (grade == 'B')
        {
            allowance = 1500.0;
        }
        else
        {
            allowance = 1300.0;
        }
        double gross;
        Console.WriteLine("HRA : {0}", hra);
        Console.WriteLine("DA : {0}", da);
        gross = Math.Round(basic + hra + da + allowance - pf);
        return (int)gross;
    }
    public static void Main(String[] args)
    {
        int basic = 10000;
        char grade = 'A';
        Console.WriteLine("\nEmployee 1 : ");
        Console.WriteLine("Total Pay : {0}", computeSalary(basic, grade));
        basic = 2000;
        grade = 'B';
        Console.WriteLine("\nEmployee 2 : ");
        Console.WriteLine("Total Pay : {0}", computeSalary(basic, grade));
        basic = 6000;
        grade = 'A';
        Console.WriteLine("\nEmployee 3 : ");
        Console.WriteLine("Total Pay : {0}", computeSalary(basic, grade));
        Console.ReadLine();
    }
}*/

//tt4-2
/*using System;
class Shape
{
    public double Width, Height;
    public void ShowDim()
    {
        Console.WriteLine("Width and height are " + Width + " and " + Height);
    }
}
class Triangle : Shape
{
    public string? Style;
    public double Area()
    {
        return Width * Height / 2;
    }
    public void ShowStyle()
    {
        Console.WriteLine(Style);
    }
}
class Driver
{
    public static void Main(string[] args)
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle();
        t1.Width = 4.0;
        t1.Height = 4.0;
        t1.Style = "isosceles";
        t2.Width = 8.0;
        t2.Height = 12.0;
        t2.Style = "right";
        Console.WriteLine("Info for t1 : ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Area is " + t1.Area());
        Console.WriteLine();
        Console.WriteLine("Info for t2 : ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Area is " + t2.Area());
    }
}*/

//tt4-3
/*class A1
{
    public Double width, height;
    public void get_data(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
}
class B1 : A1
{
    public void area()
    {
        Console.WriteLine("Area of Rectangle is : {0}", (width * height));
    }
}
class program
{
    public static void Main(string[] args)
    {
        B1 obj1 = new B1();
        Console.Write("\nEnter width : ");
        obj1.width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height : ");
        obj1.height = Convert.ToDouble(Console.ReadLine());
        obj1.area();
        Console.ReadLine();
    }
}*/

//tt4-4
/*using System;
namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public void counting()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    class StaticTester
    {
        public static void Main(string[] args)
        {
            StaticVar s = new StaticVar();
            s.counting();
            s.counting();
            s.counting();
            Console.WriteLine("\nVariable num : {0}", s.getNum());
            Console.ReadLine();
        }
    }
}*/

//tt4-5
/*using System;
class A
{
    public A(int value)
    {
        Console.WriteLine("Base constructor A()");
    }
}
class B : A
{
    public B(int value) : base(value)
    {
        Console.WriteLine("Derived constructor B()");
    }
}
class Program
{
    public static void Main()
    {
        A a = new A(0);
        B b = new B(1);
    }
}*/

//tt4-6
/*using System;
abstract class Test
{
    public int a;
    public abstract void A();
}

class Example1 : Test
{
    public override void A()
    {
        Console.WriteLine("Example1.A");
        base.a++;
    }
}

class Example2 : Test
{
    public override void A()
    {
        Console.WriteLine("Example2.A");
        base.a--;
    }
}

class Program
{
    static void Main()
    {
        Test test1 = new Example1();
        test1.A();
        Test test2 = new Example2();
        test2.A();
    }
}*/

//tt4-7
/*sealed class A
{
    public int x, y;

}
class program
{
    public static void Main()
    {
        A sc = new A();
        sc.x = 110;
        sc.y = 150;
        Console.WriteLine("\nx = {0}, y = {1}", sc.x, sc.y);
        Console.ReadLine();
    }
}*/

//tt4-8
/*using System;
class X
{
    public virtual void F() { Console.WriteLine("X.F"); }
    public virtual void F2() { Console.WriteLine("X.F2"); }
}

class Y : X
{
    public sealed override void F() { Console.WriteLine("Y.F"); }
    public override void F2() { Console.WriteLine("Y.F2"); }
}

class Z : Y
{
    //public override void F() { Console.WriteLine("Z.F"); }
    public override void F2() { Console.WriteLine("Z.F2"); }
}

class program
{
    public static void Main()
    {
        X Obj1 = new X();
        Obj1.F();
        Obj1.F2();
        Y Obj2 = new Y();
        Obj2.F();
        Obj2.F2();
        Z Obj3 = new Z();
        Obj3.F();
        Obj3.F2();
    }
}*/

//tt4-9
/*using System;
class program
{
    public static void Main()
    {
        int x = 0;
        int div = 0;
        try
        {
            div = 100 / x;
            Console.WriteLine("This line will be not executed.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Exception occured.");
        }
        Console.WriteLine($"Result is {div}");
    }
}*/

//tt4-10
/*using System;
class MyException : Exception
{
    public MyException(string str)
    {
        Console.WriteLine("User defined exception");
    }
}
class MyClient
{
    public static void Main()
    {
        try
        {
            throw new MyException("AB");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught here " + e.ToString());
        }
        Console.WriteLine("LAST STATEMENT");
    }
}*/

//pt-22-7
/*using System;
sealed class A1
{
    public string name = "ABC";
    public string location = "ABC";
    public void GetInfo()
    {
        Console.Write("Name : " + name);
        Console.Write("Name : " + location);
    }
}
class B : A
{
    public int age = 32;
    public void GetAge()
    {
        Console.Write("Age : {0}", age);
    }
}
class program
{
    public static void Main(string[] args)
    {
        B obj1 = new B();
        obj1.GetAge();
    }
}
*/

//Interface
/*using System;
interface Imath
{
    int add(int x, int y);
    int sub(int x, int y);
}
class A : Imath
{
    public int add(int x, int y)
    {
        return x + y;
    }
    public int sub(int x, int y)
    {
        return x - y;
    }
}
class program
{
    public static void Main(string[] args)
    {
        A obj1 = new A();
        Console.Write("Enter value of a : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of b : ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = obj1.add(a, b);
        int sub = obj1.sub(a, b);
        Console.Write("Addition of {0} and {1} is : {2}", a, b, sum);
        Console.WriteLine("\nSubstraction of {0} and {1} is : {2}", a, b, sub);
        Console.ReadLine();
    }
}*/

//Interface 2
/*using System;
interface Imath
{
    int add(int x, int y);
    int sub(int x, int y);
}
interface Imath2
{
    int mul(int x, int y);
}
class A : Imath, Imath2
{
    public int add(int x, int y)
    {
        return x + y;
    }
    public int sub(int x, int y)
    {
        return x - y;
    }
    public int mul(int x, int y)
    {
        return x * y;
    }
}
class program
{
    public static void Main(string[] args)
    {
        Imath obj1 = new A();
        Console.Write("Enter value of a : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of b : ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = obj1.add(a, b);
        int sub = obj1.sub(a, b);
        Console.Write("Addition of {0} and {1} is : {2}", a, b, sum);
        Console.WriteLine("\nSubstraction of {0} and {1} is : {2}", a, b, sub);
        Imath2 obj2 = new A();
        sum = obj1.add(a, b);
        int mul = obj2.mul(a, b);
        Console.Write("Multiplication of {0} and {1} is : {2}", a, b, mul);
        Console.WriteLine("\nAddition of {0} and {1} is : {2}", a, b, sum);
        Console.ReadLine();
    }
}*/

//Class Activity
/*class A
{
    public int sum(int a, int b)
    {
        return a + b;
    }
    public virtual int sub(int a, int b)
    {
        return a - b;
    }
}
class B : A
{
    public override int sub(int a, int b)
    {
        return a - b;
    }
    public int mul(int a, int b)
    {
        return a * b;
    }
}
class program
{
    public static void Main(string[] args)
    {
        B obj2 = new B();
        Console.WriteLine(obj2.sum(10, 20));
        Console.WriteLine(obj2.sub(10, 20));
        Console.WriteLine(obj2.mul(10, 20));
        A obj1 = new B();
        Console.WriteLine(obj1.sum(10, 20));
        Console.WriteLine(obj1.sub(10, 20));
        Console.WriteLine(obj1.mul(10, 20));
    }
}*/

//dtc#-1
/*using System;
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
    class TestRef
    {
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            int b = 200;
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
            n.swap(ref a, ref b);
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}*/

//dtc#-2
/*using System;
namespace ConsoleApplication1
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");
        }
    }
}*/

//dtc#-3
/*using System;
class MyClient
{
    public static void Main()
    {
        try
        {
            int x = 0;
            int div = 100 / x;
            Console.WriteLine("This line will be not executed.");
            Console.WriteLine(div);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Divide By Zero Exception occured.");
        }
    }
}*/

//dtc#-4
/*using System;
namespace MockTest
{
    class Employee
    {
        int ID;
        string? Name;
        string? Email;
        string? Country;
        public void SetData()
        {
            Console.Write("Enter Id : ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Email : ");
            Email = Console.ReadLine();
            Console.Write("Enter Country : ");
            Country = Console.ReadLine();
        }

        public void Display()
        {
            Console.Write("Id : {0}", ID);
            Console.Write("\nName : " + Name);
            Console.Write("\nEmail : " + Email);
            Console.Write("\nCountry : " + Country);
        }
    }
    class EmployeeDemo
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            e.SetData();
            e.Display();
            Console.ReadLine();
        }
    }
}*/

//dtc#-5
/*using System;
public class Hello3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("You entered the following {0} command line arguments:", args.Length);
        foreach (Object obj in args)
        {
            Console.WriteLine(obj);
        }
        Console.ReadLine();
    }
}*/

//dtc#-6
/*using System;
namespace TSEE_Mock
{
    class ArrayTest
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0} : ", i);
                string? str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.Read();
        }
    }
}*/

int a = 1;
int b = 2;
System.Console.WriteLine("Before : "+a+", "+b);
Swap<int>(ref a, ref b);
System.Console.WriteLine("After : " + a + ", " + b);

double a1 = 10.02;
double b1 = 20.04;
System.Console.WriteLine("Before : "+a1+", "+b1);
Swap<double>(ref a1, ref b1);
System.Console.WriteLine("After : "+a1+", "+b1);

class main
{
    static T Add<T>(ref T lhs, ref T rhs)
    {
        dynamic a = lhs;
        dynamic b = rhs;
        return a + b;
    }
    static T Sub<T>(ref T lhs, ref T rhs)
    {
        dynamic a = lhs;
        dynamic b = rhs;
        return a - b;
    }
    static T Mul<T>(ref T lhs, ref T rhs)
    {
        dynamic a = lhs;
        dynamic b = rhs;
        return a * b;
    }
    static T Div<T>(ref T lhs, ref T rhs)
    {
        dynamic a = lhs;
        dynamic b = rhs;
        return a / b;
    }
    public static void Main(string[] args)
    {
        int a = 2;
        int b = 1;
        Console.WriteLine("Sum = {0}", Add<int>(ref a, ref b));
        float a1 = 20;
        float b1 = 10;
        Console.WriteLine("Sub = {0}", Sub<float>(ref a1, ref b1));
        double a2 = 20.62;
        double b2 = 10.31;
        Console.WriteLine("Mul = {0}", Mul<double>(ref a2, ref b2));
        double a3 = 40.42;
        double b3 = 20.21;
        Console.WriteLine("Div = {0}", Div<double>(ref a3, ref b3));
    }
}class main
{
    static T Add<T>(ref T lhs, ref T rhs)
    {
        dynamic a = lhs;
        dynamic b = rhs;
        return a + b;
    }
    static T Sub<T>(ref T lhs, ref T rhs)
    {
        dynamic a = lhs;
        dynamic b = rhs;
        return a - b;
    }
    static T Mul<T>(ref T lhs, ref T rhs)
    {
        dynamic a = lhs;
        dynamic b = rhs;
        return a * b;
    }
    static T Div<T>(ref T lhs, ref T rhs)
    {
        dynamic a = lhs;
        dynamic b = rhs;
        return a / b;
    }
    public static void Main(string[] args)
    {
        int a = 2;
        int b = 1;
        Console.WriteLine("Sum = {0}", Add<int>(ref a, ref b));
        float a1 = 20;
        float b1 = 10;
        Console.WriteLine("Sub = {0}", Sub<float>(ref a1, ref b1));
        double a2 = 20.62;
        double b2 = 10.31;
        Console.WriteLine("Mul = {0}", Mul<double>(ref a2, ref b2));
        double a3 = 40.42;
        double b3 = 20.21;
        Console.WriteLine("Div = {0}", Div<double>(ref a3, ref b3));
    }
}

//02-09-22
using System;
using System.Collections;
class main
{
    public static void Main(string[] args)
    {
        //create
        ArrayList obj = new ArrayList();
        //add
        obj.Add("A");
        obj.Add(110);
        obj.Add(152.85);
        obj.Add('x');
        obj.Add(true);
        //show count
        Console.WriteLine("No of Elements : "+obj.Count);
        Console.WriteLine("Before deletion : ");
        foreach (object str in obj)
            Console.WriteLine(str);
        //remove A
        obj.Remove("A");
        Console.WriteLine("After Deletion : ");
        foreach (object str in obj)
            Console.WriteLine(str);
        Console.ReadKey();
    }
}

using System;
using System.Collections;
class main
{
    public static void Main(string[] args)
    {
        //create
        ArrayList obj = new ArrayList();
        //add
        obj.Add("A");
        obj.Add(110);
        obj.Add(152.85);
        obj.Add('x');
        obj.Add(true);
        //show count
        Console.WriteLine("\nNo of Elements : "+obj.Count);
        Console.WriteLine("\nBefore deletion : ");
        foreach (object str in obj)
            Console.WriteLine(str);
        //remove A
        obj.Remove("A");
        Console.WriteLine("\nAfter Deletion : ");
        foreach (object str in obj)
            Console.WriteLine(str);

        Console.WriteLine("\nAfter Operations : ");
        int[] intArray2 = {1,2,3,4,5};
        obj.AddRange(intArray2);
        obj.RemoveRange(1, 2);
        obj.Insert(1, 3);
        obj.InsertRange(0, intArray2);
        foreach (object str in obj)
            Console.Write(str + " ");
        Console.WriteLine(" ");
        //Console.ReadKey();
    }
}

using System;
using System.Collections;
class main
{
    public static void Main(string[] args)
    {
        Queue Q = new Queue();
        Q.Enqueue(18);
        Q.Enqueue(73);
        Q.Enqueue(35);
        Q.Enqueue(50);
        Console.WriteLine("\nBefore Deletion : ");
        foreach (int i in Q)
            Console.WriteLine(i);
        Q.Dequeue();
        Console.WriteLine("\nAfter Deletion : ");
        Console.WriteLine("\nNow top element is : " + Q.Peek());
    }
}

using System;
using System.Collections;
class main
{
    public static void Main(string[] args)
    {
        Stack Q = new Stack();
        Q.Push(18);
        Q.Push(73);
        Q.Push(35);
        Q.Push(50);
        Console.WriteLine("\nBefore Deletion : ");
        foreach (int i in Q)
            Console.WriteLine(i);
        Q.Pop();
        Console.WriteLine("\nAfter Deletion : ");
        Console.WriteLine("\nNow top element is : " + Q.Peek());
    }
}

using System;
using System.Collections;
class main
{
    public static void Main(string[] args)
    {
        Hashtable Ht = new Hashtable();
        Ht.Add("R", "Rajkot");
        Ht.Add("M", "Mumbai");
        Ht.Add("D", "Delhi");

        ICollection c = Ht.Keys;
        foreach (string key in c)
            Console.WriteLine(key + " " + Ht[key]);

    }
}