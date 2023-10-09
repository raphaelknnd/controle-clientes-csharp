using System;

namespace Atividade 
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;

            Console.Write("Informe o nome: ");
            string var_nome = Console.ReadLine();
            Console.Write("Informe o nome: ");
            string var_endereco = Console.ReadLine();
            Console.Write("Pessoa fisica(f) ou Juridica(j): ");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f")
            {
                //execução para PF
                Pessoa_Fisica pf = new Pessoa_Fisica ();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.Write("Informe o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.Write("Informe o RG: ");
                pf.rg = Console.ReadLine();
                Console.Write("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("======= Pessoa Física =======");
                Console.WriteLine("Nome ----------: " + pf.nome);
                Console.WriteLine("Endereco ------: " + pf.endereco);
                Console.WriteLine("CPF -----------: " + pf.cpf);
                Console.WriteLine("RG ------------: " + pf.rg);
                Console.WriteLine("Valor de compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto -------: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total ---------: " + pf.total.ToString("C"));
                Console.WriteLine("=============================");

            }

            if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.Write("Informe o CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.Write("Informe a IE: ");
                pj.ie = Console.ReadLine();
                Console.Write("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("======= Pessoa Jurídica =======");
                Console.WriteLine("Nome ----------: " + pj.nome);
                Console.WriteLine("Endereco ------: " + pj.endereco);
                Console.WriteLine("CNPJ ----------: " + pj.cnpj);
                Console.WriteLine("IE ------------: " + pj.ie);
                Console.WriteLine("Valor de compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto -------: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total ---------: " + pj.total.ToString("C"));
                Console.WriteLine("===============================");
            }
        }
    }
}