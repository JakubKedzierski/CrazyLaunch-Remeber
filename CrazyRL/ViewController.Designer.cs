
namespace CrazyRL
{
    partial class ViewController
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
            this.tabsControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPageFav = new MetroFramework.Controls.MetroTabPage();
            this.tabPageAll = new MetroFramework.Controls.MetroTabPage();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.updateFromWebButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.exportButton = new MetroFramework.Controls.MetroButton();
            this.importButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.removeButton = new MetroFramework.Controls.MetroButton();
            this.tabsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabPageFav);
            this.tabsControl.Controls.Add(this.tabPageAll);
            this.tabsControl.Location = new System.Drawing.Point(23, 63);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(500, 600);
            this.tabsControl.TabIndex = 0;
            // 
            // tabPageFav
            // 
            this.tabPageFav.HorizontalScrollbarBarColor = true;
            this.tabPageFav.Location = new System.Drawing.Point(4, 35);
            this.tabPageFav.Name = "tabPageFav";
            this.tabPageFav.Size = new System.Drawing.Size(492, 561);
            this.tabPageFav.TabIndex = 0;
            this.tabPageFav.Text = "Favourite launches";
            this.tabPageFav.VerticalScrollbarBarColor = true;
            // 
            // tabPageAll
            // 
            this.tabPageAll.HorizontalScrollbarBarColor = true;
            this.tabPageAll.Location = new System.Drawing.Point(4, 35);
            this.tabPageAll.Name = "tabPageAll";
            this.tabPageAll.Size = new System.Drawing.Size(492, 561);
            this.tabPageAll.TabIndex = 1;
            this.tabPageAll.Text = "All launches";
            this.tabPageAll.VerticalScrollbarBarColor = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(27, 669);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(462, 23);
            this.metroProgressBar1.TabIndex = 1;
            // 
            // updateFromWebButton
            // 
            this.updateFromWebButton.Location = new System.Drawing.Point(23, 698);
            this.updateFromWebButton.Name = "updateFromWebButton";
            this.updateFromWebButton.Size = new System.Drawing.Size(112, 28);
            this.updateFromWebButton.TabIndex = 2;
            this.updateFromWebButton.Text = "Update from web";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(141, 698);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 28);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add launch";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(23, 732);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(112, 28);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(141, 732);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(112, 28);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(259, 698);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 28);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit launch";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(377, 698);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(112, 28);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove launch";
            // 
            // ViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateFromWebButton);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.tabsControl);
            this.Name = "ViewController";
            this.Text = "Crazy Launch Remember";
            this.tabsControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabsControl;
        private MetroFramework.Controls.MetroTabPage tabPageFav;
        private MetroFramework.Controls.MetroTabPage tabPageAll;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton updateFromWebButton;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton exportButton;
        private MetroFramework.Controls.MetroButton importButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton removeButton;
    }
}