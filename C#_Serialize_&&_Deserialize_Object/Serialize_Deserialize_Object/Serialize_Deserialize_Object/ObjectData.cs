using System;
using System.Collections.Generic;
using System.Text;

namespace Serialize_Deserialize_Object
{
    [Serializable()]
    class ObjectData
    {

        public int ID;

        public ObjectData()
        {
            ID = 01;
        }

        public void Print()
        {
            Console.WriteLine("ID = ", ID);
        }
    }
}
