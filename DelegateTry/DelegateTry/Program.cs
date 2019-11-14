using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTry
{
    class Program
    {
        public delegate void SetOneStr(string str);
        public delegate void FullInfo(string name, string surname, int age);
        static void Main(string[] args)
        {
            #region
            //  GetMyDelegate(Test, Test2);
            //  SetOneStr setOneStr = new SetOneStr(Hey);
            //  setOneStr += How;
            //  setOneStr("Nizami");

            ////SetOneStr setOneSTR = delegate (string str)
            //  SetOneStr setOneSTR = str =>
            //  {
            //     Console.WriteLine($"Good Bye {str}");
            //  };
            //  setOneSTR+=  Hey; 
            //  setOneSTR += How;
            //  setOneSTR("Fizuli");
            //  //getFullName burda bir vareybl-dir.

            //  Console.WriteLine("\n");
            //  Student student = new Student();
            //  FullInfo fullInfo = student.getFullName;
            //  //fullInfo += delegate (string name, string surname, int age)
            //  fullInfo += (name,surname,age) =>
            //  {
            //      Console.WriteLine($" Best of Students Info {name} {surname} {age}");
            //  };
            //  fullInfo("Rehim","Abbasov",15);

            //  Temporary temporary = new Temporary();
            //  temporary.Test3();

            //Action<string> info = Test;
            //info += Test2;
            //info += str =>
            //{
            //    Console.WriteLine($"Teacher of P111 {str}");
            //};
            ////info("Kamran");
            //Func<int, string, string> func = SimpleFunc;
            ////Console.WriteLine(func(14,"Kamil"));
            #endregion
            Bankomat bankomat = new Bankomat(580);
             bankomat.CheckInfo += delegate (double hes, int x)
            {
                Console.WriteLine($"");
            };
        }

        #region
        public static string SimpleFunc(int age, string name)
        {
            return $"Student Name {name} Age {age}";
        }
        public static void GetMyDelegate(SetOneStr a, SetOneStr b)
        {
            a("Mushfig");
            b("Mushfig");
        }
        static void Test(string str)
        {
            Console.WriteLine($"Student Name : {str}");
        }
        static void Test2(string str)
        {
            Console.WriteLine($"best goog Mark belof {str}");
        }
        class Temporary
        {
            public void Test3()
            {
                Console.WriteLine($"Best Student ");
            }
        }
        static void Hey(string str)
        {
            Console.WriteLine($"Hey my friend {str}");
        }
        static void How(string str)
        {
            Console.WriteLine($"How are you {str} ?");
        }
        class Student
        {
            public void getFullName(string name, string surname, int age)
            {
                Console.WriteLine($"Name : {name} Surname {surname} Age {age}");
            }
        }
        #endregion

        class Bankomat
        {
            public event Action<double,int> CheckInfo;
            public double Hesab { get; set; }
            public Bankomat(int hes)
            {
                Hesab = hes;
            }

            public void CheckMoney(int x)
            {
                if (x <= Hesab)
                {
                    Console.WriteLine("Succesfull");
                }
                else
                {
                    CheckInfo?.Invoke(Hesab, x);
                }
            }
        }
    }
}
