using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_test
{
    public partial class Form1 : Form
    {
        public BindingSource class1BindingSource = new BindingSource();//Khai báo BindingSource     B1
        public Form1()
        {
            InitializeComponent();

            class1BindingSource.DataSource = typeof(Class1);// B2 => datasource này chỉ thêm được những đối tượng Class1. Nếu không thì nó sẽ nhận typeof(đối tượng đầu tiên thêm vào)
            dataGridView1.DataSource = class1BindingSource;

            comboBox1.DataSource = class1BindingSource;
            comboBox1.DisplayMember = "thuoctinh1";
        }

        private void btn_Buoc3_Click(object sender, EventArgs e)
        {
            #region
            // http://thuvienwinform.blogspot.com/2014/06/hien-thi-doi-tuong-len-datagridview-show-object-on-datagridview.html
            // Dang lam toi buoc 3
            #endregion

            //Khai báo và truyền giá trị cho các thuộc tính của dối tượng
            Class1 doiTuong = new Class1();
            doiTuong.ThuocTinh1 = "1";
            doiTuong.ThuocTinh2 = "2";
            doiTuong.ThuocTinh3 = "3";
            doiTuong.ThuocTinh4 = "4";
            doiTuong.ThuocTinh5 = "5";
            doiTuong.ThuocTinh6 = "6";
            
            class1BindingSource.Add(doiTuong);//Thêm 1 đối tượng lên bảng (sẽ tự tạo ra 1 hàng mới). Biến doiTuong giống như ở cách 1
            class1BindingSource.Add(doiTuong);//Thêm 1 đối tượng lên bảng (sẽ tự tạo ra 1 hàng mới). Biến doiTuong giống như ở cách 1
            class1BindingSource.Add(doiTuong);//Thêm 1 đối tượng lên bảng (sẽ tự tạo ra 1 hàng mới). Biến doiTuong giống như ở cách 1
            //class1BindingSource.AddNew();//Thêm 1 hàng mới (các giá trị đều rỗng)

            //Đặt tên cho các cột
            dataGridView1.Columns["ThuocTinh1"].HeaderText = "cột 1";
            dataGridView1.Columns["ThuocTinh2"].HeaderText = "cột 2";
            for (int i = 4; i <= 6; i++)
                dataGridView1.Columns["ThuocTinh" + i].HeaderText = "cột " + i;

            //Sắp xếp vị trí cho cột
            dataGridView1.Columns["ThuocTinh2"].DisplayIndex = 0;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu
            //string dt1 = ((Class1)class1BindingSource.Current).ThuocTinh1;
            //string dt2 = ((Class1)class1BindingSource.Current).ThuocTinh2;

            //Sửa thuộc tính của dòng đang chọn
            ((Class1)class1BindingSource.Current).ThuocTinh2 = "sửa";

            foreach (Class1 thuocTinh in class1BindingSource)
                thuocTinh.ThuocTinh1 = "OK";


            // Display DataGridView
            class1BindingSource.ResetBindings(true);
        }

        public void addOneRow()
        {
            //Lấy dữ liêu từ thuoc tinh 6
            string dataThuocTinh6 = ((Class1)class1BindingSource.Current).ThuocTinh6;

            //int temNum = Convert.ToInt32(dataThuocTinh6) + 1;

            int temNum = class1BindingSource.Count; // So luong item

            Class1 DoiTuongMoi = new Class1();
            DoiTuongMoi.ThuocTinh1 = "ten";
            DoiTuongMoi.ThuocTinh2 = "Tuoi";
            DoiTuongMoi.ThuocTinh3 = "Ngoc";
            DoiTuongMoi.ThuocTinh4 = "ten";
            DoiTuongMoi.ThuocTinh5 = "ten";
            DoiTuongMoi.ThuocTinh6 = temNum.ToString();

            class1BindingSource.Add(DoiTuongMoi);
        }

        private void btn_add1Row_Click(object sender, EventArgs e)
        {
            addOneRow();
        }

        private void btn_changeHeader_Click(object sender, EventArgs e)
        {
            int temNum = class1BindingSource.Count; // So luong item
            dataGridView1.Columns["ThuocTinh2"].HeaderText = string.Format("cột Ngọc{0} 2", temNum);
        }
    }
}
