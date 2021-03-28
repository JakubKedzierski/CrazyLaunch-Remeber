
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
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rocketColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wStartTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.updateFromWebButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.exportButton = new MetroFramework.Controls.MetroButton();
            this.importButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.removeButton = new MetroFramework.Controls.MetroButton();
            this.detailsBox = new System.Windows.Forms.GroupBox();
            this.launchTimerLabel = new MetroFramework.Controls.MetroLabel();
            this.showMapButton = new MetroFramework.Controls.MetroButton();
            this.favouriteCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.tableOfDetails = new System.Windows.Forms.TableLayoutPanel();
            this.windowStartDetail = new System.Windows.Forms.Label();
            this.launchNameLab = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.launchProvLab = new System.Windows.Forms.Label();
            this.rocketLabel = new System.Windows.Forms.Label();
            this.launchNameDetail = new System.Windows.Forms.Label();
            this.statusLabelDetail = new System.Windows.Forms.Label();
            this.launchProviderLabelDetail = new System.Windows.Forms.Label();
            this.rocketFullLabelDetail = new System.Windows.Forms.Label();
            this.launchPadLabel = new System.Windows.Forms.Label();
            this.launchPadLocDetail = new System.Windows.Forms.Label();
            this.t0label = new System.Windows.Forms.Label();
            this.windowEndDetail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.allLaunchesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.nameColumn,
            this.rocketColumn,
            this.wStartTimeColumn});
            this.allLaunchesList.FullRowSelect = true;
            this.allLaunchesList.GridLines = true;
            this.allLaunchesList.HideSelection = false;
            this.allLaunchesList.Location = new System.Drawing.Point(0, 3);
            this.allLaunchesList.Name = "allLaunchesList";
            this.allLaunchesList.Size = new System.Drawing.Size(492, 552);
            this.allLaunchesList.TabIndex = 2;
            this.allLaunchesList.UseCompatibleStateImageBehavior = false;
            this.allLaunchesList.View = System.Windows.Forms.View.Details;
            this.allLaunchesList.SelectedIndexChanged += new System.EventHandler(this.allLaunchesList_SelectedIndexChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // rocketColumn
            // 
            this.rocketColumn.Text = "Rocket";
            // 
            // wStartTimeColumn
            // 
            this.wStartTimeColumn.Text = "Window start time";
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
            this.detailsBox.Controls.Add(this.launchTimerLabel);
            this.detailsBox.Controls.Add(this.showMapButton);
            this.detailsBox.Controls.Add(this.favouriteCheckBox);
            this.detailsBox.Controls.Add(this.tableOfDetails);
            this.detailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.detailsBox.Location = new System.Drawing.Point(529, 63);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(472, 600);
            this.detailsBox.TabIndex = 8;
            this.detailsBox.TabStop = false;
            this.detailsBox.Text = "Launch Details";
            this.detailsBox.Visible = false;
            // 
            // launchTimerLabel
            // 
            this.launchTimerLabel.AccessibleName = "";
            this.launchTimerLabel.AutoSize = true;
            this.launchTimerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.launchTimerLabel.Location = new System.Drawing.Point(37, 543);
            this.launchTimerLabel.Name = "launchTimerLabel";
            this.launchTimerLabel.Size = new System.Drawing.Size(121, 25);
            this.launchTimerLabel.TabIndex = 9;
            this.launchTimerLabel.Text = "Launch timer: ";
            // 
            // showMapButton
            // 
            this.showMapButton.AccessibleName = "";
            this.showMapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showMapButton.Location = new System.Drawing.Point(237, 395);
            this.showMapButton.Name = "showMapButton";
            this.showMapButton.Size = new System.Drawing.Size(209, 28);
            this.showMapButton.TabIndex = 10;
            this.showMapButton.Text = "Show location on map";
            this.showMapButton.Click += new System.EventHandler(this.showMapButton_Click);
            // 
            // favouriteCheckBox
            // 
            this.favouriteCheckBox.AccessibleName = "";
            this.favouriteCheckBox.AutoSize = true;
            this.favouriteCheckBox.Location = new System.Drawing.Point(44, 395);
            this.favouriteCheckBox.Name = "favouriteCheckBox";
            this.favouriteCheckBox.Size = new System.Drawing.Size(72, 15);
            this.favouriteCheckBox.TabIndex = 2;
            this.favouriteCheckBox.Text = "Favourite";
            this.favouriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableOfDetails
            // 
            this.tableOfDetails.AccessibleName = "";
            this.tableOfDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableOfDetails.ColumnCount = 2;
            this.tableOfDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableOfDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.5F));
            this.tableOfDetails.Controls.Add(this.windowStartDetail, 1, 5);
            this.tableOfDetails.Controls.Add(this.launchNameLab, 0, 0);
            this.tableOfDetails.Controls.Add(this.statusLabel, 0, 1);
            this.tableOfDetails.Controls.Add(this.launchProvLab, 0, 2);
            this.tableOfDetails.Controls.Add(this.rocketLabel, 0, 3);
            this.tableOfDetails.Controls.Add(this.launchNameDetail, 1, 0);
            this.tableOfDetails.Controls.Add(this.statusLabelDetail, 1, 1);
            this.tableOfDetails.Controls.Add(this.launchProviderLabelDetail, 1, 2);
            this.tableOfDetails.Controls.Add(this.rocketFullLabelDetail, 1, 3);
            this.tableOfDetails.Controls.Add(this.launchPadLabel, 0, 4);
            this.tableOfDetails.Controls.Add(this.launchPadLocDetail, 1, 4);
            this.tableOfDetails.Controls.Add(this.t0label, 0, 5);
            this.tableOfDetails.Controls.Add(this.windowEndDetail, 1, 6);
            this.tableOfDetails.Controls.Add(this.label2, 0, 6);
            this.tableOfDetails.Location = new System.Drawing.Point(37, 59);
            this.tableOfDetails.Name = "tableOfDetails";
            this.tableOfDetails.RowCount = 7;
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableOfDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOfDetails.Size = new System.Drawing.Size(409, 330);
            this.tableOfDetails.TabIndex = 0;
            // 
            // windowStartDetail
            // 
            this.windowStartDetail.AutoSize = true;
            this.windowStartDetail.Location = new System.Drawing.Point(197, 245);
            this.windowStartDetail.Name = "windowStartDetail";
            this.windowStartDetail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.windowStartDetail.Size = new System.Drawing.Size(41, 25);
            this.windowStartDetail.TabIndex = 15;
            this.windowStartDetail.Text = "label3";
            // 
            // launchNameLab
            // 
            this.launchNameLab.AutoSize = true;
            this.launchNameLab.Location = new System.Drawing.Point(4, 1);
            this.launchNameLab.Name = "launchNameLab";
            this.launchNameLab.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.launchNameLab.Size = new System.Drawing.Size(86, 25);
            this.launchNameLab.TabIndex = 0;
            this.launchNameLab.Text = "Launch name:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(4, 52);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.statusLabel.Size = new System.Drawing.Size(44, 25);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status:";
            // 
            // launchProvLab
            // 
            this.launchProvLab.AutoSize = true;
            this.launchProvLab.Location = new System.Drawing.Point(4, 92);
            this.launchProvLab.Name = "launchProvLab";
            this.launchProvLab.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.launchProvLab.Size = new System.Drawing.Size(98, 25);
            this.launchProvLab.TabIndex = 2;
            this.launchProvLab.Text = "Launch provider:";
            // 
            // rocketLabel
            // 
            this.rocketLabel.AutoSize = true;
            this.rocketLabel.Location = new System.Drawing.Point(4, 141);
            this.rocketLabel.Name = "rocketLabel";
            this.rocketLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.rocketLabel.Size = new System.Drawing.Size(99, 25);
            this.rocketLabel.TabIndex = 3;
            this.rocketLabel.Text = "Rocket full name";
            // 
            // launchNameDetail
            // 
            this.launchNameDetail.AutoSize = true;
            this.launchNameDetail.Location = new System.Drawing.Point(197, 1);
            this.launchNameDetail.Name = "launchNameDetail";
            this.launchNameDetail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.launchNameDetail.Size = new System.Drawing.Size(41, 25);
            this.launchNameDetail.TabIndex = 4;
            this.launchNameDetail.Text = "label1";
            // 
            // statusLabelDetail
            // 
            this.statusLabelDetail.AutoSize = true;
            this.statusLabelDetail.Location = new System.Drawing.Point(197, 52);
            this.statusLabelDetail.Name = "statusLabelDetail";
            this.statusLabelDetail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.statusLabelDetail.Size = new System.Drawing.Size(41, 25);
            this.statusLabelDetail.TabIndex = 6;
            this.statusLabelDetail.Text = "label2";
            // 
            // launchProviderLabelDetail
            // 
            this.launchProviderLabelDetail.AutoSize = true;
            this.launchProviderLabelDetail.Location = new System.Drawing.Point(197, 92);
            this.launchProviderLabelDetail.Name = "launchProviderLabelDetail";
            this.launchProviderLabelDetail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.launchProviderLabelDetail.Size = new System.Drawing.Size(41, 25);
            this.launchProviderLabelDetail.TabIndex = 7;
            this.launchProviderLabelDetail.Text = "label3";
            // 
            // rocketFullLabelDetail
            // 
            this.rocketFullLabelDetail.AutoSize = true;
            this.rocketFullLabelDetail.Location = new System.Drawing.Point(197, 141);
            this.rocketFullLabelDetail.Name = "rocketFullLabelDetail";
            this.rocketFullLabelDetail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.rocketFullLabelDetail.Size = new System.Drawing.Size(41, 25);
            this.rocketFullLabelDetail.TabIndex = 8;
            this.rocketFullLabelDetail.Text = "label4";
            // 
            // launchPadLabel
            // 
            this.launchPadLabel.AutoSize = true;
            this.launchPadLabel.Location = new System.Drawing.Point(4, 198);
            this.launchPadLabel.Name = "launchPadLabel";
            this.launchPadLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.launchPadLabel.Size = new System.Drawing.Size(118, 25);
            this.launchPadLabel.TabIndex = 9;
            this.launchPadLabel.Text = "Launch pad location";
            // 
            // launchPadLocDetail
            // 
            this.launchPadLocDetail.AutoSize = true;
            this.launchPadLocDetail.Location = new System.Drawing.Point(197, 198);
            this.launchPadLocDetail.Name = "launchPadLocDetail";
            this.launchPadLocDetail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.launchPadLocDetail.Size = new System.Drawing.Size(41, 25);
            this.launchPadLocDetail.TabIndex = 10;
            this.launchPadLocDetail.Text = "label3";
            // 
            // t0label
            // 
            this.t0label.AutoSize = true;
            this.t0label.Location = new System.Drawing.Point(4, 245);
            this.t0label.Name = "t0label";
            this.t0label.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.t0label.Size = new System.Drawing.Size(128, 25);
            this.t0label.TabIndex = 14;
            this.t0label.Text = "min T-0 (window start)";
            // 
            // windowEndDetail
            // 
            this.windowEndDetail.AutoSize = true;
            this.windowEndDetail.Location = new System.Drawing.Point(197, 293);
            this.windowEndDetail.Name = "windowEndDetail";
            this.windowEndDetail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.windowEndDetail.Size = new System.Drawing.Size(73, 25);
            this.windowEndDetail.TabIndex = 5;
            this.windowEndDetail.Text = "window end";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 293);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "max T-0 (window end)";
            // 
            // ViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
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
            this.detailsBox.PerformLayout();
            this.tableOfDetails.ResumeLayout(false);
            this.tableOfDetails.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label windowEndDetail;
        private System.Windows.Forms.Label statusLabelDetail;
        private System.Windows.Forms.Label launchProviderLabelDetail;
        private System.Windows.Forms.Label rocketFullLabelDetail;
        private System.Windows.Forms.Label launchPadLabel;
        private System.Windows.Forms.Label launchPadLocDetail;
        private System.Windows.Forms.Label t0label;
        private System.Windows.Forms.Label windowStartDetail;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox favouriteCheckBox;
        private MetroFramework.Controls.MetroButton showMapButton;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader rocketColumn;
        private System.Windows.Forms.ColumnHeader wStartTimeColumn;
    }
}