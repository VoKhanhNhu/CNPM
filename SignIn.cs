using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OfficeOpenXml;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace VKN
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void signB_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu đăng ký từ các TextBox
            string username = nameTB.Text;
            string password = passTB.Text;
            string repeat = repeatTB.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeat))
            {
                MessageBox.Show("Please enter username, password and repeat password.");
                return;
            }

            if (password != repeat)
            {
                MessageBox.Show("Password and repeat password do not match!");
                return;
            }

            // Lưu đăng ký vào tệp Excel
            SaveRegistrationToExcel(username, password);

            // Thông báo cho người dùng biết rằng đăng ký thành công
            MessageBox.Show("Đăng ký thành công!");
        }

        private void SaveRegistrationToExcel(string name, string pass)
        {
            /*Application excel = new Application();// (new FileInfo(@"C:\Users\as\Downloads\condi.xlsx"));
            excel.Visible = false;
            excel.DisplayAlerts = false;

            // Mở tệp Excel đã lưu
            Workbook workbook = excel.Workbooks.Open(@"C:\Users\as\Downloads\condi.xlsx");
            Worksheets worksheet = workbook.Worksheets[1] as Worksheets;

            Range range = worksheet.Application.Cells.Find("*", System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, XlSearchOrder.xlByRows, XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            int last = range.Row + 1;

            worksheet.Application.Cells[last, 1].Value = name;
            worksheet.Application.Cells[last, 2].Value = pass;*/

            Application excel = new Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;

            // Open the saved Excel file
            Workbook workbook = excel.Workbooks.Open(@"D:\NT106\VKN\log.xlsx");
            Worksheet worksheets = (Worksheet)workbook.Worksheets[1];

            // Find the last row of the worksheet
            Range last = worksheets.Application.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing);
            int lastRow = last.Row + 1;

            // Add the registration data to the next row
            worksheets.Application.Cells[lastRow, 1].Value = name;
            worksheets.Application.Cells[lastRow, 2].Value = pass;

            // Save the changes and close the workbook and Excel application
            workbook.Save();
            workbook.Close();
            excel.Quit();
        }
    }
}
