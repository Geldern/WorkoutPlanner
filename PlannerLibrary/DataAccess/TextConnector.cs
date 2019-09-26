using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerLibrary.DataAccess.TextHelpers;
using PlannerLibrary.Models;

namespace PlannerLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        public void CreateExercise(ExerciseModel model)
        {
            List<ExerciseModel> exercises = GlobalConfig.ExerciseFile.FullFilePath().LoadFile().ConvertToExerciseModels();

            int currentId = 1;

            if (exercises.Count > 0)
            {
                currentId = exercises.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            exercises.Add(model);

            exercises.SaveToExerciseFile();
        }

        public void CreateTraining(TrainingModel model)
        {
            List<TrainingModel> trainings = GlobalConfig.TrainingFile.FullFilePath().LoadFile().ConvertToTrainingModel();

            int currentId = 1;

            if (trainings.Count > 0)
            {
                currentId = trainings.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            trainings.Add(model);

            trainings.SaveToTrainingFile();
        }

        public List<ExerciseModel> GetExercise_All()
        {
            List<ExerciseModel> output = GlobalConfig.ExerciseFile.FullFilePath().LoadFile().ConvertToExerciseModels();

            return output;
        }

        public List<PlannedTrainingModel> GetPlannedTrainings_All()
        {
            List<PlannedTrainingModel> output = GlobalConfig.PlannedTrainingsFile.FullFilePath().LoadFile().ConvertToPlannedTrainingModel();

            return output;
        }

        public List<TrainingModel> GetTraining_All()
        {
            List<TrainingModel> output = GlobalConfig.TrainingFile.FullFilePath().LoadFile().ConvertToTrainingModel();

            return output;
        }

        public List<PlannedTrainingModel> LoadPlannedTrainings_All()
        {
            List<PlannedTrainingModel> output = GlobalConfig.PlannedTrainingsFile.FullFilePath().LoadFile().ConvertToPlannedTrainingModel();

            foreach(PlannedTrainingModel plannedTraining in output)
            {
                if (plannedTraining.TrainingDateAndTime.Date < DateTime.Today)
                {
                    output.Remove(plannedTraining);
                }
            }

            output.SaveToPlannedTrainingFile();

            output = GlobalConfig.PlannedTrainingsFile.FullFilePath().LoadFile().ConvertToPlannedTrainingModel();

            return output;
        }

        public void PlanWorkouts(List<PlannedTrainingModel> models)
        {
            List<PlannedTrainingModel> plannedTrainings = GlobalConfig.PlannedTrainingsFile.FullFilePath().LoadFile().ConvertToPlannedTrainingModel();

            foreach(PlannedTrainingModel model in models)
            {
                plannedTrainings.Add(model);
            }

            plannedTrainings.OrderBy(x => x.TrainingDateAndTime.Date);

            plannedTrainings.SaveToPlannedTrainingFile();
        }

        public void UpdateExercise(ExerciseModel modelToUpdate, ExerciseModel updatedModel)
        {
            List<ExerciseModel> exercises = GetExercise_All();

            int index = exercises.IndexOf(exercises.Find(x => x.Id == modelToUpdate.Id));

            exercises.Remove(exercises.Find(x => x.Id == modelToUpdate.Id));
            exercises.Insert(index, updatedModel);

            exercises.SaveToExerciseFile();
        }
    }
}
