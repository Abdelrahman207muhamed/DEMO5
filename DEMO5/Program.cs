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


            object O1 =3;

            int X =(int)O1;

            //Explicit Casting : 
            //Unsafe  Casting
            //UnBoxing Cast from ReferenceType [int] To ValueType [object] => UnBoxing
            //Dog = (Dog) Animal =>Animal  is Dog
            //Child = Parent => Parent is Child

            #endregion

        }
    }
}
