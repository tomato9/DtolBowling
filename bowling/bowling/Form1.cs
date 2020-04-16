using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bowling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      


        private void button1_Click(object sender, EventArgs e)
        {   
            if(textBox1.Text == "")
            {
                MessageBox.Show("참가인원을 입력해주세요.");
            }
            else
            { 

            int player = int.Parse(textBox1.Text);
                for (int i = 0; i < player; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
