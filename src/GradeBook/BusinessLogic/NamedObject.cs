using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.BusinessLogic
{ 
//  Base class of Name
    public class NameObject
    {
        public NameObject(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
