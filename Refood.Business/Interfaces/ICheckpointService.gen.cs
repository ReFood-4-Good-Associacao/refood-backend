
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ICheckpointService
    {
        int AddCheckpoint(CheckpointDTO dto);

        void DeleteCheckpoint(int checkpointId);

        void DeleteCheckpoint(CheckpointDTO dto);

        CheckpointDTO GetCheckpoint(int checkpointId);

        IEnumerable<CheckpointDTO> GetCheckpoints();

        IList<CheckpointDTO> GetCheckpoints(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<CheckpointDTO> GetCheckpointListAdvancedSearch(
            string name 
            ,double? latitude 
            ,double? longitude 
            ,int? addressId 
            ,int? estimatedTimeArrival 
            ,System.DateTime? minimumTimeFrom 
            ,System.DateTime? minimumTimeTo 
            ,System.DateTime? maximumTimeFrom 
            ,System.DateTime? maximumTimeTo 
            ,bool? active 
        );

        void UpdateCheckpoint(CheckpointDTO dto);

    }
}
    