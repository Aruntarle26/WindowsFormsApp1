using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\SkillMineDoc\Employee.dat", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtBasicSalary.Text);
                BinaryFormatter br = new BinaryFormatter();
                br.Serialize(fs, emp);
                fs.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeBinary.dat", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                BinaryFormatter bf = new BinaryFormatter();
                emp = (Employee)
                    bf.Deserialize(fs);
               

                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtBasicSalary.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\SkillMineDoc\EmployeeSoap.soap", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtBasicSalary.Text);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("soap write done");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"F:\SkillMineDoc\EmployeeSoap.soap", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                SoapFormatter sf = new SoapFormatter();
                emp = (Employee)
                    sf.Deserialize(fs);


                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtBasicSalary.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        { 
        
             try
            {
                FileStream fs = new FileStream(@"F:\SkillMineDoc\EmployeeXML.xml", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtBasicSalary.Text);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
               
                 xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("xml write done");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                
                FileStream fs = new FileStream(@"F:\SkillMineDoc\EmployeeXML.xml", FileMode.Open, FileAccess.Read);
                
                Employee emp = new Employee();
               
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                fs.Close();

                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtBasicSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\SkillMineDoc\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtBasicSalary.Text);
               
                JsonSerializer.Serialize<Employee>(fs, emp);


                
                fs.Close();
                MessageBox.Show("json write done");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJasonRead_Click(object sender, EventArgs e)
        {
            try
            {

                FileStream fs = new FileStream(@"F:\SkillMineDoc\EmployeeJSON.json", FileMode.Open, FileAccess.Read);

                Employee emp = new Employee();

               emp= JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();

                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtBasicSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
