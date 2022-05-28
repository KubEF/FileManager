namespace FileManager
{
    partial class DownloadForm
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
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.newFileNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonCancelDownload = new System.Windows.Forms.Button();
            this.timePassed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(12, 42);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(498, 27);
            this.linkTextBox.TabIndex = 0;
            // 
            // newFileNameTextBox
            // 
            this.newFileNameTextBox.Location = new System.Drawing.Point(12, 152);
            this.newFileNameTextBox.Name = "newFileNameTextBox";
            this.newFileNameTextBox.Size = new System.Drawing.Size(501, 27);
            this.newFileNameTextBox.TabIndex = 1;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(416, 101);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(94, 29);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Скачать";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonCancelDownload
            // 
            this.buttonCancelDownload.Location = new System.Drawing.Point(416, 194);
            this.buttonCancelDownload.Name = "buttonCancelDownload";
            this.buttonCancelDownload.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelDownload.TabIndex = 3;
            this.buttonCancelDownload.Text = "Отмена";
            this.buttonCancelDownload.UseVisualStyleBackColor = true;
            this.buttonCancelDownload.Click += new System.EventHandler(this.buttonCanselDownload_Click);
            // 
            // timePassed
            // 
            this.timePassed.AutoSize = true;
            this.timePassed.Location = new System.Drawing.Point(12, 9);
            this.timePassed.Name = "timePassed";
            this.timePassed.Size = new System.Drawing.Size(50, 20);
            this.timePassed.TabIndex = 4;
            this.timePassed.Text = "label1";
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 243);
            this.Controls.Add(this.timePassed);
            this.Controls.Add(this.buttonCancelDownload);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.newFileNameTextBox);
            this.Controls.Add(this.linkTextBox);
            this.Name = "DownloadForm";
            this.Text = "DownloadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox linkTextBox;
        private TextBox newFileNameTextBox;
        private Button buttonDownload;
        private Button buttonCancelDownload;
        private Label timePassed;
    }
}