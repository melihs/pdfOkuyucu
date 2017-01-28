using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("C:\\Users\\melih\\Desktop\\pdfload.pdf");
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Pdf dosyaları |*.pdf";
            dosya.ShowDialog();

            if (dosya.FileName != "")
            {
                axAcroPDF1.LoadFile(dosya.FileName);
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Dispose();
            this.Close();
        }
        
    }
}
