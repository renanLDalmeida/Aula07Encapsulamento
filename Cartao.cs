namespace Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        private string token { get; set; }
        protected string cvv { get; set; }

        public string AprovarCompra(){
            return "Compra aprovada";
        }

        private bool ValidarToken(){
            if (token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }

    }
}