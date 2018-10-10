
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
    public partial class BeneficiaryRepository : IBeneficiaryRepository
    {
        public int AddBeneficiary(R_Beneficiary t)
        {
            int id = (int) t.Insert();

            return id;
        }

        public void DeleteBeneficiary(R_Beneficiary t)
        {
            t.IsDeleted = true;
            t.Update();
        }

        public void DeleteBeneficiary(int beneficiaryId)
        {
            var t = GetBeneficiary(beneficiaryId);
            DeleteBeneficiary(t);
        }

        public R_Beneficiary GetBeneficiary(int beneficiaryId)
        {
            //Requires.NotNegative("beneficiaryId", beneficiaryId);
            
            R_Beneficiary t = R_Beneficiary.SingleOrDefault(beneficiaryId);

            return t;
        }

        public IEnumerable<R_Beneficiary> GetBeneficiarys()
        {
             
            IEnumerable<R_Beneficiary> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Beneficiary")
                .Where("IsDeleted = 0")
                 
            ;

            results = R_Beneficiary.Query(sql);

            return results;
        }

        public IList<R_Beneficiary> GetBeneficiarys(string searchTerm, int pageIndex, int pageSize)
        {
                        
            IList<R_Beneficiary> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Beneficiary")
                .Where("IsDeleted = 0")
                .Where(
                    "Name like '%" + searchTerm + "%'"
                     + " or " + "Description like '%" + searchTerm + "%'"
                )
            ;

            results = R_Beneficiary.Fetch(pageIndex, pageSize, sql);

            return results;
        }

        public IEnumerable<R_Beneficiary> GetBeneficiaryListAdvancedSearch(
            string name 
            , int? number 
            , int? addressId 
            , int? numberOfAdults 
            , int? numberOfChildren 
            , int? numberOfTupperware 
            , int? numberOfSoups 
            , string description 
            , bool? active 
        )
        {
            IEnumerable<R_Beneficiary> results = null;

            var sql = PetaPoco.Sql.Builder
                .Select("*")
                .From("R_Beneficiary")
                .Where("IsDeleted = 0" 
                    + (name != null ? " and Name like '%" + name + "%'" : "")
                    + (number != null ? " and Number like '%" + number + "%'" : "")
                    + (addressId != null ? " and AddressId like '%" + addressId + "%'" : "")
                    + (numberOfAdults != null ? " and NumberOfAdults like '%" + numberOfAdults + "%'" : "")
                    + (numberOfChildren != null ? " and NumberOfChildren like '%" + numberOfChildren + "%'" : "")
                    + (numberOfTupperware != null ? " and NumberOfTupperware like '%" + numberOfTupperware + "%'" : "")
                    + (numberOfSoups != null ? " and NumberOfSoups like '%" + numberOfSoups + "%'" : "")
                    + (description != null ? " and Description like '%" + description + "%'" : "")
                    + (active != null ? " and Active = " + (active == true ? "1" : "0") : "")
                 )
            ;

            results = R_Beneficiary.Query(sql);

            return results;
        }

        public void UpdateBeneficiary(R_Beneficiary t)
        {
            //Requires.NotNull(t);
            //Requires.PropertyNotNegative(t, "BeneficiaryId");

            t.Update();
        }

    }
}

        