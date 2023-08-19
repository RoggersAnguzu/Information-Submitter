using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSTATEMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int yearOfBirth;
            int.TryParse(this.textBox1.Text, out yearOfBirth);
            int aGe;
            int currentYear = DateTime.Now.Year;
            aGe = currentYear - yearOfBirth;
            MessageBox.Show("Dear Sir/Maddam;\nYou are "+aGe.ToString() + " years Old");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submission Successful\nWould you like to continue","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile("D:\\PHOTOS\\169261548_461647484891747_7374656949420322089_n.jpg");
            this.BackgroundImage = Image.FromFile("D:\\PHOTOS\\432325b68d13588d3659177565634f04.jpg");
        }
    }
}
    