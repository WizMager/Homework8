using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tak01;

namespace Task02
{
    public partial class Form1 : Form
    {
        private TrueFalse database;
        private int currentQuest = 1;
        private int amountQuests = 0;
        private int rightAnswrs = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void itemMenuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();
                lblQuestion.Text = "В этом файле нет вопросов.";

                if (database.Count != 0)
                {
                    currentQuest = 1;
                    lblCurrentQuestion.Text = currentQuest.ToString();
                    amountQuests = database.Count;
                    lblAmountQuestion.Text = amountQuests.ToString();
                    rightAnswrs = 0;
                    lblQuestion.Text = database[index: currentQuest - 1].Text;
                    rightAnswrs = 0;
                }
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (currentQuest > amountQuests)
            {
                MessageBox.Show("Вопросов (больше) нет.");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Считаете ли вы это правдой?", "Да или нет", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (database[index: currentQuest - 1].TrueFalse)
                        rightAnswrs++;
                }
                else
                {
                    if (!database[index: currentQuest - 1].TrueFalse)
                        rightAnswrs++;
                }
                
                currentQuest++;
                if(currentQuest <= amountQuests)
                {
                    lblCurrentQuestion.Text = currentQuest.ToString();
                    lblQuestion.Text = database[index: currentQuest - 1].Text;

                }
                if(currentQuest > amountQuests)
                {
                    lblQuestion.Text = $"Воспросы закончились.\nПравильных ответов: {rightAnswrs} из {amountQuests} вопрос(ов/а).";
                }
                lblRightAnswers.Text = rightAnswrs.ToString();
                
            }


        }
    }
}
