using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace TestCall
{
    class Program
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Name
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string FirstName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string LastName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public string[] Array;
        };

        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetName(ref Name name);

        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Hello();

        //傳入和傳出的型態格式必須同ForExternCall.cpp內的設置！！

        //我將dll檔放到D:，然後設置進入點
        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Add(int a, int b);

        //也可以不設置進入點，但函數名稱必須相同
        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Sub(int a, int b);

        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Multi(int a, int b);

        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern float Div(int a, int b);

        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void Pri(StringBuilder[] astr, int size);

        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Sub(10, 20));
            Console.WriteLine(Multi(10, 20));
            Console.WriteLine(Div(10, 20));

            Hello();

            /*var name = new Name();
            GetName(ref name);
            Console.WriteLine(name.FirstName);
            foreach (var s in name.Array)
                Console.WriteLine(s);*/
                
            List<string> names = new List<string>();
            names.Add("first");
            names.Add("second");
            names.Add("third");

            StringBuilder[] astr = new StringBuilder[5];
            astr[0] = new StringBuilder();
            astr[1] = new StringBuilder();
            astr[2] = new StringBuilder();
            astr[0].Append(names[0]);
            astr[1].Append(names[1]);
            astr[2].Append(names[2]);



            Pri(astr, 3);

            Console.WriteLine(astr[4]);
            Console.ReadKey();
        }
    }
}
/*using System;
using System.Runtime.InteropServices;

namespace TestApp
{
    class Program
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Name
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string FirstName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string LastName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public string[] Array;
        };

        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetName(ref Name name);

        [DllImport("ForCSharpCall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Hello();

        static void Main(string[] args)
        {
            Hello();
            var name = new Name();
            GetName(ref name);
            Console.WriteLine(name.FirstName);
            foreach (var s in name.Array)
                Console.WriteLine(s);
        }
    }
}*/
