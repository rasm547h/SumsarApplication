using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumsarApplication.Model;
namespace SumsarApplication.Model
{
    public class Service
    {
        private int _identity;

        public int Identity
        {
            get { return _identity; }
            set { _identity = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
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

        private List<ServiceObjective> _objectives;

        public List<ServiceObjective> Objectives
        {
            get { return _objectives; }
            set { _objectives = value; }
        }
        
        private bool _isDone;

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        private DateTime _dateOfCreation;

        public DateTime DateOfCreation
        {
            get { return _dateOfCreation; }
            set { _dateOfCreation = value; }
        }


        public Service(int id, string desc, List<ServiceObjective> objectives)
        {
            Identity = id;
            Description = desc;
            ActualDuration = default(TimeSpan);
            IsDone = false;
            Objectives = new List<ServiceObjective>(objectives);
        }

        public override string ToString()
        {
            return $"Id: {Identity}, Description: {Description}, Estimated Duration: {EstimatedDuration}, Actual Duration: {ActualDuration}, Is Service Done: {(IsDone ? "Yes" : "No")}";
        }
    }
}
