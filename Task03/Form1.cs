using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task03
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        private string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (students != null)
            {
                string[] pathStr = path.Split('.');
                path = pathStr[0] + ".xml";
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(fileStream, students);
                }
                lblStatus.Text = $"Список сохранён по адресу  {path} .";
            }
            else
            {
                MessageBox.Show("Вы не загрузили список.");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(){Filter = "Text files(*.csv)|*.csv"};

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                students = new List<Student>();
                path = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(',', ';', ':');
                        students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    }
                }
                lblStatus.Text = $"Список с адресом {openFileDialog.FileName} загружен.";
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (students != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog(){Filter = "Text files(*.xml)|*.xml"};

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                    using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        xmlSerializer.Serialize(fileStream, students);
                    }
                }
                lblStatus.Text = $"Список сохранён по адресу {saveFileDialog.FileName} .";
            }
            else
            {
                MessageBox.Show("Вы не загрузили список.");
            }
        }
    }
}
