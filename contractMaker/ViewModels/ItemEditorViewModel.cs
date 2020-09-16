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

        public void SaveButtonClicked(Contract contract, FrozenContract contractAtLoad, Dictionary<String, Contract> allContracts)
        {
            if (AreContractsDifferent(contract, contractAtLoad))
            {
                contract.mDateLastModified = DateTime.Now.ToString("MM/dd/yyyy");
            }
            allContracts[contract.getTitle()] = contract;
            String jsonVersion = JsonConvert.SerializeObject(allContracts);
            System.IO.File.WriteAllText(mCoordinator.GetDataLocation(), jsonVersion);

        }

        public void FinalizeButtonClicked(Contract contract, FrozenContract contractAtLoad, Dictionary<String, Contract> allContracts)
        {
            contract.FinalizeContract();
            SaveButtonClicked(contract, contractAtLoad, allContracts);
        }

        public Boolean AreContractsDifferent(Contract c1, FrozenContract c2)
        {
            if (c1.mTotalAmount != c2.mTotalAmount)
            {
                return true;
            }

            List<ItemEntry> c1Items = c1.GetItemEntries();
            List<ItemEntry> c2Items = c2.GetItemEntries();

            if (c1Items.Count != c2Items.Count)
            {
                return true;
            } 
            else
            {
                for (int i = 0; i < c1Items.Count; i++)
                {
                    if (!c1Items[i].Equals(c2Items[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
