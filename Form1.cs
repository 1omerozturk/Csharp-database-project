using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KıRtAsİyEaPp
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
       
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
            frm5.frm1 = this;
        }

        public SqlConnection bag = new SqlConnection("Data Source=OMEROZTURK\\SQLEXPRESS; Initial Catalog=KırtasiyeApp; Integrated Security = True");
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet dtst = new DataSet();
        public Boolean durum = false;
        string toplam;







        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
