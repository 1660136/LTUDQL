using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTUDQL_1660007_1660010_1660136
{
    class Thuoc
    {
        private int _iDThuoc;
        private string _tenThuoc;
        private int _iDDonVi;
        private int _soLuongTon;
        private int _gia;
        private int _xoa;

        public int IDThuoc
        {
            get
            {
                return _iDThuoc;
            }

            set
            {
                _iDThuoc = value;
            }
        }

        public string TenThuoc
        {
            get
            {
                return _tenThuoc;
            }

            set
            {
                _tenThuoc = value;
            }
        }

        public int IDDonVi
        {
            get
            {
                return _iDDonVi;
            }

            set
            {
                _iDDonVi = value;
            }
        }

        public int SoLuongTon
        {
            get
            {
                return _soLuongTon;
            }

            set
            {
                _soLuongTon = value;
            }
        }

        public int Gia
        {
            get
            {
                return _gia;
            }

            set
            {
                _gia = value;
            }
        }

        public int Xoa
        {
            get
            {
                return _xoa;
            }

            set
            {
                _xoa = value;
            }
        }

        public void themThuoc(int a, string b, int c, int d, int e, int f)
        {
            this.IDThuoc = a;
            this.TenThuoc = b;
            this.IDDonVi = c;
            this.SoLuongTon = d;
            this.Gia = e;
            this.Xoa = f;
        }
    }
}
