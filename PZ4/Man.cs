using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    public class Man
    {
        internal string _name;
        internal int _age;
        internal string _floor;
        internal double _weight;
        public string Name
        {
            get => _name;
        }
        public int Age
        {
            get => _age;
        }
        public string Floor
        {
            get => _floor;
        }
        public double Weight
        {
            get => _weight;
        }
        public Man(string name, int age, string floor, double weight)
        {
            _name = name;
            _age = age;
            _floor = floor;
            _weight = weight;
        }
        
    }
}
