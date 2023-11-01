using b1.Model;
using b1.Models;
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
            Department();
        }
        private void Department()
        {
            ConnectDepartment obj = new ConnectDepartment();
            List<Department> ldp = obj.getData();
            foreach (var item in ldp)
            {
                cbbDepartment.Items.Add(item.DepartmentName);
            }
        }
        private void txtAuto_TextChanged(object sender, EventArgs e)
        {
            ConnectStudent obj = new ConnectStudent();
            List<Student> lsd = obj.getData();
            bool b = false;
            foreach (Student sd in lsd)
            {
                if (Convert.ToInt32(txtAuto.Text) == sd.Id)
                {
                    txtId.Text = txtAuto.Text;
                    txtName.Text = sd.Name;
                    cbbGender.SelectedIndex = sd.Gender;
                    txtYear.Text = sd.Year.ToString();
                    cbbDepartment.SelectedIndex = sd.DpId-1;
                    b = true;
                }
            }
            if (!b)
            {
                MessageBox.Show("Không tìm thấy mã sinh viên!");
            }
        }


    }
}
