using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    /*
     * Üç kontrolün (Label,Button,Button) interaktif bir biçimde birlikte çalıştığı bir senaryo kurgusu:
     * 1. Rezerve Et butonuna basıldığında, buton pasif duruma geçer ve Label'da durum bilgisi yazılır.
     * 2. Ara butonuna basıldığı zaman Label'daki işlem bilgisi değişir. Rezerve butonu yeniden aktif olur, ara butonu ise pasif
     */
    public interface ICommand
    {
        void Execute();
    }
    public class LabelGoster : Label, ICommand
    {
        IMediator _mediator;
        public LabelGoster(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterGoster(this);
        }
        public void Execute()
        {
            _mediator.Goster();
        }
    }
    public class ButtonRezerveEt : Button, ICommand
    {
        private IMediator _mediator;
        public ButtonRezerveEt(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterRezervasyon(this);
        }
        public void Execute()
        {
            _mediator.RezerveEt();
        }
    }

    public class ButtonAra : Button, ICommand
    {
        private IMediator _mediator;
        public ButtonAra(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterAra(this);
        }
        public void Execute()
        {
            _mediator.Ara();

        }
    }

    public interface IMediator
    {
        void RezerveEt();
        void Ara();
        void Goster();

        void RegisterRezervasyon(ButtonRezerveEt btn);
        void RegisterAra(ButtonAra btn);
        void RegisterGoster(LabelGoster lbl);
    }
    public class Mediator : IMediator
    {

        private LabelGoster label;
        private ButtonAra ara;
        private ButtonRezerveEt rezervasyon;
        public void RezerveEt()
        {
            rezervasyon.Enabled = false;
            ara.Enabled = true;
            label.Text = "otel rezervasyonu yapılıyor";
        }

        public void Ara()
        {
            rezervasyon.Enabled = true; 
            ara.Enabled = false;
            label.Text = "Uygun oteller aranıyor";
        }

        public void Goster()
        {
            label.Text = "Listeleniyor....";
        }

        public void RegisterRezervasyon(ButtonRezerveEt btn)
        {
            rezervasyon = btn;
        }

        public void RegisterAra(ButtonAra btn)
        {
            ara = btn;
        }

        public void RegisterGoster(LabelGoster lbl)
        {
            label = lbl;
        }
    }
}
