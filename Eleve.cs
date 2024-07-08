using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    class Eleve
    {
        public string prenom { get; private set; }
        public string nom { get; private set; }
        public List<Note> note = new List<Note>();
        public Eleve(string p, string n)
        { 
            prenom = p;
            nom = n; 
        }
        public void ajouterNote(Note n)
        {
            note.Add(n);
        }
        public double moyenneMatiere(int m)
        {
            double moyenne = 0;
            int compteur  = 0;
            foreach (Note n in note)
            {
                if (n.matiere == m)
                { 
                    moyenne += n.note;
                    compteur++;
                }
            }
            return Math.Round(moyenne / compteur, 2);
        }
        public double moyenneGeneral()
        {
            double moyenneg = 0;
            int compteur = 0;
            for (int i = 1; i < note[note.Count - 1].matiere; i++)
            {
                moyenneg += moyenneMatiere(i);
                compteur++;
            }
            return Math.Round(moyenneg / compteur, 2);
        }
    }
}
