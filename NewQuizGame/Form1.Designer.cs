namespace NewQuizGame
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LevelNumber = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(466, 137);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(465, 137);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(466, 137);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(527, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(465, 137);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // LevelNumber
            // 
            this.LevelNumber.Location = new System.Drawing.Point(0, 0);
            this.LevelNumber.Name = "LevelNumber";
            this.LevelNumber.Size = new System.Drawing.Size(1030, 35);
            this.LevelNumber.TabIndex = 7;
            this.LevelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Question.Location = new System.Drawing.Point(7, 65);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(1011, 150);
            this.Question.TabIndex = 0;
            this.Question.Text = "Question";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(10, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1008, 43);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1031, 628);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.LevelNumber);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Quiz";
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label LevelNumber;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

