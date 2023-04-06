namespace Seminar4 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.Nume = new System.Windows.Forms.Label();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.errorProviderCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSex = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVarsta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNote = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVarsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(71, 28);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 23);
            this.tbCod.TabIndex = 1;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(71, 109);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 23);
            this.tbNume.TabIndex = 3;
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(24, 109);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(40, 15);
            this.Nume.TabIndex = 2;
            this.Nume.Text = "Nume";
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(71, 151);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(100, 23);
            this.tbVarsta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Varsta";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(71, 193);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(100, 23);
            this.tbNote.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sex";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxSex.Location = new System.Drawing.Point(71, 67);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(100, 23);
            this.comboBoxSex.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(96, 238);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(75, 23);
            this.btnShowList.TabIndex = 11;
            this.btnShowList.Text = "Show list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // errorProviderCod
            // 
            this.errorProviderCod.ContainerControl = this;
            // 
            // errorProviderSex
            // 
            this.errorProviderSex.ContainerControl = this;
            // 
            // errorProviderNume
            // 
            this.errorProviderNume.ContainerControl = this;
            // 
            // errorProviderVarsta
            // 
            this.errorProviderVarsta.ContainerControl = this;
            // 
            // errorProviderNote
            // 
            this.errorProviderNote.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 273);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVarsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbCod;
        private TextBox tbNume;
        private Label Nume;
        private TextBox tbVarsta;
        private Label label3;
        private TextBox tbNote;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private ComboBox comboBoxSex;
        private Button btnSave;
        private Button btnShowList;
        private ErrorProvider errorProviderCod;
        private ErrorProvider errorProviderSex;
        private ErrorProvider errorProviderNume;
        private ErrorProvider errorProviderVarsta;
        private ErrorProvider errorProviderNote;
    }
}