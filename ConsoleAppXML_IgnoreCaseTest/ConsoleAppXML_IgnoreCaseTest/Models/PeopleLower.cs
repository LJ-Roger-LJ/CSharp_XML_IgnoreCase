using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleAppXML_IgnoreCaseTest.Models
{
    public class PeopleLower : PeopleBase
    {
        [XmlAttribute("age")]
        public int Age { set; get; }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlAttribute("gender")]
        public Gender Sex { get; set; }
    }
}