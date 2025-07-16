namespace DEMO5
{
    internal class Program
    {
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







        }
    }
}
