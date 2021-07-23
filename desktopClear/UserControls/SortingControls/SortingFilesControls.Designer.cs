
namespace desktopClear.UserControls.SortingControls
{
    partial class SortingFilesControls
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
            this.label1 = new System.Windows.Forms.Label();
            this.sortinglistView = new System.Windows.Forms.ListView();
            this.folderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extensionsFilesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Форматы файлов";
            // 
            // sortinglistView
            // 
            this.sortinglistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.folderName,
            this.extension});
            this.sortinglistView.HideSelection = false;
            this.sortinglistView.LabelEdit = true;
            this.sortinglistView.Location = new System.Drawing.Point(261, 29);
            this.sortinglistView.Name = "sortinglistView";
            this.sortinglistView.Size = new System.Drawing.Size(255, 351);
            this.sortinglistView.TabIndex = 2;
            this.sortinglistView.UseCompatibleStateImageBehavior = false;
            this.sortinglistView.View = System.Windows.Forms.View.Details;
            // 
            // folderName
            // 
            this.folderName.Text = "Название папки";
            this.folderName.Width = 150;
            // 
            // extension
            // 
            this.extension.Text = "Формат файлов";
            this.extension.Width = 100;
            // 
            // extensionsFilesCheckedListBox
            // 
            this.extensionsFilesCheckedListBox.CheckOnClick = true;
            this.extensionsFilesCheckedListBox.FormattingEnabled = true;
            this.extensionsFilesCheckedListBox.Location = new System.Drawing.Point(11, 31);
            this.extensionsFilesCheckedListBox.Name = "extensionsFilesCheckedListBox";
            this.extensionsFilesCheckedListBox.Size = new System.Drawing.Size(110, 349);
            this.extensionsFilesCheckedListBox.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(133, 191);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(116, 30);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 159);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите из списка элементов форматы которые вы хотите сгрупировать и нажмите кно" +
    "пку \"Добавить\", после создастстся папка под названием \"Новая папка\", название мо" +
    "жно помянять в самой таблице";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сортировочные папки";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(133, 270);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 30);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.Location = new System.Drawing.Point(130, 349);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(122, 30);
            this.sortBtn.TabIndex = 11;
            this.sortBtn.Text = "Сортировать";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SortingFilesControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.extensionsFilesCheckedListBox);
            this.Controls.Add(this.sortinglistView);
            this.Controls.Add(this.label1);
            this.Name = "SortingFilesControls";
            this.Size = new System.Drawing.Size(527, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView sortinglistView;
        private System.Windows.Forms.ColumnHeader folderName;
        private System.Windows.Forms.ColumnHeader extension;
        private System.Windows.Forms.CheckedListBox extensionsFilesCheckedListBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button sortBtn;
    }
}
