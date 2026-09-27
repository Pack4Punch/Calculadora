using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        //cultura brasileira: usa virgula como separador decimal
        CultureInfo ptBR = new CultureInfo("pt-BR");

        //Indica se o ultimo comando foi o botao = 
        bool novoCalculo = false;


        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        //numeros 
        private void AdicionarNumero(string numero)
        {
            //Se acabou de calcular, começa um novo numero
            if (novoCalculo)
            {
                txtResultado.Text = "";
                novoCalculo = false;
            }
            txtResultado.Text += numero;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        //virgula
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            //Se acabou de calcular, começa um novo numero
            if (novoCalculo) ;
            {
                AdicionarNumero("");
                novoCalculo = false;
            }

            //Não permite duas virgula
            if (!txtResultado.Text.Contains(",")) ;
            {
                //Se clicar na virgula sem nenhum numero, começa com 0
                if (txtResultado.Text == "") ;
                {
                    txtResultado.Text = "0,";

                }
                //Era pra ter um ELSE aqui ?
                {
                    txtResultado.Text += ",";
                }
            }
        }
        //Retroceder
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0) ;
            {
                txtResultado.Text =
                     txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }
        }
        //Operações
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") ;
            {
                valor1 = decimal.Parse(txtResultado.Text, ptBR);

               txtResultado.Text = "";

                operacao = "SOMA";

                lblResultado.Text = "+";

                novoCalculo = false;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") ;
            {
                valor1 = decimal.Parse(txtResultado.Text, ptBR);

                lblResultado.Text = "";

                operacao = "SUB";

                lblResultado.Text = "-";

                novoCalculo = false;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") ;
            {
                valor1 = decimal.Parse(txtResultado.Text, ptBR);

                txtResultado.Text = "";

                operacao = "MULT";

                lblResultado.Text = "x";

                novoCalculo = false;
            }

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") ;
            {
                valor1 = decimal.Parse(txtResultado.Text, ptBR);

                txtResultado.Text = "";

                operacao = "DIV";

                lblResultado.Text = "/";

                novoCalculo = false;
            }
        }
        //IGUAL
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "" && operacao != "") ;
            {
                valor2 = decimal.Parse(txtResultado.Text, ptBR);

                decimal resultado = 0;

                if (operacao == "SOMA") ;
                {
                    resultado = valor1 + valor2;
                }
                //Era pra ter um "else" antes do "if" ?
                if (operacao == "SUB") ;
                {
                    resultado = valor1 - valor2;
                }
                if (operacao == "MULT") ;
                {
                    resultado = valor1 * valor2;
                }
                if (operacao == "DIV") ;
                {
                    //Impede divisao por zero 
                    if (valor2 == 0) ;
                   
                    resultado = valor1 / valor2;
                }

                // Mostra o resultado usando a cultura brasileira
                txtResultado.Text = resultado.ToString(ptBR);

                // Limpa a operação exibida
                lblResultado.Text = "";

                // Indica que acabamos de calcular
                novoCalculo = true;
            }

        }
        //Limpar Tudo - C
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            valor1 = 0;
            valor2 = 0;

            operacao = "";

            lblResultado.Text = "";

            novoCalculo = false;
        }
        //Limpar Enbtrada - CE
        private void btnCe_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            novoCalculo = false;
        }
    }
}

// Calculadora com C# windows forms
// As habas principais da tela inicial são:
// - Caixa de Ferramentas, Form1.cs[Design], Gerenciador de Soluções, Propriedades
 //  ou em inglês.
 // - Toolbox, Form1.cs[Design], Solution Explorer, Properties


 // 1° Vamos arrastar o component TextBox para dentro do nosso Form1 "nossa tela de Design".
 // - Inicialmente você percebera que o texto começa da esquerda para a direita, mas devemos fazer o 
 // alinhamento para a direita. Então selecionamos o TextBox, em properties, TextAlign que estara 
 // como Left, mudamos para Right.
 // - Outra coisa que você vai notar é que o TextBox aceita letras, vamos alterar apenas para números.
 // Selecione o TextBox, em Properties iremos para ReadOnly e mudaremos seu valor de False para True,
 // para que ele aceite apenas leitura do código, nenhuma letra nenhum número.

 // 2° Próximo componente é o Button, vamos arrastar também para o Form1 Design.
 // - Após ajustar o botão, iremos para Properties, procuraremos por Text,vamos alterar 
 // seu nome para 0, Você fara o mesmo para todos os outros botões, mudando seu Text 
 // para o desejado.

 // Eles são: 
 //  ______________
 // |______________|
 // |7| 8| 9| +| CE| 
 // |4| 5| 6| -| C |
 // |1| 2| 3| X|
 // |0| ,| <| /| = | 

 // C — Clear / Limpar tudo, limpa a calculadora inteira.
 // CE — Clear Entry / Limpar entrada, O CE significa limpar a entrada atual
 // 3° Após ajustar tudo vamos arrastar uma Label para dentro do 1° componente, o TextBox.  
 // - Mudaremos o Name para txtResultado.
 // - Essa Label vai mostrar os textos que digitaremos na calculadora.
 // Uma observação, o Text da Label deve ficar em branco pois não queremos que ela 
 // exiba valores de texto não desejados.

 // 4° Agora você deve ter notado que nosso software esta alinhado a esquerda, vamos alinha-lo ao centro. 
 // - Selecione o formulário e a primeira coisa é alterar seu nome em Text de Form1 para Calculadora.
 // - Após isso na mesma aba vamos procurar StartPosition, vai estar como WindowsDefaultLocati on, vamos 
 // alterar para CenterScreen, desta forma o formulario sempre aparecera no centro da tela quando executar.

 // NESTE PONTO A CALCULADORA ESTA MONTADA E CONFIGURADA, MAS AINDA NÃO EXECUTA AÇÕES, VAMOS CODIFICAR 
 // 5°  Primeiro ponto agora é clicar duas vezes no botão zero para que o visual studio crie o código do botão,
 // vai abrir uma aba nova com a seguinte informação:

 // private void button1_Click(object sender, EventArgs e)
 // {

 // }

 // Mas existe um ponto importante aqui, o button1_Click pode ser qualquer caracter, então vamos padronizar.
 // Voltamos a haba de Designer, selecionamos o botão zero ao qual atribuimos o 0 em Properties e vamos em 
 // Name, alteraremos seu valor para btnZero.
 // Desta forma poderemos reconhecer o botão dentro do código quando clicarmos duas vezes no botão, e faremos
 // isso para todos os componentes restantes colocando seu respectivo nome.


 // IMPORTANTE caso tenha excluido algum código, você percebera que seu projeto se perdeu, voce precisa ir em 
 // Properties, Events "é um simbolo de raio no topo" e remover este evento, apó isso salve o projeto.
 // Só depois de remover o evento você pode remover o código e o próprio botão. E não esqueça de voltar para
 // Properties que fica ao lado dos Events.

 // Outra forma caso apague o código ou apague o botão, na mesma aba que o projeto crachou voce deve ver os erros,
 // então deve clicar em cima do erro, ele diz exatamente onde esta o erro e como resolver.
 // Após aberto a linha você vera o "Form1.Designer.cs*" na linha onde ele mostrou o erro, é so apagar esta linha
 // e voltar a aba do desgner
