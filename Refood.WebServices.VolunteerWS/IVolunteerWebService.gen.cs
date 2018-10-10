
// ################################################################
//                      Code generated with T4
// ################################################################

using System.ServiceModel;
using Refood.WebServices.VolunteerWS.DataContracts;

namespace Refood.WebServices.VolunteerWS
{
    [ServiceContract]
    public partial interface IVolunteerWebService
    {
        
        /// <summary>
        /// Delete Volunteer by id
        /// </summary>
        /// <param name="id">Volunteer id</param>
        /// <returns>true if the Volunteer is deleted successfully</returns>
        [OperationContract]
        public bool Delete(int id);

        /// <summary>
        /// Get Volunteer by id
        /// </summary>
        /// <param name="id">Volunteer id</param>
        /// <returns>Volunteer</returns>
        [OperationContract]
        public VolunteerDataContract Get(int id);

        /// <summary>
        /// Get list of Volunteers
        /// </summary>
        /// <returns>list of Volunteers</returns>
        [OperationContract]
        public VolunteerDataContract[] GetList();

        /// <summary>
        /// Get paged list of Volunteers
        /// </summary>
        /// <param name="id">(not used)</param>
        /// <param name="searchTerm">search text</param>
        /// <param name="pageIndex">current page index (starts at 0)</param>
        /// <param name="pageSize">page size</param>
        /// <returns>a single page from the list of Volunteers</returns>
        [OperationContract]
        public VolunteerDataContract[] GetPage(int id = 0, string searchTerm = "", int pageIndex = 1, int pageSize = 10);

        [OperationContract]
        public VolunteerDataContract[] GetListAdvancedSearch(
            int id = 0 
            , string name = null 
            , int? gender = null 
            , System.DateTime? birthDateFrom = null 
            , System.DateTime? birthDateTo = null 
            , string occupation = null 
            , string employer = null 
            , string phone = null 
            , string email = null 
            , string identityCardNumber = null 
            , int? countryId = null 
            , string friendOrFamilyContact = null 
            , int? photo = null 
            , int? addressId = null 
            , bool? hasCar = null 
            , bool? hasDriverLicense = null 
            , bool? hasBike = null 
            , string vehicleMake = null 
            , string vehicleModel = null 
            , bool? active = null 
        );

        

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Updates data for an existing Volunteer, or creates a new Volunteer if the Id is 0
        /// </summary>
        /// <param name="dataContract">Volunteer data</param>
        /// <returns>Volunteer id</returns>
        [OperationContract]
        public int Upsert(VolunteerDataContract dataContract);

        //[ValidateAntiForgeryToken]
        /// <summary>
        /// Save a list of Volunteer
        /// </summary>
        /// <param name="dataContracts">Volunteers</param>
        /// <param name="id">(not used)</param>
        /// <returns>true if the operation is successfull</returns>
        [OperationContract]
        public bool SaveList(VolunteerDataContract[] dataContracts, int? id);

    }
}

    