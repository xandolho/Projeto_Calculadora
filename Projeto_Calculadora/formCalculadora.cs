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
    public partial class formCalculadora : Form
    {
        public int contaExec = 0;
        public formCalculadora()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        Calculos cal = new Calculos();
        public int contMais = 0;
        public int contPonto = 0;
        public String n1 = null;
        public String n2 = null;
        public Char opera = 'v';
        public bool pronto = false;
        

        private void bt7_Click(object sender, EventArgs e)
        {
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "7";
                contMais++;
            }
            else
            {
                txtVisor.Text += "7";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "8";
                contMais++;
            }
            else
            {
                txtVisor.Text += "8";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "9";
                contMais++;
            }
            else
            {
                txtVisor.Text += "9";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "4";
                contMais++;
            }
            else
            {
                txtVisor.Text += "4";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "5";
                contMais++;
            }
            else
            {
                txtVisor.Text += "5";
            }

        }

        private void bt6_Click(object sender, EventArgs e)
        {
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "6";
                contMais++;

            }
            else
            {
                txtVisor.Text += "6";
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "1";
                contMais++;

            }
            else
            {
                txtVisor.Text += "1";
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
                        
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {                
                txtVisor.Text = "";
                txtVisor.Text = "2";
                contMais++;
                
            }
            else
            {                
                txtVisor.Text += "2";
            }

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            start();            
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "3";
                contMais++;
            }
            else
            {
                txtVisor.Text += "3";
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            start();
            if (pronto == true) { txtVisor.Text = ""; }
            if (contMais == 0)
            {
                txtVisor.Text = "";
                txtVisor.Text = "0";
                contMais++;
            }
            else
            {
                txtVisor.Text += "0";
            }
        }

        /*incrementa primeiro uso e limpa a tela uma vez*/
        public void start()
        {
            if (this.contaExec == 0)
            {                
                txtVisor.Text = "";
                txtMostraFormula.Text = "";
                this.contaExec++;
            }
        }
        /*verifica se a virgula já está sendo usada na tela */
        public Boolean isUsando(String valor)
        {
            for (int i = 0; i < valor.Length; i++)
            {
                if(valor[i] == ','){
                    return true;
                }
            }
            return false;
        }
        private void btPonto_Click(object sender, EventArgs e)
        {
            start();            
            if (pronto == true) { txtVisor.Text = ""; }
            if(isUsando(txtVisor.Text))
            {
            }
            else{
            if (txtVisor.Text == "")
            {
                txtVisor.Text = "0,"; 
                    
            }
            else
            {
                txtVisor.Text += ",";
            }
          }
        }
        /*limpa todos os dados*/
        private void btClear_Click(object sender, EventArgs e)
        {
            start();
            txtVisor.Text = "0";
            txtMostraFormula.Text = "DigiTex®";
            this.n1 = null;
            this.n2 = null;
            this.pronto = false;
            this.opera = 'v';
            this.contaExec = 0;
            contMais = 0;
            contPonto = 0;
            cal.clear();

        }
        /*chama o método calcula*/
        private void btSoma_Click(object sender, EventArgs e)
        {
            start();
            if (txtVisor.Text == "")
            {
            }
            else
            {
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = n1;
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('+');
                }
                else
                { 
                if (n1 == null)                
                {
                    txtMostraFormula.Text += txtVisor.Text + "+";
                    n1 = txtVisor.Text;
                    txtVisor.Text = "";
                    cal.recebeOpera('+');
                    pronto = false;
                    contMais++;
                }
                else
                {
                    n2 = txtVisor.Text;
                    txtMostraFormula.Text += txtVisor.Text + "+";
                    cal.recebeN1(n1);
                    cal.recebeN2(n2);
                    n2 = null;
                    pronto = true;
                    contMais++;

                }}
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = n1;
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('+');
                } 
            } 
        }
        /*chama o método calcula*/
        private void btSubtrai_Click(object sender, EventArgs e)
        {
            start();
            if (txtVisor.Text == "")
            {
            }
            else
            {
                if (pronto == true)
                {               
                    n1 = cal.calcula();
                    txtVisor.Text = n1;
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('-');
                }
                else
                {
                    if (n1 == null)
                    {                        
                        txtMostraFormula.Text += txtVisor.Text + "-";
                        n1 = txtVisor.Text;
                        txtVisor.Text = "";
                        cal.recebeOpera('-');
                        pronto = false;
                        contMais++;
                    }
                    else
                    {
                        n2 = txtVisor.Text;
                        txtMostraFormula.Text += txtVisor.Text + "-";                        
                        cal.recebeN1(n1);
                        cal.recebeN2(n2);
                        n2 = null;
                        pronto = true;
                        contMais++;

                    }
                }
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = n1;
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('-');
                } 
            } 
        }
        /*limpa a tela e a variavel numeroDois ou numeroUm*/
        private void CE_Click(object sender, EventArgs e)
        {
            start();
            txtVisor.Text = "";
            if (this.n1 == null)
            {
                this.n1 = null;
            }
            else
            {
                this.n2 = null;
            }
        }
        /*le os eventos do teclado*/
        private void leTecla(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == '+')
            {
                start();
                if (pronto == true) { txtVisor.Text = ""; }
                this.opera = e.KeyChar;
                btSoma_Click(sender,e);
            }
            else if (e.KeyChar == '-')
            {
                start();
                if (pronto == true) { txtVisor.Text = ""; }
                this.opera = e.KeyChar;
                btSubtrai_Click(sender, e);
            }
            else if (e.KeyChar == '*')
            {
                start();
                if (pronto == true) { txtVisor.Text = ""; }
                this.opera = e.KeyChar;
                btMulti_Click(sender, e);
            }
            else if (e.KeyChar == '/')
            {
                start();
                if (pronto == true) { txtVisor.Text = ""; }
                this.opera = e.KeyChar;
                btDivide_Click(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Enter)//casting do enter
            {
                start();
                btIgual_Click(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Escape)//casting do Esc
            {
                start();
                btClear_Click(sender, e);
            }
            else if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                start();
                if (pronto == true) { txtVisor.Text = ""; }
                txtVisor.Text += e.KeyChar.ToString();
            }
            else { }            
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            start();
            start();
            if (txtVisor.Text == "")
            {
            }
            else
            {
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = n1;
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('*');
                }
                else
                {
                    if (n1 == null)
                    {
                        txtMostraFormula.Text += txtVisor.Text + "x";
                        n1 = txtVisor.Text;
                        txtVisor.Text = "";
                        cal.recebeOpera('*');
                        pronto = false;
                        contMais++;
                    }
                    else
                    {
                        n2 = txtVisor.Text;
                        txtMostraFormula.Text += txtVisor.Text + "x";
                        cal.recebeN1(n1);
                        cal.recebeN2(n2);
                        n2 = null;
                        pronto = true;
                        contMais++;

                    }
                }
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = n1;
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('*');
                }
            } 
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            start();
            start();
            if (txtVisor.Text == "")
            {
            }
            else
            {
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = n1;
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('/');
                }
                else
                {
                    if (n1 == null)
                    {
                        txtMostraFormula.Text += txtVisor.Text + ":";
                        n1 = txtVisor.Text;
                        txtVisor.Text = "";
                        cal.recebeOpera('/');
                        pronto = false;
                        contMais++;
                    }
                    else
                    {
                        n2 = txtVisor.Text;
                        txtMostraFormula.Text += txtVisor.Text + ":";
                        cal.recebeN1(n1);
                        cal.recebeN2(n2);
                        n2 = null;
                        pronto = true;
                        contMais++;

                    }
                }
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = n1;
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('/');
                }
            } 
        }

        private void btPorcento_Click(object sender, EventArgs e)
        {
            start();
            if (txtVisor.Text == "")
            {
            }
            else
            {
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = Convert.ToString(Convert.ToDouble(n1) / 100);
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('%');
                }
                else
                {
                    if (n1 == null)
                    {
                        txtMostraFormula.Text += txtVisor.Text + "%";
                        n1 = txtVisor.Text;
                        txtVisor.Text = "";
                        cal.recebeOpera('%');
                        pronto = false;
                        contMais++;
                    }
                    else
                    {
                        n2 = txtVisor.Text;
                        txtMostraFormula.Text += txtVisor.Text + "%";
                        cal.recebeN1(n1);
                        cal.recebeN2(n2);
                        n2 = null;
                        pronto = true;
                        contMais++;

                    }
                }
                if (pronto == true)
                {
                    n1 = cal.calcula();
                    txtVisor.Text = Convert.ToString(Convert.ToDouble(n1) / 100);
                    n2 = null;
                    contMais = 0;
                    pronto = false;
                    cal.recebeOpera('%');
                }
            } 

        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            start();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            start();
            if(this.n1 != null)
            {
                this.n2 = txtVisor.Text;                 
                cal.recebeN1(this.n1);
                cal.recebeN2(this.n2);
                txtVisor.Text = cal.calcula();
                txtMostraFormula.Text = "";
                this.n1 = null;
                this.n2 = null;
                contMais = 0;
                this.pronto = false;
            }
            
        }
        /*funções do menu*/
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            new formSobre().Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formSobre frm = new formSobre();
            frm.ShowDialog();
            
        }



    }
}
