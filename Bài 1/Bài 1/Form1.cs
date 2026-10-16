using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bài_1
{
    public partial class Form1 : Form
    {
        
        private readonly BindingList<Appointment> _allAppointments = new BindingList<Appointment>();

       
        private bool _suppressLoad = false;

        private static readonly string[] Doctors =
        {
            "BS. Nguyễn Văn An",
            "BS. Trần Thị Bình",
            "BS. Lê Văn Cường",
            "BS. Phạm Thị Dung"
        };

        private static readonly string[] Statuses =
        {
            "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy"
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
            cboBacSi.Items.Clear();
            cboBacSi.Items.AddRange(Doctors);

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(Statuses);

            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.Add("(Tất cả)");
            cboLocTrangThai.Items.AddRange(Statuses);
            cboLocTrangThai.SelectedIndex = 0;
        }

        private void SeedSampleData()
        {
            _allAppointments.Add(new Appointment
            {
                MaLichHen = "LH001",
                HoTenBenhNhan = "Nguyễn Thị Hoa",
                SoDienThoai = "0901234567",
                NgayGioHen = DateTime.Now.Date.AddHours(9),
                BacSi = Doctors[0],
                LyDoKham = "Khám tổng quát",
                TrangThai = "Chờ khám"
            });

            _allAppointments.Add(new Appointment
            {
                MaLichHen = "LH002",
                HoTenBenhNhan = "Trần Văn Nam",
                SoDienThoai = "0912345678",
                NgayGioHen = DateTime.Now.Date.AddHours(10).AddMinutes(30),
                BacSi = Doctors[1],
                LyDoKham = "Đau dạ dày",
                TrangThai = "Đang khám"
            });

            _allAppointments.Add(new Appointment
            {
                MaLichHen = "LH003",
                HoTenBenhNhan = "Lê Thị Mai",
                SoDienThoai = "0987654321",
                NgayGioHen = DateTime.Now.Date.AddDays(1).AddHours(14),
                BacSi = Doctors[2],
                LyDoKham = "Tái khám tim mạch",
                TrangThai = "Chờ khám"
            });
        }

   
        private void ApplyFilter()
        {
            _suppressLoad = true;

            string keyword = (txtTimKiem.Text ?? "").Trim().ToLower();
            DateTime? filterDate = chkLocNgay.Checked ? (DateTime?)dtpLocNgay.Value.Date : null;
            string statusFilter = cboLocTrangThai.SelectedItem?.ToString();
            bool allStatus = string.IsNullOrEmpty(statusFilter) || statusFilter == "(Tất cả)";

            List<Appointment> filtered = _allAppointments.Where(a =>
                (string.IsNullOrEmpty(keyword)
                    || (a.HoTenBenhNhan ?? "").ToLower().Contains(keyword)
                    || (a.SoDienThoai ?? "").Contains(keyword))
                && (!filterDate.HasValue || a.NgayGioHen.Date == filterDate.Value)
                && (allStatus || a.TrangThai == statusFilter)
            ).ToList();

            bindingSource1.DataSource = new BindingList<Appointment>(filtered);

            lblStatus.Text = $"Số lịch hẹn: {filtered.Count} / {_allAppointments.Count}";

            _suppressLoad = false;
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

     
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (_suppressLoad) return;

            Appointment ap = bindingSource1.Current as Appointment;
            if (ap == null) return;

            txtMaLichHen.Text = ap.MaLichHen;
            txtHoTen.Text = ap.HoTenBenhNhan;
            txtSoDienThoai.Text = ap.SoDienThoai;
            dtpNgayGio.Value = ap.NgayGioHen < dtpNgayGio.MinDate
                                ? DateTime.Now
                                : ap.NgayGioHen;
            cboBacSi.SelectedItem = ap.BacSi;
            cboTrangThai.SelectedItem = ap.TrangThai;
            txtLyDo.Text = ap.LyDoKham;

            errorProvider1.Clear();
        }

      
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(null)) return;

            var ap = new Appointment
            {
                MaLichHen = txtMaLichHen.Text.Trim(),
                HoTenBenhNhan = txtHoTen.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                NgayGioHen = dtpNgayGio.Value,
                BacSi = cboBacSi.Text,
                LyDoKham = txtLyDo.Text.Trim(),
                TrangThai = cboTrangThai.Text
            };

            _allAppointments.Add(ap);
            ApplyFilter();

            MessageBox.Show("Thêm lịch hẹn thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInput();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Appointment current = bindingSource1.Current as Appointment;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn để cập nhật!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(current)) return;

            current.MaLichHen = txtMaLichHen.Text.Trim();
            current.HoTenBenhNhan = txtHoTen.Text.Trim();
            current.SoDienThoai = txtSoDienThoai.Text.Trim();
            current.NgayGioHen = dtpNgayGio.Value;
            current.BacSi = cboBacSi.Text;
            current.LyDoKham = txtLyDo.Text.Trim();
            current.TrangThai = cboTrangThai.Text;

            ApplyFilter();

            MessageBox.Show("Cập nhật lịch hẹn thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Appointment current = bindingSource1.Current as Appointment;
            if (current == null)
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show(
                $"Bạn có chắc muốn xóa lịch hẹn [{current.MaLichHen}] của {current.HoTenBenhNhan}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _allAppointments.Remove(current);
                ApplyFilter();
                ClearInput();

                MessageBox.Show("Xóa lịch hẹn thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtTimKiem.Text = "";
            chkLocNgay.Checked = false;
            cboLocTrangThai.SelectedIndex = 0;
            ApplyFilter();
        }

  
        private bool ValidateInput(Appointment editing)
        {
            errorProvider1.Clear();
            bool ok = true;

            // Mã lịch hẹn
            string ma = txtMaLichHen.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                errorProvider1.SetError(txtMaLichHen, "Vui lòng nhập mã lịch hẹn!");
                ok = false;
            }
            else if (_allAppointments.Any(a => a != editing &&
                        string.Equals(a.MaLichHen, ma, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaLichHen, "Mã lịch hẹn đã tồn tại!");
                ok = false;
            }

            // Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ tên bệnh nhân!");
                ok = false;
            }

            // Số điện thoại (10-11 chữ số, bắt đầu bằng 0)
            string sdt = txtSoDienThoai.Text.Trim();
            if (string.IsNullOrEmpty(sdt))
            {
                errorProvider1.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại!");
                ok = false;
            }
            else if (!Regex.IsMatch(sdt, @"^0\d{9,10}$"))
            {
                errorProvider1.SetError(txtSoDienThoai,
                    "Số điện thoại không hợp lệ (bắt đầu bằng 0, gồm 10-11 chữ số)!");
                ok = false;
            }

            // Ngày hẹn
            if (dtpNgayGio.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpNgayGio, "Ngày hẹn không được nằm trong quá khứ!");
                ok = false;
            }

            // Bác sĩ
            if (string.IsNullOrWhiteSpace(cboBacSi.Text))
            {
                errorProvider1.SetError(cboBacSi, "Vui lòng chọn bác sĩ!");
                ok = false;
            }

            // Lý do khám
            if (string.IsNullOrWhiteSpace(txtLyDo.Text))
            {
                errorProvider1.SetError(txtLyDo, "Vui lòng nhập lý do khám!");
                ok = false;
            }

            // Trạng thái
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

            txtMaLichHen.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            dtpNgayGio.Value = DateTime.Now.AddHours(1);
            if (cboBacSi.Items.Count > 0) cboBacSi.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            txtLyDo.Clear();

            errorProvider1.Clear();

            _suppressLoad = false;
        }

       
        private void menuExportCSV_Click(object sender, EventArgs e)
        {
            var currentList = bindingSource1.DataSource as BindingList<Appointment>;
            if (currentList == null || currentList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.FileName = "DanhSachLichHen_" + DateTime.Now.ToString("yyyyMMdd_HHmm");

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var sw = new StreamWriter(saveFileDialog1.FileName, false, new UTF8Encoding(true)))
                {
                    sw.WriteLine("Mã lịch hẹn,Họ tên bệnh nhân,Số điện thoại,Ngày giờ hẹn,Bác sĩ,Lý do khám,Trạng thái");

                    foreach (var ap in currentList)
                    {
                        sw.WriteLine(string.Join(",",
                            CsvEscape(ap.MaLichHen),
                            CsvEscape(ap.HoTenBenhNhan),
                            CsvEscape(ap.SoDienThoai),
                            CsvEscape(ap.NgayGioHen.ToString("dd/MM/yyyy HH:mm")),
                            CsvEscape(ap.BacSi),
                            CsvEscape(ap.LyDoKham),
                            CsvEscape(ap.TrangThai)));
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
