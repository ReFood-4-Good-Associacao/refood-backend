
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface IDeliveryReportRepository
    {
        int AddDeliveryReport(R_DeliveryReport t);

        void DeleteDeliveryReport(R_DeliveryReport t);

        void DeleteDeliveryReport(int deliveryReportId);

        R_DeliveryReport GetDeliveryReport(int deliveryReportId);

        IEnumerable<R_DeliveryReport> GetDeliveryReports();

        IList<R_DeliveryReport> GetDeliveryReports(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_DeliveryReport> GetDeliveryReportListAdvancedSearch(
            string name 
            , string description 
            , System.DateTime? reportDateFrom 
            , System.DateTime? reportDateTo 
            , string weekDay 
            , bool? submitted 
        );

        void UpdateDeliveryReport(R_DeliveryReport t);

    }
}

    