namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void Pagar_Imposto(float value){
            this.valor = value;
            this.valor_imposto = this.valor * 0.2f;
            this.total = this.valor + this.valor_imposto;
        }
    }
}