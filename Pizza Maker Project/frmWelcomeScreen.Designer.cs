namespace Pizza_Maker_Project
{
    partial class frmWelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcomeScreen));
            this.btnOpenScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenScreen
            // 
            this.btnOpenScreen.BackColor = System.Drawing.Color.Tomato;
            this.btnOpenScreen.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenScreen.Location = new System.Drawing.Point(405, 12);
            this.btnOpenScreen.Name = "btnOpenScreen";
            this.btnOpenScreen.Size = new System.Drawing.Size(246, 91);
            this.btnOpenScreen.TabIndex = 0;
            this.btnOpenScreen.Text = "Make Order";
            this.btnOpenScreen.UseVisualStyleBackColor = false;
            this.btnOpenScreen.Click += new System.EventHandler(this.btnOpenScreen_Click);
            // 
            // frmWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.btnOpenScreen);
            this.Name = "frmWelcomeScreen";
            this.Text = "Welcome Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenScreen;
    }
}

