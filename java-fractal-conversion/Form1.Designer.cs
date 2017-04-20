using System.Windows.Forms;

namespace java_fractal_conversion
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colourPaletteTitle = new System.Windows.Forms.Label();
            this.colourPaletteRed = new System.Windows.Forms.Button();
            this.colourPaletteOrange = new System.Windows.Forms.Button();
            this.colourPaletteTurquoise = new System.Windows.Forms.Button();
            this.colourPaletteYellow = new System.Windows.Forms.Button();
            this.colourPaletteGreen = new System.Windows.Forms.Button();
            this.colourPaletteBlue = new System.Windows.Forms.Button();
            this.colourPalettePurple = new System.Windows.Forms.Button();
            this.colourPaletteLabel = new System.Windows.Forms.Label();
            this.checkBoxColourCycle = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(49, 44);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(640, 480);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseEnter += new System.EventHandler(this.picture_MouseEnter);
            this.picture.MouseLeave += new System.EventHandler(this.picture_MouseLeave);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStateToolStripMenuItem,
            this.loadStateToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "State";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveStateToolStripMenuItem
            // 
            this.saveStateToolStripMenuItem.Name = "saveStateToolStripMenuItem";
            this.saveStateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveStateToolStripMenuItem.Text = "Save State";
            this.saveStateToolStripMenuItem.Click += new System.EventHandler(this.saveStateToolStripMenuItem_Click);
            // 
            // loadStateToolStripMenuItem
            // 
            this.loadStateToolStripMenuItem.Name = "loadStateToolStripMenuItem";
            this.loadStateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.loadStateToolStripMenuItem.Text = "Load State";
            this.loadStateToolStripMenuItem.Click += new System.EventHandler(this.loadStateToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // colourPaletteTitle
            // 
            this.colourPaletteTitle.AutoSize = true;
            this.colourPaletteTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.colourPaletteTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.colourPaletteTitle.Location = new System.Drawing.Point(708, 60);
            this.colourPaletteTitle.Name = "colourPaletteTitle";
            this.colourPaletteTitle.Size = new System.Drawing.Size(108, 21);
            this.colourPaletteTitle.TabIndex = 6;
            this.colourPaletteTitle.Text = "Colour Palette";
            // 
            // colourPaletteRed
            // 
            this.colourPaletteRed.BackColor = System.Drawing.Color.Red;
            this.colourPaletteRed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteRed.Location = new System.Drawing.Point(712, 122);
            this.colourPaletteRed.Name = "colourPaletteRed";
            this.colourPaletteRed.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteRed.TabIndex = 8;
            this.colourPaletteRed.UseVisualStyleBackColor = false;
            this.colourPaletteRed.Click += new System.EventHandler(this.colourPaletteRed_Click);
            this.colourPaletteRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteRed.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteRed.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteOrange
            // 
            this.colourPaletteOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.colourPaletteOrange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteOrange.Location = new System.Drawing.Point(746, 122);
            this.colourPaletteOrange.Name = "colourPaletteOrange";
            this.colourPaletteOrange.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteOrange.TabIndex = 9;
            this.colourPaletteOrange.UseVisualStyleBackColor = false;
            this.colourPaletteOrange.Click += new System.EventHandler(this.colourPaletteOrange_Click);
            this.colourPaletteOrange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteOrange.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteOrange.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteTurquoise
            // 
            this.colourPaletteTurquoise.BackColor = System.Drawing.Color.Turquoise;
            this.colourPaletteTurquoise.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteTurquoise.Location = new System.Drawing.Point(712, 155);
            this.colourPaletteTurquoise.Name = "colourPaletteTurquoise";
            this.colourPaletteTurquoise.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteTurquoise.TabIndex = 10;
            this.colourPaletteTurquoise.UseVisualStyleBackColor = false;
            this.colourPaletteTurquoise.Click += new System.EventHandler(this.colourPaletteTurquoise_Click);
            this.colourPaletteTurquoise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteTurquoise.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteTurquoise.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteYellow
            // 
            this.colourPaletteYellow.BackColor = System.Drawing.Color.Yellow;
            this.colourPaletteYellow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteYellow.Location = new System.Drawing.Point(816, 122);
            this.colourPaletteYellow.Name = "colourPaletteYellow";
            this.colourPaletteYellow.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteYellow.TabIndex = 11;
            this.colourPaletteYellow.UseVisualStyleBackColor = false;
            this.colourPaletteYellow.Click += new System.EventHandler(this.colourPaletteYellow_Click);
            this.colourPaletteYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteYellow.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteYellow.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteGreen
            // 
            this.colourPaletteGreen.BackColor = System.Drawing.Color.LawnGreen;
            this.colourPaletteGreen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteGreen.Location = new System.Drawing.Point(782, 122);
            this.colourPaletteGreen.Name = "colourPaletteGreen";
            this.colourPaletteGreen.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteGreen.TabIndex = 12;
            this.colourPaletteGreen.Text = " ";
            this.colourPaletteGreen.UseVisualStyleBackColor = false;
            this.colourPaletteGreen.Click += new System.EventHandler(this.colourPaletteGreen_Click);
            this.colourPaletteGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteGreen.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteGreen.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteBlue
            // 
            this.colourPaletteBlue.BackColor = System.Drawing.Color.Blue;
            this.colourPaletteBlue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteBlue.Location = new System.Drawing.Point(746, 156);
            this.colourPaletteBlue.Name = "colourPaletteBlue";
            this.colourPaletteBlue.Size = new System.Drawing.Size(28, 28);
            this.colourPaletteBlue.TabIndex = 13;
            this.colourPaletteBlue.UseVisualStyleBackColor = false;
            this.colourPaletteBlue.Click += new System.EventHandler(this.colourPaletteBlue_Click);
            this.colourPaletteBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPaletteBlue.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPaletteBlue.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPalettePurple
            // 
            this.colourPalettePurple.BackColor = System.Drawing.Color.Purple;
            this.colourPalettePurple.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPalettePurple.Location = new System.Drawing.Point(782, 156);
            this.colourPalettePurple.Name = "colourPalettePurple";
            this.colourPalettePurple.Size = new System.Drawing.Size(28, 28);
            this.colourPalettePurple.TabIndex = 14;
            this.colourPalettePurple.UseVisualStyleBackColor = false;
            this.colourPalettePurple.Click += new System.EventHandler(this.colourPalettePurple_Click);
            this.colourPalettePurple.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colourPalette_MouseClick);
            this.colourPalettePurple.MouseEnter += new System.EventHandler(this.colourPalette_MouseEnter);
            this.colourPalettePurple.MouseLeave += new System.EventHandler(this.colourPalette_MouseLeave);
            // 
            // colourPaletteLabel
            // 
            this.colourPaletteLabel.AutoSize = true;
            this.colourPaletteLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colourPaletteLabel.ForeColor = System.Drawing.Color.Black;
            this.colourPaletteLabel.Location = new System.Drawing.Point(708, 90);
            this.colourPaletteLabel.Name = "colourPaletteLabel";
            this.colourPaletteLabel.Size = new System.Drawing.Size(134, 19);
            this.colourPaletteLabel.TabIndex = 16;
            this.colourPaletteLabel.Text = "Selected Colour: Red";
            // 
            // checkBoxColourCycle
            // 
            this.checkBoxColourCycle.AutoSize = true;
            this.checkBoxColourCycle.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxColourCycle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxColourCycle.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxColourCycle.Location = new System.Drawing.Point(820, 223);
            this.checkBoxColourCycle.Name = "checkBoxColourCycle";
            this.checkBoxColourCycle.Padding = new System.Windows.Forms.Padding(5);
            this.checkBoxColourCycle.Size = new System.Drawing.Size(25, 24);
            this.checkBoxColourCycle.TabIndex = 18;
            this.checkBoxColourCycle.UseVisualStyleBackColor = false;
            this.checkBoxColourCycle.CheckedChanged += new System.EventHandler(this.checkBoxColourCycle_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(709, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Colour Cycle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1071, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.colourPaletteLabel);
            this.Controls.Add(this.colourPalettePurple);
            this.Controls.Add(this.colourPaletteBlue);
            this.Controls.Add(this.colourPaletteGreen);
            this.Controls.Add(this.colourPaletteYellow);
            this.Controls.Add(this.colourPaletteTurquoise);
            this.Controls.Add(this.colourPaletteOrange);
            this.Controls.Add(this.colourPaletteRed);
            this.Controls.Add(this.colourPaletteTitle);
            this.Controls.Add(this.checkBoxColourCycle);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveStateToolStripMenuItem;
        private ToolStripMenuItem loadStateToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label colourPaletteTitle;
        private System.Windows.Forms.Button colourPaletteRed;
        private System.Windows.Forms.Button colourPaletteOrange;
        private System.Windows.Forms.Button colourPaletteTurquoise;
        private System.Windows.Forms.Button colourPaletteYellow;
        private System.Windows.Forms.Button colourPaletteGreen;
        private System.Windows.Forms.Button colourPaletteBlue;
        private System.Windows.Forms.Button colourPalettePurple;
        private System.Windows.Forms.Label colourPaletteLabel;
        private System.Windows.Forms.CheckBox checkBoxColourCycle;
        private System.Windows.Forms.Timer timer;
        private Label label2;
    }
}

