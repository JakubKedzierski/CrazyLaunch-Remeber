
namespace CrazyRL
{
    partial class MapForm
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
            this.padLocationMap = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // padLocationMap
            // 
            this.padLocationMap.Location = new System.Drawing.Point(23, 63);
            this.padLocationMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.padLocationMap.Name = "padLocationMap";
            this.padLocationMap.ScriptErrorsSuppressed = true;
            this.padLocationMap.Size = new System.Drawing.Size(754, 514);
            this.padLocationMap.TabIndex = 2;
            this.padLocationMap.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.padLocationMap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapForm";
            this.Resizable = false;
            this.Text = "Launch location map";
            this.Load += new System.EventHandler(this.MapForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser padLocationMap;
    }
}