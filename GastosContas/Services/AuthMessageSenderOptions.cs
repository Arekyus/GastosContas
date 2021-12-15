using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace GastosContas.Services
{
    public class AuthMessageSenderOptions
    {
        public string SendGridKey { get; set; }
    }
}
