using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Gestion_Medicale
{
    public class Patient : Personne
    {
        public Consultation Consultation
        {
            get => default(Consultation);
            set
            {
            }
        }
    }
}