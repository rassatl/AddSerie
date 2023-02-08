using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace AddSerie.Models
{
    /// <summary>
    /// The Class of this project
    /// </summary>
    public class Series
    {
        /// <summary>
        /// The constructor of the class
        /// </summary>
        /// <param name="id">the id of the currency</param>
        /// <param name="nomDevise">the name the currency</param>
        /// <param name="taux">the taux of the currency</param>
        public Series(int serieid, string titre, string resume, int nbsaisons, int nbepisodes, int anneecreation, string network)
        {
            this.serieid = serieid;
            this.titre = titre;
            this.resume = resume;
            this.nbsaisons = nbsaisons;
            this.nbepisodes = nbepisodes;
            this.anneecreation = anneecreation;
            this.network = network;
        }

        /// <summary>
        /// The empty constructor of the class
        /// </summary>
        public Series()
        {
        }


        /// <summary>
        /// The id property
        /// </summary>
        private int serieid;

        public int Serieid
        {
            get { return serieid; }
            set { serieid = value; }
        }

        /// <summary>
        /// The title property
        /// </summary>
        private string titre;

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        /// <summary>
        /// The resume property
        /// </summary>
        private string resume;

        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }

        /// <summary>
        /// The nbsaisons property
        /// </summary>
        private int nbsaisons;

        public int Nbsaisons
        {
            get { return nbsaisons; }
            set { nbsaisons = value; }
        }

        /// <summary>
        /// The nbepisodes property
        /// </summary>
        private int nbepisodes;

        public int Nbepisodes
        {
            get { return nbsaisons; }
            set { nbsaisons = value; }
        }

        /// <summary>
        /// The anneecreation property
        /// </summary>
        private int anneecreation;

        public int Anneecreation
        {
            get { return anneecreation; }
            set { anneecreation = value; }
        }

        /// <summary>
        /// The network property
        /// </summary>
        private string network;

        public string Network
        {
            get { return network; }
            set { network = value; }
        }

        /// <summary>
        /// The equals function
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Series series &&
                   serieid == series.serieid &&
                   titre == series.titre &&
                   resume == series.resume &&
                   nbsaisons == series.nbsaisons &&
                   nbepisodes == series.nbepisodes &&
                   anneecreation == series.anneecreation &&
                   network == series.network;
        }

        /// <summary>
        /// The GetHashCode function
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(serieid, titre, resume, nbsaisons, nbepisodes, anneecreation, network);
        }
    }
}
