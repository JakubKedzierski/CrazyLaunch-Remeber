
namespace CrazyRL
{
    partial class DialogForm
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
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.statusTextBox = new MetroFramework.Controls.MetroTextBox();
            this.launchProviderLabel = new MetroFramework.Controls.MetroLabel();
            this.launchProviderTextBox = new MetroFramework.Controls.MetroTextBox();
            this.rocketLabel = new MetroFramework.Controls.MetroLabel();
            this.rocketTextBox = new MetroFramework.Controls.MetroTextBox();
            this.locationLabel = new MetroFramework.Controls.MetroLabel();
            this.locationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gmapsLocationLabel = new MetroFramework.Controls.MetroLabel();
            this.gmapsUrlTextBox = new MetroFramework.Controls.MetroTextBox();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(23, 82);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(404, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(23, 108);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(46, 19);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(23, 130);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(404, 23);
            this.statusTextBox.TabIndex = 3;
            // 
            // launchProviderLabel
            // 
            this.launchProviderLabel.AutoSize = true;
            this.launchProviderLabel.Location = new System.Drawing.Point(23, 156);
            this.launchProviderLabel.Name = "launchProviderLabel";
            this.launchProviderLabel.Size = new System.Drawing.Size(107, 19);
            this.launchProviderLabel.TabIndex = 4;
            this.launchProviderLabel.Text = "Launch provider:";
            // 
            // launchProviderTextBox
            // 
            this.launchProviderTextBox.Location = new System.Drawing.Point(23, 178);
            this.launchProviderTextBox.Name = "launchProviderTextBox";
            this.launchProviderTextBox.Size = new System.Drawing.Size(404, 23);
            this.launchProviderTextBox.TabIndex = 5;
            // 
            // rocketLabel
            // 
            this.rocketLabel.AutoSize = true;
            this.rocketLabel.Location = new System.Drawing.Point(23, 204);
            this.rocketLabel.Name = "rocketLabel";
            this.rocketLabel.Size = new System.Drawing.Size(51, 19);
            this.rocketLabel.TabIndex = 6;
            this.rocketLabel.Text = "Rocket:";
            // 
            // rocketTextBox
            // 
            this.rocketTextBox.Location = new System.Drawing.Point(23, 226);
            this.rocketTextBox.Name = "rocketTextBox";
            this.rocketTextBox.Size = new System.Drawing.Size(404, 23);
            this.rocketTextBox.TabIndex = 7;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(23, 252);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(61, 19);
            this.locationLabel.TabIndex = 8;
            this.locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(23, 274);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(404, 23);
            this.locationTextBox.TabIndex = 9;
            // 
            // gmapsLocationLabel
            // 
            this.gmapsLocationLabel.AutoSize = true;
            this.gmapsLocationLabel.Location = new System.Drawing.Point(23, 300);
            this.gmapsLocationLabel.Name = "gmapsLocationLabel";
            this.gmapsLocationLabel.Size = new System.Drawing.Size(160, 19);
            this.gmapsLocationLabel.TabIndex = 10;
            this.gmapsLocationLabel.Text = "Google Maps location url:";
            // 
            // gmapsUrlTextBox
            // 
            this.gmapsUrlTextBox.Location = new System.Drawing.Point(23, 322);
            this.gmapsUrlTextBox.Name = "gmapsUrlTextBox";
            this.gmapsUrlTextBox.Size = new System.Drawing.Size(404, 23);
            this.gmapsUrlTextBox.TabIndex = 11;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(23, 549);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(107, 28);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(320, 549);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 28);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.gmapsUrlTextBox);
            this.Controls.Add(this.gmapsLocationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.rocketTextBox);
            this.Controls.Add(this.rocketLabel);
            this.Controls.Add(this.launchProviderTextBox);
            this.Controls.Add(this.launchProviderLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForm";
            this.Resizable = false;
            this.Text = "Fill launch details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroTextBox statusTextBox;
        private MetroFramework.Controls.MetroLabel launchProviderLabel;
        private MetroFramework.Controls.MetroTextBox launchProviderTextBox;
        private MetroFramework.Controls.MetroLabel rocketLabel;
        private MetroFramework.Controls.MetroTextBox rocketTextBox;
        private MetroFramework.Controls.MetroLabel locationLabel;
        private MetroFramework.Controls.MetroTextBox locationTextBox;
        private MetroFramework.Controls.MetroLabel gmapsLocationLabel;
        private MetroFramework.Controls.MetroTextBox gmapsUrlTextBox;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroButton cancelButton;
    }
}