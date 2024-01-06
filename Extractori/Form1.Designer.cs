using Extractori.toiminnot;

namespace Extractori
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
            button1 = new Button();
            button3 = new Button();
            listaLoota = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button5 = new Button();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            setDefaultOutputPathToolStripMenuItem = new ToolStripMenuItem();
            setDefaultInputPathToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(38, 430);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(304, 50);
            button1.TabIndex = 0;
            button1.Text = "Add Files";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(429, 430);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(304, 50);
            button3.TabIndex = 2;
            button3.Text = "Remove File";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listaLoota
            // 
            listaLoota.FormattingEnabled = true;
            listaLoota.ItemHeight = 15;
            listaLoota.Location = new Point(38, 28);
            listaLoota.Margin = new Padding(4, 3, 4, 3);
            listaLoota.Name = "listaLoota";
            listaLoota.Size = new Size(677, 304);
            listaLoota.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, -1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Selected files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 340);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 7;
            label2.Text = "Current output folder: C:\\";
            // 
            // button2
            // 
            button2.Location = new Point(38, 378);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(304, 46);
            button2.TabIndex = 8;
            button2.Text = "Select Output Path";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(749, 28);
            button5.Name = "button5";
            button5.Size = new Size(172, 452);
            button5.TabIndex = 10;
            button5.Text = "Extract selected";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(429, 378);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(304, 46);
            progressBar1.TabIndex = 11;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 14;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(933, 25);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { setDefaultOutputPathToolStripMenuItem, setDefaultInputPathToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 22);
            toolStripDropDownButton1.Text = "Set default paths";
            // 
            // setDefaultOutputPathToolStripMenuItem
            // 
            setDefaultOutputPathToolStripMenuItem.Name = "setDefaultOutputPathToolStripMenuItem";
            setDefaultOutputPathToolStripMenuItem.Size = new Size(196, 22);
            setDefaultOutputPathToolStripMenuItem.Text = "Set default output path";
            setDefaultOutputPathToolStripMenuItem.Click += setDefaultOutputPathToolStripMenuItem_Click;
            // 
            // setDefaultInputPathToolStripMenuItem
            // 
            setDefaultInputPathToolStripMenuItem.Name = "setDefaultInputPathToolStripMenuItem";
            setDefaultInputPathToolStripMenuItem.Size = new Size(196, 22);
            setDefaultInputPathToolStripMenuItem.Text = "Set default input path";
            setDefaultInputPathToolStripMenuItem.Click += setDefaultInputPathToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(548, 340);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 15;
            label4.Text = "Progress bar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label4);
            Controls.Add(toolStrip1);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listaLoota);
            Controls.Add(button3);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "ZipRarExtractor";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listaLoota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private Button button5;
        private ProgressBar progressBar1;
        private Label label3;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem setDefaultOutputPathToolStripMenuItem;
        private ToolStripMenuItem setDefaultInputPathToolStripMenuItem;
        private Label label4;
    }
}

