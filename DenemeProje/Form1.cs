using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Bu metod ile kod yazmadığımız toolbox araçlarını kendi içerisinde barındırıyor ve her seferinde yapılan değişikliği kaydediyor.
            //With this method, it contains the toolbox tools that we do not write code for and saves the changes made. each time.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = textBox1.Text;
            //TextBox1 içerisine girilen string türündeki veriyi mesaj değişkenine atadık.
            //We have assigned the string type data entered in the TextBox1 to the message variable.
            MessageBox.Show(mesaj);
            
        }
    }
}
