using XSharp;
using GreetLib;
using System.Reflection;
using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{ 
    public static partial class CSClass
    {
        public static __Array Test_CS()
        {
            __Array testArr = XSharp.RT.Functions.ArrayNew(1, 2);

            // uncomment to load in the DLL
            //string testResult = GreetLib.Functions.Test();
            //var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            //var loadedPaths = loadedAssemblies.Select(a => a.Location).ToArray();

            //var referencedPaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");
            //var toLoad = referencedPaths.Where(r => !loadedPaths.Contains(r, StringComparer.InvariantCultureIgnoreCase)).ToList();

            //toLoad.ForEach(path => loadedAssemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(path))));

            string[] loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Select(assm => assm.Location).ToArray();
            List<string> unloadedAssemblies = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory,"*.dll").Where(assm => !loadedAssemblies.Contains(assm, StringComparer.OrdinalIgnoreCase)).ToList();
            unloadedAssemblies.ForEach(assm =>AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(assm)));

            testArr[0, 0] = "Codeblock";
            testArr[0, 1] = XSharp.RT.Functions.MCompile("{| name | Greetings(name) }");
            return testArr;
        }
    }
}
