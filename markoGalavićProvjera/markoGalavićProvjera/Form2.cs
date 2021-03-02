using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićProvjera
{
    public partial class Form2 : Form
    {
        List<Osoba> Lista = new List<Osoba>();
        Form1 form = new Form1();
        public Form2(List<Osoba> Lista)
        {
            this.Lista = Lista;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(textBoxIme.Text, textBoxPrezime.Text, textBoxOib.Text, textBoxDrodenja.Text);
            Lista.Add(osoba);
            this.Hide();
            form.Show();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
