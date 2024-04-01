using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_92_NTuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Calculation c = new Calculation(a, b);
            kq = c.Execute("+");
            txtKQ.Text = kq.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Calculation c = new Calculation(a, b);
            kq = c.Execute("-");
            txtKQ.Text = kq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Calculation c = new Calculation(a, b);
            kq = c.Execute("*");
            txtKQ.Text = kq.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            Calculation c = new Calculation(a, b);
            kq = c.Execute("/");
            txtKQ.Text = kq.ToString();
        }
    }
}
