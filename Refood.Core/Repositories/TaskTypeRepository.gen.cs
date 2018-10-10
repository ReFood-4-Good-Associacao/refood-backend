
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
    public partial class TaskTypeRepository : ITaskTypeRepository
    {
        public int AddTaskType(R_TaskType t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteTaskType(R_TaskType t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteTaskType(int taskTypeId)
        {
            var t = GetTaskType(taskTypeId);
            DeleteTaskType(t);
        }

        public R_TaskType GetTaskType(int taskTypeId)
        {
            //Requires.NotNegative("taskTypeId", taskTypeId);
            
            R_TaskType t = R_TaskType.SingleOrDefault(taskTypeId);

            return t;
        }

        public IEnumerable<R_TaskType> GetTaskTypes()
        {
             
            IEnumerable<R_TaskType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_TaskType")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_TaskType.Query(sql);

            return results;
        }

        public IList<R_TaskType> GetTaskTypes(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_TaskType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_TaskType")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_TaskType.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_TaskType> GetTaskTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_TaskType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_TaskType")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_TaskType.Query(sql);

            return results;
        }

        public void UpdateTaskType(R_TaskType t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "TaskTypeId");

            t.Update();
        }

    }
}

        