using PlannerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<ExerciseModel> ConvertToExerciseModels(this List<string> lines)
        {
            List<ExerciseModel> output = new List<ExerciseModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ExerciseModel exercise = new ExerciseModel();

                exercise.Id = int.Parse(cols[0]);
                exercise.ExerciseName = cols[1];
                exercise.NumberOfRepetitions = int.Parse(cols[2]);
                exercise.ExerciseTime = int.Parse(cols[3]);
                exercise.NumberOfSeries = int.Parse(cols[4]);
                exercise.BreakBetweenSeries = int.Parse(cols[5]);

                output.Add(exercise);
            }

            return output;
        }

        public static void SaveToExerciseFile(this List<ExerciseModel> models)
        {
            List<string> lines = new List<string>();

            foreach (ExerciseModel exercise in models)
            {
                lines.Add($"{exercise.Id},{exercise.ExerciseName},{exercise.NumberOfRepetitions},{exercise.ExerciseTime},{exercise.NumberOfSeries},{exercise.BreakBetweenSeries}");
            }

            File.WriteAllLines(GlobalConfig.ExerciseFile.FullFilePath(), lines);
        }

        public static List<TrainingModel> ConvertToTrainingModel(this List<string> lines)
        {
            List<TrainingModel> output = new List<TrainingModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TrainingModel training = new TrainingModel();

                training.Id = int.Parse(cols[0]);
                training.TrainingName = cols[1];
                training.IsCircuitTraining = byte.Parse(cols[2]);
                training.NumberOfCircuits = int.Parse(cols[3]);
                training.BreakBetweenCircuit = int.Parse(cols[4]);

                string[] ids = cols[5].Split('|');

                List<ExerciseModel> allExercises = GlobalConfig.ExerciseFile.FullFilePath().LoadFile().ConvertToExerciseModels();

                foreach (string eId in ids)
                {
                    training.Exercises.Add(allExercises.Find(x => x.Id == int.Parse(eId)));

                    //foreach(ExerciseModel exercise in allExercises)
                    //{
                    //    if (exercise.Id == int.Parse(eId))
                    //    {
                    //        training.Exercises.Add(exercise);
                    //    }
                    //}
                }

                output.Add(training);
            }

            return output;
        }

        public static void SaveToTrainingFile(this List<TrainingModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TrainingModel training in models)
            {
                lines.Add($"{training.Id},{training.TrainingName},{training.IsCircuitTraining},{training.NumberOfCircuits},{training.BreakBetweenCircuit},{ConvertExerciseListToString(training.Exercises)}");
            }

            File.WriteAllLines(GlobalConfig.TrainingFile.FullFilePath(), lines);
        }

        public static List<PlannedTrainingModel> ConvertToPlannedTrainingModel(this List<string> lines)
        {
            List<PlannedTrainingModel> output = new List<PlannedTrainingModel>();
            List<TrainingModel> trainings = GlobalConfig.TrainingFile.FullFilePath().LoadFile().ConvertToTrainingModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PlannedTrainingModel plannedTraining = new PlannedTrainingModel();

                plannedTraining.Training = trainings.Find(x => x.Id == int.Parse(cols[0]));

                string[] dateAndTime = cols[1].Split('|');

                DateTime dateTime = new DateTime(int.Parse(dateAndTime[0]), int.Parse(dateAndTime[1]), int.Parse(dateAndTime[2]), int.Parse(dateAndTime[3]), int.Parse(dateAndTime[4]), 0);

                plannedTraining.TrainingDateAndTime = dateTime;

                output.Add(plannedTraining);
            }

            return output;
        }

        public static void SaveToPlannedTrainingFile(this List<PlannedTrainingModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PlannedTrainingModel plannedTraining in models)
            {
                lines.Add($"{plannedTraining.Training.Id.ToString()},{plannedTraining.TrainingDateAndTime.Year}|{plannedTraining.TrainingDateAndTime.Month}|{plannedTraining.TrainingDateAndTime.Day}|{plannedTraining.TrainingDateAndTime.Hour}|{plannedTraining.TrainingDateAndTime.Minute}|{plannedTraining.TrainingDateAndTime.Second}");
            }

            File.AppendAllLines(GlobalConfig.PlannedTrainingsFile.FullFilePath(), lines);
        }

        static string ConvertExerciseListToString(List<ExerciseModel> exercises)
        {
            string output = null;

            if (exercises.Count == 0)
            {
                output = "";
            }

            foreach (ExerciseModel exercise in exercises)
            {
                output += exercise.Id.ToString() + "|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


    }
}
