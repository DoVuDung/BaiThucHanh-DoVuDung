using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh_DoVuDung
{
    public partial class TrangDanhMuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess;
            //Lấy idDanhMuc từ queryString của URL
            string idDanhMuc = Request.QueryString.Get("IDDANHMUC");

            dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();

            string sql;
            if (idDanhMuc == null) //Nếu không có idDanhMuc
            {
                sql = "SELECT * FROM tbSANPHAM"; //Câu lệnh sql lấy tất cả các sản phẩm
            }
            else
            {
                sql = $"SELECT * FROM tbSANPHAM where IDDANHMUC = {idDanhMuc}"; //Câu lệnh sql lấy tất cả các sản phẩm thuộc idDanhMuc

            }

            DataTable dataTable = dataAccess.LayBangDuLieu(sql);

            // Thực hiện binding dữ liệu
            this.rptDanhSachSanPham.DataSource = dataTable;
            this.rptDanhSachSanPham.DataBind();

            dataAccess.DongKetNoiCSDL();
        }
    }
}