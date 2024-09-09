using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleAppXML_IgnoreCaseTest.Models
{
    public class PeopleOther : PeopleBase
    {
        [XmlAttribute("aGE")]
        public int Age { set; get; }

        [XmlAttribute("iD")]
        public int Id { get; set; }

        [XmlElement("nAME")]
        public string Name { get; set; }

        [XmlAttribute("gENDER")]
        public Gender Sex { get; set; }
    }
}