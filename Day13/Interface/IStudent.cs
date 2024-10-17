using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covariants
{
    internal interface IStudent
    {
        string Name { get; set; }
        void Display();
    }
}