using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace đồ_án_chuyên_đề
{
    public partial class FrmMain : Form
    {


        public object Cells { get; private set; }


        public FrmMain()
        {
            InitializeComponent();
            txtDatabaseName.DataBindings.Add(new Binding("Text", bdsDatabases, "name", true));
            txtBackupPosition.DataBindings.Add(new Binding("Text", bdsBackup, "position", true));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            LoadTable();

        }
        private void LoadTable()
        {
            this.taDatabases.Connection.ConnectionString = Program.ConnectionString;
            this.taBackup.Connection.ConnectionString = Program.ConnectionString;
            this.taDevices.Connection.ConnectionString = Program.ConnectionString;
            try
            {

                this.taDatabases.Fill(this.dataSet.databases);
                this.taDevices.Fill(this.dataSet.backup_devices);
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool IsContainDevice(string dbName)
        {
           
            if (bdsDevices.Find("name", "DEVICE_" + dbName) != -1)
                return true;
            return false;
        }


        private void txtDatabaseName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String dbName = txtDatabaseName.Text.Trim();
                this.taBackup.Fill(this.dataSet.SP_STT_BACKUP, dbName);

                if (IsContainDevice(dbName))
                {

                    btnCreateDevice.Enabled = false;
                    btnBakup.Enabled = true;
                    checkTime.Enabled = true;
                    if (bdsBackup.Count == 0)
                    {
                        btnRestore.Enabled = false;
                    }
                    else
                    {
                        btnRestore.Enabled = true;
                    }

                }
                else
                {
                    btnCreateDevice.Enabled = true;
                    btnRestore.Enabled = false;
                    btnBakup.Enabled = false;
                    checkTime.Enabled = false;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

        private void btnBakup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ii = 0;
            String strBackup;
            String dbName = txtDatabaseName.Text;
            string tenDevice = Program.CreateDeviceName(dbName);
            if (txtDatabaseName.Text.Trim() == "" || tenDevice == "")
                return;
            strBackup = "BACKUP DATABASE " + txtDatabaseName.Text.Trim() + " TO " + tenDevice;

            if (ckbIsClearOldBackup.Checked)
            {
                if (MessageBox.Show("Hành động này sẽ xóa toàn bộ file backup cũ\n" +
                                                "Bạn chắc chắn muốn tiếp tục?", "QUESTION",
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    strBackup = strBackup + " WITH INIT";
            }
            int err = Program.ExecSqlNonQuery(strBackup, Program.ConnectionString, "");
           
            if (err != 0)
            {
                MessageBox.Show("lỗi backup cơ sở dữ liệu" + txtDatabaseName.Text);
                return;

            }

            else
            {
                this.ProgBK.Visible = true;
                for (; ii <= this.ProgBK.Maximum; ii++)
                {
                    this.ProgBK.Value = ii;
                }
                MessageBox.Show(" sao lưu thành công!");
                this.taBackup.Fill(this.dataSet.SP_STT_BACKUP, dbName);
                this.ProgBK.Visible = false;
                btnRestore.Enabled = true;
            }
        }

       
        
        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int err;
            int ii=0;
            string dbName = txtDatabaseName.Text.Trim();
            if (this.bdsBackup.Count == 0)
            {
                MessageBox.Show("chưa có bản sao lưu để phục hồi.", "", MessageBoxButtons.OK);

            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();

            String strRestore;
            if (dbName == "" || Program.CreateDeviceName(dbName) == "") return;
            strRestore = "ALTER DATABASE " + dbName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE  " +
                     "USE tempdb ";


            if (checkTime.Checked==false )
            {
                strRestore += "RESTORE DATABASE " + dbName + " FROM " + Program.CreateDeviceName(dbName) + " WITH FILE= " + txtBackupPosition.Text.Trim() +
                    ", REPLACE " + "ALTER DATABASE " + dbName + " SET MULTI_USER ";
                err = Program.ExecSqlNonQuery(strRestore, Program.ConnectionString, "");
                this.ProgBK.Visible = true;
               
                if (err == 0)
                {
                    for (; ii <= this.ProgBK.Maximum; ii++)
                    {
                        this.ProgBK.Value = ii;
                    }
                    MessageBox.Show("phục hồi thành công!");
                    this.ProgBK.Visible=false;
                    
                }
                else
                {
                    MessageBox.Show("lỗi phục hồi. Vui lòng kiểm tra lại!");
                    this.ProgBK.Visible = false;
                    return;
                }
               
            }
            else
            {
               
                DateTime ngayGioBK = (DateTime)((DataRowView)bdsBackup[bdsBackup.Position])["backup_start_date"];
                
                string strThoiDiemStopAt = dtpDateRestore.DateTime.Day + "/" + dtpDateRestore.DateTime.Month + "/" + dtpDateRestore.DateTime.Year + " " +
                                           timeRestore.Time.Hour + ":" + (timeRestore.Time.Minute) + ":" + timeRestore.Time.Second;
                // trường hợp h:m:s bằng nhưng còn phần ms  dương
                DateTime ThoiDiemStopAt;
                ThoiDiemStopAt = DateTime.Parse(strThoiDiemStopAt);

                if ((dtpDateRestore.DateTime.Date < ngayGioBK.Date) ||
                    (dtpDateRestore.DateTime.Date == ngayGioBK.Date && ThoiDiemStopAt.TimeOfDay.Ticks < ngayGioBK.TimeOfDay.Ticks))
                {
                    MessageBox.Show("THỜI ĐIỂM MUỐN PHỤC HỒI PHẢI SAU THỜI ĐIỂM BẢN SAO LƯU ĐÃ CHỌN.", "", MessageBoxButtons.OK);
                    return;
                }
                // phải kiểm tra sau thời điểm hiện tại
                if (ThoiDiemStopAt > DateTime.Now)
                {
                    MessageBox.Show("THỜI ĐIỂM MUỐN PHỤC HỒI PHẢI TRƯỚC THỜI ĐIỂM HIỆN TẠI.", "", MessageBoxButtons.OK);
                    return;
                }
                strRestore += "BACKUP LOG " + dbName + " TO DISK = '" + Program.DefaultPath + "/TestDB.trn' WITH INIT, NORECOVERY " +
                              " USE TEMPDB      " +
                              " RESTORE DATABASE " + dbName + " FROM " + Program.CreateDeviceName(dbName) + " WITH FILE=" + bdsBackup.Count + ",  NORECOVERY ";
                err = Program.ExecSqlNonQuery(strRestore, Program.ConnectionString, "lỗi");
               // MessageBox.Show(err + "");
                if (err == 0)
                {
                    this.ProgBK.Visible = true;
                    for (; ii <= this.ProgBK.Maximum * 3 / 4; ii++)
                    {
                        this.ProgBK.Value = ii;
                    }
                   
                }
                   
                else
                {
                    this.ProgBK.Visible = false;
                    strRestore = "   RESTORE DATABASE " + dbName + " FROM " + Program.CreateDeviceName(dbName) + " WITH FILE=" + bdsBackup.Count +
                                 " ALTER DATABASE " + dbName + "  SET MULTI_USER ";
                    Program.ExecSqlNonQuery(strRestore, Program.ConnectionString, "");
                    return;
                }
                strRestore = " USE TEMPDB SET DATEFORMAT DMY  " +
                    "    RESTORE DATABASE " +dbName + " FROM DISK = '" + Program.DefaultPath + "/TestDB.trn' " +
                                 " WITH STOPAT=N'" + dtpDateRestore.Text + " " + timeRestore.Text + "' , RECOVERY    ";
                err = Program.ExecSqlNonQuery(strRestore, Program.ConnectionString, "lỗi  phục hồi csdl từ file log");
                if (err == 0)
                {
                    for (; ii <= this.ProgBK.Maximum; ii++)
                        this.ProgBK.Value = ii;
                    strRestore = " ALTER DATABASE " + dbName + "  SET MULTI_USER ";
                    Program.ExecSqlNonQuery(strRestore, Program.ConnectionString, "");
                }
                else
                {
                    this.ProgBK.Visible = false;
                    strRestore = "   RESTORE DATABASE " + dbName + " FROM " + Program.CreateDeviceName(dbName) + " WITH FILE=" + bdsBackup.Count +
                                  " ALTER DATABASE " + dbName + "  SET MULTI_USER ";
                    Program.ExecSqlNonQuery(strRestore, Program.ConnectionString, "");
                    return;
                }

            }
        }

        private void checkTime_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkTime.Checked)
            {
                pnRestoreTime.Visible = true;
            }
            else
            {
                pnRestoreTime.Visible = false;
            }
        }

        private void btnCreateDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string deviceName = Program.CreateDeviceName(txtDatabaseName.Text);
            string physicalName = Program.DefaultPath + @"\" + deviceName + ".bak";
            string queryString= "EXEC sys.sp_addumpdevice @devtype = 'disk', @logicalname = '"+ deviceName + "', @physicalname = N'"+ physicalName + "'";
            int err = Program.ExecSqlNonQuery(queryString, Program.ConnectionString,"");

            if (err == 0)
            {
                MessageBox.Show("Tạo device thành công", "SUCCESS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.taDevices.Fill(this.dataSet.backup_devices);
                int backupPosition = bdsDatabases.Position;
                bdsDatabases.MoveFirst();
                bdsDatabases.Position = backupPosition;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ckbIsClearOldBackup_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
