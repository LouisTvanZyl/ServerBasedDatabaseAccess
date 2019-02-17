using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace HelperLibrary
{
   public static class SerializationMethods
    {
        public static byte[] Serialize(this object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, obj);

            return stream.GetBuffer();

        }

        public static object Deserialize(this byte[] buffer)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream(buffer);
            if (stream != null)
            {
                return formatter.Deserialize(stream);

            }
            else
            {
                return null;
            }

            
        }

    }
}
