using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public interface IMail
	{
		void Send();
	}
    public class Mail : IMail
    {
        public void Send()
        {
            Console.WriteLine("Mail gitti");
        }
    }

    public abstract class MailDecorator : IMail
    {
        private readonly IMail _mail;

        protected MailDecorator(IMail mail)
        {
            _mail = mail;
        }

        public virtual void Send()
        {
            _mail.Send();
        }
    }

    //1. Mail'e imza ekleyen decorator:
    public class SignedDecorator : MailDecorator
    {
        private string signedBy;
        public SignedDecorator(IMail mail, string signedBy) : base(mail)
        {
            this.signedBy = signedBy;
        }
        public void SignMail()
        {
            Console.WriteLine($"{signedBy} tarafından imzalandı");
        }
        public override void Send()
        {
            SignMail();
            base.Send();
        }

    }

    //2. Mail'i şifreleyen
    public class CryptedDecorator : MailDecorator
    {
        public CryptedDecorator(IMail mail) : base(mail)
        {
        }

        public void Crypt()
        {
            Console.WriteLine("Mail şifrelendi");
        }

        public override void Send()
        {
            Crypt();
            base.Send();
        }
    }
}
