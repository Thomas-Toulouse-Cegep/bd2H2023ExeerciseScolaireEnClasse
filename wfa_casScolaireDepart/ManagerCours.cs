using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace wfa_casScolaireDepart
{
    public class ManagerCours
    {
        public tbl_cours GetCoursInformation(string no_cours)
        {
            try
            {
                using (var context = new TT_BDscolaireEntities())
                {
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
                using (var context = new TT_BDscolaireEntities())
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