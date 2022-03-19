using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;

namespace Serialisation_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                //1.store data into the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Location = txtLocation.Text;
                //2.Create a file & open in write mode 
                FileStream fs = new FileStream(@"D:\Dept.json", FileMode.Create, FileAccess.Write);
                //3.use serliaze method 
                JsonSerializer.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();

                FileStream fs = new FileStream(@"D:\Dept.json", FileMode.Open, FileAccess.Read);

                dept = JsonSerializer.Deserialize<Department>(fs);

                txtDeptId.Text = dept.Id.ToString();
                txtDeptName.Text= dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //1 . store data into the object
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Location = txtLocation.Text;
                //2. Create a file & open in write mode 
                FileStream fs = new FileStream(@"D:\DeptXmlFile.xml", FileMode.Create, FileAccess.Write);
                //3. use serliaze method 
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"D:\DeptXmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtDeptId.Text= dept.Id.ToString();
                txtDeptName.Text= dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
