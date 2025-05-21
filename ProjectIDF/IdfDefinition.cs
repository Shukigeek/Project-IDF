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

        IdfDefinition(string dateOfEstablishment, string currentCommander)
        {
            DateOfEstablishment = dateOfEstablishment; // "may 26 1948";
            CurrentCommander = currentCommander; // "eyal zamir";
            CollectionOfStrike = new string[] { "aircraft", "drones", "artillery" };
        }

        //public string get()
        //{
        //    IdfDefinition d = new IdfDefinition("ds", "gghf");
        //    return $"{d.get()}";
        //}
      
    }
}
