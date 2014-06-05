using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Partie
    {
        #region ATTRIBUTS
        private int _id;
        private int _nbJoueur;
        private DateTime _datePartie;
        private string _etatPartie;

        #endregion

        #region PROPRIETES
        //[DataMember]    //permet à data contract de voir ce qu'il doit transoformer
        public int NbJoueur
        {
          get { return _nbJoueur; }
          set { _nbJoueur = value; }
        }

        public DateTime DatePartie
        {
          get { return _datePartie; }
          set { _datePartie = value; }
        }
       

        public string EtatPartie
        {
          get { return _etatPartie; }
          set { _etatPartie = value; }
        }
     
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        #endregion

        #region CONSTRUCTEUR
        public Partie() { }
        public Partie(int id, int nbJoueur, DateTime datePartie, string etatPartie)
        {
            Id = id;
            NbJoueur = nbJoueur;
            DatePartie = datePartie;
            EtatPartie = etatPartie;
            
        }
        #endregion

        #region METHODES PUBLIQUES
        public List<Partie> GetPartie()
        {
            List<Partie> maListe = new List<Partie>();

            for (int i = 1; i <= 10; i++)
            {
                Partie partie = new Partie();
                partie.Id = i;
                partie.NbJoueur =  10;
                partie.DatePartie = DateTime.Now;
                partie.EtatPartie = "En cours";
                maListe.Add(partie);
            }
            return maListe;
        }
        #endregion

    }
}
