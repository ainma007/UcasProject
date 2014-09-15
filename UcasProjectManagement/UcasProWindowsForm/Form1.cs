using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ucas.Data;

using Ucas.Data.CommandClass;
namespace UcasProWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GroupCmd CMD = new GroupCmd();
        private void Form1_Load(object sender, EventArgs e)
        {
            groupsTbBindingSource.DataSource = CMD.GetAllGroups();
        }
    }
}
