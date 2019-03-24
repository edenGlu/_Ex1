using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    // type of function 
    public delegate double Function(double var);
    public class FunctionsContainer
    {
        private Dictionary<string, Function> dicFunc = new Dictionary<string, Function>();

        // INDEXER
        public Function this[string key]
        {
            get
            {
                // if the key not in the dic 
                if (!dicFunc.ContainsKey(key))
                {
                    dicFunc.Add(key, value => value); // the id func
                }
                return dicFunc[key];
            }
            set
            {
                dicFunc[key] = value;
            }
        }

        public List<string> getAllMissions()
        {
            return this.dicFunc.Keys.ToList();
        }
    }
}
