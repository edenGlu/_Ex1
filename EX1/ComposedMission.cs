using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private List<Function> funcs = new List<Function>();
        public ComposedMission(string missionName)
        {
            Name = missionName;
            Type = "Composed";
        }
        // this is is
        public String Name { get; }
        public String Type { get; }

        public ComposedMission Add(Function f)
        {
            funcs.Add(f);
            return this; // So that it can be concatenated
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double ans = funcs.ElementAt(0)(value); // calculat the first one
            for (int i = 1; i < funcs.Count; i++)
            {
                ans = funcs.ElementAt(i)(ans);  // calculat all and save the resulte 
            }
            OnCalculate?.Invoke(this, ans); // if the onCalculat isnt null
            return ans;
        }


    }
}
