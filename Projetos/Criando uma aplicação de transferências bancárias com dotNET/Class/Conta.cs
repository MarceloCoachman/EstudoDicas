using System;

namespace Criando_uma_aplicação_de_transferências_bancárias_com_dotNET
{
    public class Conta
    {
        //ATRIBUTOS
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        //METODOS
        public Conta(TipoConta tipoConta, 
                        double saldo, 
                        double credito, 
                        string nome)
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
                Console.WriteLine("Pobre e sem saldo");
                return false;                
            }
            this.Saldo -= valorSaque; // = this.Saldo = this.Saldo - valorSaque;
            Console.WriteLine("Ficou mais pobre {0} só tem {1}", this.Nome, this.Saldo);
            return true;
        }
        public void Depositar(double valorDeposito)
		{
			this.Saldo += valorDeposito;// = this.Saldo = this.Saldo + valorDeposito;
            Console.WriteLine("Ficando Rico heim  {0} agora vc tem {1}", this.Nome, this.Saldo);
        }
        public void Transferir(double valorTransferencia, Conta contaDestino) // transferencia sem aviso
		{
			if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
		}

        public override string ToString() // reescrevendo o metodo ToString concatenado as variaveis do programa.
		{
            string retorno = "";
            retorno += "TipoConta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Crédito: " + this.Credito;
			return retorno;
		}

    }
}