using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh_DoVuDung
{
    public partial class TrangSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();
            //Lấy idSanPham từ query String của URL
            string idSanPham = Request.QueryString.Get("IDSANPHAM");

            string sql = $@"
            select *
            from tbSANPHAM
            where IDSANPHAM = {idSanPham};
        ";

            DataTable dataTable = dataAccess.LayBangDuLieu(sql);



            ltTenSanPham.Text = dataTable.Rows[0]["TENSANPHAM"].ToString();
            imgHinhAnhSanPham.ImageUrl = "HinhAnh/" + dataTable.Rows[0]["HINHANH"].ToString();
            ltGiaSanPham.Text = dataTable.Rows[0]["DONGIA"].ToString();
            ltMieuTaSanPham.Text = dataTable.Rows[0]["MOTA"].ToString();

        }
    }
}