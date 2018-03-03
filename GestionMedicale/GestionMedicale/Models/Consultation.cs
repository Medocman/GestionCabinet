using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Gestion_Medicale
{
    public class Consultation
    {
        public Visite Visite
        {
            get => default(Visite);
            set
            {
            }
        }

        public RendezVous RendezVous
        {
            get => default(RendezVous);
            set
            {
            }
        }

        public int num_consultation
        {
            get => default(int);
            set
            {
            }
        }

        public DateTime date_debut_consultation
        {
            get => default(int);
            set
            {
            }
        }

        public int etat_consultation
        {
            get => default(int);
            set
            {
            }
        }

        public int diagnostic
        {
            get => default(int);
            set
            {
            }
        }
    }
}