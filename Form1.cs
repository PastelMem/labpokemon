using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labpokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pikachu pikachu = new pikachu();
            label1.Text = pikachu.Name();
            pictureBox1.Image = Labpokemon.Properties.Resources.pikachu3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kyurem kyurem = new Kyurem();
            label1.Text = kyurem.Name();
            pictureBox1.Image = Labpokemon.Properties.Resources.Kyurem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Marill marill = new Marill();
            label1.Text = marill.Name();
            pictureBox1.Image = Labpokemon.Properties.Resources.Marill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Komala komala = new Komala();
            label1.Text = komala.Name();
            pictureBox1.Image = Labpokemon.Properties.Resources.Komala;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Chien_Pao chien_Pao = new Chien_Pao();
            label1.Text= chien_Pao.Name();
            pictureBox1.Image = Labpokemon.Properties.Resources.Chien_Pao;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Charizard charizard = new Charizard();
            label1.Text= charizard.Name();
            pictureBox1.Image = Labpokemon.Properties.Resources.Charizard;
        }
    }
}
