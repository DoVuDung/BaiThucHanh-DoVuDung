using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh_DoVuDung
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        private DataAccess dataAccess;
        protected void Page_Load(object sender, EventArgs e)
        {
            dataAccess = new DataAccess();
            dataAccess.MoKetNoiCSDL();

            string sql = "select * from tbDANHMUC";
            DataTable dataTable = dataAccess.LayBangDuLieu(sql);
            //thực hiện binding dữ liệu
            //data binding là kỹ thuật liên kết một nguồn dữ liệu với nơi sử dựng dữ liệu đó, và đồng bộ hóa dữ liệu giữa chúng.
            this.rptMenu.DataSource = dataTable;
            this.rptMenu.DataBind();
            //đóng kết nối
            dataAccess.DongKetNoiCSDL();
        }
    }
}