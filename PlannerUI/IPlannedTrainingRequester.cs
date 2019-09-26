using PlannerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerUI
{
    public interface IPlannedTrainingRequester
    {
        void PlanningCompleted(List<PlannedTrainingModel> models);
    }
}
