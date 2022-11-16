using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ApInfo
{
    
    public partial class Form1 : Form
    {
        Candidato cand = new Candidato();
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Salvar
            /*nome varchar(255),
sexo varchar(10),
nascimento Date,
estado varchar(100),
cidade varchar(255),
cep varchar(9),
bairro varchar(100),
telefone varchar(100),
email varchar(100),
cpf varchar(11),
senha varchar(20),
frasesecreta varchar(200),
curriculo varchar(255)*/

            cand.setNome(txtNome.Text);
            cand.setSexo(boxSexo.Text);
            cand.setNascimento(.ToString(dateNascimento.Value)) ;
            cand.setEstado(boxEstado.Text);
            cand.setCidade(txtCidade.Text);
            cand.setCep(txtCep.Text);
            cand.setBairro(txtBairro.Text);
            cand.setTelefone(txtTelefone.Text);
            cand.setEmail(txtEmail.Text);
            cand.setCpf(txtCpf.Text);
            cand.setSenha(txtSenha.Text);
            cand.setFrase(txtFrase.Text);
            cand.setCurriculo(rtbCurriculo.Text);
        }
    }
}
