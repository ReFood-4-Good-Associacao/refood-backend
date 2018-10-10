
// ################################################################
//                      Code generated with T4
// ################################################################

using System.Collections.Generic;
using Refood.Business.DTOs;

namespace Refood.Business.Interfaces
{
    public partial interface ITutorialService
    {
        int AddTutorial(TutorialDTO dto);

        void DeleteTutorial(int tutorialId);

        void DeleteTutorial(TutorialDTO dto);

        TutorialDTO GetTutorial(int tutorialId);

        IEnumerable<TutorialDTO> GetTutorials();

        IList<TutorialDTO> GetTutorials(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<TutorialDTO> GetTutorialListAdvancedSearch(
            string name 
            ,string description 
            ,string location 
            ,bool? isOnlineTutorial 
            ,string language 
            ,bool? active 
        );

        void UpdateTutorial(TutorialDTO dto);

    }
}
    