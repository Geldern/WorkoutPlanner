using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerLibrary.Models
{
    public class TrainingModel
    {
        /// <summary>
        /// The unique identifier for the training
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Training Name
        /// </summary>
        public string TrainingName { get; set; }

        /// <summary>
        /// Represents if it is a circuit training (1 - true | 0 - false)
        /// </summary>
        public byte IsCircuitTraining { get; set; }

        /// <summary>
        /// Represents how many circuit is in training
        /// </summary>
        public int NumberOfCircuits { get; set; }

        /// <summary>
        /// Length of break between circuit in seconds
        /// </summary>
        public int BreakBetweenCircuit { get; set; }

        /// <summary>
        /// The set of exercise that were involved in this training
        /// </summary>
        public List<ExerciseModel> Exercises = new List<ExerciseModel>();
    }
}
