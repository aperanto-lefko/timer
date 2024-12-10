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
        public string Title {  get; set; }
        public int Cycles { get; set; }
        public int RunUpTime { get; set; } //подготовка 
        public int WorkTime { get; set; } //работа
        public int RelaxTime { get; set; } //отдых
        public int RestTime { get; set; } //расслабление 

        public Trainee (string Title, int Cycles, int RunUpTime, int WorkTime, int RelaxTime,int RestTime)
        {
            this.Title = Title;
            this.Cycles = Cycles;
            this.RunUpTime = RunUpTime;
            this.WorkTime = WorkTime;
            this.RelaxTime = RelaxTime;
            this.RestTime = RestTime;
           
        }

        public override string ToString()
        {
            return $"Подготовка: {RunUpTime/60:F2} мин \n" +
                                 $"Работа: {WorkTime/60:F2} мин \n" +
                                 $"Отдых: {RelaxTime / 60:F2} мин \n" +
                                 $"Циклы \"работа/отдых\": {Cycles} \n" +
                                 $"Расслабление: {RestTime/60:F2} мин";
        }

        public double SumSecondsForTrainee ()
        {
            return RunUpTime + (WorkTime + RestTime) * Cycles + RelaxTime;
        }

      
    }
}
