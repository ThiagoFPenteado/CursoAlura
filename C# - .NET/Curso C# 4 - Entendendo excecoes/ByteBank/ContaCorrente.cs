﻿// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTrasferenciasNaoPermitidos { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }


        public int Agencia {get;}

        public int Numero {get;}

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento da agencia deve ser maiores que 0!", nameof(agencia));  
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento do numero deve ser maiores que 0!", nameof(numero));
            }


            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas++;
            
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo,valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para a tranferência.", nameof(valor));
            }
            try
            {
                contaDestino.Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTrasferenciasNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada.", e);
            }
            contaDestino.Depositar(valor);
        }
    }
}
