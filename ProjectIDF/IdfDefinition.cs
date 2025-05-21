using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class IdfDefinition : IOrganization
    {
        public string DateOfEstablishment {  get; set; }
        public string CurrentCommander { get; set; }
        public string[] CollectionOfStrike;

        public IdfDefinition(string dateOfEstablishment = "may 26 1948", string currentCommander = "eyal zamir")
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCommander = currentCommander;
            CollectionOfStrike = new string[] { "aircraft", "drones", "artillery" };
        }      
    }
}
