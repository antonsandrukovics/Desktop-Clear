
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
            this.saveSelectedItemsBtn = new System.Windows.Forms.Button();
            this.deleteSelectedObjectBtn = new System.Windows.Forms.Button();
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.filesNamesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.сhoseDirectoryBtn = new System.Windows.Forms.Button();
            this.textBoxDirectoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveSelectedItemsBtn
            // 
            this.saveSelectedItemsBtn.Location = new System.Drawing.Point(312, 316);
            this.saveSelectedItemsBtn.Name = "saveSelectedItemsBtn";
            this.saveSelectedItemsBtn.Size = new System.Drawing.Size(164, 55);
            this.saveSelectedItemsBtn.TabIndex = 21;
            this.saveSelectedItemsBtn.Text = "Сохранить выбранные элементы";
            this.saveSelectedItemsBtn.UseVisualStyleBackColor = true;
            this.saveSelectedItemsBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteSelectedObjectBtn
            // 
            this.deleteSelectedObjectBtn.Location = new System.Drawing.Point(312, 141);
            this.deleteSelectedObjectBtn.Name = "deleteSelectedObjectBtn";
            this.deleteSelectedObjectBtn.Size = new System.Drawing.Size(164, 38);
            this.deleteSelectedObjectBtn.TabIndex = 20;
            this.deleteSelectedObjectBtn.Text = "Удалить выбранный элемент";
            this.deleteSelectedObjectBtn.UseVisualStyleBackColor = true;
            this.deleteSelectedObjectBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Location = new System.Drawing.Point(312, 112);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(165, 23);
            this.selectAllBtn.TabIndex = 19;
            this.selectAllBtn.Text = "Выделить все";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // filesNamesCheckedListBox
            // 
            this.filesNamesCheckedListBox.CheckOnClick = true;
            this.filesNamesCheckedListBox.FormattingEnabled = true;
            this.filesNamesCheckedListBox.Location = new System.Drawing.Point(42, 112);
            this.filesNamesCheckedListBox.MaximumSize = new System.Drawing.Size(171, 319);
            this.filesNamesCheckedListBox.Name = "filesNamesCheckedListBox";
            this.filesNamesCheckedListBox.Size = new System.Drawing.Size(171, 259);
            this.filesNamesCheckedListBox.TabIndex = 18;
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
            // сhoseDirectoryBtn
            // 
            this.сhoseDirectoryBtn.Location = new System.Drawing.Point(421, 75);
            this.сhoseDirectoryBtn.Name = "сhoseDirectoryBtn";
            this.сhoseDirectoryBtn.Size = new System.Drawing.Size(56, 20);
            this.сhoseDirectoryBtn.TabIndex = 16;
            this.сhoseDirectoryBtn.Text = "Обзор...";
            this.сhoseDirectoryBtn.UseVisualStyleBackColor = true;
            this.сhoseDirectoryBtn.Click += new System.EventHandler(this.buttonChoseDirectory_Click);
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
            this.Controls.Add(this.saveSelectedItemsBtn);
            this.Controls.Add(this.deleteSelectedObjectBtn);
            this.Controls.Add(this.selectAllBtn);
            this.Controls.Add(this.filesNamesCheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.сhoseDirectoryBtn);
            this.Controls.Add(this.textBoxDirectoryName);
            this.Name = "FolderSelectionControl";
            this.Size = new System.Drawing.Size(527, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveSelectedItemsBtn;
        private System.Windows.Forms.Button deleteSelectedObjectBtn;
        private System.Windows.Forms.Button selectAllBtn;
        protected System.Windows.Forms.CheckedListBox filesNamesCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button сhoseDirectoryBtn;
        private System.Windows.Forms.TextBox textBoxDirectoryName;
        private System.Windows.Forms.Label label2;
    }
}
