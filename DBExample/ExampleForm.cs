using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBExample
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "SELECT * from Main.\"Student\" ";
            gridData.DataSource = Postgre.GetAllStudents();
        }

        private void innerJoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select s.\"Id\", s.\"Name\", s.\"Surname\", r.\"Name\" as \"RoleName\" " +
                "from main.\"Student\" s " +
                 "INNER JOIN main.\"Role\" r on r.\"Id\" = s.\"Role\"";
            gridData.DataSource = Postgre.GetAllStudents("inner join");
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "SELECT * from Main.\"Student\" ";
            gridData.DataSource = Postgre.ExecuteSql(txtSQL.Text);

        }

        private void leftJoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select s.\"Id\", s.\"Name\", s.\"Surname\", r.\"Name\" as \"RoleName\" " +
                "from main.\"Student\" s " +
                 "LEFT JOIN main.\"Role\" r on r.\"Id\" = s.\"Role\"";
            gridData.DataSource = Postgre.GetAllStudents("left join");
        }

        private void rightJoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSQL.Text = "select s.\"Id\", s.\"Name\", s.\"Surname\", r.\"Name\" as \"RoleName\" " +
                "from main.\"Student\" s " +
                 "RIGHT JOIN main.\"Role\" r on r.\"Id\" = s.\"Role\"";
            gridData.DataSource = Postgre.GetAllStudents("right join");
        }
    }
}
