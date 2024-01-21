using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_App
{
    public partial class ToDoListEnC : Form
    {
        public ToDoListEnC()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create colums
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // Point our datagridview to our datasource
            ToDoListView.DataSource = todoList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DescriptiontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            //Fill text fields with data from table
            titleTextBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescriptionTextBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescriptionTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, DescriptionTextBox.Text);
            }
            //Clear fields

            titleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            isEditing = false;
        }
    }
}
