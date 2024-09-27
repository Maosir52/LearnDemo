using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpP18
{
    #region 传值参数(参数更新为新值,变量为原来值)
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student stu = new Student() { Name = "Tim" };
    //        SomeMethod(stu);
    //        Console.WriteLine("{0}","{1}",stu.GetHashCode(),stu.Name);
    //    }

    //    static void SomeMethod(Student stu)
    //    {
    //        stu = new Student() { Name = "Tim" };
    //        Console.WriteLine("{0}","{1}",stu.GetHashCode(),stu.Name);
    //    }
    //}

    //class Student
    //{
    //    private string name;

    //    public string Name { get => name; set => name = value; }
    //} 
    #endregion

    #region 传值参数(只操作对象，变量和参数不变)
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student stu = new Student() { Name = "Tim" };
    //        UpdateObject(stu);
    //        Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(), stu.Name);
    //    }

    //    static void UpdateObject(Student stu)
    //    {
    //        stu.Name = "Tom";
    //        Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(), stu.Name);
    //    }
    //}

    //class Student
    //{
    //    private string name;

    //    public string Name { get => name; set => name = value; }
    //} 
    #endregion

    #region 引用参数(变量，参数均改变)
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        int y = 1;
    //        IWantSideEffect(ref y);
    //        Console.WriteLine(y);
    //    }

    //    static void IWantSideEffect(ref int x)
    //    {
    //        x = x + 100;
    //    }
    //}
    #endregion

    #region 引用参数，创建了新对象
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student outterStu = new Student() { Name = "Tim" };
    //        Console.WriteLine("HashCode={0},Name={1}",outterStu.GetHashCode(),outterStu.Name);
    //        Console.WriteLine("---------------------------------------");
    //        IWantSideEffect(ref outterStu);
    //        Console.WriteLine("HashCode={0},Name={1}", outterStu.GetHashCode(), outterStu.Name);
    //    }

    //    static void IWantSideEffect(ref Student stu)
    //    {
    //        stu = new Student() { Name = "Tom" };
    //        Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(), stu.Name);
    //    }
    //}

    //class Student
    //{
    //    private string name;

    //    public string Name { get => name; set => name = value; }
    //}
    #endregion

    #region 引用参数(不创建新对象只改变对象值)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student outterStu = new Student() { Name = "Tim" };
    //        Console.WriteLine("hashcode={0},name={1}", outterStu.GetHashCode(), outterStu.Name);
    //        Console.WriteLine("-------------------------");
    //        SomeSideEffect(ref outterStu);
    //        Console.WriteLine("HashCode={0},Name={1}", outterStu.GetHashCode(), outterStu.Name);
    //    }

    //    static void SomeSideEffect(ref Student stu)
    //    {
    //        stu.Name = "Tom";
    //        Console.WriteLine("HashCode={0},Name={1}", stu.GetHashCode(), stu.Name);
    //    }
    //}

    //class Student
    //{
    //    private string name;

    //    public string Name { get => name; set => name = value; }
    //}
    #endregion

    #region 输出参数(赋值后变量，参数均更改) *示例
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Please input first number:");
    //        string arg1 = Console.ReadLine();
    //        double x = 0;
    //        bool b1 = double.TryParse(arg1, out x);
    //        if (b1==false)
    //        {
    //            Console.WriteLine("Input error!");
    //            return;
    //        }

    //        Console.WriteLine("Please input second number:");
    //        string arg2 = Console.ReadLine();
    //        double y = 0;
    //        bool b2 = double.TryParse(arg2, out y);
    //        if (b2 == false)
    //        {
    //            Console.WriteLine("Input error!");
    //            return;
    //        }

    //        double z = x + y;
    //        Console.WriteLine("{0} + {1} = {2}",x,y,x+y);
    //    }
    //}
    #endregion

    #region 输出参数(赋值后变量，参数均更改) *调用
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double x = 0;
    //        bool b = DoubleParser.TryParse("789", out x);
    //        if (b == true)
    //        {
    //            Console.WriteLine(x+1);
    //        }
    //        else
    //        {
    //            Console.WriteLine(x);
    //        }
    //    }
    //}

    //class DoubleParser
    //{
    //    public static bool TryParse(string input,out double result)
    //    {
    //        try
    //        {
    //            result = double.Parse(input);
    //            return true;
    //        }
    //        catch
    //        {
    //            result = 0;
    //            return false;
    //        }
    //    }
    //}
    #endregion

    #region 输出参数->引用类型(变量，参数，对象均更改)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student stu = null;
    //        bool b = StudentFactory.Create("Tim", 34, out stu);
    //        if (b == true)
    //        {
    //            Console.WriteLine("Student {0},age is {1}",stu.Name,stu.Age);
    //        }
    //    }
    //}

    //class Student
    //{
    //    public int Age { get; set; }

    //    public string Name { get; set; }
    //}

    //class StudentFactory
    //{
    //    public static bool Create(string stuName,int stuAge,out Student result)
    //    {
    //        result = null;
    //        if (string.IsNullOrEmpty(stuName))
    //        {
    //            return false;
    //        }

    //        if (stuAge < 20 || stuAge > 80)
    //        {
    //            return false;
    //        }

    //        result = new Student() { Name = stuName, Age = stuAge };
    //        return true;
    //    }
    //}
    #endregion

    #region 数组参数
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int result = CalculateSum(1, 2, 3);
    //        Console.WriteLine(result);
    //        //string str = "Tim;Tom;Amy;Lisa";
    //        //string[] result = str.Split(';', '.', ',');
    //        //foreach (var name in result)
    //        //{
    //        //    Console.WriteLine(name);
    //        //}
    //    }

    //    static int CalculateSum(params int[] intArray)
    //    {
    //        int sum = 0;
    //        foreach(var item in intArray)
    //        {
    //            sum += item;
    //        }
    //        return sum;
    //    }
    //}
    //必须是形参列表中的最后一个,由params修饰
    //eg.String.Format方法和String.Split方法
    #endregion

    #region 具名参数
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PrintInfo(name:"Time",age:34);  //具名参数在此处控制台输出不受name,age的顺序影响
    //    }

    //    static void PrintInfo(string name, int age)
    //    {
    //        Console.WriteLine("Hello {0} , you are {1}",name,age);
    //    }
    //}
    #endregion

    #region 可选参数
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PrintInfo();    //因为PrintInfo中已经声明过Tim,34了，此处的默认值已被更改
    //    }

    //    static void PrintInfo(string name = "Tim", int age = 34)
    //    {
    //        Console.WriteLine("Hello {0} , you are {1}", name, age);
    //    }
    //}
    #endregion

    #region 拓展方法
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double x = 3.14159;
    //        double y = x.Round(4);
    //        Console.WriteLine(y);
    //    }

    //}
    //static class DoubleExtension
    //{
    //    public static double Round(this double input, int digits)
    //    {
    //        double result = Math.Round(input, digits);
    //        return result;
    //    }
    //}
    #endregion

    #region Linq拓展方法
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<int> myList = new List<int>() { 11, 12, 13, 14, 15 };
    //        //bool result = AllGreaterThanTen(myList);  //源代码行
    //        bool result = myList.All(i => i > 10);
    //        Console.WriteLine(result);
    //    }

    //    static bool AllGreaterThanTen(List<int> intList)
    //    {
    //        foreach (var item in intList)
    //        {
    //            if (item<=10)
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }
    //}
    #endregion

    #region 总结
    //传值参数:参数的默认传递方式
    //输出参数:用于除返回值外还需要输出的场景
    //引用参数:用于需要修改实际参数值的场景
    //数组参数:用于简化方法的调用
    //具名参数:提高可读性
    //可选参数:参数拥有默认值
    //拓展方法(this参数):为目标数据类型"追加"方法
    #endregion
}
