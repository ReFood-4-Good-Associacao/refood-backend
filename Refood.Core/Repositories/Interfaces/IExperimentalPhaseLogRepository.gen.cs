
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IExperimentalPhaseLogRepository
    {
        int AddExperimentalPhaseLog(R_ExperimentalPhaseLog t);

        void DeleteExperimentalPhaseLog(R_ExperimentalPhaseLog t);

        void DeleteExperimentalPhaseLog(int experimentalPhaseLogId);

        R_ExperimentalPhaseLog GetExperimentalPhaseLog(int experimentalPhaseLogId);

        IEnumerable<R_ExperimentalPhaseLog> GetExperimentalPhaseLogs();

        IList<R_ExperimentalPhaseLog> GetExperimentalPhaseLogs(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_ExperimentalPhaseLog> GetExperimentalPhaseLogListAdvancedSearch(
            int? nucleoId 
            , System.DateTime? logDateFrom 
            , System.DateTime? logDateTo 
            , string task 
            , string activityDescription 
            , string managerName 
            , string volunteerName 
            , bool? volunteerConfirmation 
            , int? documentId 
        );

        void UpdateExperimentalPhaseLog(R_ExperimentalPhaseLog t);

    }
}

    