using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace VKN
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = nameTB.Text;
            string password = passTB.Text;

            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {    
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            
            // Đọc dữ liệu từ file Excel
            var fileInfo = new FileInfo(@"D:\NT106\VKN\log.xlsx");
            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Duyệt qua từng dòng để kiểm tra thông tin đăng nhập
                for (int row = 2; row <= rowCount; row++)
                {
                    string excelUsername = worksheet.Cells[row, 1].Value?.ToString();
                    string excelPassword = worksheet.Cells[row, 2].Value?.ToString();
                    
                    if (username == excelUsername && password == excelPassword)
                    {
                        MessageBox.Show("Login successful!");
                        // Thực hiện các công việc cần thiết sau khi đăng nhập thành công, ví dụ như hiển thị form chính.
                        return;
                    }
                }
                
                // Nếu không tìm thấy thông tin đăng nhập phù hợp, hiển thị thông báo lỗi
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void signB_Click(object sender, EventArgs e)
        {
            Form signInForm = new SignIn();
            signInForm.ShowDialog();
        }
    }
}
