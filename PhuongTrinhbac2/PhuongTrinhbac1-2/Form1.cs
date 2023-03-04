using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuongTrinhbac1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            //Lấy các giá trị các hệ số từ TextBox
            double a = double.Parse(txbA.Text);
            double b = double.Parse(txbB.Text);
            double c = double.Parse(txbC.Text);

            //Tính delta
            double delta = b * b - 4 * a * c;

            // Kiểm tra giá trị delta để xác định nghiệm
            if (delta < 0)
            {
                txbResult.Text = "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                txbResult.Text = $"Phương trình có nghiệm kép: x = {x}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                txbResult.Text = $"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbA.Text = "";
            txbB.Text = "";
            txbC.Text = "";
            txbResult.Text = "";
        }
    }
}

