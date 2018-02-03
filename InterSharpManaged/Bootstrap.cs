using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InterSharp;

namespace InterSharpManaged
{
    public class Bootstrap
    {
        [DllExport(CallingConvention.Cdecl, ExportName = "InitBootstrap")]
        public static bool InitBootstrap()
        {
            Console.WriteLine("Bootstrap Connection Established!");
            LoadAddons();
            return true;
        }

        public static void LoadAddons()
        {
            string BinaryPaths = Environment.CurrentDirectory + "\\intercept\\Addons\\";
            Console.WriteLine(SQF.time());
        }
    }
}
