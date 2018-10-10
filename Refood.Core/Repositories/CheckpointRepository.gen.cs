
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
    public partial class CheckpointRepository : ICheckpointRepository
    {
        public int AddCheckpoint(R_Checkpoint t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteCheckpoint(R_Checkpoint t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteCheckpoint(int checkpointId)
        {
            var t = GetCheckpoint(checkpointId);
            DeleteCheckpoint(t);
        }

        public R_Checkpoint GetCheckpoint(int checkpointId)
        {
            //Requires.NotNegative("checkpointId", checkpointId);
            
            R_Checkpoint t = R_Checkpoint.SingleOrDefault(checkpointId);

            return t;
        }

        public IEnumerable<R_Checkpoint> GetCheckpoints()
        {
             
            IEnumerable<R_Checkpoint> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Checkpoint")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Checkpoint.Query(sql);

            return results;
        }

        public IList<R_Checkpoint> GetCheckpoints(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Checkpoint> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Checkpoint")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                )
            ;

            results = R_Checkpoint.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Checkpoint> GetCheckpointListAdvancedSearch(
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
        )
        {
            IEnumerable<R_Checkpoint> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Checkpoint")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (latitude != null ? " and Latitude like '%" + latitude + "%'" : "")
                    + (longitude != null ? " and Longitude like '%" + longitude + "%'" : "")
                    + (addressId != null ? " and AddressId like '%" + addressId + "%'" : "")
                    + (estimatedTimeArrival != null ? " and EstimatedTimeArrival = " + estimatedTimeArrival : "")
                    + (minimumTimeFrom != null ? " and MinimumTime >= '" + minimumTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (minimumTimeTo != null ? " and MinimumTime <= '" + minimumTimeTo.Value.ToShortDateString() + "'" : "")
                    + (maximumTimeFrom != null ? " and MaximumTime >= '" + maximumTimeFrom.Value.ToShortDateString() + "'" : "")
                    + (maximumTimeTo != null ? " and MaximumTime <= '" + maximumTimeTo.Value.ToShortDateString() + "'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Checkpoint.Query(sql);

            return results;
        }

        public void UpdateCheckpoint(R_Checkpoint t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "CheckpointId");

            t.Update();
        }

    }
}

        