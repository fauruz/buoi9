using b1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectDepartment obj = new ConnectDepartment();
            List<Department> ldp = obj.getData();
            foreach(var item in ldp)
            {
                cbbDepartment.Items.Add(item.DepartmentName);
                cbbDepartment.SelectedIndex = 0;
            }    
        }
    }
}
