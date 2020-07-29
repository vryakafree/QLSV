namespace QLSV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnloaddb = new System.Windows.Forms.ToolStripMenuItem();
            this.btnexit = new System.Windows.Forms.ToolStripMenuItem();
            this.btninfo = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.cbnganh = new System.Windows.Forms.ComboBox();
            this.loiten = new System.Windows.Forms.Label();
            this.loilop = new System.Windows.Forms.Label();
            this.loimssv = new System.Windows.Forms.Label();
            this.sinhVienDataSet = new QLSV.SinhVienDataSet();
            this.tHANHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHANHVIENTableAdapter = new QLSV.SinhVienDataSetTableAdapters.THANHVIENTableAdapter();
            this.tableAdapterManager = new QLSV.SinhVienDataSetTableAdapters.TableAdapterManager();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtidn = new System.Windows.Forms.TextBox();
            this.txtidk = new System.Windows.Forms.TextBox();
            this.timerauto = new System.Windows.Forms.Timer(this.components);
            this.btnfind = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lberror = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tDA2020ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(516, 389);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btninfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(617, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnloaddb,
            this.btnexit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton1.Text = "Chức năng";
            // 
            // btnloaddb
            // 
            this.btnloaddb.Name = "btnloaddb";
            this.btnloaddb.Size = new System.Drawing.Size(180, 22);
            this.btnloaddb.Text = "Load file";
            this.btnloaddb.Click += new System.EventHandler(this.btnloaddb_Click);
            // 
            // btnexit
            // 
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(180, 22);
            this.btnexit.Text = "Thoát";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btninfo
            // 
            this.btninfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btninfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tDA2020ToolStripMenuItem});
            this.btninfo.Image = ((System.Drawing.Image)(resources.GetObject("btninfo.Image")));
            this.btninfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btninfo.Name = "btninfo";
            this.btninfo.ShowDropDownArrow = false;
            this.btninfo.Size = new System.Drawing.Size(62, 22);
            this.btninfo.Text = "Thông tin";
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.Location = new System.Drawing.Point(534, 144);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.Location = new System.Drawing.Point(534, 186);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Xoá";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.Location = new System.Drawing.Point(534, 227);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "MSSV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngành:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Khoa:";
            // 
            // cbkhoa
            // 
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Location = new System.Drawing.Point(380, 71);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(222, 21);
            this.cbkhoa.TabIndex = 18;
            this.cbkhoa.SelectedIndexChanged += new System.EventHandler(this.cbkhoa_SelectedIndexChanged);
            // 
            // cbnganh
            // 
            this.cbnganh.FormattingEnabled = true;
            this.cbnganh.Location = new System.Drawing.Point(380, 35);
            this.cbnganh.Name = "cbnganh";
            this.cbnganh.Size = new System.Drawing.Size(222, 21);
            this.cbnganh.TabIndex = 19;
            this.cbnganh.SelectedIndexChanged += new System.EventHandler(this.cbnganh_SelectedIndexChanged);
            // 
            // loiten
            // 
            this.loiten.AutoSize = true;
            this.loiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loiten.ForeColor = System.Drawing.Color.Red;
            this.loiten.Location = new System.Drawing.Point(69, 20);
            this.loiten.Name = "loiten";
            this.loiten.Size = new System.Drawing.Size(0, 12);
            this.loiten.TabIndex = 22;
            this.loiten.Visible = false;
            // 
            // loilop
            // 
            this.loilop.AutoSize = true;
            this.loilop.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loilop.ForeColor = System.Drawing.Color.Red;
            this.loilop.Location = new System.Drawing.Point(69, 58);
            this.loilop.Name = "loilop";
            this.loilop.Size = new System.Drawing.Size(0, 12);
            this.loilop.TabIndex = 23;
            this.loilop.Visible = false;
            // 
            // loimssv
            // 
            this.loimssv.AutoSize = true;
            this.loimssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loimssv.ForeColor = System.Drawing.Color.Red;
            this.loimssv.Location = new System.Drawing.Point(69, 96);
            this.loimssv.Name = "loimssv";
            this.loimssv.Size = new System.Drawing.Size(0, 12);
            this.loimssv.TabIndex = 24;
            this.loimssv.Visible = false;
            // 
            // sinhVienDataSet
            // 
            this.sinhVienDataSet.DataSetName = "SinhVienDataSet";
            this.sinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHANHVIENBindingSource
            // 
            this.tHANHVIENBindingSource.DataMember = "THANHVIEN";
            this.tHANHVIENBindingSource.DataSource = this.sinhVienDataSet;
            // 
            // tHANHVIENTableAdapter
            // 
            this.tHANHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.NGANHTableAdapter = null;
            this.tableAdapterManager.THANHVIENTableAdapter = this.tHANHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLSV.SinhVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHVIENBindingSource, "MSSV", true));
            this.txtid.Location = new System.Drawing.Point(61, 107);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(144, 20);
            this.txtid.TabIndex = 25;
            // 
            // txtname
            // 
            this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHVIENBindingSource, "TEN_SV", true));
            this.txtname.Location = new System.Drawing.Point(61, 35);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(144, 20);
            this.txtname.TabIndex = 27;
            // 
            // txtclass
            // 
            this.txtclass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHVIENBindingSource, "LOP_SV", true));
            this.txtclass.Location = new System.Drawing.Point(61, 70);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(144, 20);
            this.txtclass.TabIndex = 29;
            // 
            // txtidn
            // 
            this.txtidn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHVIENBindingSource, "ID_NGANH", true));
            this.txtidn.Location = new System.Drawing.Point(347, 36);
            this.txtidn.Name = "txtidn";
            this.txtidn.Size = new System.Drawing.Size(27, 20);
            this.txtidn.TabIndex = 31;
            // 
            // txtidk
            // 
            this.txtidk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHANHVIENBindingSource, "ID_KHOA", true));
            this.txtidk.Location = new System.Drawing.Point(347, 71);
            this.txtidk.Name = "txtidk";
            this.txtidk.Size = new System.Drawing.Size(27, 20);
            this.txtidk.TabIndex = 33;
            // 
            // timerauto
            // 
            this.timerauto.Enabled = true;
            this.timerauto.Interval = 6000;
            this.timerauto.Tick += new System.EventHandler(this.timerauto_Tick);
            // 
            // btnfind
            // 
            this.btnfind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfind.Location = new System.Drawing.Point(534, 105);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 34;
            this.btnfind.Text = "Tìm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(347, 107);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(172, 20);
            this.txtTimKiem.TabIndex = 35;
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror.ForeColor = System.Drawing.Color.Red;
            this.lberror.Location = new System.Drawing.Point(212, 113);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(0, 13);
            this.lberror.TabIndex = 37;
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(180, 22);
            this.btnOpen.Text = "Mở file";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tDA2020ToolStripMenuItem
            // 
            this.tDA2020ToolStripMenuItem.Name = "tDA2020ToolStripMenuItem";
            this.tDA2020ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tDA2020ToolStripMenuItem.Text = "TDA, 2020.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 558);
            this.Controls.Add(this.lberror);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.txtidn);
            this.Controls.Add(this.txtidk);
            this.Controls.Add(this.loimssv);
            this.Controls.Add(this.loilop);
            this.Controls.Add(this.loiten);
            this.Controls.Add(this.cbnganh);
            this.Controls.Add(this.cbkhoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Chương Trình Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton btninfo;
        private System.Windows.Forms.ToolStripMenuItem btnloaddb;
        private System.Windows.Forms.ToolStripMenuItem btnexit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.ComboBox cbnganh;
        private System.Windows.Forms.Label loiten;
        private System.Windows.Forms.Label loilop;
        private System.Windows.Forms.Label loimssv;
        private SinhVienDataSet sinhVienDataSet;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource;
        private SinhVienDataSetTableAdapters.THANHVIENTableAdapter tHANHVIENTableAdapter;
        private SinhVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtidn;
        private System.Windows.Forms.TextBox txtidk;
        private System.Windows.Forms.Timer timerauto;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lberror;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem tDA2020ToolStripMenuItem;
    }
}

