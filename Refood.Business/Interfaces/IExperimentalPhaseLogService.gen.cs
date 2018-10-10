
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IExperimentalPhaseLogService
    {
        int AddExperimentalPhaseLog(ExperimentalPhaseLogDTO dto);

        void DeleteExperimentalPhaseLog(int experimentalPhaseLogId);

        void DeleteExperimentalPhaseLog(ExperimentalPhaseLogDTO dto);

        ExperimentalPhaseLogDTO GetExperimentalPhaseLog(int experimentalPhaseLogId);

        IEnumerable<ExperimentalPhaseLogDTO> GetExperimentalPhaseLogs();

        IList<ExperimentalPhaseLogDTO> GetExperimentalPhaseLogs(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<ExperimentalPhaseLogDTO> GetExperimentalPhaseLogListAdvancedSearch(
            int? nucleoId 
            ,System.DateTime? logDateFrom 
            ,System.DateTime? logDateTo 
            ,string task 
            ,string activityDescription 
            ,string managerName 
            ,string volunteerName 
            ,bool? volunteerConfirmation 
            ,int? documentId 
        );

        void UpdateExperimentalPhaseLog(ExperimentalPhaseLogDTO dto);

    }
}
    