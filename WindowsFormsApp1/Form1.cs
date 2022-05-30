using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        DataTable table = new DataTable("table");
        GpaCalculator obj = new GpaCalculator();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // GradePointCal obj = new GradePointCal();
                string name;
                name = Namee.Text;
                double hrs;
                hrs = Convert.ToDouble(this.comboBox1.SelectedItem);
                obj.setCrdHrs(hrs);
                double mids;
                mids = Convert.ToDouble(this.Mid.Text);
                if (mids < 0 || mids > 20)
                {
                    MessageBox.Show("Wrong Input");
                    Mid.Text = null;
                }
                else
                {
                    obj.SetMids(mids);
                }
                double ass;
                ass = Convert.ToDouble(this.Ass.Text);
                if (ass < 0 || ass > 20)
                {
                    MessageBox.Show("Wrong Input");
                    Ass.Text = null;
                }
                else
                {
                    obj.setAssignment(ass);
                }
                double quiz;
                quiz = Convert.ToDouble(this.Quiz.Text);
                if (quiz < 0 || quiz > 10)
                {
                    MessageBox.Show("Wrong Input");
                    Quiz.Text = null;
                }
                else
                {
                    obj.setQuiz(quiz);
                }
                double Final;
                Final = Convert.ToDouble(this.final.Text);
                if (Final < 0 || Final > 50)
                {
                    MessageBox.Show("Wrong input");
                    final.Text = null;
                }
                else
                {
                    obj.setFinal(Final);
                }

                double sessional = obj.SessionalCal();
                double total = obj.totalCal();
                double gradepoint = obj.GradePoint();
                string grade = obj.Gradee(gradepoint);
                obj.cal();
                table.Rows.Add(Namee.Text, comboBox1.SelectedItem.ToString(), sessional, total, gradepoint, grade);
                clear();

            }
            catch(Exception exc)
            {
               MessageBox.Show("Invalid Input");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("CrdHrs", Type.GetType("System.Int32"));
            table.Columns.Add("Sessional", Type.GetType("System.Double"));
            table.Columns.Add("Total", Type.GetType("System.Double"));
            table.Columns.Add("GradePoint", Type.GetType("System.Double"));
            table.Columns.Add("Grade", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        public void clear()
        {
            Namee.Text = null;
            Mid.Text = null;
            Ass.Text = null;
            Quiz.Text = null;
            final.Text = null;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            Namee.Text = row.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            clear();
           // obj
            label7.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            double var=obj.Gpa();
            label7.Text = var.ToString();
        }

        
    }
}
