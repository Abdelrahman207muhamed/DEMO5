using System.Linq.Expressions;
using System.Security.AccessControl;

namespace DEMO5
{
    //0 -> 255
    enum Season :byte
    {
        Spring =10,
        Winter,
        Summer,
        Autumn
    }


    enum WeekDay 
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wendnesday,
        Thursday,
        Friday  
    }

    enum Gender  
    {
        M=1,
        F=2,
        Male=1,
        Female = 2
    }

    internal class Program
    {


        #region Exception Handling and Protective Code
        //static void DoSomeCode()
        //{
        //    int X, Y, Z;
        //    X = int.Parse(Console.ReadLine());
        //    Y = int.Parse(Console.ReadLine());

        //    Z = X / Y;

        //    int[] Arr = { 1, 2, 3 };

        //    Arr[99] = 10;

        //}



        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine());
        //        Y = int.Parse(Console.ReadLine());

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3 };

        //        Arr[99] = 10;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally 
        //    {
        //        Console.WriteLine("Finally");
        //        //Release | Deallocate | Dissconnect | Dispose |UnManaged Resource
        //    }

        //}

        //static void DoSomeProtectedCode()
        //{

        //    int X, Y, Z;
        //    bool flag;
        //    do
        //    {
        //        Console.Write("Enter First Number ");
        //       flag = int.TryParse(Console.ReadLine(), out X);

        //    } while (flag == false);


        //    do
        //    {
        //        Console.Write("Enter Seconde Number ");
        //       flag = int.TryParse(Console.ReadLine(), out Y);

        //    } while (flag == false|| Y==0);

        //    Z = X / Y;

        //    int[] Arr = { 1, 2, 3 };

        //    if (99 < Arr?.Length)
        //    {
        //        Arr[99] = 10;
        //    }

        //} 
        #endregion
        static void Main()
        {
            #region  Boxing And Un Boxing
            //Boxing And Un Boxing

            //Boxing   : Casting From ValueType To ReferenceType
            //Unboxing :Casting From ReferenceType To ValueType

            //Object O1;
            //O1 => Can Refer to instant Of "Object" Or Any Instant  of any Type    

            //O1=1;
            //O1=1.5;
            //O1="Ahmed"


            //O1 = 3; //Cast from ValueType [int] To RefernceType [object] =>Boxing
            //O1 = 1.5;//Cast From ValueType [double] to ReferenceType[object]=>Boxing
            //O1 = 'A';//Cast From ValueType [char] to ReferenceType[object]=>Boxing
            //O1 = true;//Cast From ValueType [bool] to ReferenceType[object]=>Boxing
            //O1 = new DateTime();//Cast From ValueType [Datetime] to ReferenceType[object]=>Boxing

            //int X = 5;
            //object O1 = /*(object)*/X;

            ////inmplicit Casting 
            ////Safe Casting
            /////Boxing
            ////Parent => Child :Child is Parent
            ////Animal=Dog => Dog is Animal 


            //object O1 =3;

            //int X =(int)O1;

            //Explicit Casting : 
            //Unsafe  Casting
            //UnBoxing Cast from ReferenceType [int] To ValueType [object] => UnBoxing
            //Dog = (Dog) Animal =>Animal  is Dog
            //Child = Parent => Parent is Child

            #endregion

            #region NullableType
            //NullableType

            //Value Type
            //Reference Type 

            //int X = 6;

            //X=null; NotValid


            //Nullable Value type =>Value Type Allow Null as valid Value

            //Nullable<int> :Allow Int value Or Null as Null as Valid Value
            //int? Age = 20;

            //Age = null;



            ////Nullable <Double> : Allow double Value Or Null As Valid Value
            //double? Salary=4000.5;

            //Salary = null;



            //int X = 5;

            ////Y:Nullable<int>
            ////Y:Allow Int Value Or Null

            //int? Y = X;

            ////Implicit Casting
            ////Safe Casting 


            //Console.WriteLine(Y);



            //int? X = 5;

            //X = null;
            //X = null;

            //Y : int 
            //Y :Allow Int Value Only

            //int Y ; //System.InvalidOperationException: Nullable object must have a value.

            //Explicit Castign
            //May Throw EXception


            //Defensive Code

            //if (X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;


            //=====================

            //if (X is not  null)
            //    Y = (int)X;
            //else
            //    Y = 0;


            //=====================


            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;

            //======================

            //Y = X.HasValue ? X.Value : 0;


            //========================


            //Y = X is not null ? X.Value : 0;



            //========================

            //Null Coalescing Operator ??

            //Y = X ?? 0;  //Syntax Sugar :X is not null ? X.value :0

            //Console.WriteLine(Y); 
            #endregion

            #region nullable reference type
            //nullable reference type

            //string Message01= null; //Required


            //String? Message02 = null; //Nullable

            //Console.WriteLine(Message01.Length);
            //Console.WriteLine(Message02);

            #endregion

            #region Null propagation operator
            // Null propagation operator ?

            //double X = default; //0
            //bool C = default;//false

            //Console.WriteLine(C);


            /*  int[] Arr = default;*/  //null
            /*int[] Arr = { 1, 2, 3, 4, 5 };*/  //null

            //Best Practice
            //if (Arr is not null)
            //{

            //    for (int i = 0;  i < Arr.Length; i++)
            //        Console.WriteLine(Arr[i]);
            //}

            ////for (int i =0; (Arr is not null) && i<Arr.Length;i++)
            ////    Console.WriteLine(Arr[i]);



            //for (int i = 0;  i < Arr?.Length; i++)
            //    Console.WriteLine(Arr[i]);



            //E?.Department?.DeptaName 

            //int Len = Arr is not null ? Arr.Length:0;



            //int? Len = Arr?.Length;

            //int Len = Arr?.Length is not null ? Arr.Length : 0;

            //int Len = Arr?.Length?? -1;

            //Console.WriteLine(Len);  
            #endregion

            #region Exception Handling and Protective Code
            //Exception Handling and Protective Code

            //DoSomeCode();

            //DoSomeProtectedCode();

            //Console.WriteLine("Hello After Exception");


            //Exception 
            //1.System Exception:-

            //1.1. FormatException
            //1.2. indexoutofException
            //1.3. nullreferenceException
            //1.4. ArithimaticException
            //1.4.1 OverFlowException
            //1.4.2 DivideByZeroExceptionv

            //2.ApplicationException

            #endregion

            #region Access Modifieres
            //Claa Library 

            //Common.TypeA typeA = new TypeA(); //Invalid TypeA is internal

            // Common.TypeB typeB = new Common.TypeB(); //Valid TypeB is Public

            ////typeB.X = 12; //InValid Private
            ////typeB.Y = 12; //InValid internal
            // typeB.Z = 12; //valid public 

            #endregion

            #region Enum
            //Enum :Value Types
            //Stack


            //Season S01 = Season.Autumn;

            //S01 = Season.Summer;

            //Console.WriteLine(S01);

            //stack


            //CLR Represent Enum As Integer Value In memory


            //Gender G01 = (Gender) 10;

            //Console.WriteLine(G01);




            //Gender G01 = (Gender)Enum.Parse(typeof(Gender) ,Console.ReadLine(),true);

            ////UnBoxing 

            //Gender G01;
            //Enum.TryParse(typeof(Gender),Console.ReadLine(),true ,out object O1);

            //G01 =(Gender) O1;


            //Console.WriteLine(G01); 
            #endregion




        }
    }
}
