using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TimerApp
{
    internal class Trainee
    {
        private string Title {  get; set; }
        private int Cycles { get; set; }
        private double RunUpTime { get; set; } //подготовка 
        private double WorkTime { get; set; } //работа
        private double RestTime { get; set; } //отдых
        private double RelaxTime { get; set; } //расслабление 

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
