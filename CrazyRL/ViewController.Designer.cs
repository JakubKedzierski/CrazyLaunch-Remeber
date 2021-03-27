
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
            this.allLaunchesList = new System.Windows.Forms.ListView();
            this.updateProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.updateFromWebButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.exportButton = new MetroFramework.Controls.MetroButton();
            this.importButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.removeButton = new MetroFramework.Controls.MetroButton();
            this.detailsBox = new System.Windows.Forms.GroupBox();
            this.tableOfDetails = new System.Windows.Forms.TableLayoutPanel();
            this.launchTimerLabel = new MetroFramework.Controls.MetroLabel();
            this.launchNameLab = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.launchProvLab = new System.Windows.Forms.Label();
            this.rocketLabel = new System.Windows.Forms.Label();
            this.launchNameDetail = new System.Windows.Forms.Label();
            this.tabsControl.SuspendLayout();
            this.tabPageAll.SuspendLayout();
            this.detailsBox.SuspendLayout();
            this.tableOfDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabsControl.Controls.Add(this.tabPageFav);
            this.tabsControl.Controls.Add(this.tabPageAll);
            this.tabsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabsControl.Location = new System.Drawing.Point(23, 63);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 1;
            this.tabsControl.Size = new System.Drawing.Size(500, 600);
            this.tabsControl.TabIndex = 0;
            // 
            // tabPageFav
            // 
            this.tabPageFav.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageFav.HorizontalScrollbarBarColor = true;
            this.tabPageFav.Location = new System.Drawing.Point(4, 38);
            this.tabPageFav.Name = "tabPageFav";
            this.tabPageFav.Size = new System.Drawing.Size(492, 558);
            this.tabPageFav.TabIndex = 0;
            this.tabPageFav.Text = "Favourite launches";
            this.tabPageFav.VerticalScrollbarBarColor = true;
            // 
            // tabPageAll
            // 
            this.tabPageAll.Controls.Add(this.allLaunchesList);
            this.tabPageAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageAll.HorizontalScrollbarBarColor = true;
            this.tabPageAll.Location = new System.Drawing.Point(4, 38);
            this.tabPageAll.Name = "tabPageAll";
            this.tabPageAll.Size = new System.Drawing.Size(492, 558);
            this.tabPageAll.TabIndex = 1;
            this.tabPageAll.Text = "All launches";
            this.tabPageAll.VerticalScrollbarBarColor = true;
            // 
            // allLaunchesList
            // 
            this.allLaunchesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allLaunchesList.HideSelection = false;
            this.allLaunchesList.Location = new System.Drawing.Point(0, 3);
            this.allLaunchesList.Name = "allLaunchesList";
            this.allLaunchesList.Size = new System.Drawing.Size(492, 552);
            this.allLaunchesList.TabIndex = 2;
            this.allLaunchesList.UseCompatibleStateImageBehavior = false;
            this.allLaunchesList.SelectedIndexChanged += new System.EventHandler(this.allLaunchesList_SelectedIndexChanged);

            // 
            // updateProgressBar
            // 
            this.updateProgressBar.Location = new System.Drawing.Point(27, 669);
            this.updateProgressBar.Name = "updateProgressBar";
            this.updateProgressBar.Size = new System.Drawing.Size(498, 23);
            this.updateProgressBar.TabIndex = 1;
            // 
            // updateFromWebButton
            // 
            this.updateFromWebButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateFromWebButton.Location = new System.Drawing.Point(27, 698);
            this.updateFromWebButton.Name = "updateFromWebButton";
            this.updateFromWebButton.Size = new System.Drawing.Size(120, 28);
            this.updateFromWebButton.TabIndex = 2;
            this.updateFromWebButton.Text = "Update from web";
            this.updateFromWebButton.Click += new System.EventHandler(this.updateFromWebButton_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(153, 698);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 28);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add launch";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportButton.Location = new System.Drawing.Point(27, 732);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(120, 28);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importButton.Location = new System.Drawing.Point(153, 732);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(120, 28);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // editButton
            // 
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(279, 698);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 28);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit launch";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(405, 698);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(120, 28);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove launch";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.Controls.Add(this.tableOfDetails);
            this.detailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.detailsBox.Location = new System.Drawing.Point(529, 63);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(472, 600);
            this.detailsBox.TabIndex = 8;
            this.detailsBox.TabStop = false;
            this.detailsBox.Text = "Launch Details";
            // 
            // tableOfDetails
            // 
            this.tableOfDetails.ColumnCount = 2;
            this.tableOfDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableOfDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.5F));
            this.tableOfDetails.Controls.Add(this.launchNameLab, 0, 0);
            this.tableOfDetails.Controls.Add(this.statusLabel, 0, 1);
            this.tableOfDetails.Controls.Add(this.launchProvLab, 0, 2);
            this.tableOfDetails.Controls.Add(this.rocketLabel, 0, 3);
            this.tableOfDetails.Controls.Add(this.launchNameDetail, 1, 0);
            this.tableOfDetails.Location = new System.Drawing.Point(37, 93);
            this.tableOfDetails.Name = "tableOfDetails";
            this.tableOfDetails.RowCount = 5;
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.94521F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.05479F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOfDetails.Size = new System.Drawing.Size(429, 263);
            this.tableOfDetails.TabIndex = 0;
            this.tableOfDetails.Visible = false;
            // 
            // launchTimerLabel
            // 
            this.launchTimerLabel.AutoSize = true;
            this.launchTimerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.launchTimerLabel.Location = new System.Drawing.Point(566, 701);
            this.launchTimerLabel.Name = "launchTimerLabel";
            this.launchTimerLabel.Size = new System.Drawing.Size(121, 25);
            this.launchTimerLabel.TabIndex = 9;
            this.launchTimerLabel.Text = "Launch timer: ";
            // 
            // launchNameLab
            // 
            this.launchNameLab.AutoSize = true;
            this.launchNameLab.Location = new System.Drawing.Point(3, 0);
            this.launchNameLab.Name = "launchNameLab";
            this.launchNameLab.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.launchNameLab.Size = new System.Drawing.Size(86, 25);
            this.launchNameLab.TabIndex = 0;
            this.launchNameLab.Text = "Launch name:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 54);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.statusLabel.Size = new System.Drawing.Size(44, 25);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status:";
            // 
            // launchProvLab
            // 
            this.launchProvLab.AutoSize = true;
            this.launchProvLab.Location = new System.Drawing.Point(3, 112);
            this.launchProvLab.Name = "launchProvLab";
            this.launchProvLab.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.launchProvLab.Size = new System.Drawing.Size(98, 25);
            this.launchProvLab.TabIndex = 2;
            this.launchProvLab.Text = "Launch provider:";
            // 
            // rocketLabel
            // 
            this.rocketLabel.AutoSize = true;
            this.rocketLabel.Location = new System.Drawing.Point(3, 177);
            this.rocketLabel.Name = "rocketLabel";
            this.rocketLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.rocketLabel.Size = new System.Drawing.Size(99, 25);
            this.rocketLabel.TabIndex = 3;
            this.rocketLabel.Text = "Rocket full name";
            // 
            // launchNameDetail
            // 
            this.launchNameDetail.AutoSize = true;
            this.launchNameDetail.Location = new System.Drawing.Point(206, 0);
            this.launchNameDetail.Name = "launchNameDetail";
            this.launchNameDetail.Size = new System.Drawing.Size(7, 30);
            this.launchNameDetail.TabIndex = 4;
            this.launchNameDetail.Text = "\r\n\r\n";
            // 
            // ViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.launchTimerLabel);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateFromWebButton);
            this.Controls.Add(this.updateProgressBar);
            this.Controls.Add(this.tabsControl);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ViewController";
            this.Resizable = false;
            this.Text = "Crazy Launch Remember";
            this.Load += new System.EventHandler(this.ViewController_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewController_KeyDown);
            this.tabsControl.ResumeLayout(false);
            this.tabPageAll.ResumeLayout(false);
            this.detailsBox.ResumeLayout(false);
            this.tableOfDetails.ResumeLayout(false);
            this.tableOfDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabsControl;
        private MetroFramework.Controls.MetroTabPage tabPageFav;
        private MetroFramework.Controls.MetroTabPage tabPageAll;
        private MetroFramework.Controls.MetroProgressBar updateProgressBar;
        private MetroFramework.Controls.MetroButton updateFromWebButton;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton exportButton;
        private MetroFramework.Controls.MetroButton importButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton removeButton;
        private System.Windows.Forms.GroupBox detailsBox;
        private MetroFramework.Controls.MetroLabel launchTimerLabel;
        private System.Windows.Forms.ListView allLaunchesList;
        private System.Windows.Forms.TableLayoutPanel tableOfDetails;
        private System.Windows.Forms.Label launchNameLab;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label launchProvLab;
        private System.Windows.Forms.Label rocketLabel;
        private System.Windows.Forms.Label launchNameDetail;
    }
}