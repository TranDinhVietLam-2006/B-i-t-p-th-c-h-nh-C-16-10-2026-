using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bài_2
{
    public class PhieuMuon : INotifyPropertyChanged
    {
        private string _maPhieu;
        private string _maSinhVien;
        private string _hoTenSinhVien;
        private string _thietBi;
        private int _soLuong;
        private DateTime _ngayMuon;
        private DateTime _hanTra;
        private DateTime? _ngayTraThucTe;
        private string _tinhTrang;

        public string MaPhieu
        {
            get => _maPhieu;
            set { _maPhieu = value; OnPropertyChanged(); }
        }

        public string MaSinhVien
        {
            get => _maSinhVien;
            set { _maSinhVien = value; OnPropertyChanged(); }
        }

        public string HoTenSinhVien
        {
            get => _hoTenSinhVien;
            set { _hoTenSinhVien = value; OnPropertyChanged(); }
        }

        public string ThietBi
        {
            get => _thietBi;
            set { _thietBi = value; OnPropertyChanged(); }
        }

        public int SoLuong
        {
            get => _soLuong;
            set { _soLuong = value; OnPropertyChanged(); }
        }

        public DateTime NgayMuon
        {
            get => _ngayMuon;
            set { _ngayMuon = value; OnPropertyChanged(); }
        }

        public DateTime HanTra
        {
            get => _hanTra;
            set { _hanTra = value; OnPropertyChanged(); UpdateTinhTrang(); }
        }

        public DateTime? NgayTraThucTe
        {
            get => _ngayTraThucTe;
            set { _ngayTraThucTe = value; OnPropertyChanged(); UpdateTinhTrang(); }
        }

        public string TinhTrang
        {
            get => _tinhTrang;
            set { _tinhTrang = value; OnPropertyChanged(); }
        }

        public void UpdateTinhTrang()
        {
            if (NgayTraThucTe.HasValue)
                TinhTrang = "Đã trả";
            else if (HanTra.Date < DateTime.Today)
                TinhTrang = "Quá hạn";
            else
                TinhTrang = "Đang mượn";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}