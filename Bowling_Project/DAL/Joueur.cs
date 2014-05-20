using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Joueur
    {
        #region ATTRIBUTS
        private int _id;
        private string _surnom;
        private int _score;
        private DateTime _date;
        #endregion

        #region PROPRIETES
        //[DataMember]    //permet à data contract de voir ce qu'il doit transoformer
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //la même chose -> private int id { get; set; }
       // [DataMember]
        public string Surnom
        {
            get { return _surnom; }
            set { _surnom = value; }
        }
       // [DataMember]
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
      //  [DataMember]
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        #region CONSTRUCTEUR
        public Joueur() { }
        public Joueur(int id, string surnom, int score, DateTime date)
        {
            Id = id;
            Surnom = surnom;
            Score = score;
            Date = date;
        }
        #endregion

        #region METHODES PUBLIQUES
        public List<Joueur> GetMesJoueurs()
        {
            List<Joueur> maListe = new List<Joueur>();

            for (int i = 1; i <= 10; i++)
            {
                Joueur monJoueur = new Joueur();
                monJoueur.Id = i;
                monJoueur.Surnom = "SURNOM " + i.ToString();
                monJoueur.Score = 0;
                monJoueur.Date = DateTime.Now;
                maListe.Add(monJoueur);
            }
            return maListe;
        }
        #endregion

    }
}
