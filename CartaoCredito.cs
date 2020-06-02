namespace Aula08_Abstracao
{
    public class CartaoCredito : Cartao
    {
        internal object data;

        public float limite { get; set; }
        
        public void AumentarLimite( float acrescimo ){
         limite = limite + acrescimo;
        }
    }
}