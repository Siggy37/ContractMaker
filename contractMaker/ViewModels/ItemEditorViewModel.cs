using contractMaker.Utils.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using contractMaker.Coordinators;

namespace contractMaker.ViewModels
{
    class ItemEditorViewModel
    {
        private ContractMakerCoordinator mCoordinator;
        public ItemEditorViewModel(ContractMakerCoordinator coordinator) { 
            mCoordinator = coordinator;
        }

        public List<ItemEntry> AddItemButtonClicked(List<ItemEntry> itemEntries)
        {
            ItemEntry newBlankEntry = new ItemEntry();
            itemEntries.Add(newBlankEntry);
            return itemEntries;
        }

        public void SaveButtonClicked(Contract contract, Dictionary<String, Contract> allContracts)
        {
            // Dictionary<String, Contract> contractDict = new Dictionary<string, Contract>();
            allContracts[contract.getTitle()] = contract;
            String jsonVersion = JsonConvert.SerializeObject(allContracts);
            System.IO.File.WriteAllText(mCoordinator.GetDataLocation(), jsonVersion);
            // Dictionary<String, List<ItemEntry>> realVersion = JsonConvert.DeserializeObject<Dictionary<String, List<ItemEntry>>>(jsonVersion);
            String m = "m";
        }

        public void FinalizeButtonClicked(Contract contract, Dictionary<String, Contract> allContracts)
        {
            contract.FinalizeContract();
            SaveButtonClicked(contract, allContracts);
        }

    }
}
