namespace Aula08_Abstracao
{
    public class Cartao 
    {
        protected string token = "asddadwefwfw$@@$$@$rwfggwgewwffewfw";
        public string titular { get; set; }
        public int numero { get; set; }
        public string cvv { get; set; }
        public string bandeira { get; set; }
        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

    }
}