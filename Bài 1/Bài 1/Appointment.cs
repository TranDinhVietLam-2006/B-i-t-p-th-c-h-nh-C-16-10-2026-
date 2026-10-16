using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bài_1
{
    public class Appointment : INotifyPropertyChanged
    {
        private string _maLichHen;
        private string _hoTenBenhNhan;
        private string _soDienThoai;
        private DateTime _ngayGioHen;
        private string _bacSi;
        private string _lyDoKham;
        private string _trangThai;

        public string MaLichHen
        {
            get => _maLichHen;
            set { _maLichHen = value; OnPropertyChanged(); }
        }

        public string HoTenBenhNhan
        {
            get => _hoTenBenhNhan;
            set { _hoTenBenhNhan = value; OnPropertyChanged(); }
        }

        public string SoDienThoai
        {
            get => _soDienThoai;
            set { _soDienThoai = value; OnPropertyChanged(); }
        }

        public DateTime NgayGioHen
        {
            get => _ngayGioHen;
            set { _ngayGioHen = value; OnPropertyChanged(); }
        }

        public string BacSi
        {
            get => _bacSi;
            set { _bacSi = value; OnPropertyChanged(); }
        }

        public string LyDoKham
        {
            get => _lyDoKham;
            set { _lyDoKham = value; OnPropertyChanged(); }
        }

        public string TrangThai
        {
            get => _trangThai;
            set { _trangThai = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}