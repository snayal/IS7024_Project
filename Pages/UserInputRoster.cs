using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IS7024_Project.Pages
{
    public static class UserInputRoster
    {
        static UserInputRoster()
        {
            allUserInputs = new List<UserInput>();
        }

        public static IList<UserInput> allUserInputs { get; set; }
    }
}