namespace Bacon
{
    partial class Help_Encode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_Encode));
            this.T_Help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // T_Help
            // 
            this.T_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.T_Help.Location = new System.Drawing.Point(5, 3);
            this.T_Help.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.T_Help.Multiline = true;
            this.T_Help.Name = "T_Help";
            this.T_Help.ReadOnly = true;
            this.T_Help.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.T_Help.Size = new System.Drawing.Size(579, 473);
            this.T_Help.TabIndex = 27;
            this.T_Help.TabStop = false;
            this.T_Help.Text = resources.GetString("T_Help.Text");
            // 
            // Help_Encode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 488);
            this.Controls.Add(this.T_Help);
            this.Name = "Help_Encode";
            this.Text = "Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_Help;
    }
}