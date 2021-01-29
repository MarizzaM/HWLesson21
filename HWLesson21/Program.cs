using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HWLesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car juke = new Car("Nissan", "Juke", 2020, "Black", 0101, 5);

            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Car));

            //using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Create))
            //{
            //    myXmlSerializer.Serialize(file, juke);

            //}

            Car juke;

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Open)) 
            {
                juke = myXmlSerializer.Deserialize(file) as Car;

            }
            Console.WriteLine(juke);

            Car[] cArray;

//            Car[] cArray =
//{
//                new Car("Nissan", " Micra", 2021, "Black", 0101, 5),
//                new Car("Nissan", "X-Trail ", 2020, "Silver", 0102, 7),
//                new Car("Nissan", "Navara", 2020, "Orange", 0103, 5),
//                new Car("Nissan", " GT-R", 2020, "Red", 0104, 5)
//            };

            XmlSerializer myXmlSerializerArray = new XmlSerializer(typeof(Car[]));
            //using (Stream file = new FileStream(@"c:\temp\xmlarrayfile.xml", FileMode.Create))
            //{
            //    myXmlSerializerArray.Serialize(file, cArray);
            //}

            using (Stream file = new FileStream(@"c:\temp\xmlarrayfile.xml", FileMode.Open))
            {
                cArray = myXmlSerializerArray.Deserialize(file) as Car[];
            }

            for (int i = 0; i < cArray.Length; i++) {
                Console.WriteLine(cArray[i]);
            }

        }
    }
}
