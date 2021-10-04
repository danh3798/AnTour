using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AnTour.ChildForm
{
    public partial class FormQLKH : Form
    {
        public static String conStr = ConfigurationManager.ConnectionStrings["AnTourConnString"].ConnectionString.ToString();
        public FormQLKH()
        {
            InitializeComponent();

        }

        void load_khachhang()
        {
            lsvKhachHang.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from KhachHang", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaKH"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["HoTen"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["gTinh"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["CMND"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["ngaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["diaChi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["sdt"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["email"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["username"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["password"] + ""));
                            lsvKhachHang.Items.Add(item);
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void FormQLKH_Load(object sender, EventArgs e)
        {
            load_khachhang();
        }

        //Insert ảnh lên csdl
        public void InsertPic(byte[] image)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("update KhachHang set anh = @image where MaKH = '" + txtKH_ma.Text + "'", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();

            }
        }

        private void btnKH_anh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picboxKH.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        //Chức năng
        private void btnKH_them_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "insert_kh";
                        cmd.Parameters.AddWithValue("@MaKH", txtKH_ma.Text);
                        cmd.Parameters.AddWithValue("@HoTen ", txtKH_ten.Text);
                        cmd.Parameters.AddWithValue("@gTinh ", cbKhachHang.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@CMND ", txtKH_cmnd.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh ", Convert.ToDateTime(dtKH_ngaysinh.Text));
                        cmd.Parameters.AddWithValue("@diaChi ", txtKH_diachi.Text);
                        cmd.Parameters.AddWithValue("@sdt ", txtKH_sdt.Text);
                        cmd.Parameters.AddWithValue("@email ", txtKH_email.Text);
                        cmd.Parameters.AddWithValue("@username ", txtKH_usrn.Text);
                        cmd.Parameters.AddWithValue("@password ", txtKH_pwd.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            InsertPic(ConvertImageToBytes(picboxKH.Image));
                            MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_khachhang();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKH_sua_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Dữ liệu không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "edit_kh";
                        cmd.Parameters.AddWithValue("@MaKH", txtKH_ma.Text);
                        cmd.Parameters.AddWithValue("@HoTen ", txtKH_ten.Text);
                        cmd.Parameters.AddWithValue("@gTinh ", cbKhachHang.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@CMND ", txtKH_cmnd.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh ", Convert.ToDateTime(dtKH_ngaysinh.Text));
                        cmd.Parameters.AddWithValue("@diaChi ", txtKH_diachi.Text);
                        cmd.Parameters.AddWithValue("@sdt ", txtKH_sdt.Text);
                        cmd.Parameters.AddWithValue("@email ", txtKH_email.Text);
                        cmd.Parameters.AddWithValue("@username ", txtKH_usrn.Text);
                        cmd.Parameters.AddWithValue("@password ", txtKH_pwd.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            InsertPic(ConvertImageToBytes(picboxKH.Image));
                            MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_khachhang();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công\nVui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKH_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "del_kh";
                        cmd.Parameters.AddWithValue("@MaKH", txtKH_ma.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_khachhang();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKH_huy_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
                picboxKH.Image = picboxKH.InitialImage;
            }
        }

        
    }
}
