﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.View
{
    public partial class AgendamentoView : ContentPage
    {
        public Veiculo veiculo { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento 
        { 
            get 
            {
                return dataAgendamento;
            }
            set 
            {
                dataAgendamento = value;
            } 
        }
        public TimeSpan HoraAgendamento { get; set; }
        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.veiculo = veiculo;
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", 
string.Format(
@"Nome: {0}
Fone: {1}
Email: {2}
Data Agendamento: {3}
Hora Agendamento: {4}",
Nome, Fone, Email, DataAgendamento.ToString("dd/MM/yyy"), HoraAgendamento
), 
                "OK");
        }
    }
}