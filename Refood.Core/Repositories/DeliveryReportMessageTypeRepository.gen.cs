
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
    public partial class DeliveryReportMessageTypeRepository : IDeliveryReportMessageTypeRepository
    {
        public int AddDeliveryReportMessageType(R_DeliveryReportMessageType t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteDeliveryReportMessageType(R_DeliveryReportMessageType t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteDeliveryReportMessageType(int deliveryReportMessageTypeId)
        {
            var t = GetDeliveryReportMessageType(deliveryReportMessageTypeId);
            DeleteDeliveryReportMessageType(t);
        }

        public R_DeliveryReportMessageType GetDeliveryReportMessageType(int deliveryReportMessageTypeId)
        {
            //Requires.NotNegative("deliveryReportMessageTypeId", deliveryReportMessageTypeId);
            
            R_DeliveryReportMessageType t = R_DeliveryReportMessageType.SingleOrDefault(deliveryReportMessageTypeId);

            return t;
        }

        public IEnumerable<R_DeliveryReportMessageType> GetDeliveryReportMessageTypes()
        {
             
            IEnumerable<R_DeliveryReportMessageType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReportMessageType")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_DeliveryReportMessageType.Query(sql);

            return results;
        }

        public IList<R_DeliveryReportMessageType> GetDeliveryReportMessageTypes(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_DeliveryReportMessageType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReportMessageType")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_DeliveryReportMessageType.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_DeliveryReportMessageType> GetDeliveryReportMessageTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_DeliveryReportMessageType> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReportMessageType")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_DeliveryReportMessageType.Query(sql);

            return results;
        }

        public void UpdateDeliveryReportMessageType(R_DeliveryReportMessageType t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "DeliveryReportMessageTypeId");

            t.Update();
        }

    }
}

        