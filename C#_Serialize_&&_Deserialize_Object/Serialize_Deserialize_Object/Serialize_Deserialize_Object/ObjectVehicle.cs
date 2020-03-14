using System;
using System.Collections.Generic;
using System.Text;

namespace Serialize_Deserialize_Object
{
    [Serializable()]
    class ObjectVehicle : ObjectData
    {
        public string type;

        public ObjectVehicle()
        {
            ID = 02;
            type = "Vehicle";
        }

        public void print()
        {
            Console.WriteLine("ID = ", ID);
            Console.WriteLine("Type = ", type);
        }
    }
}
