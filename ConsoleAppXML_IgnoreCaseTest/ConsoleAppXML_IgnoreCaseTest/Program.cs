using ConsoleAppXML_IgnoreCaseTest.Models;
using ConsoleAppXML_IgnoreCaseTest.Helpers;

namespace ConsoleAppXML_IgnoreCaseTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PeopleUpper peopleUpper = new PeopleUpper()
            {
                Id = 123,
                Age = 1,
                Name = "Upper",
                Sex = Gender.FEMALE,
            };
            PeopleLower peopleLower = new PeopleLower()
            {
                Id = 234,
                Age = 2,
                Name = "Lower",
                Sex = Gender.MALE,
            };
            PeopleOther peopleOther = new PeopleOther()
            {
                Id = 345,
                Age = 3,
                Name = "Other",
                Sex = Gender.FEMALE,
            };
            //XMLHepler.XMLWriteToFile<PeopleLower>(peopleLower, "../../../XML/Lower.xml");
            //XMLHepler.XMLWriteToFile<PeopleUpper>(peopleUpper, "../../../XML/Upper.xml");
            //XMLHepler.XMLWriteToFile<PeopleOther>(peopleOther, "../../../XML/Other.xml");

            PeopleLower lowerRead = XMLHepler.XMLReadFromFile<PeopleLower>("../../../XML/Lower.xml");
            Console.WriteLine($"{lowerRead.Id}");
            Console.WriteLine($"{lowerRead.Name}");

            PeopleUpper UpperRead = XMLHepler.XMLReadFromFile<PeopleUpper>("../../../XML/Upper.xml");
            Console.WriteLine($"{UpperRead.Id}");
            Console.WriteLine($"{UpperRead.Name}");

            PeopleOther otherRead = XMLHepler.XMLReadFromFile<PeopleOther>("../../../XML/Other.xml");
            Console.WriteLine($"{otherRead.Id}");
            Console.WriteLine($"{otherRead.Name}");
        }
    }
}