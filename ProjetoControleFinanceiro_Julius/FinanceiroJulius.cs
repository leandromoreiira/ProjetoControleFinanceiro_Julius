using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleFinanceiro_Julius {
    class FinanceiroJulius {

        public static double saldo;

        public static void adicionarDespesa(double valor,string descricao) {

            if(valor>saldo) {
                Console.WriteLine("Saldo insuficiente para essa despesa! ");
            }
            else {
                saldo=saldo-valor;
                Console.WriteLine("Despesa adicionada: "+descricao);
                MostrarSaldo();
            }
        }

        public static void adicionarEconomia(double valor,string descricao) {
            saldo=saldo+valor;
            Console.WriteLine("Economia adicionada"+descricao);
            MostrarSaldo();
        }

        public static void MostrarSaldo() {
            Console.WriteLine("Seu saldo é: "+saldo.ToString("F2",CultureInfo.InvariantCulture));
        }


        public static void DefinirSaldoInicial(double valor) {
            saldo=valor;
            MostrarSaldo();
        }

    }
}
