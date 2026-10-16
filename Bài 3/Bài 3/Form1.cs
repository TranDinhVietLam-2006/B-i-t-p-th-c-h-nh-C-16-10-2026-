using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class Form1 : Form
    {
        private readonly BindingList<DonSuaChua> _allDon = new BindingList<DonSuaChua>();
        private bool _suppressLoad = false;
        private string _currentImagePath = null;

        private static readonly string[] LoaiThietBiList =
        {
            "Tivi",
            "Tủ lạnh",
            "Máy giặt",
            "Điều hòa",
            "Máy tính / Laptop",
            "Điện thoại",
            "Lò vi sóng",
            "Quạt điện"
        };

        private static readonly string[] TrangThaiList =
        {
            "Mới tiếp nhận",
            "Đang sửa",
            "Chờ linh kiện",
            "Hoàn tất",
            "Đã hủy"
        };

        public Form1()
        {
            InitializeComponent();

            SetupComboBoxes();
            SeedSampleData();

            ApplyFilter();
            ClearInput();
        }

        private void SetupComboBoxes()
        {
            cboLoaiTB.Items.Clear();
            cboLoaiTB.Items.AddRange(LoaiThietBiList);

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(TrangThaiList);

            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.Add("(Tất cả)");
            cboLocTrangThai.Items.AddRange(TrangThaiList);
            cboLocTrangThai.SelectedIndex = 0;
        }

        private void SeedSampleData()
        {
            _allDon.Add(new DonSuaChua
            {
                MaDon = "DH001",
                TenKhachHang = "Nguyễn Văn An",
                SoDienThoai = "0901111222",
                LoaiThietBi = "Tivi",
                MoTaLoi = "Không lên nguồn, đèn đỏ nhấp nháy",
                NgayTiepNhan = DateTime.Today.AddDays(-3),
                ChiPhiDuKien = 500000,
                TrangThai = "Đang sửa",
                AnhThietBi = null
            });

            _allDon.Add(new DonSuaChua
            {
                MaDon = "DH002",
                TenKhachHang = "Trần Thị Bình",
                SoDienThoai = "0903333444",
                LoaiThietBi = "Tủ lạnh",
                MoTaLoi = "Không lạnh, ngăn đá vẫn đông",
                NgayTiepNhan = DateTime.Today.AddDays(-1),
                ChiPhiDuKien = 800000,
                TrangThai = "Chờ linh kiện",
                AnhThietBi = null
            });

            _allDon.Add(new DonSuaChua
            {
                MaDon = "DH003",
                TenKhachHang = "Lê Văn Cường",
                SoDienThoai = "0905555666",
                LoaiThietBi = "Máy giặt",
                MoTaLoi = "Không vắt, có tiếng kêu lạ",
                NgayTiepNhan = DateTime.Today.AddDays(-7),
                ChiPhiDuKien = 1200000,
                TrangThai = "Hoàn tất",
                AnhThietBi = null
            });
        }

        private void ApplyFilter()
        {
            _suppressLoad = true;

            string keyword = (txtTimKiem.Text ?? "").Trim().ToLower();
            string statusFilter = cboLocTrangThai.SelectedItem?.ToString();
            bool allStatus = string.IsNullOrEmpty(statusFilter) || statusFilter == "(Tất cả)";

            List<DonSuaChua> filtered = _allDon.Where(d =>
                (string.IsNullOrEmpty(keyword)
                    || (d.MaDon ?? "").ToLower().Contains(keyword)
                    || (d.TenKhachHang ?? "").ToLower().Contains(keyword)
                    || (d.SoDienThoai ?? "").Contains(keyword))
                && (allStatus || d.TrangThai == statusFilter)
            ).ToList();

            bindingSource1.DataSource = new BindingList<DonSuaChua>(filtered);

            decimal tongChiPhi = filtered
                .Where(d => d.TrangThai != "Hoàn tất" && d.TrangThai != "Đã hủy")
                .Sum(d => d.ChiPhiDuKien);

            lblStatus.Text = $"Số đơn: {filtered.Count} / {_allDon.Count} | Tổng chi phí chưa hoàn tất: {tongChiPhi:N0} VNĐ";

            _suppressLoad = false;
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (_suppressLoad) return;

            DonSuaChua d = bindingSource1.Current as DonSuaChua;
            if (d == null) return;

            txtMaDon.Text = d.MaDon;
            txtTenKH.Text = d.TenKhachHang;
            txtSDT.Text = d.SoDienThoai;
            cboLoaiTB.SelectedItem = d.LoaiThietBi;
            txtMoTaLoi.Text = d.MoTaLoi;
            dtpNgayTiepNhan.Value = d.NgayTiepNhan < dtpNgayTiepNhan.MinDate
                                        ? DateTime.Today
                                        : d.NgayTiepNhan;
            numChiPhi.Value = Math.Max(numChiPhi.Minimum,
                                Math.Min(numChiPhi.Maximum, d.ChiPhiDuKien));
            cboTrangThai.SelectedItem = d.TrangThai;

            _currentImagePath = d.AnhThietBi;
            LoadImagePreview(_currentImagePath);

            errorProvider1.Clear();
        }

        private void LoadImagePreview(string path)
        {
            if (picThietBi.Image != null)
            {
                picThietBi.Image.Dispose();
                picThietBi.Image = null;
            }

            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return;

            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    var img = Image.FromStream(fs);
                    picThietBi.Image = new Bitmap(img);
                }
            }
            catch
            {
                picThietBi.Image = null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            _currentImagePath = openFileDialog1.FileName;
            LoadImagePreview(_currentImagePath);
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            _currentImagePath = null;
            LoadImagePreview(null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(null)) return;

            var d = new DonSuaChua
            {
                MaDon = txtMaDon.Text.Trim(),
                TenKhachHang = txtTenKH.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                LoaiThietBi = cboLoaiTB.Text,
                MoTaLoi = txtMoTaLoi.Text.Trim(),
                NgayTiepNhan = dtpNgayTiepNhan.Value.Date,
                ChiPhiDuKien = numChiPhi.Value,
                TrangThai = cboTrangThai.Text,
                AnhThietBi = _currentImagePath
            };

            _allDon.Add(d);
            ApplyFilter();

            MessageBox.Show("Thêm đơn thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInput();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DonSuaChua current = bindingSource1.Current as DonSuaChua;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn để cập nhật!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(current)) return;

            current.MaDon = txtMaDon.Text.Trim();
            current.TenKhachHang = txtTenKH.Text.Trim();
            current.SoDienThoai = txtSDT.Text.Trim();
            current.LoaiThietBi = cboLoaiTB.Text;
            current.MoTaLoi = txtMoTaLoi.Text.Trim();
            current.NgayTiepNhan = dtpNgayTiepNhan.Value.Date;
            current.ChiPhiDuKien = numChiPhi.Value;
            current.TrangThai = cboTrangThai.Text;
            current.AnhThietBi = _currentImagePath;

            ApplyFilter();

            MessageBox.Show("Cập nhật đơn thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DonSuaChua current = bindingSource1.Current as DonSuaChua;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show(
                $"Bạn có chắc muốn xóa đơn [{current.MaDon}] của {current.TenKhachHang}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _allDon.Remove(current);
                ApplyFilter();
                ClearInput();

                MessageBox.Show("Xóa đơn thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtTimKiem.Text = "";
            cboLocTrangThai.SelectedIndex = 0;
            ApplyFilter();
        }

        private bool ValidateInput(DonSuaChua editing)
        {
            errorProvider1.Clear();
            bool ok = true;

            string ma = txtMaDon.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                errorProvider1.SetError(txtMaDon, "Vui lòng nhập mã đơn!");
                ok = false;
            }
            else if (_allDon.Any(d => d != editing &&
                        string.Equals(d.MaDon, ma, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaDon, "Mã đơn đã tồn tại!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                errorProvider1.SetError(txtTenKH, "Vui lòng nhập tên khách hàng!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(cboLoaiTB.Text))
            {
                errorProvider1.SetError(cboLoaiTB, "Vui lòng chọn loại thiết bị!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtMoTaLoi.Text))
            {
                errorProvider1.SetError(txtMoTaLoi, "Vui lòng nhập mô tả lỗi!");
                ok = false;
            }

            if (numChiPhi.Value < 0)
            {
                errorProvider1.SetError(numChiPhi, "Chi phí dự kiến phải là số không âm!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(cboTrangThai.Text))
            {
                errorProvider1.SetError(cboTrangThai, "Vui lòng chọn trạng thái!");
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các trường được đánh dấu đỏ!",
                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ok;
        }

        private void ClearInput()
        {
            _suppressLoad = true;

            txtMaDon.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            if (cboLoaiTB.Items.Count > 0) cboLoaiTB.SelectedIndex = 0;
            txtMoTaLoi.Clear();
            dtpNgayTiepNhan.Value = DateTime.Today;
            numChiPhi.Value = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;

            _currentImagePath = null;
            LoadImagePreview(null);

            errorProvider1.Clear();

            _suppressLoad = false;
        }

        private void menuExportCSV_Click(object sender, EventArgs e)
        {
            var list = bindingSource1.DataSource as BindingList<DonSuaChua>;
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.FileName = "DanhSachDonSuaChua_" + DateTime.Now.ToString("yyyyMMdd_HHmm");

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var sw = new StreamWriter(saveFileDialog1.FileName, false, new UTF8Encoding(true)))
                {
                    sw.WriteLine("Mã đơn,Tên khách hàng,Số điện thoại,Loại thiết bị,Mô tả lỗi,Ngày tiếp nhận,Chi phí dự kiến,Trạng thái");

                    foreach (var d in list)
                    {
                        sw.WriteLine(string.Join(",",
                            CsvEscape(d.MaDon),
                            CsvEscape(d.TenKhachHang),
                            CsvEscape(d.SoDienThoai),
                            CsvEscape(d.LoaiThietBi),
                            CsvEscape(d.MoTaLoi),
                            CsvEscape(d.NgayTiepNhan.ToString("dd/MM/yyyy")),
                            d.ChiPhiDuKien.ToString("N0"),
                            CsvEscape(d.TrangThai)));
                    }
                }

                MessageBox.Show($"Xuất file CSV thành công!\n{saveFileDialog1.FileName}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CsvEscape(string s)
        {
            if (s == null) return "";
            if (s.Contains(",") || s.Contains("\"") || s.Contains("\n"))
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Bạn có chắc muốn thoát?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}