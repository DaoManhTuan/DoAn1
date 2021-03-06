﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using IP.Core.IPBusinessService;
using IP.Core.IPUserService;

using System.Threading;
using TOSApp.App_Code;
using TOSApp.DanhMuc;
using TOSApp.BaoCao;
namespace TOSApp
{
    #region Nhiệm vụ của Class
    //*********************************************************************************
    //*  Là khởi động và điều khiển dăng nhập mới vào  Hệ thống
    //*  - hiện thị form login
    //*  - nếu OK thì tạo context và hiện thị form main, User không muốn vào thì thoát ra
    //*  - nếu trở lại từ main theo kiểu login mới thì lại hiện thị form login
    //*  - nếu trở lại từ main theo kiểu "exit from system" thì thoát
    //*********************************************************************************
    #endregion
    public class ApplicationControl
    {
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                    new System.Globalization.CultureInfo("vi-VN");

            // The following line provides localization for data formats. 
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("vi-VN");
            //f100_DM_SINH_VIEN v_f = new f100_DM_SINH_VIEN();
            //f999_main v_f = new f999_main();
            f000_login v_f = new f000_login();
           // BaoCao.f9906_bao_cao_demo v_f = new BaoCao.f9906_bao_cao_demo();
           // f9908_bieu_do_ty_le_qua_mon v_f = new f9908_bieu_do_ty_le_qua_mon();

            v_f.ShowDialog();
        }
    }
}


