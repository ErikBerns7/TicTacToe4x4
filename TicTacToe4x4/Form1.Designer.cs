namespace TicTacToe4x4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            neuesSpielToolStripMenuItem = new ToolStripMenuItem();
            spielVerlassenToolStripMenuItem = new ToolStripMenuItem();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            C4 = new Button();
            B4 = new Button();
            A4 = new Button();
            D4 = new Button();
            D3 = new Button();
            D2 = new Button();
            D1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(343, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuesSpielToolStripMenuItem, spielVerlassenToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(46, 20);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuesSpielToolStripMenuItem
            // 
            neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            neuesSpielToolStripMenuItem.Size = new Size(150, 22);
            neuesSpielToolStripMenuItem.Text = "Neues Spiel";
            // 
            // spielVerlassenToolStripMenuItem
            // 
            spielVerlassenToolStripMenuItem.Name = "spielVerlassenToolStripMenuItem";
            spielVerlassenToolStripMenuItem.Size = new Size(150, 22);
            spielVerlassenToolStripMenuItem.Text = "Spiel Verlassen";
            spielVerlassenToolStripMenuItem.Click += spielVerlassenToolStripMenuItem_Click;
            // 
            // A1
            // 
            A1.BackColor = SystemColors.Control;
            A1.Location = new Point(13, 83);
            A1.Name = "A1";
            A1.Size = new Size(75, 75);
            A1.TabIndex = 1;
            A1.UseVisualStyleBackColor = false;
            A1.Click += knopf_klick;
            // 
            // A2
            // 
            A2.BackColor = SystemColors.Control;
            A2.Location = new Point(94, 83);
            A2.Name = "A2";
            A2.Size = new Size(75, 75);
            A2.TabIndex = 2;
            A2.UseVisualStyleBackColor = false;
            A2.Click += knopf_klick;
            // 
            // A3
            // 
            A3.BackColor = SystemColors.Control;
            A3.Location = new Point(175, 83);
            A3.Name = "A3";
            A3.Size = new Size(75, 75);
            A3.TabIndex = 3;
            A3.UseVisualStyleBackColor = false;
            A3.Click += knopf_klick;
            // 
            // B1
            // 
            B1.BackColor = SystemColors.Control;
            B1.Location = new Point(13, 164);
            B1.Name = "B1";
            B1.Size = new Size(75, 75);
            B1.TabIndex = 4;
            B1.UseVisualStyleBackColor = false;
            B1.Click += knopf_klick;
            // 
            // B2
            // 
            B2.BackColor = SystemColors.Control;
            B2.Location = new Point(94, 164);
            B2.Name = "B2";
            B2.Size = new Size(75, 75);
            B2.TabIndex = 5;
            B2.UseVisualStyleBackColor = false;
            B2.Click += knopf_klick;
            // 
            // B3
            // 
            B3.BackColor = SystemColors.Control;
            B3.Location = new Point(175, 164);
            B3.Name = "B3";
            B3.Size = new Size(75, 75);
            B3.TabIndex = 6;
            B3.UseVisualStyleBackColor = false;
            B3.Click += knopf_klick;
            // 
            // C1
            // 
            C1.BackColor = SystemColors.Control;
            C1.Location = new Point(13, 245);
            C1.Name = "C1";
            C1.Size = new Size(75, 75);
            C1.TabIndex = 7;
            C1.UseVisualStyleBackColor = false;
            C1.Click += knopf_klick;
            // 
            // C2
            // 
            C2.BackColor = SystemColors.Control;
            C2.Location = new Point(94, 245);
            C2.Name = "C2";
            C2.Size = new Size(75, 75);
            C2.TabIndex = 8;
            C2.UseVisualStyleBackColor = false;
            C2.Click += knopf_klick;
            // 
            // C3
            // 
            C3.BackColor = SystemColors.Control;
            C3.Location = new Point(175, 245);
            C3.Name = "C3";
            C3.Size = new Size(75, 75);
            C3.TabIndex = 9;
            C3.UseVisualStyleBackColor = false;
            C3.Click += knopf_klick;
            // 
            // C4
            // 
            C4.BackColor = SystemColors.Control;
            C4.Location = new Point(256, 245);
            C4.Name = "C4";
            C4.Size = new Size(75, 75);
            C4.TabIndex = 12;
            C4.UseVisualStyleBackColor = false;
            C4.Click += knopf_klick;
            // 
            // B4
            // 
            B4.BackColor = SystemColors.Control;
            B4.Location = new Point(256, 164);
            B4.Name = "B4";
            B4.Size = new Size(75, 75);
            B4.TabIndex = 11;
            B4.UseVisualStyleBackColor = false;
            B4.Click += knopf_klick;
            // 
            // A4
            // 
            A4.BackColor = SystemColors.Control;
            A4.Location = new Point(256, 83);
            A4.Name = "A4";
            A4.Size = new Size(75, 75);
            A4.TabIndex = 10;
            A4.UseVisualStyleBackColor = false;
            A4.Click += knopf_klick;
            // 
            // D4
            // 
            D4.BackColor = SystemColors.Control;
            D4.Location = new Point(256, 326);
            D4.Name = "D4";
            D4.Size = new Size(75, 75);
            D4.TabIndex = 16;
            D4.UseVisualStyleBackColor = false;
            D4.Click += knopf_klick;
            // 
            // D3
            // 
            D3.BackColor = SystemColors.Control;
            D3.Location = new Point(175, 326);
            D3.Name = "D3";
            D3.Size = new Size(75, 75);
            D3.TabIndex = 15;
            D3.UseVisualStyleBackColor = false;
            D3.Click += knopf_klick;
            // 
            // D2
            // 
            D2.BackColor = SystemColors.Control;
            D2.Location = new Point(94, 326);
            D2.Name = "D2";
            D2.Size = new Size(75, 75);
            D2.TabIndex = 14;
            D2.UseVisualStyleBackColor = false;
            D2.Click += knopf_klick;
            // 
            // D1
            // 
            D1.BackColor = SystemColors.Control;
            D1.Location = new Point(13, 326);
            D1.Name = "D1";
            D1.Size = new Size(75, 75);
            D1.TabIndex = 13;
            D1.UseVisualStyleBackColor = false;
            D1.Click += knopf_klick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 403);
            Controls.Add(D4);
            Controls.Add(D3);
            Controls.Add(D2);
            Controls.Add(D1);
            Controls.Add(C4);
            Controls.Add(B4);
            Controls.Add(A4);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe4x4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuesSpielToolStripMenuItem;
        private ToolStripMenuItem spielVerlassenToolStripMenuItem;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button C4;
        private Button B4;
        private Button A4;
        private Button D4;
        private Button D3;
        private Button D2;
        private Button D1;
    }
}
