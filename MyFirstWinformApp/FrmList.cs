using MyFirstWinformApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinformApp
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBind_Click(object sender, EventArgs e)
        {
            List<Person> persons = new List<Person>();
            Person p1 = new Person();
            p1.Name = "whywhc";
            p1.Age = 1;
            p1.Id = 1;
            persons.Add(p1);
            Person p2 = new Person()
            {
                Name = "whcchw",
                Id = 2,
                Age = 2,
            };
            persons.Add(p2);
            persons.Add(new Person()
            {
                Name = "wyhhyw",
                Id = 3,
                Age = 3,
            });
            persons.Add(new Person()
            {
                Name = "woiwoi",
                Id = 4,
                Age = 4,
            });
            dataGridView1.DataSource = persons;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
        
}
