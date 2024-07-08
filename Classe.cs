using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    class Classe
    {
        public string nomClasse { get; private set; }

        public List<Eleve> eleves = new List<Eleve>();
        public List<string> matieres = new List<string>();
        public Classe(string c)
        {
            nomClasse = c;
        }

        public void ajouterEleve(string p, string n)
        {
            eleves.Add(new Eleve(p, n));
        }
        public void ajouterMatiere(string m)
        {
            matieres.Add(m);
        }
        public double moyenneMatiere(int m)
        {
            double moyennec = 0;
            foreach (Eleve e in eleves)
            {
                moyennec += e.moyenneMatiere(m);
            }
            return Math.Round(moyennec / eleves.Count, 2);
        }
        public double moyenneGeneral()
        {
            double moyennecg = 0;
            for (int i = 1; i < matieres.Count; i++)
            {
                moyennecg += moyenneMatiere(i);
            }
            return Math.Round(moyennecg / matieres.Count, 2);
        }
    }
}
