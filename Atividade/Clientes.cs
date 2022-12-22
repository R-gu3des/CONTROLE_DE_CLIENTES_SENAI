namespace csharp_senai
{
    public class Clientes {
        
        public string nome {get; set;}
        public string endereco {get; set;}
        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}


        public virtual void Pagar_Imposto(float val) {
            this.valor = val;
            this.valor_imposto = (float)(this.valor * 0.1);
            this.total = this.valor + this.valor_imposto;
        }
    }
}