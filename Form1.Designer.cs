namespace ToDoList
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
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            nouToolStripMenuItem = new ToolStripMenuItem();
            deschideToolStripMenuItem = new ToolStripMenuItem();
            salvareToolStripMenuItem = new ToolStripMenuItem();
            salvareCaToolStripMenuItem = new ToolStripMenuItem();
            iesireToolStripMenuItem = new ToolStripMenuItem();
            editareToolStripMenuItem = new ToolStripMenuItem();
            adaugaSarcinaToolStripMenuItem = new ToolStripMenuItem();
            editatiSarcinaToolStripMenuItem = new ToolStripMenuItem();
            stergetiSarcinaToolStripMenuItem = new ToolStripMenuItem();
            ajutorToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            Numele = new Label();
            textBox4 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            despreToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 364);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, editareToolStripMenuItem, ajutorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(575, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouToolStripMenuItem, deschideToolStripMenuItem, salvareToolStripMenuItem, salvareCaToolStripMenuItem, iesireToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(57, 24);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // nouToolStripMenuItem
            // 
            nouToolStripMenuItem.Name = "nouToolStripMenuItem";
            nouToolStripMenuItem.Size = new Size(224, 26);
            nouToolStripMenuItem.Text = "Nou";
            nouToolStripMenuItem.Click += nouToolStripMenuItem_Click;
            // 
            // deschideToolStripMenuItem
            // 
            deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            deschideToolStripMenuItem.Size = new Size(224, 26);
            deschideToolStripMenuItem.Text = "Deschide";
            deschideToolStripMenuItem.Click += deschidereToolStripMenuItem_Click;
            // 
            // salvareToolStripMenuItem
            // 
            salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            salvareToolStripMenuItem.Size = new Size(224, 26);
            salvareToolStripMenuItem.Text = "Salvare";
            salvareToolStripMenuItem.Click += salvareToolStripMenuItem_Click;
            // 
            // salvareCaToolStripMenuItem
            // 
            salvareCaToolStripMenuItem.Name = "salvareCaToolStripMenuItem";
            salvareCaToolStripMenuItem.Size = new Size(224, 26);
            salvareCaToolStripMenuItem.Text = "Salvare ca";
            salvareCaToolStripMenuItem.Click += salvareCaToolStripMenuItem_Click;
            // 
            // iesireToolStripMenuItem
            // 
            iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            iesireToolStripMenuItem.Size = new Size(224, 26);
            iesireToolStripMenuItem.Text = "Iesire";
            iesireToolStripMenuItem.Click += iesireToolStripMenuItem_Click;
            // 
            // editareToolStripMenuItem
            // 
            editareToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaSarcinaToolStripMenuItem, editatiSarcinaToolStripMenuItem, stergetiSarcinaToolStripMenuItem });
            editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            editareToolStripMenuItem.Size = new Size(70, 24);
            editareToolStripMenuItem.Text = "Editare";
            // 
            // adaugaSarcinaToolStripMenuItem
            // 
            adaugaSarcinaToolStripMenuItem.Name = "adaugaSarcinaToolStripMenuItem";
            adaugaSarcinaToolStripMenuItem.Size = new Size(224, 26);
            adaugaSarcinaToolStripMenuItem.Text = "Adauga Sarcina";
            adaugaSarcinaToolStripMenuItem.Click += adaugaSarcinaToolStripMenuItem_Click;
            // 
            // editatiSarcinaToolStripMenuItem
            // 
            editatiSarcinaToolStripMenuItem.Name = "editatiSarcinaToolStripMenuItem";
            editatiSarcinaToolStripMenuItem.Size = new Size(224, 26);
            editatiSarcinaToolStripMenuItem.Text = "Editati Sarcina";
            editatiSarcinaToolStripMenuItem.Click += editatiSarcinaToolStripMenuItem_Click;
            // 
            // stergetiSarcinaToolStripMenuItem
            // 
            stergetiSarcinaToolStripMenuItem.Name = "stergetiSarcinaToolStripMenuItem";
            stergetiSarcinaToolStripMenuItem.Size = new Size(224, 26);
            stergetiSarcinaToolStripMenuItem.Text = "Stergeti Sarcina";
            stergetiSarcinaToolStripMenuItem.Click += sterToolStripMenuItem_Click;
            // 
            // ajutorToolStripMenuItem
            // 
            ajutorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despreToolStripMenuItem });
            ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            ajutorToolStripMenuItem.Size = new Size(64, 24);
            ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(428, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // Numele
            // 
            Numele.AutoSize = true;
            Numele.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Numele.Location = new Point(445, 71);
            Numele.Name = "Numele";
            Numele.Size = new Size(93, 30);
            Numele.TabIndex = 3;
            Numele.Text = "Numele";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(221, 182);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(332, 142);
            textBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(443, 149);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 5;
            label1.Text = "Descriere";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(428, 330);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // despreToolStripMenuItem
            // 
            despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            despreToolStripMenuItem.Size = new Size(224, 26);
            despreToolStripMenuItem.Text = "Despre";
            despreToolStripMenuItem.Click += despreToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(221, 385);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 7;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(444, 385);
            button2.Name = "button2";
            button2.Size = new Size(109, 40);
            button2.TabIndex = 8;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 38);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Fisier:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 38);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 13;
            label6.Text = "label6";
            label6.Visible = false;
            label6.TextChanged += label6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 453);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(Numele);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem nouToolStripMenuItem;
        private ToolStripMenuItem deschideToolStripMenuItem;
        private ToolStripMenuItem salvareToolStripMenuItem;
        private ToolStripMenuItem salvareCaToolStripMenuItem;
        private ToolStripMenuItem iesireToolStripMenuItem;
        private ToolStripMenuItem editareToolStripMenuItem;
        private ToolStripMenuItem adaugaSarcinaToolStripMenuItem;
        private ToolStripMenuItem editatiSarcinaToolStripMenuItem;
        private ToolStripMenuItem stergetiSarcinaToolStripMenuItem;
        private ToolStripMenuItem ajutorToolStripMenuItem;
        private TextBox textBox1;
        private Label Numele;
        private TextBox textBox4;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem despreToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
    }
}