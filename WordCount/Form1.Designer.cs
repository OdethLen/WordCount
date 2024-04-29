namespace WordCount
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
            btnOpen = new Button();
            txtDocument = new TextBox();
            lblLargestWord = new Label();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(215, 35);
            btnOpen.Name = "btnOpen";
            btnOpen.RightToLeft = RightToLeft.Yes;
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open ";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtDocument
            // 
            txtDocument.Location = new Point(51, 85);
            txtDocument.Multiline = true;
            txtDocument.Name = "txtDocument";
            txtDocument.ReadOnly = true;
            txtDocument.Size = new Size(424, 150);
            txtDocument.TabIndex = 1;
            // 
            // lblLargestWord
            // 
            lblLargestWord.AutoSize = true;
            lblLargestWord.Location = new Point(252, 254);
            lblLargestWord.Name = "lblLargestWord";
            lblLargestWord.Size = new Size(16, 15);
            lblLargestWord.TabIndex = 2;
            lblLargestWord.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 289);
            Controls.Add(lblLargestWord);
            Controls.Add(txtDocument);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private TextBox txtDocument;
        private Label lblLargestWord;
    }
}
