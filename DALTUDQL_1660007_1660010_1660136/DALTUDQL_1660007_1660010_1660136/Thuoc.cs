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
        private string _donVi;
        private int _soLuongTon;
        private float _gia;
        private bool _xoa;

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

        public string DonVi
        {
            get
            {
                return _donVi;
            }

            set
            {
                _donVi = value;
            }
        }

        public float Gia
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

        public bool Xoa
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

        public void themThuoc(int a, string b, string c, int d, float e, bool f)
        {
            this._iDThuoc = a;
            this._tenThuoc = b;
            this._donVi = c;
            this._soLuongTon = d;
            this._gia = e;
            this._xoa = f;
        }
    }
}
