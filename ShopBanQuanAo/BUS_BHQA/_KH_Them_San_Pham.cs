﻿using DAL_BHQA;
using DTO_BHQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BHQA
{
    public class _KH_Them_San_Pham
    {
        DAL_KH_ThemSP Dal_Them_Sp = new DAL_KH_ThemSP();
        public bool Bus_Nhan_Data(GioHang gioHang)
        {
            if (Dal_Them_Sp.khachHangThemSP(gioHang))
            {
                return true;
            }
            return false;
        }
    }
}
