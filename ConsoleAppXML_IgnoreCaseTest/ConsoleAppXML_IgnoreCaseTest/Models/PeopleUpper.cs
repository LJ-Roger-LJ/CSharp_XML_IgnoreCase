using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleAppXML_IgnoreCaseTest.Models
{
    public class PeopleUpper : PeopleBase
    {
        [XmlAttribute("Age")]
        public int Age { set; get; }

        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlAttribute("Gender")]
        public Gender Sex { get; set; }
    }
}