using contractMaker.Coordinators;
using contractMaker.Test.TestClasses;
using contractMaker.Utils;
using contractMaker.Utils.DataTypes;
using contractMaker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace contractMaker.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ItemEditorWindow : Window
    {
        private ItemEditorViewModel mViewModel;
        private Contract mContract;
        private List<ItemEntry> mItemEntries;
        private ContractMakerCoordinator mCoordinator;

        public ItemEditorWindow(Contract contract, ContractMakerCoordinator coordinator)
        {
            mContract = contract;
            mCoordinator = coordinator;
            mViewModel = new ItemEditorViewModel(mCoordinator);
            mItemEntries = mContract.GetItemEntries();
            if (mItemEntries.Count() == 0)
            {
                mItemEntries.Add(new ItemEntry());
            }
            InitializeComponent();

            Binding headerBinding = new Binding();
            headerBinding.Source = mContract;
            BindingOperations.SetBinding(Header, TextBox.TextProperty, headerBinding);
            // totalAmountText.Text = mContract.GetTotalAmount().ToString();
            titleText.Text = mContract.getTitle();
            itemList.ItemsSource = mItemEntries;
        }

        private void SaveButtonClicked(object sender, RoutedEventArgs e)
        {
            mContract.SetItemEntries(mItemEntries);
            mViewModel.SaveButtonClicked(mContract, mCoordinator.GetContracts());
        }

        public void NewItemButtonClicked(object sender, RoutedEventArgs e)
        {
            mItemEntries.Add(new ItemEntry());
            this.itemList.Items.Refresh();
        }

        public void DeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext;
            int index = this.itemList.Items.IndexOf(item);
            mItemEntries.RemoveAt(index);
            this.itemList.Items.Refresh();
        }

        public void UpdateTotal(object sender, RoutedEventArgs e)
        {
            mContract.mTotalAmount = 0;
            foreach (var item in itemList.Items)
            {
               ItemEntry thisItem = (ItemEntry)item;
                float amount = thisItem.mAmount;
                mContract.mTotalAmount += amount;
            }
            float total = mContract.mTotalAmount;
            totalAmountText.Text = total.ToString();
        }
    }
}
