
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
    public partial class DeliveryReportMessageRepository : IDeliveryReportMessageRepository
    {
        public int AddDeliveryReportMessage(R_DeliveryReportMessage t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteDeliveryReportMessage(R_DeliveryReportMessage t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteDeliveryReportMessage(int deliveryReportMessageId)
        {
            var t = GetDeliveryReportMessage(deliveryReportMessageId);
            DeleteDeliveryReportMessage(t);
        }

        public R_DeliveryReportMessage GetDeliveryReportMessage(int deliveryReportMessageId)
        {
            //Requires.NotNegative("deliveryReportMessageId", deliveryReportMessageId);
            
            R_DeliveryReportMessage t = R_DeliveryReportMessage.SingleOrDefault(deliveryReportMessageId);

            return t;
        }

        public IEnumerable<R_DeliveryReportMessage> GetDeliveryReportMessages()
        {
             
            IEnumerable<R_DeliveryReportMessage> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReportMessage")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_DeliveryReportMessage.Query(sql);

            return results;
        }

        public IList<R_DeliveryReportMessage> GetDeliveryReportMessages(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_DeliveryReportMessage> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReportMessage")
                .Where("IsDeleted = 0")
                .Where(
                    "Message like '%" + searchTerm + "%'"
                )
            ;

            results = R_DeliveryReportMessage.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_DeliveryReportMessage> GetDeliveryReportMessageListAdvancedSearch(
            int? deliveryReportMessageTypeId 
            , string message 
        )
        {
            IEnumerable<R_DeliveryReportMessage> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReportMessage")
                .Where("IsDeleted = 0" 
                    + (deliveryReportMessageTypeId != null ? " and DeliveryReportMessageTypeId = " + deliveryReportMessageTypeId : "")
                    + (message != null ? " and Message like '%" + message + "%'" : "")
                 )
            ;

            results = R_DeliveryReportMessage.Query(sql);

            return results;
        }

        public void UpdateDeliveryReportMessage(R_DeliveryReportMessage t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "DeliveryReportMessageId");

            t.Update();
        }

    }
}

        