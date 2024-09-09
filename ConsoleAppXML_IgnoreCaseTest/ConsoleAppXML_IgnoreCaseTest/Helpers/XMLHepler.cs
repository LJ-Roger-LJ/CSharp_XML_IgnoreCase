using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleAppXML_IgnoreCaseTest.Helpers
{
    internal static class XMLHepler
    {
        public static void XMLWriteToFile<T>(T target, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            using FileStream fileStream = new(path, FileMode.OpenOrCreate | FileMode.Truncate, FileAccess.Write);
            serializer.Serialize(fileStream, target, ns);
        }

        public static T XMLReadFromFile<T>(string path) where T : class
        {
            if (!File.Exists(path))
                return null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using FileStream fileStream = new(path, FileMode.Open, FileAccess.Read);
            using StreamReader reader = new StreamReader(fileStream, Encoding.UTF8);
            return (T)serializer.Deserialize(reader);
        }
    }
}