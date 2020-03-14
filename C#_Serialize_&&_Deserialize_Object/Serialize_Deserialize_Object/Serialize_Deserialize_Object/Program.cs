using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialize_Deserialize_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new TestSimpleObject object.
            ObjectData obj = new ObjectVehicle();

            Console.WriteLine("Before serialization the object contains: ");
            obj.Print();

            // Opens a file and serializes the object into it in binary format.
            Stream stream = File.Open("data.xml", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(stream, obj);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                stream.Close();
            }

            // Empties obj.
            obj = null;

            // Opens file "data.xml" and deserializes the object from it.
            stream = File.Open("data.xml", FileMode.Open);
            formatter = new BinaryFormatter();
            try
            {
                obj = (ObjectVehicle)formatter.Deserialize(stream);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                stream.Close();
            }

            Console.WriteLine("");
            Console.WriteLine("After deserialization the object contains: ");
            obj.Print();

        }
    }
}
