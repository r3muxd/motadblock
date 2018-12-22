namespace motadblock
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
            this.enableButton = new System.Windows.Forms.Button();
            this.disableButton = new System.Windows.Forms.Button();
            this.statusTextBefore = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableButton
            // 
            this.enableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enableButton.Location = new System.Drawing.Point(12, 39);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(468, 200);
            this.enableButton.TabIndex = 0;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // disableButton
            // 
            this.disableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.disableButton.Location = new System.Drawing.Point(12, 245);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(468, 200);
            this.disableButton.TabIndex = 1;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // statusTextBefore
            // 
            this.statusTextBefore.AutoSize = true;
            this.statusTextBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statusTextBefore.Location = new System.Drawing.Point(12, 13);
            this.statusTextBefore.Name = "statusTextBefore";
            this.statusTextBefore.Size = new System.Drawing.Size(154, 26);
            this.statusTextBefore.TabIndex = 2;
            this.statusTextBefore.Text = "Current status:";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statusText.ForeColor = System.Drawing.Color.Red;
            this.statusText.Location = new System.Drawing.Point(172, 13);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(305, 26);
            this.statusText.TabIndex = 3;
            this.statusText.Text = "FUCKED - CAN\'T READ FILE";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(492, 457);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.statusTextBefore);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "motdadblock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Label statusTextBefore;
        private System.Windows.Forms.Label statusText;
    }
}

