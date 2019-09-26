using PlannerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateExercise(ExerciseModel model);
        void CreateTraining(TrainingModel model);
        void UpdateExercise(ExerciseModel modelToUpdate, ExerciseModel updatedModel);
        void PlanWorkouts(List<PlannedTrainingModel> models);
        List<ExerciseModel> GetExercise_All();
        List<TrainingModel> GetTraining_All();
        List<PlannedTrainingModel> GetPlannedTrainings_All();
        List<PlannedTrainingModel> LoadPlannedTrainings_All();
    }
}
