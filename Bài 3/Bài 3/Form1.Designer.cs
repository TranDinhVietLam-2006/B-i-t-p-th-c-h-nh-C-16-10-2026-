namespace Bài_3
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
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelImage = new System.Windows.Forms.TableLayoutPanel();

            this.lblMaDon = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();

            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblLoaiTB = new System.Windows.Forms.Label();
            this.cboLoaiTB = new System.Windows.Forms.ComboBox();

            this.lblNgayTiepNhan = new System.Windows.Forms.Label();
            this.dtpNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();

            this.lblChiPhi = new System.Windows.Forms.Label();
            this.numChiPhi = new System.Windows.Forms.NumericUpDown();

            this.lblMoTaLoi = new System.Windows.Forms.Label();
            this.txtMoTaLoi = new System.Windows.Forms.TextBox();

            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.picThietBi = new System.Windows.Forms.PictureBox();
            this.flowImageButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXoaAnh = new System.Windows.Forms.Button();

            this.flowFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();

            this.dgvDon = new System.Windows.Forms.DataGridView();
            this.colMaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuFile });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 720);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 1;

            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Số đơn: 0";

            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.flowFilter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dgvDon, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1150, 696);
            this.tableLayoutPanelMain.TabIndex = 2;

            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanelInput, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanelImage, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanelTop.AutoSize = true;
            this.tableLayoutPanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.TabIndex = 0;

            this.tableLayoutPanelInput.AutoSize = true;
            this.tableLayoutPanelInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelInput.ColumnCount = 4;
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            this.tableLayoutPanelInput.Controls.Add(this.lblMaDon, 0, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtMaDon, 1, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblTenKH, 2, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtTenKH, 3, 0);

            this.tableLayoutPanelInput.Controls.Add(this.lblSDT, 0, 1);
            this.tableLayoutPanelInput.Controls.Add(this.txtSDT, 1, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblLoaiTB, 2, 1);
            this.tableLayoutPanelInput.Controls.Add(this.cboLoaiTB, 3, 1);

            this.tableLayoutPanelInput.Controls.Add(this.lblNgayTiepNhan, 0, 2);
            this.tableLayoutPanelInput.Controls.Add(this.dtpNgayTiepNhan, 1, 2);
            this.tableLayoutPanelInput.Controls.Add(this.lblTrangThai, 2, 2);
            this.tableLayoutPanelInput.Controls.Add(this.cboTrangThai, 3, 2);

            this.tableLayoutPanelInput.Controls.Add(this.lblChiPhi, 0, 3);
            this.tableLayoutPanelInput.Controls.Add(this.numChiPhi, 1, 3);
            this.tableLayoutPanelInput.SetColumnSpan(this.numChiPhi, 3);

            this.tableLayoutPanelInput.Controls.Add(this.lblMoTaLoi, 0, 4);
            this.tableLayoutPanelInput.Controls.Add(this.txtMoTaLoi, 1, 4);
            this.tableLayoutPanelInput.SetColumnSpan(this.txtMoTaLoi, 3);

            this.tableLayoutPanelInput.Controls.Add(this.flowButtons, 0, 5);
            this.tableLayoutPanelInput.SetColumnSpan(this.flowButtons, 4);

            this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            this.tableLayoutPanelInput.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanelInput.RowCount = 6;
            for (int i = 0; i < 6; i++)
                this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());

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

            styleLabel(this.lblMaDon); this.lblMaDon.Text = "Mã đơn:";
            styleLabel(this.lblTenKH); this.lblTenKH.Text = "Tên khách hàng:";
            styleLabel(this.lblSDT); this.lblSDT.Text = "Số điện thoại:";
            styleLabel(this.lblLoaiTB); this.lblLoaiTB.Text = "Loại thiết bị:";
            styleLabel(this.lblNgayTiepNhan); this.lblNgayTiepNhan.Text = "Ngày tiếp nhận:";
            styleLabel(this.lblTrangThai); this.lblTrangThai.Text = "Trạng thái:";
            styleLabel(this.lblChiPhi); this.lblChiPhi.Text = "Chi phí dự kiến:";
            styleLabel(this.lblMoTaLoi); this.lblMoTaLoi.Text = "Mô tả lỗi:";

            styleControl(this.txtMaDon);
            styleControl(this.txtTenKH);
            styleControl(this.txtSDT);
            styleControl(this.cboLoaiTB);
            styleControl(this.dtpNgayTiepNhan);
            styleControl(this.cboTrangThai);
            styleControl(this.numChiPhi);
            styleControl(this.txtMoTaLoi);

            this.txtMoTaLoi.Multiline = true;
            this.txtMoTaLoi.Height = 60;

            this.cboLoaiTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.dtpNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.numChiPhi.Minimum = 0;
            this.numChiPhi.Maximum = 1000000000;
            this.numChiPhi.DecimalPlaces = 0;
            this.numChiPhi.ThousandsSeparator = true;

            this.flowButtons.AutoSize = true;
            this.flowButtons.Controls.Add(this.btnThem);
            this.flowButtons.Controls.Add(this.btnCapNhat);
            this.flowButtons.Controls.Add(this.btnXoa);
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

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.tableLayoutPanelImage.ColumnCount = 1;
            this.tableLayoutPanelImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelImage.Controls.Add(this.picThietBi, 0, 0);
            this.tableLayoutPanelImage.Controls.Add(this.flowImageButtons, 0, 1);
            this.tableLayoutPanelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelImage.RowCount = 2;
            this.tableLayoutPanelImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanelImage.Name = "tableLayoutPanelImage";
            this.tableLayoutPanelImage.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanelImage.TabIndex = 1;

            this.picThietBi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picThietBi.Name = "picThietBi";
            this.picThietBi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThietBi.TabStop = false;
            this.picThietBi.MinimumSize = new System.Drawing.Size(200, 180);

            this.flowImageButtons.AutoSize = true;
            this.flowImageButtons.Controls.Add(this.btnChonAnh);
            this.flowImageButtons.Controls.Add(this.btnXoaAnh);
            this.flowImageButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowImageButtons.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowImageButtons.WrapContents = false;

            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.Size = new System.Drawing.Size(110, 30);
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

            this.btnXoaAnh.Text = "Xóa ảnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(90, 30);
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);

            this.flowFilter.AutoSize = true;
            this.flowFilter.Controls.Add(this.lblTimKiem);
            this.flowFilter.Controls.Add(this.txtTimKiem);
            this.flowFilter.Controls.Add(this.lblLocTrangThai);
            this.flowFilter.Controls.Add(this.cboLocTrangThai);
            this.flowFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFilter.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.flowFilter.WrapContents = false;

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Text = "Tìm kiếm (mã đơn / tên / SĐT):";
            this.lblTimKiem.Padding = new System.Windows.Forms.Padding(0, 6, 4, 0);

            this.txtTimKiem.Width = 280;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.Filter_Changed);

            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Text = "Lọc trạng thái:";
            this.lblLocTrangThai.Padding = new System.Windows.Forms.Padding(12, 6, 4, 0);

            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Width = 170;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            this.dgvDon.AllowUserToAddRows = false;
            this.dgvDon.AllowUserToDeleteRows = false;
            this.dgvDon.AutoGenerateColumns = false;
            this.dgvDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaDon, this.colTenKH, this.colSDT, this.colLoaiTB,
                this.colMoTaLoi, this.colNgayTiepNhan, this.colChiPhi, this.colTrangThai });
            this.dgvDon.DataSource = this.bindingSource1;
            this.dgvDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDon.MultiSelect = false;
            this.dgvDon.Name = "dgvDon";
            this.dgvDon.ReadOnly = true;
            this.dgvDon.RowHeadersWidth = 30;
            this.dgvDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDon.TabIndex = 1;

            this.colMaDon.HeaderText = "Mã đơn"; this.colMaDon.DataPropertyName = "MaDon"; this.colMaDon.FillWeight = 60F;
            this.colTenKH.HeaderText = "Tên khách hàng"; this.colTenKH.DataPropertyName = "TenKhachHang"; this.colTenKH.FillWeight = 120F;
            this.colSDT.HeaderText = "Số điện thoại"; this.colSDT.DataPropertyName = "SoDienThoai"; this.colSDT.FillWeight = 80F;
            this.colLoaiTB.HeaderText = "Loại thiết bị"; this.colLoaiTB.DataPropertyName = "LoaiThietBi"; this.colLoaiTB.FillWeight = 100F;
            this.colMoTaLoi.HeaderText = "Mô tả lỗi"; this.colMoTaLoi.DataPropertyName = "MoTaLoi"; this.colMoTaLoi.FillWeight = 160F;
            this.colNgayTiepNhan.HeaderText = "Ngày tiếp nhận"; this.colNgayTiepNhan.DataPropertyName = "NgayTiepNhan"; this.colNgayTiepNhan.DefaultCellStyle.Format = "dd/MM/yyyy"; this.colNgayTiepNhan.FillWeight = 90F;
            this.colChiPhi.HeaderText = "Chi phí dự kiến"; this.colChiPhi.DataPropertyName = "ChiPhiDuKien"; this.colChiPhi.DefaultCellStyle.Format = "N0"; this.colChiPhi.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight; this.colChiPhi.FillWeight = 90F;
            this.colTrangThai.HeaderText = "Trạng thái"; this.colTrangThai.DataPropertyName = "TrangThai"; this.colTrangThai.FillWeight = 90F;

            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;

            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);

            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialog1.Title = "Chọn nơi lưu file CSV";

            this.openFileDialog1.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Chọn ảnh thiết bị";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 742);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 3 - Quản lý đơn đăng ký dịch vụ sửa chữa";
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExportCSV;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelImage;

        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblLoaiTB;
        private System.Windows.Forms.ComboBox cboLoaiTB;
        private System.Windows.Forms.Label lblNgayTiepNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayTiepNhan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.NumericUpDown numChiPhi;
        private System.Windows.Forms.Label lblMoTaLoi;
        private System.Windows.Forms.TextBox txtMoTaLoi;

        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.PictureBox picThietBi;
        private System.Windows.Forms.FlowLayoutPanel flowImageButtons;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnXoaAnh;

        private System.Windows.Forms.FlowLayoutPanel flowFilter;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;

        private System.Windows.Forms.DataGridView dgvDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
