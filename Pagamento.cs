using System;

namespace Aula08_Abstracao
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }

        public string Pagar(float valorpago){
            return "Valor pago: R$"+valorpago;
        }
        public string Cancelar(){
            return "Pagamento cancelado";
        }
    }
}