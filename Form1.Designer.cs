namespace Paint
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
            this.RedL = new System.Windows.Forms.Label();
            this.BlueL = new System.Windows.Forms.Label();
            this.GreenL = new System.Windows.Forms.Label();
            this.RedTB = new System.Windows.Forms.TrackBar();
            this.BlueTB = new System.Windows.Forms.TrackBar();
            this.GreenTB = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.AlphaL = new System.Windows.Forms.Label();
            this.AlphaTB = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.EraserTB = new System.Windows.Forms.Button();
            this.Penbt = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaTB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RedL
            // 
            this.RedL.AutoSize = true;
            this.RedL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedL.Location = new System.Drawing.Point(821, 266);
            this.RedL.Name = "RedL";
            this.RedL.Size = new System.Drawing.Size(64, 25);
            this.RedL.TabIndex = 3;
            this.RedL.Text = "label1";
            // 
            // BlueL
            // 
            this.BlueL.AutoSize = true;
            this.BlueL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueL.Location = new System.Drawing.Point(821, 308);
            this.BlueL.Name = "BlueL";
            this.BlueL.Size = new System.Drawing.Size(64, 25);
            this.BlueL.TabIndex = 4;
            this.BlueL.Text = "label2";
            // 
            // GreenL
            // 
            this.GreenL.AutoSize = true;
            this.GreenL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenL.Location = new System.Drawing.Point(821, 361);
            this.GreenL.Name = "GreenL";
            this.GreenL.Size = new System.Drawing.Size(64, 25);
            this.GreenL.TabIndex = 5;
            this.GreenL.Text = "label3";
            // 
            // RedTB
            // 
            this.RedTB.Location = new System.Drawing.Point(921, 266);
            this.RedTB.Maximum = 255;
            this.RedTB.Name = "RedTB";
            this.RedTB.Size = new System.Drawing.Size(255, 56);
            this.RedTB.TabIndex = 6;
            this.RedTB.Tag = "";
            this.RedTB.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.RedTB.ValueChanged += new System.EventHandler(this.RedTB_ValueChanged);
            // 
            // BlueTB
            // 
            this.BlueTB.Location = new System.Drawing.Point(921, 308);
            this.BlueTB.Maximum = 255;
            this.BlueTB.Name = "BlueTB";
            this.BlueTB.Size = new System.Drawing.Size(255, 56);
            this.BlueTB.TabIndex = 7;
            this.BlueTB.Scroll += new System.EventHandler(this.BlueTB_Scroll);
            this.BlueTB.ValueChanged += new System.EventHandler(this.RedTB_ValueChanged);
            // 
            // GreenTB
            // 
            this.GreenTB.Location = new System.Drawing.Point(921, 361);
            this.GreenTB.Maximum = 255;
            this.GreenTB.Name = "GreenTB";
            this.GreenTB.Size = new System.Drawing.Size(255, 56);
            this.GreenTB.TabIndex = 8;
            this.GreenTB.Scroll += new System.EventHandler(this.GreenTB_Scroll);
            this.GreenTB.ValueChanged += new System.EventHandler(this.RedTB_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 31);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.newCanvasToolStripMenuItem,
            this.toolStripSeparator1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(46, 27);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveToolStripMenuItem1_Click);
            // 
            // newCanvasToolStripMenuItem
            // 
            this.newCanvasToolStripMenuItem.Name = "newCanvasToolStripMenuItem";
            this.newCanvasToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.newCanvasToolStripMenuItem.Text = "New Canvas";
            this.newCanvasToolStripMenuItem.Click += new System.EventHandler(this.NewCanvasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Image = global::Paint.Properties.Resources.wheel_of_color;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 27);
            this.toolStripMenuItem1.Text = "Custom color";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // AlphaL
            // 
            this.AlphaL.AutoSize = true;
            this.AlphaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphaL.Location = new System.Drawing.Point(821, 411);
            this.AlphaL.Name = "AlphaL";
            this.AlphaL.Size = new System.Drawing.Size(64, 25);
            this.AlphaL.TabIndex = 10;
            this.AlphaL.Text = "label1";
            // 
            // AlphaTB
            // 
            this.AlphaTB.Location = new System.Drawing.Point(921, 411);
            this.AlphaTB.Maximum = 255;
            this.AlphaTB.Name = "AlphaTB";
            this.AlphaTB.Size = new System.Drawing.Size(255, 56);
            this.AlphaTB.TabIndex = 11;
            this.AlphaTB.Scroll += new System.EventHandler(this.AlphaTB_Scroll);
            this.AlphaTB.ValueChanged += new System.EventHandler(this.RedTB_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.EraserTB);
            this.groupBox1.Controls.Add(this.Penbt);
            this.groupBox1.Location = new System.Drawing.Point(818, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 119);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(29, 79);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // EraserTB
            // 
            this.EraserTB.Location = new System.Drawing.Point(116, 31);
            this.EraserTB.Name = "EraserTB";
            this.EraserTB.Size = new System.Drawing.Size(84, 31);
            this.EraserTB.TabIndex = 14;
            this.EraserTB.Text = "Eraser";
            this.EraserTB.UseVisualStyleBackColor = true;
            this.EraserTB.Click += new System.EventHandler(this.LineBT_Click);
            // 
            // Penbt
            // 
            this.Penbt.Location = new System.Drawing.Point(17, 31);
            this.Penbt.Name = "Penbt";
            this.Penbt.Size = new System.Drawing.Size(84, 31);
            this.Penbt.TabIndex = 13;
            this.Penbt.Text = "Pen";
            this.Penbt.UseVisualStyleBackColor = true;
            this.Penbt.Click += new System.EventHandler(this.Penbt_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(921, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 164);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(60, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 623);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AlphaTB);
            this.Controls.Add(this.AlphaL);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GreenTB);
            this.Controls.Add(this.BlueTB);
            this.Controls.Add(this.RedTB);
            this.Controls.Add(this.GreenL);
            this.Controls.Add(this.BlueL);
            this.Controls.Add(this.RedL);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaTB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label RedL;
        private System.Windows.Forms.Label BlueL;
        private System.Windows.Forms.Label GreenL;
        private System.Windows.Forms.TrackBar RedTB;
        private System.Windows.Forms.TrackBar BlueTB;
        private System.Windows.Forms.TrackBar GreenTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label AlphaL;
        private System.Windows.Forms.TrackBar AlphaTB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newCanvasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button EraserTB;
        private System.Windows.Forms.Button Penbt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

