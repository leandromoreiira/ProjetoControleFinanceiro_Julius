using ProjetoControleFinanceiro_Julius;
using System.Globalization;

int EscolhaUsuario;
string DataAtual;




//Definição e exibição do saldo atual.
Console.WriteLine("Olá Julius! Informe seu saldo atual: ");
double SaldoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
FinanceiroJulius.DefinirSaldoInicial(SaldoInicial);


//Adicionando despesas e mostrando novo saldo

Console.WriteLine("Olá Julius, Informe o valor da sua despesa R$: ");
double valorGasto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("qual foi o motivo: ");
string descricao = Console.ReadLine();
FinanceiroJulius.adicionarDespesa(valorGasto,descricao);


//Adicionando economia e mostrando novo saldo

Console.WriteLine("Olá Julius ,Como você fez essa economia ");
double ValorEconomizado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("qual foi o motivo: ");
string descricaoEconomia = Console.ReadLine();
FinanceiroJulius.adicionarEconomia(ValorEconomizado,descricaoEconomia);





