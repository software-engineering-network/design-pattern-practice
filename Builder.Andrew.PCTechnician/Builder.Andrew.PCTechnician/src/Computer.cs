using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Andrew.PCTechnician.src
{
    class Computer
    {
        private string _computerType;

        private Dictionary<string, string> _components =
            new Dictionary<string, string>()
            {
                { "processor", "" },
                { "storage", "" },
                { "memory", "" },
                { "cooling", "" }
            };

        public Computer(string computerType)
        {
            _computerType = computerType;
        }

        public string Processor
        {
            get
            {
                return _components["processor"];
            }
            set
            {
                _components["processor"] = value;
            }
        }

        public string Storage
        {
            get
            {
                return _components["storage"];
            }
            set
            {
                _components["storage"] = value;
            }
        }

        public string Memory
        {
            get
            {
                return _components["memory"];
            }
            set
            {
                _components["memory"] = value;
            }
        }

        public string Cooling
        {
            get
            {
                return _components["cooling"];
            }
            set
            {
                _components["cooling"] = value;
            }
        }

        public Dictionary<string, string> LookInside()
        {
            return _components;
        }
    }
}
