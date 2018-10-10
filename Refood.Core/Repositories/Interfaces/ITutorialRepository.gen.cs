
// ################################################################
//                      Code generated with T4
// ################################################################

using System;
using System.Collections.Generic;
using System.Linq;
using Refood.Core;

namespace Refood.Core.Repositories.Interfaces
{
    public partial interface ITutorialRepository
    {
        int AddTutorial(R_Tutorial t);

        void DeleteTutorial(R_Tutorial t);

        void DeleteTutorial(int tutorialId);

        R_Tutorial GetTutorial(int tutorialId);

        IEnumerable<R_Tutorial> GetTutorials();

        IList<R_Tutorial> GetTutorials(string searchTerm, int pageIndex, int pageSize);

        IEnumerable<R_Tutorial> GetTutorialListAdvancedSearch(
            string name 
            , string description 
            , string location 
            , bool? isOnlineTutorial 
            , string language 
            , bool? active 
        );

        void UpdateTutorial(R_Tutorial t);

    }
}

    