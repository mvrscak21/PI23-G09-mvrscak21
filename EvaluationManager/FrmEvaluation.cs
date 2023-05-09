using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvaluation : Form {

        private Student student;
        private object selectedStudents;

        public FrmEvaluation() {
            InitializeComponent();
        }

        public FrmEvaluation(object selectedStudents) {
            this.selectedStudents = selectedStudents;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void FrmEvaluation_Load(object sender, EventArgs e) {
            SetFormText();
            var activities = ActivityReposytory.GetActivities();
        }
        

        private void SetFormText()
        {
            Text=student.FirstName+ " "+ student.LastName;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) 
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            var currentActivity=cboActivities_SelectedIdndexChanged(object se)
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
