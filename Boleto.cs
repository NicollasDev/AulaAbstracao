using System;

namespace Aula08_Abstracao
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
        public string BancoEmissor { get; set; }
        public string codDeBarras { get; set; }
        public string Registrar(){    
            return "Boleto registrado com sucesso!";

        }
    }
}