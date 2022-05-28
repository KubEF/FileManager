namespace FileManager
{
    partial class FinderForm
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.regexTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(52, 25);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(612, 27);
            this.pathTextBox.TabIndex = 0;
            // 
            // regexTextBox
            // 
            this.regexTextBox.Location = new System.Drawing.Point(52, 83);
            this.regexTextBox.Name = "regexTextBox";
            this.regexTextBox.Size = new System.Drawing.Size(612, 27);
            this.regexTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(694, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 20;
            this.filesListBox.Location = new System.Drawing.Point(52, 133);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(736, 364);
            this.filesListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Путь папки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Регулярное выражение поиска:";
            // 
            // FinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.regexTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Name = "FinderForm";
            this.Text = "FinderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pathTextBox;
        private TextBox regexTextBox;
        private Button searchButton;
        private ListBox filesListBox;
        private Label label1;
        private Label label2;
    }
}