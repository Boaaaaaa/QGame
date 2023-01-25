namespace BimQGame
{
    partial class DesignForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.picNone = new System.Windows.Forms.PictureBox();
            this.picWall = new System.Windows.Forms.PictureBox();
            this.picRedDoor = new System.Windows.Forms.PictureBox();
            this.picGreenDoor = new System.Windows.Forms.PictureBox();
            this.picRedBox = new System.Windows.Forms.PictureBox();
            this.picGreenBox = new System.Windows.Forms.PictureBox();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.txtColumns);
            this.panel1.Controls.Add(this.txtRows);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(398, 13);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(251, 17);
            this.txtColumns.Margin = new System.Windows.Forms.Padding(2);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(121, 20);
            this.txtColumns.TabIndex = 3;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(68, 17);
            this.txtRows.Margin = new System.Windows.Forms.Padding(2);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(111, 20);
            this.txtRows.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columns:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 76);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(136, 465);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toolbox";
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(14, 132);
            this.btnNone.Margin = new System.Windows.Forms.Padding(2);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(106, 43);
            this.btnNone.TabIndex = 5;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.ToolboxClick);
            // 
            // btnWall
            // 
            this.btnWall.Location = new System.Drawing.Point(14, 186);
            this.btnWall.Margin = new System.Windows.Forms.Padding(2);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(106, 43);
            this.btnWall.TabIndex = 6;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.ToolboxClick);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Location = new System.Drawing.Point(14, 241);
            this.btnRedDoor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(106, 43);
            this.btnRedDoor.TabIndex = 7;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.ToolboxClick);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Location = new System.Drawing.Point(14, 297);
            this.btnGreenDoor.Margin = new System.Windows.Forms.Padding(2);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(106, 43);
            this.btnGreenDoor.TabIndex = 8;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.ToolboxClick);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Location = new System.Drawing.Point(14, 353);
            this.btnRedBox.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(106, 43);
            this.btnRedBox.TabIndex = 9;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.ToolboxClick);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Location = new System.Drawing.Point(14, 409);
            this.btnGreenBox.Margin = new System.Windows.Forms.Padding(2);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(106, 43);
            this.btnGreenBox.TabIndex = 10;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.ToolboxClick);
            // 
            // picNone
            // 
            this.picNone.Location = new System.Drawing.Point(16, 134);
            this.picNone.Margin = new System.Windows.Forms.Padding(2);
            this.picNone.Name = "picNone";
            this.picNone.Size = new System.Drawing.Size(38, 39);
            this.picNone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNone.TabIndex = 11;
            this.picNone.TabStop = false;
            // 
            // picWall
            // 
            this.picWall.Location = new System.Drawing.Point(16, 188);
            this.picWall.Margin = new System.Windows.Forms.Padding(2);
            this.picWall.Name = "picWall";
            this.picWall.Size = new System.Drawing.Size(38, 39);
            this.picWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall.TabIndex = 12;
            this.picWall.TabStop = false;
            // 
            // picRedDoor
            // 
            this.picRedDoor.Location = new System.Drawing.Point(16, 243);
            this.picRedDoor.Margin = new System.Windows.Forms.Padding(2);
            this.picRedDoor.Name = "picRedDoor";
            this.picRedDoor.Size = new System.Drawing.Size(38, 39);
            this.picRedDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedDoor.TabIndex = 13;
            this.picRedDoor.TabStop = false;
            // 
            // picGreenDoor
            // 
            this.picGreenDoor.Location = new System.Drawing.Point(16, 299);
            this.picGreenDoor.Margin = new System.Windows.Forms.Padding(2);
            this.picGreenDoor.Name = "picGreenDoor";
            this.picGreenDoor.Size = new System.Drawing.Size(38, 39);
            this.picGreenDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenDoor.TabIndex = 14;
            this.picGreenDoor.TabStop = false;
            // 
            // picRedBox
            // 
            this.picRedBox.Location = new System.Drawing.Point(16, 355);
            this.picRedBox.Margin = new System.Windows.Forms.Padding(2);
            this.picRedBox.Name = "picRedBox";
            this.picRedBox.Size = new System.Drawing.Size(38, 39);
            this.picRedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedBox.TabIndex = 15;
            this.picRedBox.TabStop = false;
            // 
            // picGreenBox
            // 
            this.picGreenBox.Location = new System.Drawing.Point(16, 411);
            this.picGreenBox.Margin = new System.Windows.Forms.Padding(2);
            this.picGreenBox.Name = "picGreenBox";
            this.picGreenBox.Size = new System.Drawing.Size(38, 39);
            this.picGreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenBox.TabIndex = 16;
            this.picGreenBox.TabStop = false;
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 548);
            this.Controls.Add(this.picGreenBox);
            this.Controls.Add(this.picRedBox);
            this.Controls.Add(this.picGreenDoor);
            this.Controls.Add(this.picRedDoor);
            this.Controls.Add(this.picWall);
            this.Controls.Add(this.picNone);
            this.Controls.Add(this.btnGreenBox);
            this.Controls.Add(this.btnRedBox);
            this.Controls.Add(this.btnGreenDoor);
            this.Controls.Add(this.btnRedDoor);
            this.Controls.Add(this.btnWall);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DesignForm";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.PictureBox picNone;
        private System.Windows.Forms.PictureBox picWall;
        private System.Windows.Forms.PictureBox picRedDoor;
        private System.Windows.Forms.PictureBox picGreenDoor;
        private System.Windows.Forms.PictureBox picRedBox;
        private System.Windows.Forms.PictureBox picGreenBox;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}