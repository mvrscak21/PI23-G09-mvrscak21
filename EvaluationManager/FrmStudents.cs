using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class btnEvaluateStudents : Form
    {
        public btnEvaluateStudents()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        private void FrmStudents_Load(object sender, EventArgs e) {
            ShowStudents();

        }
        private void ShowStudents() {
                var students = StudentRepository.GetStudents();
                dgvStudents.DataSource = students;

                dgvStudents.Columns["Id"].DisplayIndex = 0;
                dgvStudents.Columns["FirstName"].DisplayIndex = 1;
                dgvStudents.Columns["LastName"].DisplayIndex = 2;
                dgvStudents.Columns["Grade"].DisplayIndex = 3;
            }

        private void button2_Click(object sender, EventArgs e) {

        }
        Student selectedStudent=dgvStudents.CurrentRow.DataBoundItem as Student;
        if(selectedStudent !=null){
            FrmEvaluation frmEvaluation = new FrmEvaluation(selectedStudents);
        FrmEvaluation.ShowDialog();
            }


    }

    }

    

