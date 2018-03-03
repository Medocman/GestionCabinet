using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Gestion_Medicale
{
    public class Medecin : Utilisateur
    {
        public Consultation Consultation
        {
            get => default(Consultation);
            set
            {
            }
        }

        public Traitement Traitement
        {
            get => default(Traitement);
            set
            {
            }
        }

        public int domaine
        {
            get => default(int);
            set
            {
            }
        }
    }
}