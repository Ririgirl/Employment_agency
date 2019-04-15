using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсовая_вп
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form3 newvacancy = new Form3();
            newvacancy.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form4 newcompany = new Form4();
            newcompany.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            Form5 newcandidate = new Form5();
            newcandidate.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trudkontDataSet.company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.trudkontDataSet.company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trudkontDataSet.resume". При необходимости она может быть перемещена или удалена.
            this.resumeTableAdapter.Fill(this.trudkontDataSet.resume);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trudkontDataSet.vacancy". При необходимости она может быть перемещена или удалена.
            this.vacancyTableAdapter.Fill(this.trudkontDataSet.vacancy);
            DateTime date = DateTime.Now;
            label1.Text = date.ToShortDateString();
        }

        

        private void toolStripTextBox5_TextChanged(object sender, EventArgs e)
        { 
            vacancyBindingSource.Filter = "name_vac like '%"+toolStripTextBox5.Text+"%'";
            resumeBindingSource.Filter = "fname_res like '%" + toolStripTextBox5.Text + "%'";
            companyBindingSource.Filter = "name_comp like '%" + toolStripTextBox5.Text + "%'";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?",
            "Завершение программы",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
         }

        private void companyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.companyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.companyDataGridView.MultiSelect = false;
        }

        private void vacancyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.vacancyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.vacancyDataGridView.MultiSelect = false;
        }
        string a;
        private void vacancyDataGridView_DoubleClick(object sender, EventArgs e)
        {
                if (vacancyDataGridView.SelectedCells.Count > 0)
                {
                    int selectedrowindex = vacancyDataGridView.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = vacancyDataGridView.Rows[selectedrowindex];
                
                    a = Convert.ToString(selectedRow.Cells["column1"].Value);
                label3.Text = a;
                Form6 form6 = new Form6(label3.Text);
                form6.Show();
                }
        }

        private void companyDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (companyDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = companyDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = companyDataGridView.Rows[selectedrowindex];

                a = Convert.ToString(selectedRow.Cells["column2"].Value);
                label3.Text = a;
                Form7 form7 = new Form7(label3.Text);
                form7.Show();
            }
        }

        private void resumeDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (resumeDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = resumeDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = resumeDataGridView.Rows[selectedrowindex];

                a = Convert.ToString(selectedRow.Cells["column3"].Value);
                label3.Text = a;
                Form8 form8 = new Form8(label3.Text);
                form8.Show();
            }
        }

        private void resumeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.resumeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.resumeDataGridView.MultiSelect = false;
            
        }
        
        private void tabControl1_Click(object sender, EventArgs e)
        {
            this.vacancyTableAdapter.Fill(this.trudkontDataSet.vacancy);
            this.companyTableAdapter.Fill(this.trudkontDataSet.company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trudkontDataSet.resume". При необходимости она может быть перемещена или удалена.
            this.resumeTableAdapter.Fill(this.trudkontDataSet.resume);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

