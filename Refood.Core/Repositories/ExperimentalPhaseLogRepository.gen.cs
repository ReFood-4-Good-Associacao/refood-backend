
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
    public partial class ExperimentalPhaseLogRepository : IExperimentalPhaseLogRepository
    {
        public int AddExperimentalPhaseLog(R_ExperimentalPhaseLog t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteExperimentalPhaseLog(R_ExperimentalPhaseLog t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteExperimentalPhaseLog(int experimentalPhaseLogId)
        {
            var t = GetExperimentalPhaseLog(experimentalPhaseLogId);
            DeleteExperimentalPhaseLog(t);
        }

        public R_ExperimentalPhaseLog GetExperimentalPhaseLog(int experimentalPhaseLogId)
        {
            //Requires.NotNegative("experimentalPhaseLogId", experimentalPhaseLogId);
            
            R_ExperimentalPhaseLog t = R_ExperimentalPhaseLog.SingleOrDefault(experimentalPhaseLogId);

            return t;
        }

        public IEnumerable<R_ExperimentalPhaseLog> GetExperimentalPhaseLogs()
        {
             
            IEnumerable<R_ExperimentalPhaseLog> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ExperimentalPhaseLog")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_ExperimentalPhaseLog.Query(sql);

            return results;
        }

        public IList<R_ExperimentalPhaseLog> GetExperimentalPhaseLogs(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_ExperimentalPhaseLog> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ExperimentalPhaseLog")
                .Where("IsDeleted = 0")
                .Where(
                    "Task like '%" + searchTerm + "%'"
                     + " or " + "ActivityDescription like '%" + searchTerm + "%'"
                     + " or " + "ManagerName like '%" + searchTerm + "%'"
                     + " or " + "VolunteerName like '%" + searchTerm + "%'"
                )
            ;

            results = R_ExperimentalPhaseLog.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_ExperimentalPhaseLog> GetExperimentalPhaseLogListAdvancedSearch(
            int? nucleoId 
            , System.DateTime? logDateFrom 
            , System.DateTime? logDateTo 
            , string task 
            , string activityDescription 
            , string managerName 
            , string volunteerName 
            , bool? volunteerConfirmation 
            , int? documentId 
        )
        {
            IEnumerable<R_ExperimentalPhaseLog> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_ExperimentalPhaseLog")
                .Where("IsDeleted = 0" 
                    + (nucleoId != null ? " and NucleoId like '%" + nucleoId + "%'" : "")
                    + (logDateFrom != null ? " and LogDate >= '" + logDateFrom.Value.ToShortDateString() + "'" : "")
                    + (logDateTo != null ? " and LogDate <= '" + logDateTo.Value.ToShortDateString() + "'" : "")
                    + (task != null ? " and Task like '%" + task + "%'" : "")
                    + (activityDescription != null ? " and ActivityDescription like '%" + activityDescription + "%'" : "")
                    + (managerName != null ? " and ManagerName like '%" + managerName + "%'" : "")
                    + (volunteerName != null ? " and VolunteerName like '%" + volunteerName + "%'" : "")
                    + (volunteerConfirmation != null ? " and VolunteerConfirmation = " + (volunteerConfirmation == true ? "1" : "0") : "")
                    + (documentId != null ? " and DocumentId like '%" + documentId + "%'" : "")
                 )
            ;

            results = R_ExperimentalPhaseLog.Query(sql);

            return results;
        }

        public void UpdateExperimentalPhaseLog(R_ExperimentalPhaseLog t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "ExperimentalPhaseLogId");

            t.Update();
        }

    }
}

        