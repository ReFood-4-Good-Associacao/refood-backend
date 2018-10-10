
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ICheckpointRepository
    {
        int AddCheckpoint(R_Checkpoint t);

        void DeleteCheckpoint(R_Checkpoint t);

        void DeleteCheckpoint(int checkpointId);

        R_Checkpoint GetCheckpoint(int checkpointId);

        IEnumerable<R_Checkpoint> GetCheckpoints();

        IList<R_Checkpoint> GetCheckpoints(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Checkpoint> GetCheckpointListAdvancedSearch(
            string name 
            , double? latitude 
            , double? longitude 
            , int? addressId 
            , int? estimatedTimeArrival 
            , System.DateTime? minimumTimeFrom 
            , System.DateTime? minimumTimeTo 
            , System.DateTime? maximumTimeFrom 
            , System.DateTime? maximumTimeTo 
            , bool? active 
        );

        void UpdateCheckpoint(R_Checkpoint t);

    }
}

    