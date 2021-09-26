using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackeru.DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            student.Id = int.Parse(txtId.Text);
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Phone = int.Parse(txtPhone.Text);
            student.City = comboBox1.Text;
            student.Email = txtEmail.Text;
            student.BirthDate = dateTimePicker1.Text;
 
            for (int i = 0; i <checkedListBox1.CheckedItems.Count; i++)
            {
                student.Course[i] = checkedListBox1.CheckedItems[i].ToString();
            }
            MyDB.Add(student);
            MessageBox.Show("Students Added Succesfully");

            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i,false);
         

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (MyDB.Remove(student))
                MessageBox.Show("Delete Student");

            else
                MessageBox.Show("Valid Information");

            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           var stud= MyDB.ShowByLastName(txtSearch.Text);

            if (stud == null)
                MessageBox.Show("Student Not Exist");
            else
            {
                txtId.Text = stud.Id.ToString();
                txtFirstName.Text = stud.FirstName;
                txtLastName.Text = stud.LastName;
                txtPhone.Text = stud.Phone.ToString();
                txtEmail.Text = stud.Email;
                comboBox1.Text = stud.City;
                dateTimePicker1.Text = stud.BirthDate;
                for (int i = 0; i < stud.Course.Length; i++)
                {
                    if (stud.Course[i] == ".Net Basic")
                        checkedListBox1.SetItemChecked(0, true);
                    if (stud.Course[i] == "OOP")
                        checkedListBox1.SetItemChecked(1, true);
                    if (stud.Course[i] == "Core")
                        checkedListBox1.SetItemChecked(2, true);
                    if (stud.Course[i] == "CSS")
                        checkedListBox1.SetItemChecked(3, true);
                    if (stud.Course[i] == "HTML")
                        checkedListBox1.SetItemChecked(4, true);
                }
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            student.Id = int.Parse(txtId.Text);
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Phone = int.Parse(txtPhone.Text);
            student.City = comboBox1.Text;
            student.Email = txtEmail.Text;
            student.BirthDate = dateTimePicker1.Text;
            checkedListBox1.CheckedItems.CopyTo(student.Course, 0);
            
            MyDB.Save(student);
            MessageBox.Show("Successfully Saved");

            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

       
    }
}
