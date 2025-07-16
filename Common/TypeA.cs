using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //Access Modifires :C# KeyWords Indicate Accessibility Scope
    //1.private
    //2.private protected
    //3.protected
    //4.internal
    //5.internal protected
    //6.public

    //What can Write inside the namespace?
    //1.class
    //2.struct
    //3.interface
    //4.enum



    //Access Modifiers inside The Namespace:
    //1.internal : inside the same project
    //2.public   : EveryWhere

    //Default Access Modifiers Inside The NameSpace"Internal" 



    //What Can Write Inside The Class Or Struct?
    //1.Attributes [filed -Member Variable]
    //2.Properties [Full Property -Automatic Property - Special Property(indexer) ]
    //3.Methodes Or Functions
    //4.Event


    //Access Modifiers Inside The Class:

    //1.private
    //2.private protected
    //3.protected
    //4.internal
    //5.internal protected
    //6.public


    //Access Modifiers Inside The Struct:

    //1. private  : Inside The Same Class
    //2. internal : Inside The Same Project
    //3. Public   : EveryWhere




    //Access Modifiers Inside The Class Or Struct "Private"


    //What Can Write Inside The Interface?
    //1.Signature  OF Methods [ReturnType -Name - Parameter]
    //2.Signature  OF property
    //3.Default inplenented Methods [C#8.0 .Net Core3.1]


    //All Access Modifiers Except "Private "

   
    //Default Access Modifiers Inside The Interface "Public"


    internal class TypeA
    {
        void Fun01()
        {
            TypeA typeA = new TypeA(); //Invalid TypeA is internal

            TypeB typeB = new TypeB(); //Valid

           // typeB.X = 12; //InValid
            typeB.Y = 12; //Valid
            typeB.Z = 12; //Valid



        }


    }
}
