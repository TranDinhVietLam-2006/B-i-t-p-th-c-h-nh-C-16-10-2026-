namespace Bài_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();

            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();

            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.cboThietBi = new System.Windows.Forms.ComboBox();

            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();

            this.lblHanTra = new System.Windows.Forms.Label();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTraTT = new System.Windows.Forms.Label();
            this.pnlNgayTra = new System.Windows.Forms.FlowLayoutPanel();
            this.chkDaTra = new System.Windows.Forms.CheckBox();
            this.dtpNgayTraThucTe = new System.Windows.Forms.DateTimePicker();

            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();

            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDanhDauDaTra = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.flowFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();

            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTraTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuFile });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 0;

            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuExportCSV, this.menuExit });
            this.menuFile.Name = "menuFile";
            this.menuFile.Text = "&Tệp";

            this.menuExportCSV.Name = "menuExportCSV";
            this.menuExportCSV.Text = "Xuất CSV...";
            this.menuExportCSV.Click += new System.EventHandler(this.menuExportCSV_Click);

            this.menuExit.Name = "menuExit";
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Location = new System.Drawing.Point(0, 700);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip1.TabIndex = 1;

            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Tổng số phiếu: 0 | Quá hạn: 0";

            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelInput, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.flowFilter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dgvPhieuMuon, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1100, 676);
            this.tableLayoutPanelMain.TabIndex = 2;

            this.tableLayoutPanelInput.AutoSize = true;
            this.tableLayoutPanelInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelInput.ColumnCount = 4;
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            this.tableLayoutPanelInput.Controls.Add(this.lblMaPhieu, 0, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtMaPhieu, 1, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblMaSV, 2, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtMaSV, 3, 0);

            this.tableLayoutPanelInput.Controls.Add(this.lblHoTenSV, 0, 1);
            this.tableLayoutPanelInput.Controls.Add(this.txtHoTenSV, 1, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblThietBi, 2, 1);
            this.tableLayoutPanelInput.Controls.Add(this.cboThietBi, 3, 1);

            this.tableLayoutPanelInput.Controls.Add(this.lblSoLuong, 0, 2);
            this.tableLayoutPanelInput.Controls.Add(this.numSoLuong, 1, 2);
            this.tableLayoutPanelInput.Controls.Add(this.lblNgayMuon, 2, 2);
            this.tableLayoutPanelInput.Controls.Add(this.dtpNgayMuon, 3, 2);

            this.tableLayoutPanelInput.Controls.Add(this.lblHanTra, 0, 3);
            this.tableLayoutPanelInput.Controls.Add(this.dtpHanTra, 1, 3);
            this.tableLayoutPanelInput.Controls.Add(this.lblNgayTraTT, 2, 3);
            this.tableLayoutPanelInput.Controls.Add(this.pnlNgayTra, 3, 3);

            this.tableLayoutPanelInput.Controls.Add(this.lblTinhTrang, 0, 4);
            this.tableLayoutPanelInput.Controls.Add(this.txtTinhTrang, 1, 4);
            this.tableLayoutPanelInput.SetColumnSpan(this.txtTinhTrang, 3);

            this.tableLayoutPanelInput.Controls.Add(this.flowButtons, 0, 5);
            this.tableLayoutPanelInput.SetColumnSpan(this.flowButtons, 4);

            this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelInput.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            this.tableLayoutPanelInput.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanelInput.RowCount = 6;
            for (int i = 0; i < 6; i++)
                this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInput.Size = new System.Drawing.Size(1094, 230);
            this.tableLayoutPanelInput.TabIndex = 0;

            System.Action<System.Windows.Forms.Label> styleLabel = (l) =>
            {
                l.AutoSize = true;
                l.Anchor = System.Windows.Forms.AnchorStyles.Left;
                l.Padding = new System.Windows.Forms.Padding(4, 6, 4, 0);
            };
            System.Action<System.Windows.Forms.Control> styleControl = (c) =>
            {
                c.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
                c.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            };

            styleLabel(this.lblMaPhieu); this.lblMaPhieu.Text = "Mã phiếu:";
            styleLabel(this.lblMaSV); this.lblMaSV.Text = "Mã sinh viên:";
            styleLabel(this.lblHoTenSV); this.lblHoTenSV.Text = "Họ tên sinh viên:";
            styleLabel(this.lblThietBi); this.lblThietBi.Text = "Thiết bị:";
            styleLabel(this.lblSoLuong); this.lblSoLuong.Text = "Số lượng:";
            styleLabel(this.lblNgayMuon); this.lblNgayMuon.Text = "Ngày mượn:";
            styleLabel(this.lblHanTra); this.lblHanTra.Text = "Hạn trả:";
            styleLabel(this.lblNgayTraTT); this.lblNgayTraTT.Text = "Ngày trả thực tế:";
            styleLabel(this.lblTinhTrang); this.lblTinhTrang.Text = "Tình trạng:";

            styleControl(this.txtMaPhieu);
            styleControl(this.txtMaSV);
            styleControl(this.txtHoTenSV);
            styleControl(this.cboThietBi);
            styleControl(this.numSoLuong);
            styleControl(this.dtpNgayMuon);
            styleControl(this.dtpHanTra);
            styleControl(this.txtTinhTrang);

            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaSV.Name = "txtMaSV";
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.BackColor = System.Drawing.SystemColors.Info;

            this.cboThietBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.numSoLuong.Minimum = 1;
            this.numSoLuong.Maximum = 1000;
            this.numSoLuong.Value = 1;

            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.pnlNgayTra.AutoSize = true;
            this.pnlNgayTra.Controls.Add(this.chkDaTra);
            this.pnlNgayTra.Controls.Add(this.dtpNgayTraThucTe);
            this.pnlNgayTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNgayTra.WrapContents = false;

            this.chkDaTra.AutoSize = true;
            this.chkDaTra.Text = "Đã trả";
            this.chkDaTra.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.chkDaTra.CheckedChanged += new System.EventHandler(this.chkDaTra_CheckedChanged);

            this.dtpNgayTraThucTe.Width = 130;
            this.dtpNgayTraThucTe.Enabled = false;
            this.dtpNgayTraThucTe.ValueChanged += new System.EventHandler(this.PreviewTinhTrang_Changed);

            this.dtpHanTra.ValueChanged += new System.EventHandler(this.PreviewTinhTrang_Changed);

            this.flowButtons.AutoSize = true;
            this.flowButtons.Controls.Add(this.btnThem);
            this.flowButtons.Controls.Add(this.btnCapNhat);
            this.flowButtons.Controls.Add(this.btnXoa);
            this.flowButtons.Controls.Add(this.btnDanhDauDaTra);
            this.flowButtons.Controls.Add(this.btnLamMoi);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowButtons.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowButtons.WrapContents = false;

            this.btnThem.Text = "Thêm";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnDanhDauDaTra.Text = "Đánh dấu đã trả";
            this.btnDanhDauDaTra.Size = new System.Drawing.Size(120, 30);
            this.btnDanhDauDaTra.Click += new System.EventHandler(this.btnDanhDauDaTra_Click);

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.flowFilter.AutoSize = true;
            this.flowFilter.Controls.Add(this.lblTimKiem);
            this.flowFilter.Controls.Add(this.txtTimKiem);
            this.flowFilter.Controls.Add(this.lblLocTrangThai);
            this.flowFilter.Controls.Add(this.cboLocTrangThai);
            this.flowFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFilter.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.flowFilter.WrapContents = false;

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Text = "Tìm kiếm (mã SV / thiết bị):";
            this.lblTimKiem.Padding = new System.Windows.Forms.Padding(0, 6, 4, 0);

            this.txtTimKiem.Width = 250;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.Filter_Changed);

            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Text = "Lọc tình trạng:";
            this.lblLocTrangThai.Padding = new System.Windows.Forms.Padding(12, 6, 4, 0);

            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Width = 160;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.AutoGenerateColumns = false;
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaPhieu, this.colMaSV, this.colHoTenSV, this.colThietBi, this.colSoLuong,
                this.colNgayMuon, this.colHanTra, this.colNgayTraTT, this.colTinhTrang });
            this.dgvPhieuMuon.DataSource = this.bindingSource1;
            this.dgvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(3, 260);
            this.dgvPhieuMuon.MultiSelect = false;
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.RowHeadersWidth = 30;
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(1094, 413);
            this.dgvPhieuMuon.TabIndex = 1;

            this.colMaPhieu.HeaderText = "Mã phiếu"; this.colMaPhieu.DataPropertyName = "MaPhieu"; this.colMaPhieu.FillWeight = 70F;
            this.colMaSV.HeaderText = "Mã SV"; this.colMaSV.DataPropertyName = "MaSinhVien"; this.colMaSV.FillWeight = 70F;
            this.colHoTenSV.HeaderText = "Họ tên SV"; this.colHoTenSV.DataPropertyName = "HoTenSinhVien"; this.colHoTenSV.FillWeight = 130F;
            this.colThietBi.HeaderText = "Thiết bị"; this.colThietBi.DataPropertyName = "ThietBi"; this.colThietBi.FillWeight = 130F;
            this.colSoLuong.HeaderText = "SL"; this.colSoLuong.DataPropertyName = "SoLuong"; this.colSoLuong.FillWeight = 45F;
            this.colNgayMuon.HeaderText = "Ngày mượn"; this.colNgayMuon.DataPropertyName = "NgayMuon"; this.colNgayMuon.DefaultCellStyle.Format = "dd/MM/yyyy"; this.colNgayMuon.FillWeight = 90F;
            this.colHanTra.HeaderText = "Hạn trả"; this.colHanTra.DataPropertyName = "HanTra"; this.colHanTra.DefaultCellStyle.Format = "dd/MM/yyyy"; this.colHanTra.FillWeight = 90F;
            this.colNgayTraTT.HeaderText = "Ngày trả"; this.colNgayTraTT.DataPropertyName = "NgayTraThucTe"; this.colNgayTraTT.DefaultCellStyle.Format = "dd/MM/yyyy"; this.colNgayTraTT.FillWeight = 90F;
            this.colTinhTrang.HeaderText = "Tình trạng"; this.colTinhTrang.DataPropertyName = "TinhTrang"; this.colTinhTrang.FillWeight = 85F;

            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;

            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);

            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialog1.Title = "Chọn nơi lưu file CSV";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 722);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2 - Quản lý mượn trả thiết bị phòng thực hành";
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExportCSV;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;

        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.Label lblThietBi;
        private System.Windows.Forms.ComboBox cboThietBi;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.Label lblNgayTraTT;
        private System.Windows.Forms.FlowLayoutPanel pnlNgayTra;
        private System.Windows.Forms.CheckBox chkDaTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTraThucTe;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;

        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDanhDauDaTra;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.FlowLayoutPanel flowFilter;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;

        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTraTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}