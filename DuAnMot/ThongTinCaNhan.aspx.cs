using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnMot
{
    public partial class ThongTinCaNhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code khoi tao du lieu cho cac dieu kien
            if (!Page.IsPostBack)
            {
            //khoi tao cho ddlTrinhDo
            ddlTrinhDo.Items.Add(new ListItem("Trung cấp"));
            ddlTrinhDo.Items.Add(new ListItem("Cao đẳng"));
            //...

            //khoi tao cho lstNgheNghiep
            lstNgheNghiep.Items.Add(new ListItem("Công nhân"));
            lstNgheNghiep.Items.Add(new ListItem("Lập trình viên"));
            lstNgheNghiep.Items.Add(new ListItem("Kỹ sư"));
            //...

            //khoi tao cho chkListSoThich
            chkListSoThich.Items.Add(new ListItem("Mua sắm"));
            chkListSoThich.Items.Add(new ListItem("Xem phim"));
            chkListSoThich.Items.Add(new ListItem("Du lịch"));
            chkListSoThich.Items.Add(new ListItem("Leo Núi"));
            ///...
            }
        }
        protected void btGui_Click(object sender, EventArgs e)
        {
            string kq = "";
            //b1 thu thap tt
            kq += "<h2>Thông tin đăng ký của bạn </h2>";
            kq += "<ul>";
            //lay tt ho ten
            kq += $"<li>Họ tên {txtHoTen.Text}</li>";
            //tuong tu cho cac tt khac
            kq += string.Format("<li> Ngày Sinh:{0}</li>", txtNgaySinh.Text);
            if (rdNam.Checked)
            {
                kq += $"<li> Giới tính {rdNam.Text} </li>";
            }
            else
            {
                kq += $"<li> Giới tính {rdNu.Text} </li>";
            }
            kq += $"<li>Trình độ {ddlTrinhDo.SelectedItem.Text}</li>";
            kq += $"<li>Nghề nghiệp {lstNgheNghiep.SelectedItem.Text}</li>";
            // xưu lý upload
            if (FHinh.HasFile)
            {
                //lấy về đường dẫn tuyệt đối các thu mục tren sever
                string path = Server.MapPath("~/uploads");
                //sao chep tap tin ttu người dung len server
                FHinh.SaveAs(path + "/" + FHinh.FileName);
                kq += $"<li>Ảnh : <img src='Uploads/{FHinh.FileName}'> </li>";
            }
            kq += "<ul>";

            //b2 tra ket qua ve client
            lbKetQua.Text = kq;
        }

        protected void btGui_Click1(object sender, EventArgs e)
        {
            string kq = "";
            //b1 thu thap tt
            kq += "<h2>Thông tin đăng ký của bạn </h2>";
            kq += "<ul>";
            //lay tt ho ten
            kq += $"<li>Họ tên {txtHoTen.Text}</li>";
            //tuong tu cho cac tt khac
            kq += string.Format("<li> Ngày Sinh:{0}</li>", txtNgaySinh.Text);
            if (rdNam.Checked)
            {
                kq += $"<li> Giới tính {rdNam.Text} </li>";
            }
            else
            {
                kq += $"<li> Giới tính {rdNu.Text} </li>";
            }
            kq += $"<li>Trình độ {ddlTrinhDo.SelectedItem.Text}</li>";
            kq += $"<li>Nghề nghiệp {lstNgheNghiep.SelectedItem.Text}</li>";
            // xưu lý upload
            if (FHinh.HasFile)
            {
                //lấy về đường dẫn tuyệt đối các thu mục tren sever
                string path = Server.MapPath("~/uploads");
                //sao chep tap tin ttu người dung len server
                FHinh.SaveAs(path + "/" + FHinh.FileName);
                kq += $"<li>Ảnh : <img src='Uploads/{FHinh.FileName}'> </li>";
            }
            string sothich = " ";
            foreach (ListItem x in chkListSoThich.Items)
            {
                if (x.Selected)
                {
                    sothich += x.Text + ";";
                }
            }
            kq += $"<li>Sở thích: {sothich}</li>";
            kq += "<ul>";

            //b2 tra ket qua ve client
            lbKetQua.Text = kq;
        }
    }
}


          
