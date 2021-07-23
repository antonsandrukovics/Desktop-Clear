
namespace desktopClear.UserControls
{
    partial class SortingControl
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
            this.mainTitle = new System.Windows.Forms.Label();
            this.sortedFilesStorageTextbox = new System.Windows.Forms.TextBox();
            this.reviewBtn = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.Label();
            this.defaultBtn = new System.Windows.Forms.Button();
            this.furtherBtn = new System.Windows.Forms.Button();
            this.sortingControlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Uighur", 29.25F, System.Drawing.FontStyle.Bold);
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(-2, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(526, 123);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Выберите место хранения отсортированых файлов";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortedFilesStorageTextbox
            // 
            this.sortedFilesStorageTextbox.Location = new System.Drawing.Point(94, 240);
            this.sortedFilesStorageTextbox.Name = "sortedFilesStorageTextbox";
            this.sortedFilesStorageTextbox.Size = new System.Drawing.Size(352, 20);
            this.sortedFilesStorageTextbox.TabIndex = 1;
            // 
            // reviewBtn
            // 
            this.reviewBtn.Location = new System.Drawing.Point(332, 266);
            this.reviewBtn.Name = "reviewBtn";
            this.reviewBtn.Size = new System.Drawing.Size(114, 20);
            this.reviewBtn.TabIndex = 2;
            this.reviewBtn.Text = "Обзор...";
            this.reviewBtn.UseVisualStyleBackColor = true;
            this.reviewBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.ForeColor = System.Drawing.Color.White;
            this.descriptionText.Location = new System.Drawing.Point(117, 162);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(300, 75);
            this.descriptionText.TabIndex = 3;
            this.descriptionText.Text = "Выберите место на вашем диске для хранения отсортированых файлов. Место хранения " +
    "по умолчанию является папка \'Sorting Files\' на рабочем столе компьютера";
            this.descriptionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defaultBtn
            // 
            this.defaultBtn.Location = new System.Drawing.Point(94, 266);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(114, 20);
            this.defaultBtn.TabIndex = 4;
            this.defaultBtn.Text = "По умолчанию";
            this.defaultBtn.UseVisualStyleBackColor = true;
            this.defaultBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // furtherBtn
            // 
            this.furtherBtn.Location = new System.Drawing.Point(362, 337);
            this.furtherBtn.Name = "furtherBtn";
            this.furtherBtn.Size = new System.Drawing.Size(114, 20);
            this.furtherBtn.TabIndex = 5;
            this.furtherBtn.Text = "Далее";
            this.furtherBtn.UseVisualStyleBackColor = true;
            this.furtherBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // sortingControlPanel
            // 
            this.sortingControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortingControlPanel.Location = new System.Drawing.Point(0, 0);
            this.sortingControlPanel.Name = "sortingControlPanel";
            this.sortingControlPanel.Size = new System.Drawing.Size(527, 399);
            this.sortingControlPanel.TabIndex = 6;
            // 
            // SortingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.furtherBtn);
            this.Controls.Add(this.defaultBtn);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.reviewBtn);
            this.Controls.Add(this.sortedFilesStorageTextbox);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.sortingControlPanel);
            this.Name = "SortingControl";
            this.Size = new System.Drawing.Size(527, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.TextBox sortedFilesStorageTextbox;
        private System.Windows.Forms.Button reviewBtn;
        private System.Windows.Forms.Label descriptionText;
        private System.Windows.Forms.Button defaultBtn;
        private System.Windows.Forms.Button furtherBtn;
        private System.Windows.Forms.Panel sortingControlPanel;
    }
}
