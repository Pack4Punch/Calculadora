~\Desktop\Form1.cs
 using System;
 using System.Globalization;
 using System.Windows.Forms;

 namespace Calculadora
 {
 public partial class Form1 : Form
 {
 decimal valor1 = 0;
 decimal valor2 = 0;
 string operacao = "";

 // Cultura brasileira: usa vírgula como separador decimal
 CultureInfo ptBR = new CultureInfo("pt-BR");
 // Indica se o último comando foi o botão =
 bool novoCalculo = false;

 public Form1()
 {
 InitializeComponent();
 }

 private void txtResultado_TextChanged(object sender, EventArgs e)
 {
 }

 // NÚMEROS
 private void AdicionarNumero(string numero)
 {
 // Se acabou de calcular, começa um novo número
 if (novoCalculo)
 {
 txtResultado.Text = "";
 novoCalculo = false;
 }

 txtResultado.Text += numero;
 }

 private void btnZero_Click(object sender, EventArgs e)
 {
 AdicionarNumero("0");
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

 // VÍRGULA
 private void btnVirgula_Click(object sender, EventArgs e)
 {
 // Se acabou de calcular, começa um novo número
 if (novoCalculo)
 {
 txtResultado.Text = "";
 novoCalculo = false;
 }

 // Não permite duas vírgulas
 if (!txtResultado.Text.Contains(","))
 {
 // Se clicar na vírgula sem nenhum número,
 // começa com 0,
 if (txtResultado.Text == "")
 {
 txtResultado.Text = "0,";
 }
 else
 {
 txtResultado.Text += ",";
 }
 }
 }

 // RETROCEDER
 private void btnRetroceder_Click(object sender, EventArgs e)
 {
 if (txtResultado.Text.Length > 0)
 {
 txtResultado.Text =
 txtResultado.Text.Remove(txtResultado.Text.Length - 1);
 }
 }

 // OPERAÇÕES
 private void btnAdicao_Click(object sender, EventArgs e)
 {
 if (txtResultado.Text != "")
 {
 valor1 = decimal.Parse(txtResultado.Text, ptBR);

 txtResultado.Text = "";

 operacao = "SOMA";

 lblOperacao.Text = "+";

 novoCalculo = false;
 }
 }

 private void btnSubtracao_Click(object sender, EventArgs e)
 {
 if (txtResultado.Text != "")
 {
 valor1 = decimal.Parse(txtResultado.Text, ptBR);

 txtResultado.Text = "";

 operacao = "SUB";

 lblOperacao.Text = "-";

 novoCalculo = false;
 }
 }

 private void btnMultiplicacao_Click(object sender, EventArgs e)
 {
 if (txtResultado.Text != "")
 {
 valor1 = decimal.Parse(txtResultado.Text, ptBR);

 txtResultado.Text = "";

 operacao = "MULT";

 lblOperacao.Text = "*";

 novoCalculo = false;
 }
 }

 private void btnDivisao_Click(object sender, EventArgs e)
 {
 if (txtResultado.Text != "")
 {
 valor1 = decimal.Parse(txtResultado.Text, ptBR);

 txtResultado.Text = "";

 operacao = "DIV";

 lblOperacao.Text = "/";

 novoCalculo = false;
 }
 }

 // IGUAL
 private void btnIgual_Click(object sender, EventArgs e)
 {
 if (txtResultado.Text != "" && operacao != "")
 {
 valor2 = decimal.Parse(txtResultado.Text, ptBR);

 decimal resultado = 0;

 if (operacao == "SOMA")
 {
 resultado = valor1 + valor2;
 }
 else if (operacao == "SUB")
 {
 resultado = valor1 - valor2;
 }
 else if (operacao == "MULT")
 {
 resultado = valor1 * valor2;
 }
 else if (operacao == "DIV")
 {
// Impede divisão por zero
 if (valor2 == 0)
 {
 MessageBox.Show(
 "Não é possível dividir por zero.",
 "Erro",
 MessageBoxButtons.OK,
 MessageBoxIcon.Error
 );

 return;
 }

 resultado = valor1 / valor2;
 }

 // Mostra o resultado usando a cultura brasileira
 txtResultado.Text = resultado.ToString(ptBR);

 // Limpa a operação exibida
 lblOperacao.Text = "";

 // Indica que acabamos de calcular
 novoCalculo = true;
 }
 }

 // LIMPAR TUDO - C
 private void btnLimpar_Click(object sender, EventArgs e)
 {
 txtResultado.Text = "";

 valor1 = 0;
 valor2 = 0;

 operacao = "";

 lblOperacao.Text = "";

 novoCalculo = false;
 }

 // LIMPAR ENTRADA - CE
 private void btnCE_Click(object sender, EventArgs e)
 {
 txtResultado.Text = "";

 novoCalculo = false;
 }
 }
 }
 // Calculadora com C# windows forms

 // As habas principais da tela inicial são:
 // - Caixa de Ferramentas, Form1.cs[Design], Gerenciador de Soluções, Propriedades
271 // ou em inglês.
272 // - Toolbox, Form1.cs[Design], Solution Explorer, Properties
273
274
275 // 1° Vamos arrastar o component TextBox para dentro do nosso Form1 "nossa tela de Design".
276 // - Inicialmente você percebera que o texto começa da esquerda para a direita, mas devemos fazer o
277 // alinhamento para a direita. Então selecionamos o TextBox, em properties, TextAlign que estara
278 // como Left, mudamos para Right.
279 // - Outra coisa que você vai notar é que o TextBox aceita letras, vamos alterar apenas para números.
280 // Selecione o TextBox, em Properties iremos para ReadOnly e mudaremos seu valor de False para True,
281 // para que ele aceite apenas leitura do código, nenhuma letra nenhum número.
282
283 // 2° Próximo componente é o Button, vamos arrastar também para o Form1 Design.
284 // - Após ajustar o botão, iremos para Properties, procuraremos por Text,vamos alterar
285 // seu nome para 0, Você fara o mesmo para todos os outros botões, mudando seu Text
286 // para o desejado.
287
288 // Eles são:
289 // ______________
290 // |______________|
291 // |7| 8| 9| +| CE|
292 // |4| 5| 6| -| C |
293 // |1| 2| 3| X|
294 // |0| ,| <| /| = |
295
296 // C — Clear / Limpar tudo, limpa a calculadora inteira.
297 // CE — Clear Entry / Limpar entrada, O CE significa limpar a entrada atual.
298
299 // 3° Após ajustar tudo vamos arrastar uma Label para dentro do 1° componente, o TextBox.
300 // - Mudaremos o Name para txtResultado.
301 // - Essa Label vai mostrar os textos que digitaremos na calculadora.
302 // Uma observação, o Text da Label deve ficar em branco pois não queremos que ela
303 // exiba valores de texto não desejados.
304
305 // 4° Agora você deve ter notado que nosso software esta alinhado a esquerda, vamos alinha-lo ao centro.
306 // - Selecione o formulário e a primeira coisa é alterar seu nome em Text de Form1 para Calculadora.
307 // - Após isso na mesma aba vamos procurar StartPosition, vai estar como WindowsDefaultLocation, vamos
308 // alterar para CenterScreen, desta forma o formulario sempre aparecera no centro da tela quando executar.
309
310
311 // NESTE PONTO A CALCULADORA ESTA MONTADA E CONFIGURADA, MAS AINDA NÃO EXECUTA AÇÕES, VAMOS CODIFICAR

314 // 5° Primeiro ponto agora é clicar duas vezes no botão zero para que o visual studio crie o código do botão,
315 // vai abrir uma aba nova com a seguinte informação:

317 // private void button1_Click(object sender, EventArgs e)
318 // {

320 // }

322 // Mas existe um ponto importante aqui, o button1_Click pode ser qualquer caracter, então vamos padronizar.
323 // Voltamos a haba de Designer, selecionamos o botão zero ao qual atribuimos o 0 em Properties e vamos em
324 // Name, alteraremos seu valor para btnZero.
325 // Desta forma poderemos reconhecer o botão dentro do código quando clicarmos duas vezes no botão, e faremos
326 // isso para todos os componentes restantes colocando seu respectivo nome.

329 // IMPORTANTE caso tenha excluido algum código, você percebera que seu projeto se perdeu, voce precisa ir em
330 // Properties, Events "é um simbolo de raio no topo" e remover este evento, apó isso salve o projeto.
331 // Só depois de remover o evento você pode remover o código e o próprio botão. E não esqueça de voltar para
332 // Properties que fica ao lado dos Events.
 // Outra forma caso apague o código ou apague o botão, na mesma aba que o projeto crachou voce deve ver os erros,
 // então deve clicar em cima do erro, ele diz exatamente onde esta o erro e como resolver.
 // Após aberto a linha você vera o "Form1.Designer.cs*" na linha onde ele mostrou o erro, é so apagar esta linha
 // e voltar a aba do desgner.
