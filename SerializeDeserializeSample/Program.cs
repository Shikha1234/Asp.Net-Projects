using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializeDeserializeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetails ud = new UserDetails(1, "Shikha", "Pune");
            Console.WriteLine("Before serialization the object contains: ");
            ud.GetDetails();
            string fpath = @"C:\Users\SH352687\source\repos\Asp.Net-Projects\SerializeDeserializeSample\XmlTest.txt";

            // Check if file exists

            if (File.Exists(fpath))

            {

                File.Delete(fpath);

            }

            //Opens a file and serializes the object into it in binary format.

            Stream stream = File.Open(fpath, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();


            bf.Serialize(stream, ud);


            //#region XmlSerialization
            //XmlSerializer mySerializer = new XmlSerializer(typeof(UserDetails));
            //// To write to a file, create a StreamWriter object.  
            //StreamWriter myWriter = new StreamWriter("myFileName.xml");
            //mySerializer.Serialize(myWriter, ud);

            //#endregion


            stream.Close();

            Console.WriteLine("\nSerialization Successful");

            Console.ReadLine();
        }
        [Serializable()]

        public class UserDetails

        {

            public int userId { get; set; }

            public string userName { get; set; }

            public string location { get; set; }

            public UserDetails(int id, string name, string place)

            {

                userId = id;

                userName = name;

                location = place;

            }

            public void GetDetails()

            {

                Console.WriteLine("UserId: {0}", userId);

                Console.WriteLine("UserName: {0}", userName);

                Console.WriteLine("Location: {0}", location);

            }

        }
    }
}
