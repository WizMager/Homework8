using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Task01;

namespace Tak01
{
    public class TrueFalse
    {
        private string fileName;
        private List<Question> list;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public Question this[int index]
        {
            get { return list[index]; }
        }

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0)
                list.RemoveAt(index);
        }

        public void Load()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    list = (xmlSerializer.Deserialize((fileStream)) as List<Question>);
                }
            }
            catch (System.InvalidOperationException)
            {
                list.Clear();
                list.Add(new Question("Вы загрузили неподходящий файл", true));
            }           
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, list);
            }
        }

        public void SaveAs()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using(FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, list);
            }
        }
    }
}
