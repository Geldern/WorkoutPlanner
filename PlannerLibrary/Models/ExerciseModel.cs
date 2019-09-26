using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerLibrary.Models
{
    /// <summary>
    /// Represent one exercise
    /// </summary>
    public class ExerciseModel
    {
        /// <summary>
        /// The unique identifier for the exercise
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the exercise
        /// </summary>
        public string ExerciseName { get; set; }

        /// <summary>
        /// Number of repetitions
        /// </summary>
        public int NumberOfRepetitions { get; set; }

        /// <summary>
        /// Exercise time in seconds
        /// </summary>
        public int ExerciseTime { get; set; }

        /// <summary>
        /// Number of series
        /// </summary>
        public int NumberOfSeries { get; set; }

        /// <summary>
        /// Length of break between series in seconds
        /// </summary>
        public int BreakBetweenSeries { get; set; }

        public string DisplayName
        {
            get
            {
                string output;

                string numberOrLength = "";

                if (ExerciseTime == 0)
                {
                    numberOrLength = NumberOfRepetitions.ToString();
                }
                else if (NumberOfRepetitions == 0)
                {
                    numberOrLength = ExerciseTime.ToString() + "(s)";
                }

                output = $"{ExerciseName}   {numberOrLength}x{NumberOfSeries} | break: {BreakBetweenSeries}s";

                return output;
            }
        }

        public string DisplayShortName
        {
            get
            {
                string output;

                string numberOrLength = "";

                if (ExerciseTime == 0)
                {
                    numberOrLength = NumberOfRepetitions.ToString();
                }
                else if (NumberOfRepetitions == 0)
                {
                    numberOrLength = ExerciseTime.ToString() + "(s)";
                }

                output = $"{ExerciseName} | {numberOrLength}";

                return output;
            }
        }

        public ExerciseModel()
        {

        }

        public ExerciseModel(string aExerciseName, string aNumberOfRepetitions, string aExerciseTime, string aNumberOfSeries, string aBreakBetweenSeries)
        {
            ExerciseName = aExerciseName;

            int numberOfRepetitionsValue = 0;
            int.TryParse(aNumberOfRepetitions, out numberOfRepetitionsValue);
            NumberOfRepetitions = numberOfRepetitionsValue;

            int exerciseTimeValue = 0;
            int.TryParse(aExerciseTime, out exerciseTimeValue);
            ExerciseTime = exerciseTimeValue;

            int numberOfSeriesValue = 0;
            int.TryParse(aNumberOfSeries, out numberOfSeriesValue);
            NumberOfSeries = numberOfSeriesValue;

            int breakBetweenSeriesValue = 0;
            int.TryParse(aBreakBetweenSeries, out breakBetweenSeriesValue);
            BreakBetweenSeries = breakBetweenSeriesValue;
        }
    }
}
