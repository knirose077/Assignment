using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sep12_B
{
    public class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\NIROSE K\source\repos\Section_B\bin\Debug\Section_B.dll";

            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("name= " + item.Name);//classname
                Console.WriteLine("Full Name= " + item.FullName);//(assemblyname/namespacename) . class

                Console.WriteLine("IS Class=" + item.IsClass);
                Console.WriteLine("IS Absatract=" + item.IsAbstract);
                Console.WriteLine("Whether public " + item.IsPublic);


                Console.WriteLine("-----------------");
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("--> Method : {0}", method.Name);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        Console.WriteLine(" Parameter : {0} Type : {1}",
                        arg.Name, arg.ParameterType);


                    }
                }
                Console.WriteLine("________________________________");
                Type t = null;
                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);

                int ans = (int)item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 4, 9 });

                item.InvokeMember("SquareRoot", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { 16.00, 100.00 });

                break;

            }
            Console.WriteLine("________________");
            Program.WritedataForEachCode(typeof(Song));
            Console.Read();
        }
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);
            foreach (System.Attribute attr in attrs)
            {
                if (attr is DeveloperAttribute)
                {
                    DeveloperAttribute a = (DeveloperAttribute)attr;
                    Console.WriteLine(a.SongName);

                }
            }
            Console.WriteLine("_____________________");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is DeveloperAttribute)
                    {
                        DeveloperAttribute a = (DeveloperAttribute)attrItem;
                        System.Console.WriteLine(a.SongName);
                    }
                }

            }
        }
    }
}
