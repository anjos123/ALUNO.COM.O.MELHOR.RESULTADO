using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS.ALUNOS.CAMPEÃO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome, curso, turma, turno;
            Double prova1, prova2, prova3, media;

            nome = textBox1.Text;
            curso = textBox2.Text;
            turma = textBox3.Text;
            turno = textBox4.Text;

            prova1 = Convert.ToDouble(textBox5.Text);
            prova2 = Convert.ToDouble(textBox5.Text);
            prova3 = Convert.ToDouble(textBox5.Text);

            media = (prova1 + prova2 + prova3) / 3;

            if (media >= 6)
            {
                label13.Text = "APROVADO COM A MELHOR NOTA CAMPEÃO ";
            }
            else
            {
                label13.Text = "REPROVADO";
            }
            label11.Text = label11.Text + nome + "\n" + curso + "\n" + turno + "\n" + turma;

            label12.Text = Convert.ToString(label12.Text + "A MEDIA É: " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
