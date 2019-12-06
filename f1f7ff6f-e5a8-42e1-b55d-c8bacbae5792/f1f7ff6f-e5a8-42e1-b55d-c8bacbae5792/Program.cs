using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1f7ff6f_e5a8_42e1_b55d_c8bacbae5792
{

    class Program
    {
        static void Main(string[] args)
        {
RootObject rootObject;
rootObject = new RootObject();

string[] lesCategories;
lesCategories = rootObject.features.Select(f => f.properties.categories).ToArray();

double[] lesCoordonnées;
lesCoordonnées = rootObject.features.SelectMany(f => f.geometry.coordinates).ToArray();
        }
    }

    public class RootObject
    {
        public string type { get; set; }
        public List<Feature> features { get; set; }
    }


    public class Feature
    {
        public string type { get; set; }
        public string id { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }


    public class Properties
    {
        public string categories { get; set; }
    }


    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

}
