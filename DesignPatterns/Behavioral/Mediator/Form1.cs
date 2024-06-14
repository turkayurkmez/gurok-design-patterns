using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMediator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            /*
             *   Mediator: Arabulucu
             *   
             *      1. Sunum dosyası -> Az sayıda imaj ve içerik varsa; PPTX
             *      2. Word Belgesi -> Yoğun içerik ise docx
             *      3. Excel Belgesi -> Veri setleri ve tablolar varsa xslx
             *    
             *      
             * 
             * 
             * 
             */


            //karmaşık akışlara sahip kontrollerin birbirleriyle olan etkileşimlerini tek bir nesne üzerinden yönetebilmek için bu desen kullanılabilir.
            /*
             * Örnek:
             * Otel arama ve rezervasyon işlemini yapan iki buton var.
             * Biri aktifken diğeri pasif olmalı.
             * Süreçleri Label Kontrolü yönetebilmeli.
             *               * 
             */
        }
        Mediator mediator = new Mediator();
        public void InitializeMediator()
        {
            LabelGoster label = new LabelGoster(mediator);
            ButtonAra ara = new ButtonAra(mediator);
            ButtonRezerveEt rezerve = new ButtonRezerveEt(mediator);

            mediator.Goster();
            label.Top = 20;
            label.AutoSize = true;
            ara.Text = "Otel ara";
            ara.AutoSize = true;
            ara.Top = label.Top + ara.Height + 5;
            rezerve.Top = ara.Top;
            rezerve.Left = ara.Left + ara.Width + 10;
            rezerve.Text = "Rezervasyon yap";

            this.Controls.Add(label);
            this.Controls.Add(ara);
            this.Controls.Add(rezerve);

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Click += item_Click;
                }
            }


        }

        void item_Click(object sender, EventArgs e)
        {
            ICommand command = (ICommand)sender;
            command.Execute();
            //MVP: Model View Presenter
            //MVVM: Model-View-ViewModel 
            //MVC : Model View Controller

            //Angular.js
        }

    }
}
