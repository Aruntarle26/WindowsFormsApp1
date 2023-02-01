using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormFile : Form
    {
        public FormFile()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"F:\SkillMineDoc";
            try
            {
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory Created...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"F:\SkillMineDoc\Test1.txt";
            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("File is already exist");
                }
                else
                {
                    File.Create(path);
                  
                    MessageBox.Show("File Created...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fr = new FileStream(@"F:\SkillMineDoc\Test1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fr);
                br.Write(Convert.ToInt32(txtEmployeeId.Text));
                br.Write(txtEmployeeName.Text);
                br.Write(Convert.ToDouble(txtSalary.Text));
                br.Close();
                fr.Close();
                MessageBox.Show("Data is saved...");
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
                FileStream fr = new FileStream(@"F:\SkillMineDoc\Test1.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fr);
               txtEmployeeId.Text= br.ReadInt32().ToString();
               txtEmployeeName.Text= br.ReadString();
               txtSalary.Text= br.ReadDouble().ToString();
                br.Close();
                fr.Close();
                MessageBox.Show("Data is Opened...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
