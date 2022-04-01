using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.SQLite;

namespace tp_gene
{
    class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private Personne pere;
        private Personne mere;
        private List<Personne> enfants;

        public Personne(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.pere = null;
            this.mere = null;
            this.enfants = new List<Personne>();
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        internal Personne Pere { get => pere; set => pere = value; }
        internal Personne Mere { get => mere; set => mere = value; }
        internal List<Personne> Enfants { get => enfants; set => enfants = value; }

    }
}
