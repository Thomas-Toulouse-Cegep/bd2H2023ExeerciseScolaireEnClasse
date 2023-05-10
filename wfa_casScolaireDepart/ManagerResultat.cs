using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core;

namespace wfa_casScolaireDepart
{
    public class ManagerResultat
    {
        public List<vueNoteEtudiant> ListerResultat(string noCours, string session, ref TT_BDscolaireEntities1 context)
        {
            try
            {
                context = new TT_BDscolaireEntities1();
                return context.vueNoteEtudiants.Where(r => r.Numéro_de_cours == noCours && r.session == session).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

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

        public int enregistrerLaNote(ref TT_BDscolaireEntities1 context)
        {
            int r = 0;
            try
            {
                if (context.ChangeTracker.HasChanges())
                {
                    r = context.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException.InnerException is UpdateException)
                {

                }
            }
            catch (Exception)
            {
                throw;
            }

            return r;
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