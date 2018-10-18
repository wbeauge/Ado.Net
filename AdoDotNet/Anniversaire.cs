using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdoDotNet
{
    class Anniversaire
    {
        private DateTime dateAnniversaire;
        private int id;
        private string nom;
        private string nomPseudonyme;
        private string prenom;
        private string prenomPseudonyme;

        public Anniversaire(int id, DateTime dateAnniversaire, string prenomPseudonyme, string nomPseudonyme, string prenom, string nom)
        {
            this.id=id;
            this.dateAnniversaire=dateAnniversaire;
            this.prenomPseudonyme=prenomPseudonyme;
            this.nomPseudonyme=nomPseudonyme;
            this.prenom=prenom;
            this.nom = nom;
        }
        public Anniversaire(DateTime dateAnniversaire, string prenomPseudonyme, string nomPseudonyme, string prenom, string nom) 
        {
            this.dateAnniversaire = dateAnniversaire;
            this.prenomPseudonyme = prenomPseudonyme;
            this.nomPseudonyme = nomPseudonyme;
            this.prenom = prenom;
            this.nom = nom;
        }
        public string ToString() { return string.Format("id : {0}\n nom : {1}\n prenomPseudonyme : {2}\n dateAnniversaire :{3}", id, nom, prenomPseudonyme, dateAnniversaire.ToLongDateString()); }
        
        public DateTime DateAnniversaire{
            get { return this.dateAnniversaire; }
        }

        public int Id {
            get { return this.id; }
        }

        public string Nom{
        get{return this.nom;}
        }

        public string Prenom {
            get { return this.prenom; }
        }

        public string PrenomPseudonyme {
            get { return this.prenomPseudonyme; }
        }

        
    }
}
