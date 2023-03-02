using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_casScolaireDepart
{
    public class ManagerCours
    {
        public List<tbl_cours> listerCours()
        {
            try
            {
                using (var context = new TT_BDscolaireEntities())
                {
                    context.Database.Log = Console.Write;
                    return context.tbl_cours.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}