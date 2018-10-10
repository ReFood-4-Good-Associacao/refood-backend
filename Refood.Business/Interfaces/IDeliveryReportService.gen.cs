
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface IDeliveryReportService
    {
        int AddDeliveryReport(DeliveryReportDTO dto);

        void DeleteDeliveryReport(int deliveryReportId);

        void DeleteDeliveryReport(DeliveryReportDTO dto);

        DeliveryReportDTO GetDeliveryReport(int deliveryReportId);

        IEnumerable<DeliveryReportDTO> GetDeliveryReports();

        IList<DeliveryReportDTO> GetDeliveryReports(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<DeliveryReportDTO> GetDeliveryReportListAdvancedSearch(
            string name 
            ,string description 
            ,System.DateTime? reportDateFrom 
            ,System.DateTime? reportDateTo 
            ,string weekDay 
            ,bool? submitted 
        );

        void UpdateDeliveryReport(DeliveryReportDTO dto);

    }
}
    