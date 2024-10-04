namespace WinFormsFileCopy
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
            panel1 = new Panel();
            chkRecursive = new CheckBox();
            cboFilter = new ComboBox();
            btnClose = new Button();
            btnCopy = new Button();
            button2 = new Button();
            btnSourceDir = new Button();
            cboDest = new ComboBox();
            cboSource = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chkRecursive);
            panel1.Controls.Add(cboFilter);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnCopy);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSourceDir);
            panel1.Controls.Add(cboDest);
            panel1.Controls.Add(cboSource);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 251);
            panel1.TabIndex = 0;
            // 
            // chkRecursive
            // 
            chkRecursive.AutoSize = true;
            chkRecursive.Location = new Point(465, 54);
            chkRecursive.Name = "chkRecursive";
            chkRecursive.Size = new Size(73, 19);
            chkRecursive.TabIndex = 10;
            chkRecursive.Text = "recursive";
            chkRecursive.UseVisualStyleBackColor = true;
            // 
            // cboFilter
            // 
            cboFilter.FormattingEnabled = true;
            cboFilter.Items.AddRange(new object[] { "*.*", "*.txt", "*.docx", "*.xlsx", "*.cs", "*cpp" });
            cboFilter.Location = new Point(612, 56);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(128, 23);
            cboFilter.TabIndex = 9;
            cboFilter.Text = "*.*";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(612, 170);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 23);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(612, 135);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(128, 23);
            btnCopy.TabIndex = 7;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // button2
            // 
            button2.Location = new Point(343, 135);
            button2.Name = "button2";
            button2.Size = new Size(35, 23);
            button2.TabIndex = 6;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSourceDir
            // 
            btnSourceDir.Location = new Point(343, 50);
            btnSourceDir.Name = "btnSourceDir";
            btnSourceDir.Size = new Size(35, 23);
            btnSourceDir.TabIndex = 5;
            btnSourceDir.Text = "...";
            btnSourceDir.UseVisualStyleBackColor = true;
            btnSourceDir.Click += btnSourceDir_Click;
            // 
            // cboDest
            // 
            cboDest.FormattingEnabled = true;
            cboDest.Items.AddRange(new object[] { "C:\\temp\\a", "C:\\temp\\b" });
            cboDest.Location = new Point(49, 135);
            cboDest.Name = "cboDest";
            cboDest.Size = new Size(288, 23);
            cboDest.TabIndex = 4;
            cboDest.Text = "C:\\temp\\b";
            cboDest.SelectedIndexChanged += cboDest_SelectedIndexChanged;
            // 
            // cboSource
            // 
            cboSource.FormattingEnabled = true;
            cboSource.Items.AddRange(new object[] { "C:\\temp\\a", "C:\\temp\\b" });
            cboSource.Location = new Point(49, 51);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(288, 23);
            cboSource.TabIndex = 3;
            cboSource.Text = "C:\\temp\\a";
            cboSource.SelectedIndexChanged += cboSource_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 33);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Filter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 98);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Source";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 251);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(800, 199);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WindowsFormsFileCopy";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkRecursive;
        private ComboBox cboFilter;
        private Button btnClose;
        private Button btnCopy;
        private Button button2;
        private Button btnSourceDir;
        private ComboBox cboDest;
        private ComboBox cboSource;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
