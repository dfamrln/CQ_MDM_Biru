using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=P\\SQLEXPRESS;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
