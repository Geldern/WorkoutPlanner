using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerLibrary.Models;

namespace PlannerLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        const string db = "WorkoutPlanner";

        public void CreateExercise(ExerciseModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@ExerciseName", model.ExerciseName);
                p.Add("@NumberOfRepetitions", model.NumberOfRepetitions);
                p.Add("@ExerciseTime", model.ExerciseTime);
                p.Add("@NumberOfSeries", model.NumberOfSeries);
                p.Add("@BreakBetweenSeries", model.BreakBetweenSeries);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spExercise_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public void CreateTraining(TrainingModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@TrainingName", model.TrainingName);
                p.Add("@IsCircuitTraining", model.IsCircuitTraining);
                p.Add("@NumberOfCircuits", model.NumberOfCircuits);
                p.Add("@BreakBetweenCircuit", model.BreakBetweenCircuit);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTraining_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach (ExerciseModel exercise in model.Exercises)
                {
                    p = new DynamicParameters();

                    p.Add("@TrainingId", model.Id);
                    p.Add("@ExerciseId", exercise.Id);
                    p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTrainingElements_Insert", p, commandType: CommandType.StoredProcedure);

                    exercise.Id = p.Get<int>("@id");
                }
            }
        }

        public List<ExerciseModel> GetExercise_All()
        {
            List<ExerciseModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ExerciseModel>("dbo.spExercise_GetAll").ToList();
            }

            return output;
        }

        public List<PlannedTrainingModel> GetPlannedTrainings_All()
        {
            List<PlannedTrainingModel> output = new List<PlannedTrainingModel>();
            List<TrainingModel> trainings = GetTraining_All();
            

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                foreach (TrainingModel training in trainings)
                {
                    DateTime[] dates;
                    DateTime[] times;
                    int[] ids;

                    var p = new DynamicParameters();

                    p.Add("@TrainingId", training.Id);

                    dates = connection.Query<DateTime>("dbo.spPlannedTrainingsDate_GetByTraining", p, commandType: CommandType.StoredProcedure).ToArray();
                    times = connection.Query<DateTime>("dbo.spPlannedTrainingsTime_GetByTraining", p, commandType: CommandType.StoredProcedure).ToArray();
                    ids = connection.Query<int>("dbo.spPlannedTrainingsId_GetByTraining", p, commandType: CommandType.StoredProcedure).ToArray();

                    if (dates.Length > 0 && times.Length > 0)
                    {
                        for (int i= 0; i < dates.Length; i++)
                        {
                            PlannedTrainingModel plannedTraining = new PlannedTrainingModel();
                            DateTime dateTime = new DateTime(dates[i].Year, dates[i].Month, dates[i].Day, times[i].Hour, times[i].Minute, 0);

                            plannedTraining.Id = ids[i];
                            plannedTraining.Training = training;
                            plannedTraining.TrainingDateAndTime = dateTime;

                            output.Add(plannedTraining);
                        }
                    }
                }

            }

            return output;
        }

        public List<TrainingModel> GetTraining_All()
        {
            List<TrainingModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TrainingModel>("dbo.spTraining_GetAll").ToList();

                foreach (TrainingModel training in output)
                {
                    var p = new DynamicParameters();

                    p.Add("@TrainingId", training.Id);

                    training.Exercises = connection.Query<ExerciseModel>("spTrainingElements_GetByTraining", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public List<PlannedTrainingModel> LoadPlannedTrainings_All()
        {
            List<PlannedTrainingModel> output = GetPlannedTrainings_All();

            foreach(PlannedTrainingModel plannedTraining in output)
            {
                if (plannedTraining.TrainingDateAndTime.Date < DateTime.Today)
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
                    {
                        var p = new DynamicParameters();

                        p.Add("@Id", plannedTraining.Id);

                        connection.Execute("dbo.spPlannedTrainings_DeleteById", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }

            output = GetPlannedTrainings_All();

            return output;
        }

        public void PlanWorkouts(List<PlannedTrainingModel> models)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                foreach (PlannedTrainingModel plannedTrainingModel in models)
                {
                    var p = new DynamicParameters();

                    p.Add("@TrainingId", plannedTrainingModel.Training.Id);
                    p.Add("@TrainingDate", plannedTrainingModel.TrainingDateAndTime.Date);
                    p.Add("@TrainingTime", plannedTrainingModel.TrainingDateAndTime.TimeOfDay);
                    p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spPlannedTrainings_Insert", p, commandType: CommandType.StoredProcedure);

                    plannedTrainingModel.Id = p.Get<int>("@id");
                }
            }
        }

        public void UpdateExercise(ExerciseModel modelToUpdate, ExerciseModel updatedModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@id", modelToUpdate.Id);
                p.Add("@ExerciseName", updatedModel.ExerciseName);
                p.Add("@NumberOfRepetitions", updatedModel.NumberOfRepetitions);
                p.Add("@ExerciseTime", updatedModel.ExerciseTime);
                p.Add("@NumberOfSeries", updatedModel.NumberOfSeries);
                p.Add("@BreakBetweenSeries", updatedModel.BreakBetweenSeries);

                connection.Execute("dbo.spExercise_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
