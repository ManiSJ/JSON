using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Cirrcle
    {
        public int Radi { get; set; }
        public int Diamr { get; set; }
        partial void Arrea();      
    }

    public partial class Cirrcle
    {
        partial void Arrea()
        {
            Sum(this.Radi,this.Diamr);
        }

        public int Sum(int x,int y)
        {
            return x + y;
        }
    }

    public class Grid
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public static string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Mobile { get; set; }
        public Grid()
        {
            Grid.LastName = "SJ";
        }
        public Grid(string first, string middle)
        {
            this.FirstName = first;
            this.MiddleName = middle;
        }
    }

    public static class staticGridd 
    {
        public static string Designation { get; set; }
        public static int Addsum()
        {
            return 2;
        }
        
    }

    public class Gridd : Grid
    {
        public string Designation { get; set; }
    }

    public abstract class Gridone : Gridd
    {
        public int EmpId { get; set; }
        public abstract int Addnum();
        public abstract int Mobileabst { get; set; }
        public int Sub(int x, int y)
        {
            int z = Math.Abs(x - y);
            return z;
        }
    }

    public class Gridtwo : Gridone
    {
        public string EmpNameab { get; set; }
        public override int Mobileabst { get; set; }
        public override int Addnum()
        {
            return 2;
        }
    }

    public interface IEmployee
    {
        int Addnum();
        int Sub(int x, int y);
    }


    public interface IMat
    { 
        int Mulnum();
        int Div(int x, int y);
    }

    public class Inherclass : IEmployee,IMat
    {
        public int Addnum()
        {
            return 2;
        }

        public int Sub(int x, int y)
        {
            int z = Math.Abs(x - y);
            return z;
        }

        public int Mulnum()
        {
            return 2;
        }

        public int Div(int x, int y)
        {
            int z = (x / y);
            return z;
        }
    }

    public class parentclass
    {
        public virtual string FirstName()
        {
            return "Mani--Parent";
        }

        public virtual string LastName()
        {
            return "SJ--Parent";
        }

        public string Native()
        {
            return "Vellore--Parent";
        }
    }

    public class childclass :parentclass
    {
        public override string FirstName()
        {
            return "Mani--Child";
        }

        public new string LastName()
        {
            return "SJ--Child";
        }

        public string Native()
        {
            return "Vellore--Child";
        }

        public string School()
        {
            return "Vvnkm--Child";
        }
    }

    public class Program
    {

        public delegate int degname(int x);

        public static int fnname(int y)
        {
            return y;
        }

        public static void Main(string[] args)
        {
            parentclass m = new parentclass(); //All methods of particular class called
            Console.WriteLine(m.FirstName());  //Mani--Parent
            Console.WriteLine(m.LastName());  //SJ--Parent
            Console.WriteLine(m.Native());    //Vellore--Parent

            Console.WriteLine("--------");

            parentclass p = new childclass();
            // Polymorphism: Using base class ref var to call child class methods
            Console.WriteLine(p.FirstName());//Mani--Child (Since overwritten in child using override keyword and parent has virtual keyword)
            Console.WriteLine(p.LastName());//SJ--Parent (Since hiding in child using new keyword and parent has virtual keyword)
            Console.WriteLine(p.Native());     //Vellore--Parent (but here parent class Native called since p is of type Parentclass)

            Console.WriteLine("--------");

            childclass n = new childclass();   //All methods of particular class called
            Console.WriteLine(n.FirstName()); //Mani--Child
            Console.WriteLine(n.LastName());  //SJ--Child
            Console.WriteLine(n.Native());    //Vellore--Child
            Console.WriteLine(n.School());    //Vvnkm--Child

            Console.WriteLine("--------");

             int[] a = new int[2];
             a[0] = 10;
             a[1] = 20;

             int[] b = new int[2] { 10, 11 };
             int[] c = new int[2] { 10, 11 };

             for (int i = 0; i < a.Length; i++)
             {
                 Console.WriteLine(a[i]);
             }
             Console.WriteLine("-----------");

             foreach (int i in a)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");

             List<int> intlist = new List<int>();
             intlist.Add(10);
             intlist.Add(20);

             List<String> strlist = new List<String>();
             strlist.Add("Narayana");
             strlist.Add("Mahadeva");

             List<String> strnlist = new List<String>
             {
                 "Narayana",
                 "Mahadeva"
             };


             List<Gridd> gh = new List<Gridd>
             {
                new Gridd{ EmpID=1, EmpName="Ball", Designation="Hello", Mobile =646 },
                new Gridd{ EmpID=2, EmpName="Hat", Designation="Test", Mobile =564 }
             };

             Gridd n1 = new Gridd { EmpID = 4, EmpName = "Ball", Designation = "Hello", Mobile = 646 };
             Gridd n2 = new Gridd { EmpID = 2, EmpName = "Hat", Designation = "Test", Mobile = 564 };
             Gridd n3 = new Gridd();
             n3.EmpID = 1212;
             n3.EmpName = "Mani ";
             n3.Designation = "Programmer";
             n3.Mobile = 45654;
             List<Gridd> gh1 = new List<Gridd>();
             gh1.Add(n1);
             gh1.Add(n2);
             gh1.Add(n3);

             for (int i = 0; i < gh.Count; i++)
             {
                 Console.WriteLine(gh[i].Designation);
             }
             Console.WriteLine("-----------");

             foreach (Gridd i in gh)
             {
                 Console.WriteLine(i.EmpID + " " + i.EmpName + " " + i.Mobile + " " + i.Designation);
             }
             Console.WriteLine("-----------");

             for (int i = 0; i < gh1.Count; i++)
             {
                 Console.WriteLine(gh1[i].Designation);
             }
             Console.WriteLine("-----------");

             foreach (Gridd i in gh1)
             {
                 Console.WriteLine(i.EmpID + " " + i.EmpName + " " + i.Mobile + " " + i.Designation);
             }
             Console.WriteLine("-----------");

             Dictionary<int, String> newd = new Dictionary<int, string>();
             newd.Add(3, "Gogo");
             newd.Add(n1.EmpID, n1.EmpName);

             Dictionary<int, Gridd> newob = new Dictionary<int, Gridd>
             {
                 [1] = new Gridd { EmpID = 1, EmpName = "Ball", Designation = "Hello", Mobile = 646 },
                 [2] = new Gridd { EmpID = 2, EmpName = "Hat", Designation = "Test", Mobile = 564 }
             };


             foreach (int i in newd.Keys)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");

             foreach (string i in newd.Values)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");

             foreach (KeyValuePair<int, Gridd> i in newob)
             {
                 Console.WriteLine(i.Key + " " + i.Value);
             }
             Console.WriteLine("-----------");

             Stack<int> S = new Stack<int>();
             S.Push(19);
             S.Push(34);
             S.Push(67);
             S.Push(77);
             S.Push(87);

             foreach (int i in S)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");

             Console.WriteLine(S.Peek());
             Console.WriteLine("-----------");

             foreach (int i in S)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");

             Console.WriteLine(S.Pop());
             Console.WriteLine("-----------");

             foreach (int i in S)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");

             Queue<int> Q = new Queue<int>();
             Q.Enqueue(19);
             Q.Enqueue(34);
             Q.Enqueue(67);
             Q.Enqueue(77);
             Q.Enqueue(87);

             foreach (int i in Q)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");

             Console.WriteLine(Q.Peek());
             Console.WriteLine("-----------");

             foreach (int i in Q)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");

             Console.WriteLine(Q.Dequeue());
             Console.WriteLine("-----------");

             foreach (int i in Q)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine("-----------");


             degname d = new degname(fnname);
             degname d1 = fnname;

             Console.WriteLine(d(200));
             Console.WriteLine(d1(400)); 
        }
    }
}
