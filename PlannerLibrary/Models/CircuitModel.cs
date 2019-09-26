using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerLibrary.Models
{
    public class CircuitModel
    {
        /// <summary>
        /// The unique identifier for the training
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Length of break between exercise in seconds
        /// </summary>
        public int BreakBetweenExercise { get; set; }

        /// <summary>
        /// A set of exercises that belong to the circuit
        /// </summary>
        public List<ExerciseModel> Exercises = new List<ExerciseModel>();
    }
}
