using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasefileDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.databasefileDataSet.Person);

        }
    }
}
