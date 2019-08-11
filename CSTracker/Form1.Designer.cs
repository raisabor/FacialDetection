namespace CSTracker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.imgCamUser = new Emgu.CV.UI.ImageBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtXYRadius = new System.Windows.Forms.RichTextBox();
            this.ButtonPauseOrResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamUser)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCamUser
            // 
            this.imgCamUser.Location = new System.Drawing.Point(106, 36);
            this.imgCamUser.Name = "imgCamUser";
            this.imgCamUser.Size = new System.Drawing.Size(712, 395);
            this.imgCamUser.TabIndex = 2;
            this.imgCamUser.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtXYRadius
            // 
            this.txtXYRadius.Location = new System.Drawing.Point(570, 469);
            this.txtXYRadius.Name = "txtXYRadius";
            this.txtXYRadius.Size = new System.Drawing.Size(248, 96);
            this.txtXYRadius.TabIndex = 5;
            this.txtXYRadius.Text = "";
            // 
            // ButtonPauseOrResume
            // 
            this.ButtonPauseOrResume.Location = new System.Drawing.Point(106, 514);
            this.ButtonPauseOrResume.Name = "ButtonPauseOrResume";
            this.ButtonPauseOrResume.Size = new System.Drawing.Size(92, 36);
            this.ButtonPauseOrResume.TabIndex = 6;
            this.ButtonPauseOrResume.Text = "pause";
            this.ButtonPauseOrResume.UseVisualStyleBackColor = true;
            this.ButtonPauseOrResume.Click += new System.EventHandler(this.ButtonPauseOrResume_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1103, 621);
            this.Controls.Add(this.ButtonPauseOrResume);
            this.Controls.Add(this.txtXYRadius);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imgCamUser);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCamUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private Emgu.CV.UI.ImageBox imgCamUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtXYRadius;
        private System.Windows.Forms.Button ButtonPauseOrResume;
    }
}

