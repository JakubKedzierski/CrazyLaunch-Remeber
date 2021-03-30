namespace CrazyRL
{
    partial class LaunchAlert
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
            this.msgLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.launchwindtext = new System.Windows.Forms.Label();
            this.launchDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msgLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.msgLabel.Location = new System.Drawing.Point(132, 9);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(134, 23);
            this.msgLabel.TabIndex = 0;
            this.msgLabel.Text = "Launch Alert";
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::CrazyRL.Properties.Resources.icons8_close_window_50px;
            this.closeButton.Location = new System.Drawing.Point(353, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(49, 44);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // launchwindtext
            // 
            this.launchwindtext.AutoSize = true;
            this.launchwindtext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.launchwindtext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.launchwindtext.Location = new System.Drawing.Point(51, 82);
            this.launchwindtext.Name = "launchwindtext";
            this.launchwindtext.Size = new System.Drawing.Size(318, 21);
            this.launchwindtext.TabIndex = 3;
            this.launchwindtext.Text = "Launch window starts within 15 minutes";
            // 
            // launchDetail
            // 
            this.launchDetail.AutoSize = true;
            this.launchDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.launchDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.launchDetail.Location = new System.Drawing.Point(70, 48);
            this.launchDetail.Name = "launchDetail";
            this.launchDetail.Size = new System.Drawing.Size(0, 21);
            this.launchDetail.TabIndex = 4;
            // 
            // LaunchAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(404, 122);
            this.Controls.Add(this.launchDetail);
            this.Controls.Add(this.launchwindtext);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.msgLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LaunchAlert";
            this.Text = "LaunchAlert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label launchwindtext;
        private System.Windows.Forms.Label launchDetail;
    }
}