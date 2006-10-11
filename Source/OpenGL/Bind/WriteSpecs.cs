#region License
//Copyright (c) 2006 Stephen Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections;

namespace OpenTK.OpenGL.Bind
{
    static partial class SpecWriter
    {
        #region WriteSpecs
        public static void WriteSpecs(string output_path, string class_name, List<Function> functions, List<Function> wrappers, Hashtable enums)
        {
            string filename = Path.Combine(output_path, class_name + ".cs");

            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            StreamWriter sw = new StreamWriter(filename, false);

            Console.WriteLine("Writing {0} class to {1}", class_name, filename);

            WriteLicense(sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine();
            sw.WriteLine("namespace {0}", Settings.OutputNamespace);
            sw.WriteLine("{");

            WriteTypes(sw);
            WriteEnums(sw, enums);

            sw.WriteLine("    public static partial class {0}", class_name);
            sw.WriteLine("    {");

            WriteFunctionSignatures(sw, functions);
            WriteDllImports(sw, functions);
            WriteFunctions(sw, functions);
            WriteWrappers(sw, wrappers);

            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.WriteLine();

            sw.Flush();
            sw.Close();
        }
        #endregion

        #region WriteLicense
        public static void WriteLicense(StreamWriter sw)
        {
            sw.WriteLine("#region License");
            sw.WriteLine("//Copyright (c) 2006 Stephen Apostolopoulos");
            sw.WriteLine("//See license.txt for license info");
            sw.WriteLine("#endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write types

        private static void WriteTypes(StreamWriter sw)
        {
            sw.WriteLine("    #region Types");
            //foreach ( c in constants)
            foreach (string key in Translation.CSTypes.Keys)
            {
                sw.WriteLine("    using {0} = System.{1};", key, Translation.CSTypes[key]);
                //sw.WriteLine("        public const {0};", c.ToString());
            }
            sw.WriteLine("    #endregion");
            sw.WriteLine();
        }

        #endregion

        #region Write enums
        private static void WriteEnums(StreamWriter sw, Hashtable enums)
        {
            sw.WriteLine("    #region Enums");
            sw.WriteLine("    public struct Enums");
            sw.WriteLine("    {");

            #region Missing constants

            sw.WriteLine("        #region Missing Constants");
            sw.WriteLine();

            sw.WriteLine();
            sw.WriteLine("        #endregion");
            sw.WriteLine();

            #endregion

            foreach (Enum e in enums.Values)
            {
                sw.WriteLine(e.ToString());
            }

            sw.WriteLine("    }");
            sw.WriteLine("    #endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write function signatures
        private static void WriteFunctionSignatures(StreamWriter sw, List<Function> functions)
        {
            sw.WriteLine("        #region Function signatures");
            sw.WriteLine();
            sw.WriteLine("        public static class Delegates");
            sw.WriteLine("        {");

            foreach (Function f in functions)
            {
                sw.WriteLine("            public delegate {0};", f.ToString());
            }

            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write dll imports
        private static void WriteDllImports(StreamWriter sw, List<Function> functions)
        {
            sw.WriteLine("        #region Imports");
            sw.WriteLine();
            sw.WriteLine("        internal class Imports");
            sw.WriteLine("        {");

            foreach (Function f in functions)
            {
                if (!f.Extension)
                {
                    sw.WriteLine("            [DllImport(\"opengl32.dll\", EntryPoint = \"gl{0}\")]", f.Name.TrimEnd('_'));
                    sw.WriteLine("            public static extern {0};", f.ToString());
                }
            }

            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write functions

        private static void WriteFunctions(StreamWriter sw, List<Function> functions)
        {
            sw.WriteLine("        #region Function initialisation");
            sw.WriteLine();

            foreach (Function f in functions)
            {
                sw.WriteLine("        public static Delegates.{0} {0};", f.Name);
            }

            sw.WriteLine();
            sw.WriteLine("        #endregion");
            sw.WriteLine();
        }

        #endregion

        #region Write wrappers

        public static void WriteWrappers(StreamWriter sw, List<Function> wrappers)
        {
            sw.WriteLine("        #region Wrappers");
            sw.WriteLine();

            if (wrappers != null)
            {
                foreach (Function w in wrappers)
                {
                    sw.WriteLine("        #region {0}{1}", w.Name, w.Parameters.ToString());
                    sw.WriteLine();

                    sw.WriteLine("        public static");
                    sw.WriteLine(w.ToString("        "));

                    sw.WriteLine("        #endregion");
                    sw.WriteLine();
                }
            }

            sw.WriteLine("        #endregion");
        }

        #endregion
    }
}