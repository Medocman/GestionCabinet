using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Gestion_Medicale
{
    public class Traitement
    {
        public Visite Visite
        {
            get => default(Visite);
            set
            {
            }
        }

        public int nom_traitement
        {
            get => default(int);
            set
            {
            }
        }
    }
}