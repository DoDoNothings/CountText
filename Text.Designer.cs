
namespace CountText
{
    partial class Text
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text));
            this.progressBarText = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownlooad = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // progressBarText
            // 
            this.progressBarText.Location = new System.Drawing.Point(41, 274);
            this.progressBarText.Maximum = 40;
            this.progressBarText.Name = "progressBarText";
            this.progressBarText.Size = new System.Drawing.Size(697, 29);
            this.progressBarText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст";
            // 
            // btnDownlooad
            // 
            this.btnDownlooad.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownlooad.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDownlooad.Location = new System.Drawing.Point(222, 341);
            this.btnDownlooad.Name = "btnDownlooad";
            this.btnDownlooad.Size = new System.Drawing.Size(380, 46);
            this.btnDownlooad.TabIndex = 3;
            this.btnDownlooad.Text = "Загрузить";
            this.btnDownlooad.UseVisualStyleBackColor = true;
            this.btnDownlooad.Click += new System.EventHandler(this.btnDownlooad_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(41, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(697, 187);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDownlooad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarText);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Text";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownlooad;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}