using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Agenda
{
    class Persistencia<T>
    {
        public void SalvarArquivo(string arquivo, T obj)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            StreamWriter stream = new StreamWriter(arquivo);
            xml.Serialize(stream, obj);
            stream.Close();
        }

        public T AbrirArquivo(string arquivo)
        {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                StreamReader stream = new StreamReader(arquivo);
                T result = (T)xml.Deserialize(stream);
                stream.Close();
                return result;            
        }
    }
}
