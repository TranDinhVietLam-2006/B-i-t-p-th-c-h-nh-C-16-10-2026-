using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bài_3
{
    public class DonSuaChua : INotifyPropertyChanged
    {
        private string _maDon;
        private string _tenKhachHang;
        private string _soDienThoai;
        private string _loaiThietBi;
        private string _moTaLoi;
        private DateTime _ngayTiepNhan;
        private decimal _chiPhiDuKien;
        private string _trangThai;
        private string _anhThietBi;

        public string MaDon
        {
            get => _maDon;
            set { _maDon = value; OnPropertyChanged(); }
        }

        public string TenKhachHang
        {
            get => _tenKhachHang;
            set { _tenKhachHang = value; OnPropertyChanged(); }
        }

        public string SoDienThoai
        {
            get => _soDienThoai;
            set { _soDienThoai = value; OnPropertyChanged(); }
        }

        public string LoaiThietBi
        {
            get => _loaiThietBi;
            set { _loaiThietBi = value; OnPropertyChanged(); }
        }

        public string MoTaLoi
        {
            get => _moTaLoi;
            set { _moTaLoi = value; OnPropertyChanged(); }
        }

        public DateTime NgayTiepNhan
        {
            get => _ngayTiepNhan;
            set { _ngayTiepNhan = value; OnPropertyChanged(); }
        }

        public decimal ChiPhiDuKien
        {
            get => _chiPhiDuKien;
            set { _chiPhiDuKien = value; OnPropertyChanged(); }
        }

        public string TrangThai
        {
            get => _trangThai;
            set { _trangThai = value; OnPropertyChanged(); }
        }

        public string AnhThietBi
        {
            get => _anhThietBi;
            set { _anhThietBi = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}