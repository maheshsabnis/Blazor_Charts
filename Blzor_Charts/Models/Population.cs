using System.Collections.Generic;

namespace Blzor_Charts.Models
{
    public class Population
    {
        public string State { get; set; }
        public int Count { get; set; }
    }

    public class PopulationData : List<Population>
    {
        public PopulationData()
        {
            Add(new Population { State = "MH", Count = 34000});
            Add(new Population { State = "AP", Count = 14000 });
            Add(new Population { State = "GJ", Count = 24000 });
            Add(new Population { State = "KR", Count = 28000 });
            Add(new Population { State = "AP", Count = 26000 });
            Add(new Population { State = "PB", Count = 30000 });
            Add(new Population { State = "UP", Count = 64000 });
            Add(new Population { State = "JK", Count = 4000 });
            Add(new Population { State = "RJ", Count = 15000 });
            Add(new Population { State = "MP", Count = 64000 });
            Add(new Population { State = "TN", Count = 34000 });
            Add(new Population { State = "TS", Count = 16000 });
            Add(new Population { State = "OR", Count = 38000 });
            Add(new Population { State = "UK", Count = 14000 });
        }
    }
}
