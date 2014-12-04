using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataTableToListExample
{
    public partial class FormDataTableToList : Form
    {
        public FormDataTableToList()
        {
            InitializeComponent();
        }

        private void btnDatatableToList_Click(object sender, EventArgs e)
        {
            //here we get a datatable for students info
            DataTable dtStudent = GetDataTable();

            //now we need to convert this datatable to List<Student> for further use
            //we've created a Student class in Student.cs
            //The mapping is directly upon "Student Class Property Name" and "Column Name of the DataTable".
            List<Student> listStudents = DataTableToListLib.DataTableToList.Convert<Student>(dtStudent);
            
            //now here we have the List<Student>. Use as you want...cheers

            foreach (Student student in listStudents)
            {
                //write related code
            }
            
            MessageBox.Show("Total Students in list = " + listStudents.Count);
        }

        static DataTable GetDataTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Roll", typeof(string));

            // Here we add five DataRows.
            table.Rows.Add("David", "a-100");
            table.Rows.Add("Sam", "a-101");
            table.Rows.Add("Christoff", "a-102");
            table.Rows.Add("Janet", "a-103");
            table.Rows.Add("Melanie", "a-104");

            return table;
        }
    }
}
