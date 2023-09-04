namespace Atividade
{
    public class ClienteCnpj : cliente
    {
        public string Cnpj;
        public string Ie;
        public override void PagarImposto(float v)
        {
            Valor = v;
            Total = Valor * 1.2F;
            ValorImposto = Total - Valor;
        }
        public override void imprimir()
        {
            Console.WriteLine("-------- Pessoa Jurídica ---------");
            Console.WriteLine("Nome ..........: " + this.Nome);
            Console.WriteLine("Endereço ......: " + this.Endereço);
            Console.WriteLine("CNPJ ..........: " + Cnpj);
            Console.WriteLine("IE ............: " + Ie);
            Console.WriteLine("Valor de Compra: " + Valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + ValorImposto.ToString("C"));
            Console.WriteLine("Total a Pagar..: " + Total.ToString("C"));
            Console.ReadLine();
        }
    }
}