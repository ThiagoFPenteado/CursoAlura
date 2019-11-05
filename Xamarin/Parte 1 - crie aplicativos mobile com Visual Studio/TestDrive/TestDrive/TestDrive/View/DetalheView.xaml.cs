using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.View
{
    public partial class DetalheView : ContentPage
    {
        public Veiculo veiculo { get; set; }
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;

        public string TextoFreioAbs
        {
            get { return string.Format("Freio ABS - R$ {0}", FREIO_ABS); }
        }
        public string TextoArCondicionado
        {
            get { return string.Format("Ar Condicionado - R$ {0}", AR_CONDICIONADO); }
        }
        public string TextoMP3Player
        {
            get { return string.Format("MP3 Player - R$ {0}", MP3_PLAYER); }
        }
        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            //this.Title = veiculo.Nome;
            this.veiculo = veiculo;
            this.BindingContext = this;
        }
        bool temFreioAbs;
        public bool TemFreioAbs 
        {
            get 
            {
                return temFreioAbs;
            }
            set
            {
                temFreioAbs = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
                //if (temFreioAbs)
                //{
                //    DisplayAlert("Freio ABS", "Ligado!", "ok");
                //}
                //else
                //{
                //    DisplayAlert("Freio ABS", "Desligado!", "ok");
                //}
            } 
        }

        bool temArCondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool temMP3Player;
        public bool TemMP3Player
        {
            get
            {
                return temMP3Player;
            }
            set
            {
                temMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public string ValorTotal
        { 
            get 
            {
                return string.Format("Valor total: R$ {0}", 
                        veiculo.Preco 
                        + (TemFreioAbs ? FREIO_ABS : 0)
                        + (TemArCondicionado ? AR_CONDICIONADO : 0 )
                        + (TemMP3Player ? MP3_PLAYER : 0 )
                    );
            } 
        }
        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.veiculo));
        }
    }
}