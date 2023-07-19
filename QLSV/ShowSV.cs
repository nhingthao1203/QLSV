using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ShowSV : Form
    {
        public DataGridView DataGridView1 { get { return dataGridView1; } }

        public ShowSV()
        {
            InitializeComponent();
        }
    }
}
