using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AnTour.ChildForm
{
    public partial class FormQLNV : Form
    {
        public static String conStr = ConfigurationManager.ConnectionStrings["AnTourConnString"].ConnectionString.ToString();
        public FormQLNV()
        {
            InitializeComponent();
        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            load_nhanvien();
        }

        void load_nhanvien()
        {
            lsvNhanVien.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from NhanVien", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["MaNV"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["HoTen"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["gTinh"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["CMND"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["ngaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["diaChi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["sdt"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["email"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["username"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["password"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["chucvu"] + ""));
                            lsvNhanVien.Items.Add(item);
                        }
                    }

                    conn.Close();
                }
            }
        }

        //Đưa dữ liệu từ ListView ra từng Textbox
        private void LsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvNhanVien.SelectedItems)
            {
                txtNV_ma.Text = item.SubItems[0].Text;
                txtNV_hoten.Text = item.SubItems[1].Text;
                cbNhanVien.Text = item.SubItems[2].Text;
                txtNV_CMND.Text = item.SubItems[3].Text;
                dtNV_ngaysinh.Text = item.SubItems[4].Text;
                txtNV_diachi.Text = item.SubItems[5].Text;
                txtNV_sdt.Text = item.SubItems[6].Text;
                txtNV_email.Text = item.SubItems[7].Text;
                txtNV_usrn.Text = item.SubItems[8].Text;
                txtNV_pwd.Text = item.SubItems[9].Text;
                txtNV_chucvu.Text = item.SubItems[10].Text;
            }

            //Load ảnh từ csdl
            //byte[] getImg = new byte[0];
            //using (SqlConnection conn = new SqlConnection(conStr))
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("select anh from NhanVien where MaNV = '" + txtNV_ma.Text + "'", conn);
            //    cmd.CommandType = CommandType.Text;
            //    SqlDataAdapter da = new SqlDataAdapter();
            //    DataSet ds = new DataSet();
            //    da.SelectCommand = cmd;
            //    da.Fill(ds);
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //        getImg = (byte[])dr["anh"];
            //    }
            //    byte[] imgData = getImg;
            //    MemoryStream stream = new MemoryStream(imgData);
            //    picboxNV.Image = Image.FromStream(stream);
            //    conn.Close();
            //}

        }

        //Insert ảnh lên csdl
        public void InsertPic(byte[] image)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("update NhanVien set anh = @image where MaNV = '" + txtNV_ma.Text + "'", conn))
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

        private void btnNV_anh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picboxNV.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        //Thêm nhân viên mới
        private void btnNV_them_Click(object sender, EventArgs e)
        {
            foreach(Control c in groupBox2.Controls)
            {
                if(c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if(textBox.Text == string.Empty)
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
                        cmd.CommandText = "insert_nv";
                        cmd.Parameters.AddWithValue("@MaNV", txtNV_ma.Text);
                        cmd.Parameters.AddWithValue("@HoTen ", txtNV_hoten.Text);
                        cmd.Parameters.AddWithValue("@gTinh ", cbNhanVien.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@CMND ", txtNV_CMND.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh ", Convert.ToDateTime(dtNV_ngaysinh.Text));
                        cmd.Parameters.AddWithValue("@diaChi ", txtNV_diachi.Text);
                        cmd.Parameters.AddWithValue("@sdt ", txtNV_sdt.Text);
                        cmd.Parameters.AddWithValue("@email ", txtNV_email.Text);
                        cmd.Parameters.AddWithValue("@username ", txtNV_usrn.Text);
                        cmd.Parameters.AddWithValue("@password ", txtNV_pwd.Text);
                        cmd.Parameters.AddWithValue("@chucvu ", txtNV_chucvu.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            InsertPic(ConvertImageToBytes(picboxNV.Image));
                            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_nhanvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNV_huy_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
                picboxNV.Image = picboxNV.InitialImage;
            }
        }

        private void btnNV_sua_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "edit_nv";
                        cmd.Parameters.AddWithValue("@MaNV", txtNV_ma.Text);
                        cmd.Parameters.AddWithValue("@HoTen ", txtNV_hoten.Text);
                        cmd.Parameters.AddWithValue("@gTinh ", cbNhanVien.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@CMND ", txtNV_CMND.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh ", Convert.ToDateTime(dtNV_ngaysinh.Text));
                        cmd.Parameters.AddWithValue("@diaChi ", txtNV_diachi.Text);
                        cmd.Parameters.AddWithValue("@sdt ", txtNV_sdt.Text);
                        cmd.Parameters.AddWithValue("@email ", txtNV_email.Text);
                        cmd.Parameters.AddWithValue("@username ", txtNV_usrn.Text);
                        cmd.Parameters.AddWithValue("@password ", txtNV_pwd.Text);
                        cmd.Parameters.AddWithValue("@chucvu ", txtNV_chucvu.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            InsertPic(ConvertImageToBytes(picboxNV.Image));
                            MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_nhanvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công\nVui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNV_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "del_nv";
                        cmd.Parameters.AddWithValue("@MaNV", txtNV_ma.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_nhanvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
