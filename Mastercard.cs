using System;

namespace Encapsulamento
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }
        public void ComprarComDescontoMastercard(float desconto){

            cvv = "123";

             Console.WriteLine($"Compra realizada com {parcelas} parcelas e R${desconto} de desconto");

        }
    }
}