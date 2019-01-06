using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTUDQL_1660007_1660010_1660136
{
    class BenhNhan
    {
        private int _iDBN;
        private string _tenBN;
        private string _gioiTinh;
        private string _namSinh;
        private string _diaChi;

        public int IDBN
        {
            get
            {
                return _iDBN;
            }

            set
            {
                _iDBN = value;
            }
        }

        public string TenBN
        {
            get
            {
                return _tenBN;
            }

            set
            {
                _tenBN = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _gioiTinh;
            }

            set
            {
                _gioiTinh = value;
            }
        }

        public string NamSinh
        {
            get
            {
                return _namSinh;
            }

            set
            {
                _namSinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        public void themBenhNhan(int a, string b, string c, string d, string e)
        {
            this._iDBN = a;
            this._tenBN = b;
            this._gioiTinh = c;
            this._namSinh = d;
            this._diaChi = e;
        }
    }
}
