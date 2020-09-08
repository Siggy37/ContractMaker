using contractMaker.Coordinators;
using contractMaker.Utils;
using contractMaker.Utils.DataTypes;
using contractMaker.Views;
using contractMaker.Views.PopUpWindows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace contractMaker.ViewModels
{
    public class HomeWindowViewModel
    {
        private ContractMakerCoordinator mCoordinator;
        public HomeWindowViewModel(ContractMakerCoordinator coordinator) { 
            mCoordinator = coordinator;
        }

        /*
         * For testing the editor window and injections before
         * having fully designed and implemented the home window
         */
        public void ShowEditerWindow(Contract contract)
        {
            // List<ItemEntry> testItemEntries = new List<ItemEntry>();
            // Contract testContract = new Contract("Test Contract");
            Window editorWindow = new ItemEditorWindow(contract, mCoordinator);
            editorWindow.Show();
        }

        public List<Contract> GetContractsList(Dictionary<String, Contract> contracts)
        {
            List<Contract> output = new List<Contract>();
            foreach(String key in contracts.Keys)
            {
                output.Add(contracts[key]);
            }
            return output;
        }

        public void NewContract()
        {
            NewContractPopUpWindow popUp = new NewContractPopUpWindow(this);
            popUp.ShowDialog();
        }

        public void PopUpSaveButtonClicked(Contract newContract)
        {
            mCoordinator.AddContract(newContract);
            mCoordinator.RefreshHomeWindow();
        }

        public void RefreshHomeWindow()
        {
            
        }
    }
}
