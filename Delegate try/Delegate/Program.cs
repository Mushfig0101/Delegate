using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate string Natural(int number);
        //public delegate void DelegateLearn(string str);

        //public delegate void Welcome(string s);
        //public delegate void FulInfo(string name, int age);
        //public delegate string FulName(string name, string surname);
        static void Main(string[] args)
        {
            Program program = new Program();
            #region
            //DelegateLearn delegateLearn = str =>
            //{
            //    Console.WriteLine(str);
            //};

            //delegateLearn += Test;
            //delegateLearn += Test2;
            //delegateLearn += Test2;
            //delegateLearn -= Test2;

            //// DelegateLearn delegateLearn = Test;
            //GetDelegate("Kamran", delegateLearn);


            #endregion
            #region delegant first instal we must do
            //Welcome welcome = How;//sekil b
            //welcome("Cavid");
            //How("Cavid");
            //Biz hemise delegantdan instal daha dogru desek
            //obyekt alib hemin obyekte oz methodlarimizi elave edirdik;
            //ancaq birbasa hemin obyekte de oz delegant ucun  methodu da bir
            // yazdigimiz methodu da beraber ede bilerik.

            //Welcome welcome3 = How;// Sekil c
            //welcome3 = delegate (string str)
            //           {
            //               Console.WriteLine($"Anonium delegant {str} ");
            //           };
            //welcome3 += Hello;

            //welcome3("Aydin");
            #endregion
            #region 3 Variant of Anonium delegates 

            //Welcome welcome1 = new Welcome((str) =>
            //{
            //    Console.WriteLine($"Anonium Welcomdan instal alindi 1 {str}");
            //});//1-ci variant
            //welcome1 += Test;
            //welcome1("Kamran1");

            //Welcome welcome2 = str =>
            //{
            //    Console.WriteLine($"Anonium Welcomdan instal alindi 2 {str}");
            //};//2-ci variant
            //welcome2("Kamran2");

            //Welcome welcome4 = delegate (string s)//
            //{
            //    Console.WriteLine($"Welcome welcome=delegate(string s)...{s}");
            //}; welcome4("Third variant");//3-cu variant


            //DelegateLearn delegateLearn = new DelegateLearn((str) => { });
            //delegateLearn += Test;
            //delegateLearn += Test2;
            //delegateLearn += Test2;
            //delegateLearn("Abdullah");
            Console.WriteLine("2ci video \n");
            //Yeni ki Methodun parametrine delegant tipinden method vermisemse 
            //FulInfo fulinfo = delegate (string name, int age)
            //{
            //    Console.WriteLine($"Ful Info: {name} {age}");
            //};

            //fulinfo += Man;
            //fulinfo += Woman;
            //fulinfo("Cavid", 25);

            //FulInfo fulInfo = (name, age) =>
            //{
            //    Console.WriteLine($"It is Testing name={name} age={age}");
            //};
            //fulInfo += Man;
            //fulInfo += Woman;
            //fulInfo("Adil", 25);

            //FulName fulname = new FulName(program.GetFullName1);

            //FulName fulName;
            //fulName += program.GetFullName1;
            //fulName += program.GetFullName2;
            #endregion
            #region Action
            //Action<string> welcome = Hello;
            //welcome("Sukur");
            //Action<string> myaction = delegate (string str)
            //{
            //    Console.WriteLine($"Hello {str}");
            //};
            //myaction += Test;
            //myaction("Sami");

            //Func<int, int, bool> compare = (i, j) =>
            //{

            //    if (i > j)
            //    {
            //        return true;
            //    }
            //    else return false;
            //}; Console.WriteLine(compare(5, 7));
            //Func<string, string> name = delegate (string str)
            //{

            //    return str;
            //};

            //Console.WriteLine(name("Kamil"));
            #endregion
            #region Bu yazilis
            //public delegate void Welcome(string s);
            // welcome2 = str =>
            //{
            //    Console.WriteLine($"Anonium Welcomdan instal alindi 2 {str}");
            //}
            //2yazilisi bir arada toplayir!!!
            #endregion
            Konpare konpare = new Konpare();

            //Natural natura =delegate(int c) { }

            Compare compare1 = new Compare(3);
            compare1.CompareEvent += delegate (int n, int m)
            {
                Console.WriteLine($"{n} ededi {m} ededinden boyukdur");
            };
            compare1.CompareNumbers(4);

            Payment payment = new Payment(1580);
            payment.PaySystem += delegate (float a, int b)
             {
                 Console.WriteLine($"Hesabinizda istediyiniz mebleg yoxdur.");
             };
            payment.GetQuiz(986);
        }

        #region Delegate Esas
        //         DelegateLearn delegateLearn;
        //         delegateLearn = Test;
        //         delegateLearn += Test2;
        //         delegateLearn -= Test2;
        //         GetDelegate("Kamran", delegateLearn);

        //----------------------------------------------------------

        //         DelegateLearn delegateLearn = new DelegateLearn((str) => { });
        //         delegateLearn += Test;
        //         delegateLearn += Test2;
        //         delegateLearn += Test2;

        //         -------------------------------------------------------------------
        //      DelegateLearn delegateLearn = str =>
        //    {
        //      Console.WriteLine(str);
        //     };

        //    delegateLearn += Test;
        //    delegateLearn += Test2;
        //    delegateLearn += Test2;

        //    GetDelegate("Kamran", delegateLearn);
        //       //Her uc delegate uygun methodu delegant dan instal
        //alinanda birlesdirdik. Ve ona tehkim eledik.
        #endregion

        //static void GetDelegate(string str, DelegateLearn Test)//sekil a
        //{
        //    Test(str);
        //    #region
        //    //Test1 static methoddur. 
        //    //static methodlari ise eyni clasin icinde adini yazmaqla cagirmaq olar.
        //    // Biz a seklinde her hansi sadecve string qebul eden bir methodun icerisine 
        //    // bir method type goderirik ki bize icaze veriri ki,
        //    // delegate typlere uyjgun methodlari hemin methodda cagiraq. 
        //    #endregion

        //}

        class Compare
        {
            public event Action<int, int> CompareEvent;

            public int Myint { get; private set; }
            public Compare(int k)
            {
                Myint = k;
            }

            public void CompareNumbers(int cmv)
            {
                if (Myint > cmv)
                {
                    Console.WriteLine("boyukdur");
                }
                else
                {
                    CompareEvent.Invoke(cmv, Myint);

                }
            }
        }

        public class Payment
        {
            public event Action<float, int> PaySystem;
            public float Money { get; private set; }

            public Payment(float m)
            {
                Money = m;
            }

            public void GetQuiz(int q)
            {
                if (Money >= q)
                {
                    Console.WriteLine($"Hesabinizdan {q} AZN mebleg silindi: Hesabinizin qaligi {Money - q}  ");

                }
                else
                {
                    PaySystem.Invoke(Money, q);
                }
            }
        }
        #region
        static void Test(string str)
        {
            Console.WriteLine($"{str} Method : Test1");
        }
        static void Test2(string str)
        {
            Console.WriteLine($"{str} asdas");
        }
        static void Test1(int str1)
        {
        }


        static void Hello(string str)
        {
            // Console.WriteLine("Hello World {0}",str );
            Console.WriteLine($"Hello World {str}");
        }

        static void How(string s)
        {
            Console.WriteLine($"How are you{s} ?");
        }

        static void Man(string name, int age)
        {
            Console.WriteLine($"I am Man {name} {age}");
        }

        static void Woman(string name, int age)
        {
            Console.WriteLine($"I am Woman {name} {age}");
        }
        public string GetFullName1(string name, string surname)
        {
            string result = $"{name} {surname}";
            return result;
        }
        public string GetFullName2(string name, string surname)
        {
            string result = $"{name} {surname}";
            return result;
        }
        #endregion

        public class Konpare
        {
            public int Number { get; private set; }
           
            public string Check(int num) {
                if (num >= 0) {
                  
                    return $"{num} menfi ededdir";
                }
                else
                {
            
                    return $"{num} musbet ededdir";
                }

                
            }

            public string SadeEded(int num1)
            { 
        
               int count = 0;
                for (int i = 1; i <= num1; i++)
                {
                    
                    if (num1%i == 0)
                    {
                        count++;
                    }
                        
                }

                if (count > 2)
                {
                    return $"{num1} sade eded deyil ";
                }
                else
                {
                    return $"{num1} sade ededdir";
                }
            }

            public string TekCut(int num2)
            {
                if (num2 % 2 == 0)
                {
                    return $"{num2} cut ededdir";
                }
                else {
                    return $"{num2} Tek ededdir";
                }
            }

           
        }
    }




}

///<summary>
///Biz her hansi bir delegantdan instal almadan da istifade ed bilerik.
///Action<> 16 qeder ]parametr qebul ede bilir.
///Generic type oldugundan muxtelif tipden 16 parametr qebul ede biler.  
///</summary>
