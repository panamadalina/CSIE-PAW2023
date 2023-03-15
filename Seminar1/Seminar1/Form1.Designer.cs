namespace Seminar1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbCod = new TextBox();
            tbNume = new TextBox();
            tbVarsta = new TextBox();
            tbMedie = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 54);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 0;
            label1.Text = "Cod:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 110);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 1;
            label2.Text = "Nume:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 172);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 2;
            label3.Text = "Varsta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 239);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 3;
            label4.Text = "Medie:";
            // 
            // tbCod
            // 
            tbCod.Location = new Point(154, 51);
            tbCod.Name = "tbCod";
            tbCod.Size = new Size(175, 35);
            tbCod.TabIndex = 4;
            // 
            // tbNume
            // 
            tbNume.Location = new Point(154, 105);
            tbNume.Name = "tbNume";
            tbNume.Size = new Size(175, 35);
            tbNume.TabIndex = 5;
            // 
            // tbVarsta
            // 
            tbVarsta.Location = new Point(154, 169);
            tbVarsta.Name = "tbVarsta";
            tbVarsta.Size = new Size(175, 35);
            tbVarsta.TabIndex = 6;
            // 
            // tbMedie
            // 
            tbMedie.Location = new Point(154, 239);
            tbMedie.Name = "tbMedie";
            tbMedie.Size = new Size(175, 35);
            tbMedie.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(122, 346);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 8;
            button1.Text = "Afisare";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(410, 450);
            Controls.Add(button1);
            Controls.Add(tbMedie);
            Controls.Add(tbVarsta);
            Controls.Add(tbNume);
            Controls.Add(tbCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbCod;
        private TextBox tbNume;
        private TextBox tbVarsta;
        private TextBox tbMedie;
        private Button button1;
    }
}