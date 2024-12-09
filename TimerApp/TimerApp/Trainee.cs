using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TimerApp
{
    public class Trainee
    {
        private string Title {  get; set; }
        public int Cycles { get; set; }
        public int RunUpTime { get; set; } //подготовка 
        public int WorkTime { get; set; } //работа
        public int RestTime { get; set; } //отдых
        public int RelaxTime { get; set; } //расслабление 

        public Trainee (string Title, int Cycles, int RunUpTime, int WorkTime, int RelaxTime)
        {
            this.Title = Title;
            this.Cycles = Cycles;
            this.RunUpTime = RunUpTime;
            this.WorkTime = WorkTime;
            this.RelaxTime = RelaxTime;

        }

        public override string ToString()
        {
            return $"Подготовка: {RunUpTime:F2} мин \n" +
                                 $"Работа: {WorkTime:F2} мин \n" +
                                 $"Отдых: {RestTime:F2} мин \n" +
                                 $"Циклы: {Cycles} \n" +
                                 $"Расслабление: {RelaxTime:F2} мин";
        }

        public double SumSecondsForTrainee ()
        {
            return RunUpTime + (WorkTime + RestTime) * Cycles + RelaxTime;
        }

      
    }
}
