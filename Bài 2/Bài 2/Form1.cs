using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {
        private readonly BindingList<PhieuMuon> _allPhieu = new BindingList<PhieuMuon>();
        private bool _suppressLoad = false;

        private static readonly string[] ThietBiList =
        {
            "Kính hiển vi",
            "Máy đo pH",
            "Cân điện tử",
            "Bộ dụng cụ thí nghiệm hóa",
            "Máy ly tâm",
            "Ống nghiệm (bộ 10)",
            "Buret 25ml",
            "Máy quang phổ UV-Vis"
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
            cboThietBi.Items.Clear();
            cboThietBi.Items.AddRange(ThietBiList);

            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.Add("(Tất cả)");
            cboLocTrangThai.Items.Add("Đang mượn");
            cboLocTrangThai.Items.Add("Đã trả");
            cboLocTrangThai.Items.Add("Quá hạn");
            cboLocTrangThai.SelectedIndex = 0;
        }

        private void SeedSampleData()
        {
            var p1 = new PhieuMuon
            {
                MaPhieu = "PM001",
                MaSinhVien = "SV001",
                HoTenSinhVien = "Nguyễn Văn An",
                ThietBi = "Kính hiển vi",
                SoLuong = 2,
                NgayMuon = DateTime.Today.AddDays(-5),
                HanTra = DateTime.Today.AddDays(-1),
                NgayTraThucTe = null
            };
            p1.UpdateTinhTrang();
            _allPhieu.Add(p1);

            var p2 = new PhieuMuon
            {
                MaPhieu = "PM002",
                MaSinhVien = "SV002",
                HoTenSinhVien = "Trần Thị Bình",
                ThietBi = "Máy đo pH",
                SoLuong = 1,
                NgayMuon = DateTime.Today.AddDays(-2),
                HanTra = DateTime.Today.AddDays(3),
                NgayTraThucTe = null
            };
            p2.UpdateTinhTrang();
            _allPhieu.Add(p2);

            var p3 = new PhieuMuon
            {
                MaPhieu = "PM003",
                MaSinhVien = "SV003",
                HoTenSinhVien = "Lê Văn Cường",
                ThietBi = "Cân điện tử",
                SoLuong = 1,
                NgayMuon = DateTime.Today.AddDays(-10),
                HanTra = DateTime.Today.AddDays(-5),
                NgayTraThucTe = DateTime.Today.AddDays(-6)
            };
            p3.UpdateTinhTrang();
            _allPhieu.Add(p3);
        }

        private void ApplyFilter()
        {
            _suppressLoad = true;

            foreach (var p in _allPhieu) p.UpdateTinhTrang();

            string keyword = (txtTimKiem.Text ?? "").Trim().ToLower();
            string statusFilter = cboLocTrangThai.SelectedItem?.ToString();
            bool allStatus = string.IsNullOrEmpty(statusFilter) || statusFilter == "(Tất cả)";

            List<PhieuMuon> filtered = _allPhieu.Where(p =>
                (string.IsNullOrEmpty(keyword)
                    || (p.MaSinhVien ?? "").ToLower().Contains(keyword)
                    || (p.ThietBi ?? "").ToLower().Contains(keyword))
                && (allStatus || p.TinhTrang == statusFilter)
            ).ToList();

            bindingSource1.DataSource = new BindingList<PhieuMuon>(filtered);

            int overdue = filtered.Count(p => p.TinhTrang == "Quá hạn");
            lblStatus.Text = $"Tổng số phiếu: {filtered.Count} / {_allPhieu.Count} | Quá hạn: {overdue}";

            _suppressLoad = false;
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (_suppressLoad) return;

            PhieuMuon p = bindingSource1.Current as PhieuMuon;
            if (p == null) return;

            txtMaPhieu.Text = p.MaPhieu;
            txtMaSV.Text = p.MaSinhVien;
            txtHoTenSV.Text = p.HoTenSinhVien;
            cboThietBi.SelectedItem = p.ThietBi;
            numSoLuong.Value = Math.Max(numSoLuong.Minimum, Math.Min(numSoLuong.Maximum, p.SoLuong));
            dtpNgayMuon.Value = p.NgayMuon;
            dtpHanTra.Value = p.HanTra;
            if (p.NgayTraThucTe.HasValue)
            {
                chkDaTra.Checked = true;
                dtpNgayTraThucTe.Value = p.NgayTraThucTe.Value;
            }
            else
            {
                chkDaTra.Checked = false;
                dtpNgayTraThucTe.Value = DateTime.Today;
            }
            txtTinhTrang.Text = p.TinhTrang;

            errorProvider1.Clear();
        }

        private void PreviewTinhTrang_Changed(object sender, EventArgs e)
        {
            PreviewTinhTrang();
        }

        private void chkDaTra_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayTraThucTe.Enabled = chkDaTra.Checked;
            PreviewTinhTrang();
        }

        private void PreviewTinhTrang()
        {
            if (_suppressLoad) return;

            if (chkDaTra.Checked)
                txtTinhTrang.Text = "Đã trả";
            else if (dtpHanTra.Value.Date < DateTime.Today)
                txtTinhTrang.Text = "Quá hạn";
            else
                txtTinhTrang.Text = "Đang mượn";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(null)) return;

            var p = new PhieuMuon
            {
                MaPhieu = txtMaPhieu.Text.Trim(),
                MaSinhVien = txtMaSV.Text.Trim(),
                HoTenSinhVien = txtHoTenSV.Text.Trim(),
                ThietBi = cboThietBi.Text,
                SoLuong = (int)numSoLuong.Value,
                NgayMuon = dtpNgayMuon.Value.Date,
                HanTra = dtpHanTra.Value.Date,
                NgayTraThucTe = chkDaTra.Checked ? (DateTime?)dtpNgayTraThucTe.Value.Date : null
            };
            p.UpdateTinhTrang();

            _allPhieu.Add(p);
            ApplyFilter();

            MessageBox.Show("Thêm phiếu mượn thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInput();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            PhieuMuon current = bindingSource1.Current as PhieuMuon;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu để cập nhật!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(current)) return;

            current.MaPhieu = txtMaPhieu.Text.Trim();
            current.MaSinhVien = txtMaSV.Text.Trim();
            current.HoTenSinhVien = txtHoTenSV.Text.Trim();
            current.ThietBi = cboThietBi.Text;
            current.SoLuong = (int)numSoLuong.Value;
            current.NgayMuon = dtpNgayMuon.Value.Date;
            current.HanTra = dtpHanTra.Value.Date;
            current.NgayTraThucTe = chkDaTra.Checked ? (DateTime?)dtpNgayTraThucTe.Value.Date : null;
            current.UpdateTinhTrang();

            ApplyFilter();

            MessageBox.Show("Cập nhật phiếu mượn thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuMuon current = bindingSource1.Current as PhieuMuon;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show(
                $"Bạn có chắc muốn xóa phiếu [{current.MaPhieu}] của SV {current.HoTenSinhVien}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _allPhieu.Remove(current);
                ApplyFilter();
                ClearInput();

                MessageBox.Show("Xóa phiếu mượn thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDanhDauDaTra_Click(object sender, EventArgs e)
        {
            PhieuMuon current = bindingSource1.Current as PhieuMuon;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu để đánh dấu đã trả!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (current.NgayTraThucTe.HasValue)
            {
                MessageBox.Show("Phiếu này đã được đánh dấu trả trước đó!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show(
                $"Đánh dấu phiếu [{current.MaPhieu}] đã trả vào ngày hôm nay ({DateTime.Today:dd/MM/yyyy})?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r != DialogResult.Yes) return;

            current.NgayTraThucTe = DateTime.Today;
            current.UpdateTinhTrang();

            chkDaTra.Checked = true;
            dtpNgayTraThucTe.Value = current.NgayTraThucTe.Value;
            txtTinhTrang.Text = current.TinhTrang;

            ApplyFilter();

            MessageBox.Show("Đã đánh dấu trả thiết bị thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtTimKiem.Text = "";
            cboLocTrangThai.SelectedIndex = 0;
            ApplyFilter();
        }

        private bool ValidateInput(PhieuMuon editing)
        {
            errorProvider1.Clear();
            bool ok = true;

            string ma = txtMaPhieu.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                errorProvider1.SetError(txtMaPhieu, "Vui lòng nhập mã phiếu!");
                ok = false;
            }
            else if (_allPhieu.Any(p => p != editing &&
                        string.Equals(p.MaPhieu, ma, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaPhieu, "Mã phiếu đã tồn tại!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errorProvider1.SetError(txtMaSV, "Vui lòng nhập mã sinh viên!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTenSV.Text))
            {
                errorProvider1.SetError(txtHoTenSV, "Vui lòng nhập họ tên sinh viên!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(cboThietBi.Text))
            {
                errorProvider1.SetError(cboThietBi, "Vui lòng chọn thiết bị!");
                ok = false;
            }

            if (numSoLuong.Value <= 0)
            {
                errorProvider1.SetError(numSoLuong, "Số lượng phải lớn hơn 0!");
                ok = false;
            }

            if (dtpHanTra.Value.Date < dtpNgayMuon.Value.Date)
            {
                errorProvider1.SetError(dtpHanTra, "Hạn trả không được trước ngày mượn!");
                ok = false;
            }

            if (chkDaTra.Checked && dtpNgayTraThucTe.Value.Date < dtpNgayMuon.Value.Date)
            {
                errorProvider1.SetError(dtpNgayTraThucTe, "Ngày trả thực tế không được trước ngày mượn!");
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

            txtMaPhieu.Clear();
            txtMaSV.Clear();
            txtHoTenSV.Clear();
            if (cboThietBi.Items.Count > 0) cboThietBi.SelectedIndex = 0;
            numSoLuong.Value = numSoLuong.Minimum;
            dtpNgayMuon.Value = DateTime.Today;
            dtpHanTra.Value = DateTime.Today.AddDays(7);
            chkDaTra.Checked = false;
            dtpNgayTraThucTe.Value = DateTime.Today;
            dtpNgayTraThucTe.Enabled = false;
            txtTinhTrang.Text = "";

            errorProvider1.Clear();

            _suppressLoad = false;
        }

        private void menuExportCSV_Click(object sender, EventArgs e)
        {
            var list = bindingSource1.DataSource as BindingList<PhieuMuon>;
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.FileName = "DanhSachPhieuMuon_" + DateTime.Now.ToString("yyyyMMdd_HHmm");

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var sw = new StreamWriter(saveFileDialog1.FileName, false, new UTF8Encoding(true)))
                {
                    sw.WriteLine("Mã phiếu,Mã sinh viên,Họ tên sinh viên,Thiết bị,Số lượng,Ngày mượn,Hạn trả,Ngày trả thực tế,Tình trạng");

                    foreach (var p in list)
                    {
                        sw.WriteLine(string.Join(",",
                            CsvEscape(p.MaPhieu),
                            CsvEscape(p.MaSinhVien),
                            CsvEscape(p.HoTenSinhVien),
                            CsvEscape(p.ThietBi),
                            p.SoLuong.ToString(),
                            CsvEscape(p.NgayMuon.ToString("dd/MM/yyyy")),
                            CsvEscape(p.HanTra.ToString("dd/MM/yyyy")),
                            CsvEscape(p.NgayTraThucTe.HasValue
                                        ? p.NgayTraThucTe.Value.ToString("dd/MM/yyyy")
                                        : ""),
                            CsvEscape(p.TinhTrang)));
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