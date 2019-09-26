using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerLibrary.Models
{
    public class PlannedTrainingModel
    {
        public int Id { get; set; }
        public TrainingModel Training { get; set; }
        public DateTime TrainingDateAndTime { get; set; }
        public string DisplayNameAndDate
        {
            get
            {
                string output;

                string timeMinute;

                if (TrainingDateAndTime.Minute == 0)
                {
                    timeMinute = "00";
                }
                else if (TrainingDateAndTime.Minute < 10)
                {
                    timeMinute = "0" + TrainingDateAndTime.Minute.ToString();
                }
                else
                {
                    timeMinute = TrainingDateAndTime.Minute.ToString();
                }

                output = $"{Training.TrainingName}  {TrainingDateAndTime.Day}.{TrainingDateAndTime.Month}.{TrainingDateAndTime.Year} {TrainingDateAndTime.Hour}:{timeMinute}";

                return output;
            }
        }

        public PlannedTrainingModel()
        {

        }

        public PlannedTrainingModel(TrainingModel model, DateTime dateTime)
        {
            Training = model;
            TrainingDateAndTime = dateTime;
        }
    }
}
