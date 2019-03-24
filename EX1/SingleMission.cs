using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise_1
{
    class SingleMission : IMission
    {
        private Function func;
        public String Name { get; }
        public String Type { get; }

        public SingleMission(Function f, string mission)
        {
            Name = mission;
            Type = "Single";
            func = f;
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double ans = this.func(value); // calculat the mission

            OnCalculate?.Invoke(this, ans); //if the onCalculat isnt null
            return ans;
        }
    }
}