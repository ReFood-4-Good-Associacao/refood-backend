
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
    public partial class NucleoRepository : INucleoRepository
    {
        public int AddNucleo(R_Nucleo t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteNucleo(R_Nucleo t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteNucleo(int nucleoId)
        {
            var t = GetNucleo(nucleoId);
            DeleteNucleo(t);
        }

        public R_Nucleo GetNucleo(int nucleoId)
        {
            //Requires.NotNegative("nucleoId", nucleoId);
            
            R_Nucleo t = R_Nucleo.SingleOrDefault(nucleoId);

            return t;
        }

        public IEnumerable<R_Nucleo> GetNucleos()
        {
             
            IEnumerable<R_Nucleo> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Nucleo")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Nucleo.Query(sql);

            return results;
        }

        public IList<R_Nucleo> GetNucleos(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Nucleo> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Nucleo")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "PersonResponsible like '%" + searchTerm + "%'"
                     + " or " + "PrimaryPhoneNumber like '%" + searchTerm + "%'"
                     + " or " + "PrimaryEmail like '%" + searchTerm + "%'"
                )
            ;

            results = R_Nucleo.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Nucleo> GetNucleoListAdvancedSearch(
            string name 
            , string personResponsible 
            , int? photo 
            , int? addressId 
            , System.DateTime? openingDateFrom 
            , System.DateTime? openingDateTo 
            , string primaryPhoneNumber 
            , string primaryEmail 
            , bool? active 
        )
        {
            IEnumerable<R_Nucleo> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Nucleo")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (personResponsible != null ? " and PersonResponsible like '%" + personResponsible + "%'" : "")
                    + (photo != null ? " and Photo like '%" + photo + "%'" : "")
                    + (addressId != null ? " and AddressId like '%" + addressId + "%'" : "")
                    + (openingDateFrom != null ? " and OpeningDate >= '" + openingDateFrom.Value.ToShortDateString() + "'" : "")
                    + (openingDateTo != null ? " and OpeningDate <= '" + openingDateTo.Value.ToShortDateString() + "'" : "")
                    + (primaryPhoneNumber != null ? " and PrimaryPhoneNumber like '%" + primaryPhoneNumber + "%'" : "")
                    + (primaryEmail != null ? " and PrimaryEmail like '%" + primaryEmail + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Nucleo.Query(sql);

            return results;
        }

        public void UpdateNucleo(R_Nucleo t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "NucleoId");

            t.Update();
        }

    }
}

        