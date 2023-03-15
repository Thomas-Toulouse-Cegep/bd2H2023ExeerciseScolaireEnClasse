using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_casScolaireDepart
{
    public class ManagerCours
    {
        public int ModifierCours(tbl_cours coursModifier, tbl_cours coursNonModifier)
        {
            int nbDeLigneAffectee = 0;
            try
            {
                using (var context = new TT_BDscolaireEntities1())
                {
                    context.Database.Log = Console.Write;
                    tbl_cours cours = context.tbl_cours.Attach(coursNonModifier);//remplace find
                    string etat = context.Entry(cours).State.ToString();

                    //change l'état
                    // cours.no_cours = coursModifier.no_cours;
                    cours.nom_cours = coursModifier.nom_cours;
                    cours.pond = coursModifier.pond;
                    etat = context.Entry(cours).State.ToString();
                    if (context.ChangeTracker.HasChanges())
                    {
                        nbDeLigneAffectee = context.SaveChanges();
                        MessageBox.Show("Complété avec succès");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return nbDeLigneAffectee;
        }

        public int ModifierCours(tbl_cours coursModifier)
        {
            int nbDeLigneAffectee = 0;
            try
            {
                using (var context = new TT_BDscolaireEntities1())
                {
                    context.Database.Log = Console.Write;
                    tbl_cours cours = context.tbl_cours.Find(coursModifier.no_cours);
                    string etat = context.Entry(cours).State.ToString();

                    //change l'état
                    cours.no_cours = coursModifier.no_cours;
                    cours.nom_cours = coursModifier.nom_cours;
                    cours.pond = coursModifier.pond;
                    etat = context.Entry(cours).State.ToString();

                    if (context.ChangeTracker.HasChanges())
                    {
                        nbDeLigneAffectee = context.SaveChanges();
                        MessageBox.Show("Complété avec succès");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return nbDeLigneAffectee;
        }

        public tbl_cours GetCoursInformation(string no_cours)
        {
            try
            {
                using (var context = new TT_BDscolaireEntities1())
                {
                    context.Database.Log = Console.Write;
                    return context.tbl_cours.Find(no_cours);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<tbl_cours> listerCours()
        {
            try
            {
                using (var context = new TT_BDscolaireEntities1())
                {
                    context.Database.Log = Console.Write;

                    return context.tbl_cours.OrderBy(c => c.nom_cours).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}