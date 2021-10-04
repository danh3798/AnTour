using MaterialSkin;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AnTour.ChildForm
{
    public partial class FormLogin : Form
    {
        public bool IsLogin { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public static String conStr = ConfigurationManager.ConnectionStrings["AnTourConnString"].ConnectionString.ToString();
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            IsLogin = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey500, Primary.Grey500, Primary.Grey300, Accent.Blue700, TextShade.WHITE);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from login_chk where username ='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read() == true)
                    {
                        //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                        IsLogin = true;
                        GlobalValue.FullName = dataReader["HoTen"].ToString();
                        GlobalValue.Username = txtUsername.Text;
                        FullName = dataReader["HoTen"].ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công, hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    conn.Close();
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
