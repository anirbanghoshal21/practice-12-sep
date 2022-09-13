using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Reflection_hands_on
{
     class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Public\Anirban\Reflection hands on\CalculatorLibrary\bin\Debug\CalculatorLibrary.dll";

            Assembly asm = Assembly.LoadFrom(path);

            Type Type = asm.GetType("CalculatorLibrary.clsCalculation");
            

            object objInstance = Activator.CreateInstance(Type);

            Type objectType = objInstance.GetType();
           

            foreach (MemberInfo objMemberInfo in objectType.GetMembers())
            {

                Console.WriteLine(objMemberInfo.Name);

               
                double answer = (double)objectType.InvokeMember("Cube", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance, null, objInstance, new object[] { 27 });
                _ = (double)objectType.InvokeMember("sqrt", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance, null, objInstance, new object[] { 144 });
                Console.WriteLine(answer);
            }
            Console.ReadLine();
        }
    }
}
