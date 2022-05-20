
namespace đồ_án_chuyên_đề
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.bdsDatabases = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new đồ_án_chuyên_đề.DataSet();
            this.bdsBackup = new System.Windows.Forms.BindingSource(this.components);
            this.taDatabases = new đồ_án_chuyên_đề.DataSetTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new đồ_án_chuyên_đề.DataSetTableAdapters.TableAdapterManager();
            this.taBackup = new đồ_án_chuyên_đề.DataSetTableAdapters.SP_STT_BACKUPTableAdapter();
            this.bdsDevices = new System.Windows.Forms.BindingSource(this.components);
            this.taDevices = new đồ_án_chuyên_đề.DataSetTableAdapters.backup_devicesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProgBK = new System.Windows.Forms.ProgressBar();
            this.ckbIsClearOldBackup = new DevExpress.XtraEditors.CheckEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBackupPosition = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bar = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnBakup = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.checkTime = new DevExpress.XtraBars.BarCheckItem();
            this.btnCreateDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.pnRestoreTime = new System.Windows.Forms.Panel();
            this.memoEditDoc = new DevExpress.XtraEditors.MemoEdit();
            this.timeRestore = new DevExpress.XtraEditors.TimeEdit();
            this.dtpDateRestore = new DevExpress.XtraEditors.DateEdit();
            this.lblRestore = new DevExpress.XtraEditors.LabelControl();
            this.backup_devicesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbIsClearOldBackup.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.pnRestoreTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateRestore.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backup_devicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsDatabases
            // 
            this.bdsDatabases.DataMember = "databases";
            this.bdsDatabases.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBackup
            // 
            this.bdsBackup.DataMember = "SP_STT_BACKUP";
            this.bdsBackup.DataSource = this.dataSet;
            // 
            // taDatabases
            // 
            this.taDatabases.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = đồ_án_chuyên_đề.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taBackup
            // 
            this.taBackup.ClearBeforeFill = true;
            // 
            // bdsDevices
            // 
            this.bdsDevices.DataMember = "backup_devices";
            this.bdsDevices.DataSource = this.dataSet;
            // 
            // taDevices
            // 
            this.taDevices.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdsDatabases;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(248, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 246;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 413);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở dữ liệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ProgBK);
            this.panel2.Controls.Add(this.ckbIsClearOldBackup);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(251, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 267);
            this.panel2.TabIndex = 3;
            // 
            // ProgBK
            // 
            this.ProgBK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProgBK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProgBK.Location = new System.Drawing.Point(16, 224);
            this.ProgBK.MarqueeAnimationSpeed = 1000;
            this.ProgBK.Name = "ProgBK";
            this.ProgBK.Size = new System.Drawing.Size(516, 23);
            this.ProgBK.TabIndex = 7;
            this.ProgBK.Visible = false;
            // 
            // ckbIsClearOldBackup
            // 
            this.ckbIsClearOldBackup.Location = new System.Drawing.Point(16, 193);
            this.ckbIsClearOldBackup.Name = "ckbIsClearOldBackup";
            this.ckbIsClearOldBackup.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIsClearOldBackup.Properties.Appearance.Options.UseFont = true;
            this.ckbIsClearOldBackup.Properties.Caption = "Xóa tất cả các bản sao lưu cũ trong File trước khi sao lưu bản mới";
            this.ckbIsClearOldBackup.Size = new System.Drawing.Size(516, 25);
            this.ckbIsClearOldBackup.TabIndex = 6;
            this.ckbIsClearOldBackup.CheckedChanged += new System.EventHandler(this.ckbIsClearOldBackup_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.txtBackupPosition);
            this.panel3.Controls.Add(this.txtDatabaseName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 187);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionDataGridViewTextBoxColumn,
            this.backupstartdateDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bdsBackup;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(574, 161);
            this.dataGridView2.TabIndex = 8;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Bản sao lưu thứ #";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 170;
            // 
            // backupstartdateDataGridViewTextBoxColumn
            // 
            this.backupstartdateDataGridViewTextBoxColumn.DataPropertyName = "backup_start_date";
            this.backupstartdateDataGridViewTextBoxColumn.HeaderText = "Ngày giờ sao lưu";
            this.backupstartdateDataGridViewTextBoxColumn.Name = "backupstartdateDataGridViewTextBoxColumn";
            this.backupstartdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User sao lưu";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Diễn giải";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // txtBackupPosition
            // 
            this.txtBackupPosition.Location = new System.Drawing.Point(437, 3);
            this.txtBackupPosition.Name = "txtBackupPosition";
            this.txtBackupPosition.Size = new System.Drawing.Size(129, 20);
            this.txtBackupPosition.TabIndex = 7;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(175, 3);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(256, 20);
            this.txtDatabaseName.TabIndex = 6;
            this.txtDatabaseName.TextChanged += new System.EventHandler(this.txtDatabaseName_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(-5, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cơ sở dữ liệu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // bar7
            // 
            this.bar7.BarName = "Main menu";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.OptionsBar.MultiLine = true;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar9});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBakup,
            this.btnRestore,
            this.checkTime,
            this.barEditItem1,
            this.btnCreateDevice,
            this.btnExit});
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bar9;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(95, 132);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBakup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRestore, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.checkTime, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCreateDevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.Text = "Tools";
            // 
            // btnBakup
            // 
            this.btnBakup.ActAsDropDown = true;
            this.btnBakup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnBakup.Caption = "SAO LƯU";
            this.btnBakup.DropDownControl = this.galleryDropDown1;
            this.btnBakup.Id = 0;
            this.btnBakup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBakup.ImageOptions.Image")));
            this.btnBakup.Name = "btnBakup";
            this.btnBakup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBakup_ItemClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = this.barManager1;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "PHỤC HỒI";
            this.btnRestore.Id = 1;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // checkTime
            // 
            this.checkTime.Caption = "theo thời gian";
            this.checkTime.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.checkTime.Id = 2;
            this.checkTime.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkTime.ImageOptions.Image")));
            this.checkTime.Name = "checkTime";
            this.checkTime.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.checkTime_CheckedChanged);
            // 
            // btnCreateDevice
            // 
            this.btnCreateDevice.Caption = "TẠO DEVICE SAO LƯU";
            this.btnCreateDevice.Id = 4;
            this.btnCreateDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDevice.ImageOptions.Image")));
            this.btnCreateDevice.Name = "btnCreateDevice";
            this.btnCreateDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateDevice_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "EXIT";
            this.btnExit.Id = 5;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar9
            // 
            this.bar9.BarName = "Status bar";
            this.bar9.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar9.DockCol = 0;
            this.bar9.DockRow = 0;
            this.bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar9.OptionsBar.AllowQuickCustomization = false;
            this.bar9.OptionsBar.DrawDragBorder = false;
            this.bar9.OptionsBar.UseWholeRow = true;
            this.bar9.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(888, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 548);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(888, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 508);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(888, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 508);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 3;
            this.barEditItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barEditItem1.ImageOptions.Image")));
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "SAO LƯU";
            this.btnBackup.Id = 0;
            this.btnBackup.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar8
            // 
            this.bar8.BarName = "Main menu";
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar8.OptionsBar.MultiLine = true;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.Text = "Main menu";
            // 
            // pnRestoreTime
            // 
            this.pnRestoreTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRestoreTime.Controls.Add(this.memoEditDoc);
            this.pnRestoreTime.Controls.Add(this.timeRestore);
            this.pnRestoreTime.Controls.Add(this.dtpDateRestore);
            this.pnRestoreTime.Controls.Add(this.lblRestore);
            this.pnRestoreTime.Location = new System.Drawing.Point(251, 329);
            this.pnRestoreTime.Name = "pnRestoreTime";
            this.pnRestoreTime.Size = new System.Drawing.Size(574, 130);
            this.pnRestoreTime.TabIndex = 9;
            this.pnRestoreTime.Visible = false;
            // 
            // memoEditDoc
            // 
            this.memoEditDoc.EditValue = resources.GetString("memoEditDoc.EditValue");
            this.memoEditDoc.Location = new System.Drawing.Point(23, 51);
            this.memoEditDoc.Name = "memoEditDoc";
            this.memoEditDoc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEditDoc.Properties.Appearance.Options.UseFont = true;
            this.memoEditDoc.Properties.ReadOnly = true;
            this.memoEditDoc.Size = new System.Drawing.Size(548, 67);
            this.memoEditDoc.TabIndex = 16;
            // 
            // timeRestore
            // 
            this.timeRestore.EditValue = new System.DateTime(2020, 4, 25, 0, 0, 0, 0);
            this.timeRestore.Location = new System.Drawing.Point(409, 12);
            this.timeRestore.Name = "timeRestore";
            this.timeRestore.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRestore.Properties.Appearance.Options.UseFont = true;
            this.timeRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeRestore.Size = new System.Drawing.Size(100, 24);
            this.timeRestore.TabIndex = 15;
            // 
            // dtpDateRestore
            // 
            this.dtpDateRestore.EditValue = null;
            this.dtpDateRestore.Location = new System.Drawing.Point(257, 12);
            this.dtpDateRestore.Name = "dtpDateRestore";
            this.dtpDateRestore.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRestore.Properties.Appearance.Options.UseFont = true;
            this.dtpDateRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateRestore.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateRestore.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpDateRestore.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDateRestore.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpDateRestore.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDateRestore.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtpDateRestore.Size = new System.Drawing.Size(134, 24);
            this.dtpDateRestore.TabIndex = 14;
            // 
            // lblRestore
            // 
            this.lblRestore.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestore.Appearance.Options.UseFont = true;
            this.lblRestore.Location = new System.Drawing.Point(23, 15);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(228, 17);
            this.lblRestore.TabIndex = 13;
            this.lblRestore.Text = "Ngày giờ để phục hồi tới thời điểm đó:";
            // 
            // backup_devicesDataGridView
            // 
            this.backup_devicesDataGridView.AutoGenerateColumns = false;
            this.backup_devicesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.backup_devicesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backup_devicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.backup_devicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2});
            this.backup_devicesDataGridView.DataSource = this.bdsDevices;
            this.backup_devicesDataGridView.Location = new System.Drawing.Point(532, 538);
            this.backup_devicesDataGridView.Name = "backup_devicesDataGridView";
            this.backup_devicesDataGridView.Size = new System.Drawing.Size(247, 10);
            this.backup_devicesDataGridView.TabIndex = 4;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(905, 492);
            this.Controls.Add(this.pnRestoreTime);
            this.Controls.Add(this.backup_devicesDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckbIsClearOldBackup.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.pnRestoreTime.ResumeLayout(false);
            this.pnRestoreTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateRestore.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backup_devicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource bdsDatabases;
        private DataSetTableAdapters.databasesTableAdapter taDatabases;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsBackup;
        private DataSetTableAdapters.SP_STT_BACKUPTableAdapter taBackup;
        private System.Windows.Forms.BindingSource bdsDevices;
        private DataSetTableAdapters.backup_devicesTableAdapter taDevices;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBackupPosition;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit ckbIsClearOldBackup;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnBakup;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarCheckItem checkTime;
        private DevExpress.XtraBars.BarButtonItem btnCreateDevice;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.Bar bar8;
        private System.Windows.Forms.Panel pnRestoreTime;
        private DevExpress.XtraEditors.MemoEdit memoEditDoc;
        private DevExpress.XtraEditors.TimeEdit timeRestore;
        private DevExpress.XtraEditors.DateEdit dtpDateRestore;
        private DevExpress.XtraEditors.LabelControl lblRestore;
        private System.Windows.Forms.ProgressBar ProgBK;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView backup_devicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
    }
}