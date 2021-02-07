using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SApp03
{
    public partial class Form1 : Form
    {
        private TrueFalse database;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);
                database.Add("Тестовый вопрос, да или нет?", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;

            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;

                if (database.Count != 0)
                {
                    tbQuestion.Text = database[0].Text;
                    cbTrue.Checked = database[0].TrueFalse;
                }
            }
        }

        /// <summary>
        /// Обновим вопрос в коллекции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if(database == null)
            {
                MessageBox.Show("Сначала создайте базу данных.");
                return;
            }
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if(database == null)
            {
                MessageBox.Show("База данных не создана.");
                return;
            }
                tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте базу данных!");
                return;
            }

            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить вопрос?", "Удалить?" , MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (nudNumber.Maximum == 1 || database == null)
                {
                    MessageBox.Show("БД не создана или остался последний вопрос.");
                    return;
                }
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Save();
            }
            else
            {
                MessageBox.Show("БД не создана.");
            } 
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Атор: Антон Островский\nВерсия: 1.0\nСкопирована у преподавателя Станислава и дополнена");
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            if(database == null)
            {
                MessageBox.Show("Создайте БД.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else 
            {
                database.FileName = saveFileDialog.FileName;
                database.SaveAs();
            }
        }
    }
}
