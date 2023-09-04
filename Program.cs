namespace Atividade
{
    class Program
    {
        public static void Main(string[] args)
        {
            int controle = 0;   /// Var to control loop and decision of witch class will be used.
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione o tipo de cliente ou qualquer outro valor para sair!");
                Console.WriteLine("1 - Pessoa Fisica | 2 - Pessoa Juridica");
                controle = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o nome do cliente?");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o endereço:");
                string endereço = Console.ReadLine();
                //Creating the objects
                if (controle == 1)
                {
                    ClienteCpf pf = new ClienteCpf();
                    pf.Nome = nome;
                    pf.Endereço = endereço;
                    Console.WriteLine("Insira o cpf:");
                    pf.cpf = Console.ReadLine();
                    Console.WriteLine("Insira o RG:");
                    pf.rg = Console.ReadLine();
                    Console.WriteLine("Informe o valor de compra:");
                    float entrada = float.Parse(Console.ReadLine());
                    pf.PagarImposto(entrada);
                    // print
                    pf.imprimir();
                }
                if (controle == 2)
                {
                    ClienteCnpj pj = new ClienteCnpj();
                    pj.Nome = nome;
                    pj.Endereço = endereço;
                    Console.WriteLine("Insira o CNPJ:");
                    pj.Cnpj = Console.ReadLine();
                    Console.WriteLine("Insira o IE:");
                    pj.Ie = Console.ReadLine();
                    Console.WriteLine("Informe o valor de compra:");
                    float entrada = float.Parse(Console.ReadLine());
                    pj.PagarImposto(entrada);
                    // print
                    pj.imprimir();
                }
                Console.WriteLine("Digite qualquer valor diferente de 1 e 2 para sair!");
                controle = int.Parse(Console.ReadLine());
            } while (controle == 1 || controle == 2);
        }
    }
}