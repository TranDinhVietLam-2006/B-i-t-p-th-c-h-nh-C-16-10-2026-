namespace Bài_1
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

            this.lblMaLichHen = new System.Windows.Forms.Label();
            this.txtMaLichHen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();

            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblNgayGio = new System.Windows.Forms.Label();
            this.dtpNgayGio = new System.Windows.Forms.DateTimePicker();

            this.lblBacSi = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();

            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();

            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.flowFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.chkLocNgay = new System.Windows.Forms.CheckBox();
            this.dtpLocNgay = new System.Windows.Forms.DateTimePicker();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();

            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.colMaLichHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            // ================= menuStrip1 =================
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuFile });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 0;

            // menuFile
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuExportCSV, this.menuExit });
            this.menuFile.Name = "menuFile";
            this.menuFile.Text = "&Tệp";

            // menuExportCSV
            this.menuExportCSV.Name = "menuExportCSV";
            this.menuExportCSV.Text = "Xuất CSV...";
            this.menuExportCSV.Click += new System.EventHandler(this.menuExportCSV_Click);

            // menuExit
            this.menuExit.Name = "menuExit";
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);

            // ================= statusStrip1 =================
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1050, 22);
            this.statusStrip1.TabIndex = 1;

            // lblStatus
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Số lịch hẹn: 0";

            // ================= tableLayoutPanelMain =================
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelInput, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.flowFilter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dgvLichHen, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1050, 636);
            this.tableLayoutPanelMain.TabIndex = 2;

            // ================= tableLayoutPanelInput =================
            this.tableLayoutPanelInput.AutoSize = true;
            this.tableLayoutPanelInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelInput.ColumnCount = 4;
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInput.Controls.Add(this.lblMaLichHen, 0, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtMaLichHen, 1, 0);
            this.tableLayoutPanelInput.Controls.Add(this.lblHoTen, 2, 0);
            this.tableLayoutPanelInput.Controls.Add(this.txtHoTen, 3, 0);

            this.tableLayoutPanelInput.Controls.Add(this.lblSoDienThoai, 0, 1);
            this.tableLayoutPanelInput.Controls.Add(this.txtSoDienThoai, 1, 1);
            this.tableLayoutPanelInput.Controls.Add(this.lblNgayGio, 2, 1);
            this.tableLayoutPanelInput.Controls.Add(this.dtpNgayGio, 3, 1);

            this.tableLayoutPanelInput.Controls.Add(this.lblBacSi, 0, 2);
            this.tableLayoutPanelInput.Controls.Add(this.cboBacSi, 1, 2);
            this.tableLayoutPanelInput.Controls.Add(this.lblTrangThai, 2, 2);
            this.tableLayoutPanelInput.Controls.Add(this.cboTrangThai, 3, 2);

            this.tableLayoutPanelInput.Controls.Add(this.lblLyDo, 0, 3);
            this.tableLayoutPanelInput.Controls.Add(this.txtLyDo, 1, 3);
            this.tableLayoutPanelInput.SetColumnSpan(this.txtLyDo, 3);

            this.tableLayoutPanelInput.Controls.Add(this.flowButtons, 0, 4);
            this.tableLayoutPanelInput.SetColumnSpan(this.flowButtons, 4);

            this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelInput.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            this.tableLayoutPanelInput.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanelInput.RowCount = 5;
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInput.Size = new System.Drawing.Size(1044, 200);
            this.tableLayoutPanelInput.TabIndex = 0;

            // Labels + Controls
            System.Action<System.Windows.Forms.Label> styleLabel = (l) =>
            {
                l.AutoSize = true;
                l.Anchor = System.Windows.Forms.AnchorStyles.Left;
                l.Padding = new System.Windows.Forms.Padding(4, 6, 4, 0);
            };

            styleLabel(this.lblMaLichHen); this.lblMaLichHen.Text = "Mã lịch hẹn:";
            styleLabel(this.lblHoTen); this.lblHoTen.Text = "Họ tên bệnh nhân:";
            styleLabel(this.lblSoDienThoai); this.lblSoDienThoai.Text = "Số điện thoại:";
            styleLabel(this.lblNgayGio); this.lblNgayGio.Text = "Ngày giờ hẹn:";
            styleLabel(this.lblBacSi); this.lblBacSi.Text = "Bác sĩ:";
            styleLabel(this.lblTrangThai); this.lblTrangThai.Text = "Trạng thái:";
            styleLabel(this.lblLyDo); this.lblLyDo.Text = "Lý do khám:";

            System.Action<System.Windows.Forms.Control> styleControl = (c) =>
            {
                c.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
                c.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            };

            styleControl(this.txtMaLichHen);
            styleControl(this.txtHoTen);
            styleControl(this.txtSoDienThoai);
            styleControl(this.dtpNgayGio);
            styleControl(this.cboBacSi);
            styleControl(this.cboTrangThai);
            styleControl(this.txtLyDo);

            this.txtMaLichHen.Name = "txtMaLichHen";
            this.txtHoTen.Name = "txtHoTen";
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtLyDo.Name = "txtLyDo";

            this.dtpNgayGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayGio.ShowUpDown = true;

            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // ================= flowButtons =================
            this.flowButtons.AutoSize = true;
            this.flowButtons.Controls.Add(this.btnThem);
            this.flowButtons.Controls.Add(this.btnCapNhat);
            this.flowButtons.Controls.Add(this.btnXoa);
            this.flowButtons.Controls.Add(this.btnLamMoi);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowButtons.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowButtons.WrapContents = false;

            this.btnThem.Text = "Thêm";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // ================= flowFilter =================
            this.flowFilter.AutoSize = true;
            this.flowFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowFilter.Controls.Add(this.lblTimKiem);
            this.flowFilter.Controls.Add(this.txtTimKiem);
            this.flowFilter.Controls.Add(this.chkLocNgay);
            this.flowFilter.Controls.Add(this.dtpLocNgay);
            this.flowFilter.Controls.Add(this.lblLocTrangThai);
            this.flowFilter.Controls.Add(this.cboLocTrangThai);
            this.flowFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFilter.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.flowFilter.WrapContents = false;

            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Text = "Tìm kiếm (tên / SĐT):";
            this.lblTimKiem.Padding = new System.Windows.Forms.Padding(0, 6, 4, 0);

            this.txtTimKiem.Width = 220;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.Filter_Changed);

            this.chkLocNgay.AutoSize = true;
            this.chkLocNgay.Text = "Lọc theo ngày:";
            this.chkLocNgay.Padding = new System.Windows.Forms.Padding(12, 6, 4, 0);
            this.chkLocNgay.CheckedChanged += new System.EventHandler(this.Filter_Changed);

            this.dtpLocNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLocNgay.Width = 130;
            this.dtpLocNgay.ValueChanged += new System.EventHandler(this.Filter_Changed);

            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Text = "Trạng thái:";
            this.lblLocTrangThai.Padding = new System.Windows.Forms.Padding(12, 6, 4, 0);

            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Width = 150;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            // ================= dgvLichHen =================
            this.dgvLichHen.AllowUserToAddRows = false;
            this.dgvLichHen.AllowUserToDeleteRows = false;
            this.dgvLichHen.AutoGenerateColumns = false;
            this.dgvLichHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaLichHen, this.colHoTen, this.colSoDienThoai, this.colNgayGio,
                this.colBacSi, this.colLyDo, this.colTrangThai });
            this.dgvLichHen.DataSource = this.bindingSource1;
            this.dgvLichHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHen.Location = new System.Drawing.Point(3, 224);
            this.dgvLichHen.MultiSelect = false;
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.ReadOnly = true;
            this.dgvLichHen.RowHeadersWidth = 30;
            this.dgvLichHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHen.Size = new System.Drawing.Size(1044, 409);
            this.dgvLichHen.TabIndex = 1;

            // Columns
            this.colMaLichHen.HeaderText = "Mã lịch hẹn";
            this.colMaLichHen.DataPropertyName = "MaLichHen";
            this.colMaLichHen.FillWeight = 70F;

            this.colHoTen.HeaderText = "Họ tên bệnh nhân";
            this.colHoTen.DataPropertyName = "HoTenBenhNhan";
            this.colHoTen.FillWeight = 130F;

            this.colSoDienThoai.HeaderText = "Số điện thoại";
            this.colSoDienThoai.DataPropertyName = "SoDienThoai";
            this.colSoDienThoai.FillWeight = 80F;

            this.colNgayGio.HeaderText = "Ngày giờ hẹn";
            this.colNgayGio.DataPropertyName = "NgayGioHen";
            this.colNgayGio.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            this.colNgayGio.FillWeight = 90F;

            this.colBacSi.HeaderText = "Bác sĩ";
            this.colBacSi.DataPropertyName = "BacSi";
            this.colBacSi.FillWeight = 100F;

            this.colLyDo.HeaderText = "Lý do khám";
            this.colLyDo.DataPropertyName = "LyDoKham";
            this.colLyDo.FillWeight = 140F;

            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 80F;

            // ================= errorProvider1 =================
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;

            // ================= bindingSource1 =================
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);

            // ================= saveFileDialog1 =================
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialog1.Title = "Chọn nơi lưu file CSV";

            // ================= Form1 =================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 682);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1 - Quản lý lịch hẹn phòng khám";
        }

        #endregion

        // Designer fields
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExportCSV;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;

        private System.Windows.Forms.Label lblMaLichHen;
        private System.Windows.Forms.TextBox txtMaLichHen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblNgayGio;
        private System.Windows.Forms.DateTimePicker dtpNgayGio;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;

        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.FlowLayoutPanel flowFilter;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.CheckBox chkLocNgay;
        private System.Windows.Forms.DateTimePicker dtpLocNgay;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;

        private System.Windows.Forms.DataGridView dgvLichHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLichHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
