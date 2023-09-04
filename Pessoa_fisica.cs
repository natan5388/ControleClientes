namespace Atividade
{
    public class ClienteCpf : cliente
    {
        public string cpf;
        public string rg;
        public virtual void PagarImposto(float v) => base.PagarImposto(v);
        public override void imprimir()
        {
            Console.WriteLine("-------- Pessoa Física ---------");
            Console.WriteLine("Nome ..........: " + this.Nome);
            Console.WriteLine("Endereço ......: " + this.Endereço);
            Console.WriteLine("CPF ...........: " + cpf);
            Console.WriteLine("RG ............: " + rg);
            Console.WriteLine("Valor de Compra: " + Valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + ValorImposto.ToString("C"));
            Console.WriteLine("Total a Pagar..: " + Total.ToString("C"));
            Console.ReadLine();
        }
    }
}
