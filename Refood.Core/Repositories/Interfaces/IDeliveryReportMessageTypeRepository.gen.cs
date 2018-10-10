
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IDeliveryReportMessageTypeRepository
    {
        int AddDeliveryReportMessageType(R_DeliveryReportMessageType t);

        void DeleteDeliveryReportMessageType(R_DeliveryReportMessageType t);

        void DeleteDeliveryReportMessageType(int deliveryReportMessageTypeId);

        R_DeliveryReportMessageType GetDeliveryReportMessageType(int deliveryReportMessageTypeId);

        IEnumerable<R_DeliveryReportMessageType> GetDeliveryReportMessageTypes();

        IList<R_DeliveryReportMessageType> GetDeliveryReportMessageTypes(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_DeliveryReportMessageType> GetDeliveryReportMessageTypeListAdvancedSearch(
            string name 
            , string description 
            , bool? active 
        );

        void UpdateDeliveryReportMessageType(R_DeliveryReportMessageType t);

    }
}

    