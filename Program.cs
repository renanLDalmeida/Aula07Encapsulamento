using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            card.numero = "11515";
            card.AprovarCompra();

            Mastercard master = new Mastercard();
            master.parcelas = 10;
            master.ComprarComDescontoMastercard(20f);

        }
    }
}
