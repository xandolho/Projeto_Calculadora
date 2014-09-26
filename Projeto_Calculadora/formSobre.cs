using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Calculadora
{
    public partial class formSobre : Form
    {
        public formSobre()
        {
            InitializeComponent();
            txtArea.Text = 
                "A Calculadora DIGITEX® 1.0, é um projeto de uma calculadora básica,"+ 
                "desenvolvida em CSharp, por estudantes de TI da escola "+"\n"+
                "Fundação IENH de Novo - RS." + "\n" + "\n" + "Desenvolvedores:" + "\n" +
                "Alexandre Rossi Grings - alexandregrings@hotmail.com"+"\n"+
                "Leonardo Brizolla - leonardobrizollars@gmail.com"+"\n"+
                "Jefferson W. - jjeff@gmail.com";
            
        }

        private void formSobre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
