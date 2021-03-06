using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractionDemoKitchen
{
    public interface IMachinery
    {
        void ListOfMachines();

        List<string> Machines {get; set;}
    }
}
