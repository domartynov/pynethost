using System.IO;
using System.Linq;
using Python.Runtime;

namespace pynethost
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var path = Path.GetFullPath(args.First());
            Directory.SetCurrentDirectory(Path.GetDirectoryName(path));

            var moduleName = Path.GetFileNameWithoutExtension(path);
            
            PythonEngine.Initialize();
            using (Py.GIL())
            {
                PythonEngine.ImportModule(moduleName);
            }

        }
    }
}