using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_gene
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Personne> lespers = DAOPersonne.Load();

            foreach(Personne p in lespers)
            {
                dgvpersonne.Rows.Add(p);
            }
        }
        
    }
}
