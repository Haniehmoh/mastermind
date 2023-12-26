namespace GRAPHIQUE
{
    partial class Menu
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
            this.playBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Magenta;
            this.playBtn.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(650, 304);
            this.playBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(280, 170);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Jouer";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.playBtn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Menu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
    }
}