using System;
using System.IO;
using System.Collections.Generic;
using System.Windows;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using contractMaker.Utils.DataTypes;
using contractMaker.Views;
using contractMaker.Views.PopUpWindows;

namespace contractMaker.Coordinators
{
    public class ContractMakerCoordinator
    { 
        private Dictionary<String, Contract> mContracts;

        private HomeWindow mHomeWindow;
        private ItemEditorWindow mItemEditorWindow;
        private NewContractPopUpWindow mNewContractPopUpWindow;

        private String mDataLocation;

        // upon launching of the app
        public ContractMakerCoordinator()
        {
            mDataLocation = @"../../../Storage/ContractData.json";

            using StreamReader file = File.OpenText(mDataLocation);
            mContracts = JsonConvert.DeserializeObject<Dictionary<String, Contract>>(file.ReadToEnd());
            if (null == mContracts)
            {
                mContracts = new Dictionary<string, Contract>();
            }
        }

        public void SetHomeWindow(HomeWindow homeWindow)
        {
            mHomeWindow = homeWindow;
        }

        public void SetItemEditorWindow(ItemEditorWindow itemEditorWindow)
        {
            mItemEditorWindow = itemEditorWindow;
        }

        public void SetNewContractPopUpWindow(NewContractPopUpWindow newContractPopUpWindow)
        {
            mNewContractPopUpWindow = newContractPopUpWindow;
        }

        public Dictionary<String, Contract> GetContracts()
        { 
            return mContracts;
        }
        public String GetDataLocation()
        {
            return mDataLocation;
        }

        public void AddContract(Contract contract)
        {
            mContracts[contract.mTitle] = contract;
        }

        public void RefreshHomeWindow()
        {
            if (null != mHomeWindow)
            {
                mHomeWindow.RefreshItems();
            }
        }
    }
}
