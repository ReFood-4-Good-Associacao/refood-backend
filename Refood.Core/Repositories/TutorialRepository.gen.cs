
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;
using Refood.Core.Repositories.Interfaces;

namespace Refood.Core.Repositories
{
    public partial class TutorialRepository : ITutorialRepository
    {
        public int AddTutorial(R_Tutorial t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteTutorial(R_Tutorial t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteTutorial(int tutorialId)
        {
            var t = GetTutorial(tutorialId);
            DeleteTutorial(t);
        }

        public R_Tutorial GetTutorial(int tutorialId)
        {
            //Requires.NotNegative("tutorialId", tutorialId);
            
            R_Tutorial t = R_Tutorial.SingleOrDefault(tutorialId);

            return t;
        }

        public IEnumerable<R_Tutorial> GetTutorials()
        {
             
            IEnumerable<R_Tutorial> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Tutorial")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Tutorial.Query(sql);

            return results;
        }

        public IList<R_Tutorial> GetTutorials(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Tutorial> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Tutorial")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                     + " or " + "Location like '%" + searchTerm + "%'"
                     + " or " + "Language like '%" + searchTerm + "%'"
                )
            ;

            results = R_Tutorial.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Tutorial> GetTutorialListAdvancedSearch(
            string name 
            , string description 
            , string location 
            , bool? isOnlineTutorial 
            , string language 
            , bool? active 
        )
        {
            IEnumerable<R_Tutorial> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Tutorial")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (location != null ? " and Location like '%" + location + "%'" : "")
                    + (isOnlineTutorial != null ? " and IsOnlineTutorial = " + (isOnlineTutorial == true ? "1" : "0") : "")
                    + (language != null ? " and Language like '%" + language + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Tutorial.Query(sql);

            return results;
        }

        public void UpdateTutorial(R_Tutorial t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "TutorialId");

            t.Update();
        }

    }
}

        