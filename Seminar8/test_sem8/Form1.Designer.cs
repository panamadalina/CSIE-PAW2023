namespace test_sem8
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            scumbaCuloareaToolStripMenuItem = new ToolStripMenuItem();
            construiesteGraficToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            saveGraficToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ContextMenuStrip = contextMenuStrip1;
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { construiesteGraficToolStripMenuItem, printPreviewToolStripMenuItem, saveGraficToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { scumbaCuloareaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(271, 78);
            // 
            // scumbaCuloareaToolStripMenuItem
            // 
            scumbaCuloareaToolStripMenuItem.Name = "scumbaCuloareaToolStripMenuItem";
            scumbaCuloareaToolStripMenuItem.Size = new Size(270, 36);
            scumbaCuloareaToolStripMenuItem.Text = "Scumba culoarea";
            //scumbaCuloareaToolStripMenuItem.Click += scumbaCuloareaToolStripMenuItem_Click;
            // 
            // construiesteGraficToolStripMenuItem
            // 
            construiesteGraficToolStripMenuItem.Name = "construiesteGraficToolStripMenuItem";
            construiesteGraficToolStripMenuItem.Size = new Size(204, 34);
            construiesteGraficToolStripMenuItem.Text = "Construieste grafic";
            construiesteGraficToolStripMenuItem.Click += construiesteGraficToolStripMenuItem_Click;
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(151, 34);
            printPreviewToolStripMenuItem.Text = "Print preview";
            //printPreviewToolStripMenuItem.Click += printPreviewToolStripMenuItem_Click;
            // 
            // saveGraficToolStripMenuItem
            // 
            saveGraficToolStripMenuItem.Name = "saveGraficToolStripMenuItem";
            saveGraficToolStripMenuItem.Size = new Size(134, 34);
            saveGraficToolStripMenuItem.Text = "Save Grafic";
            //saveGraficToolStripMenuItem.Click += saveGraficToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 412);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem construiesteGraficToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripMenuItem saveGraficToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem scumbaCuloareaToolStripMenuItem;
        private Panel panel1;
    }
}