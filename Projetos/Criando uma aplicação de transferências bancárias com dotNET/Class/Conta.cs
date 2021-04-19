using System;

namespace Criando_uma_aplicação_de_transferências_bancárias_com_dotNET
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        public bool Sacar(double valorSaque)
        {
            //Validação do saldo suficiente para o saque.
            if (this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WhiteLine("Pobre sem saldo");
                return false;                
            }
            this.Saldo = valorSaque;
        }
    }
}