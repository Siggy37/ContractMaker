using contractMaker.Coordinators;
using contractMaker.ViewModels;
using contractMaker.Utils.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace contractMaker.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private HomeWindowViewModel mViewModel;
        private ContractMakerCoordinator mCoordinator;
        private Dictionary<String, Contract> mContracts;
        private List<Contract> mContractsList;
        private List<Contract> mPendingList;
        private List<Contract> mOutstandingList;
        private List<Contract> mCompletedList;
        public HomeWindow()
        {
            mCoordinator = new ContractMakerCoordinator();
            mCoordinator.SetHomeWindow(this);
            mContracts = mCoordinator.GetContracts();
            mViewModel = new HomeWindowViewModel(mCoordinator);
            mContractsList = mViewModel.GetContractsList(mContracts);
            
            InitializeComponent();

            InitializeLists(mContractsList);

            contractsList.ItemsSource = mPendingList;
            outstandingList.ItemsSource = mOutstandingList;
            completedList.ItemsSource = mCompletedList;
        }

        public void ShowEditerWindow(Object sender, RoutedEventArgs e)
        {
            mViewModel.ShowEditerWindow(new Contract("Test Contract"));
        }

        public void LaunchEditerWindow(Object sender, RoutedEventArgs e)
        {
            Grid currItem = (Grid)sender;
            TextBlock currTextBlock = (TextBlock)currItem.FindName("titleBlock");
            String selectedContractName = currTextBlock.Text;
            Contract selectedContract = mContracts[selectedContractName];
            ItemEditorWindow editorWindow = new ItemEditorWindow(selectedContract, mCoordinator);
            editorWindow.Show();

        }

        public void NewContractClicked(Object sender, RoutedEventArgs e)
        {
            mViewModel.NewContract();
        }

        public void RefreshItems()
        {

            
            List<Contract> newContracts = mViewModel.GetContractsList(mCoordinator.GetContracts());
            InitializeLists(newContracts);
            contractsList.ItemsSource = mPendingList;
            contractsList.Items.Refresh();

            outstandingList.ItemsSource = mOutstandingList;
            outstandingList.Items.Refresh();
        }

        private List<Contract> ConvertContractDictToList()
        {
            List<Contract> output = new List<Contract>();
            foreach(var item in mContracts)
            {
                Contract contract = new Contract(item.Key);
                output.Add(contract);
            }
            return output;
        }

        private void InitializeLists(List<Contract> allContracts)
        {
            mPendingList = new List<Contract>();
            mOutstandingList = new List<Contract>();
            mCompletedList = new List<Contract>();

            foreach(Contract contract in allContracts)
            {
                if (contract.isPending())
                {
                    mPendingList.Add(contract);
                }
                if (contract.isOutstanding())
                {
                    mOutstandingList.Add(contract);
                }
                if (contract.isCompleted())
                {
                    mCompletedList.Add(contract);
                }
            }

        }

    }
}
