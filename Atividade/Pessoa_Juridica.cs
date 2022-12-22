namespace csharp_senai
{
    public class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}


        public override void Pagar_Imposto(float val) {
            this.valor = val;
            this.valor_imposto = (float)(this.valor * 0.2);
            this.total = this.valor + this.valor_imposto;
        }   
    }
}