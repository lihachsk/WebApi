using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebApi.Infrastructure
{
    public static class CustomSerializer
    {
        public static MemoryStream Serializ(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(stream, obj);
            stream.Seek(0, SeekOrigin.Begin);

            return stream;
        }
        public static T Deserializ<T>(Stream stream) where T : class
        {
            T obj = Activator.CreateInstance<T>();
            try
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                stream.Seek(0, SeekOrigin.Begin);
                obj = (T)serializer.Deserialize(stream);
            }
            catch
            { }
            return obj;
        }
    }
}