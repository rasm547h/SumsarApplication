using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsarApplication.Model
{
    public class ServiceObjective
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private TimeSpan _estimatedDuration;

        public TimeSpan EstimatedDuration
        {
            get { return _estimatedDuration; }
            set { _estimatedDuration = value; }
        }

        private TimeSpan _actualDuration;

        public TimeSpan ActualDuration
        {
            get { return _actualDuration; }
            set { _actualDuration = value; }
        }
        
        public ServiceObjective(string name, string desc)
        {
            Name = name;
            Description = desc;
            EstimatedDuration = default(TimeSpan);
            ActualDuration = default(TimeSpan);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Duration: {EstimatedDuration}";
        }
    }
}
