
namespace desktopClear
{
    partial class FolderSelectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChoseDirectory = new System.Windows.Forms.Button();
            this.textBoxDirectoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 55);
            this.button3.TabIndex = 21;
            this.button3.Text = "Сохранить выбранные элементы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Удалить выбранный элемент";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Выделить все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(42, 112);
            this.checkedListBox1.MaximumSize = new System.Drawing.Size(171, 319);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(171, 259);
            this.checkedListBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 47);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выберете папку для работы";
            // 
            // buttonChoseDirectory
            // 
            this.buttonChoseDirectory.Location = new System.Drawing.Point(421, 75);
            this.buttonChoseDirectory.Name = "buttonChoseDirectory";
            this.buttonChoseDirectory.Size = new System.Drawing.Size(56, 20);
            this.buttonChoseDirectory.TabIndex = 16;
            this.buttonChoseDirectory.Text = "Обзор...";
            this.buttonChoseDirectory.UseVisualStyleBackColor = true;
            this.buttonChoseDirectory.Click += new System.EventHandler(this.buttonChoseDirectory_Click);
            // 
            // textBoxDirectoryName
            // 
            this.textBoxDirectoryName.Location = new System.Drawing.Point(42, 75);
            this.textBoxDirectoryName.Name = "textBoxDirectoryName";
            this.textBoxDirectoryName.Size = new System.Drawing.Size(373, 20);
            this.textBoxDirectoryName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 118);
            this.label2.TabIndex = 22;
            this.label2.Text = "Отметьте файлы которые остануться неизменными и не будут участвовать в сортировке" +
    " и сохраните выбранные элементы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolderSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoseDirectory);
            this.Controls.Add(this.textBoxDirectoryName);
            this.Name = "FolderSelectionControl";
            this.Size = new System.Drawing.Size(527, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChoseDirectory;
        private System.Windows.Forms.TextBox textBoxDirectoryName;
        private System.Windows.Forms.Label label2;
    }
}
