
namespace Task02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLoad = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemMenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRightAnswers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAmountQuestion = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.lblAmountQuestiontext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLoad
            // 
            this.toolStripLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLoad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuLoad});
            this.toolStripLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLoad.Image")));
            this.toolStripLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLoad.Name = "toolStripLoad";
            this.toolStripLoad.Size = new System.Drawing.Size(51, 22);
            this.toolStripLoad.Text = "Menu";
            // 
            // itemMenuLoad
            // 
            this.itemMenuLoad.Name = "itemMenuLoad";
            this.itemMenuLoad.Size = new System.Drawing.Size(153, 22);
            this.itemMenuLoad.Text = "LoadQuestions";
            this.itemMenuLoad.Click += new System.EventHandler(this.itemMenuLoad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRightAnswers);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblAmountQuestion);
            this.panel1.Controls.Add(this.btnAnswer);
            this.panel1.Controls.Add(this.lblCurrentQuestion);
            this.panel1.Controls.Add(this.lblAmountQuestiontext);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 79);
            this.panel1.TabIndex = 2;
            // 
            // lblRightAnswers
            // 
            this.lblRightAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRightAnswers.AutoSize = true;
            this.lblRightAnswers.Location = new System.Drawing.Point(538, 39);
            this.lblRightAnswers.Name = "lblRightAnswers";
            this.lblRightAnswers.Size = new System.Drawing.Size(13, 13);
            this.lblRightAnswers.TabIndex = 6;
            this.lblRightAnswers.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Right Answers";
            // 
            // lblAmountQuestion
            // 
            this.lblAmountQuestion.AutoSize = true;
            this.lblAmountQuestion.Location = new System.Drawing.Point(160, 39);
            this.lblAmountQuestion.Name = "lblAmountQuestion";
            this.lblAmountQuestion.Size = new System.Drawing.Size(13, 13);
            this.lblAmountQuestion.TabIndex = 4;
            this.lblAmountQuestion.Text = "0";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer.Location = new System.Drawing.Point(384, 16);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(104, 36);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "Answer!";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.AutoSize = true;
            this.lblCurrentQuestion.Location = new System.Drawing.Point(33, 39);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentQuestion.TabIndex = 2;
            this.lblCurrentQuestion.Text = "0";
            // 
            // lblAmountQuestiontext
            // 
            this.lblAmountQuestiontext.AutoSize = true;
            this.lblAmountQuestiontext.Location = new System.Drawing.Point(137, 16);
            this.lblAmountQuestiontext.Name = "lblAmountQuestiontext";
            this.lblAmountQuestiontext.Size = new System.Drawing.Size(88, 13);
            this.lblAmountQuestiontext.TabIndex = 1;
            this.lblAmountQuestiontext.Text = "Amount Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current question";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Location = new System.Drawing.Point(0, 25);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(649, 387);
            this.lblQuestion.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 491);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(520, 400);
            this.Name = "Form1";
            this.Text = "Верю не верю";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLoad;
        private System.Windows.Forms.ToolStripMenuItem itemMenuLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRightAnswers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAmountQuestion;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.Label lblAmountQuestiontext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestion;
    }
}

