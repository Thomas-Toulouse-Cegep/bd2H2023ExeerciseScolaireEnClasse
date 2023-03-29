using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_casScolaireDepart
{
    public class ManagerResultat
    {
        public List<listerCoursUnEtudiant_Result> listerCoursUnEtudiant_Results(string no_da)
        {
            try
            {
                using (var context = new TT_BDscolaireEntities1())
                {
                    return context.listerCoursUnEtudiant(no_da).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> ListerSession(string no_cours)
        {
            try
            {
                using (var context = new TT_BDscolaireEntities1())
                {
                    return context.ListerSessionDUNCours(no_cours).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}