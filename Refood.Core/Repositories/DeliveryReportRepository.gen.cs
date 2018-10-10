
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
    public partial class DeliveryReportRepository : IDeliveryReportRepository
    {
        public int AddDeliveryReport(R_DeliveryReport t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteDeliveryReport(R_DeliveryReport t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteDeliveryReport(int deliveryReportId)
        {
            var t = GetDeliveryReport(deliveryReportId);
            DeleteDeliveryReport(t);
        }

        public R_DeliveryReport GetDeliveryReport(int deliveryReportId)
        {
            //Requires.NotNegative("deliveryReportId", deliveryReportId);
            
            R_DeliveryReport t = R_DeliveryReport.SingleOrDefault(deliveryReportId);

            return t;
        }

        public IEnumerable<R_DeliveryReport> GetDeliveryReports()
        {
             
            IEnumerable<R_DeliveryReport> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReport")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_DeliveryReport.Query(sql);

            return results;
        }

        public IList<R_DeliveryReport> GetDeliveryReports(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_DeliveryReport> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReport")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                     + " or " + "WeekDay like '%" + searchTerm + "%'"
                )
            ;

            results = R_DeliveryReport.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_DeliveryReport> GetDeliveryReportListAdvancedSearch(
            string name 
            , string description 
            , System.DateTime? reportDateFrom 
            , System.DateTime? reportDateTo 
            , string weekDay 
            , bool? submitted 
        )
        {
            IEnumerable<R_DeliveryReport> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_DeliveryReport")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (reportDateFrom != null ? " and ReportDate >= '" + reportDateFrom.Value.ToShortDateString() + "'" : "")
                    + (reportDateTo != null ? " and ReportDate <= '" + reportDateTo.Value.ToShortDateString() + "'" : "")
                    + (weekDay != null ? " and WeekDay like '%" + weekDay + "%'" : "")
                    + (submitted != null ? " and Submitted = " + (submitted == true ? "1" : "0") : "")
                 )
            ;

            results = R_DeliveryReport.Query(sql);

            return results;
        }

        public void UpdateDeliveryReport(R_DeliveryReport t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "DeliveryReportId");

            t.Update();
        }

    }
}

        