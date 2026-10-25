/*um cliente quer solicitar um emprestimo. receba o valor solicitado, a quantidade de parcelas desejadas e a renda mensal comprovada. so autorize 
emprestimos cuja parcela não ultrapasse 30% da renda.*/

double ValorSOL;
int parcelas;
double renda;

Console.Write("Digite o valor do emprestimo solicitado: ");
ValorSOL = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor das parcelas do emprestimo solicitado: ");
parcelas = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o valor da renda mensal: ");
renda = Convert.ToDouble(Console.ReadLine());

var limite = ValorSOL / parcelas;
renda = (renda * 0.3);

if(renda < limite)
{
    Console.WriteLine("Emprestimo não-autorizado");
}
else
{
    Console.WriteLine("Emprestimo autorizado");
}