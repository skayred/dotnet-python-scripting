using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuuka.Scripting
{   public class Tag
    {
        public long ID { get; set; }
        public List<HistoryItem> History { get; set; }

        public double First()
        {
            return this.History.FirstOrDefault().Value;
        }

        public double Last()
        {
            return this.History.LastOrDefault().Value;
        }
    }

    public class HistoryItem
    {
        public HistoryItem(double value)
        {
            this.Value = value;
        }

        public double Value { get; set; }
    }
}
