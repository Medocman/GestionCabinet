using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Gestion_Medicale
{
    public class Secretaire : Utilisateur
    {
        public Facture Facture
        {
            get => default(Facture);
            set
            {
            }
        }
    }
}