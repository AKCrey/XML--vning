using System;
using System.IO;
using System.Xml.Serialization;

namespace XML_övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Golfboll mini = new Golfboll();

            mini.speed = 5;


            XmlSerializer serializer = new XmlSerializer(typeof(Golfboll));

            FileStream myFile = File.Open("golfboll.xml", FileMode.OpenOrCreate);

            serializer.Serialize(myFile, mini);

            //Golfboll mini = (Golfboll) serializer.Dezerialize(myFile):

            myFile.Close();

            Console.WriteLine("What speed is the golf ball gonna be? Please don't question this question...questception :o");
            
            string input = Console.ReadLine();

            int num = 0;

            bool success = int.TryParse(input, out num);

            Console.WriteLine(num + 1);

            Console.ReadLine();


        }
    }
}
