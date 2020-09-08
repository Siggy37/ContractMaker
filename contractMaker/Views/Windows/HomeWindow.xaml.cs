﻿using contractMaker.Coordinators;
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
        public HomeWindow()
        {
            mCoordinator = new ContractMakerCoordinator();
            mCoordinator.SetHomeWindow(this);
            mContracts = mCoordinator.GetContracts();
            mViewModel = new HomeWindowViewModel(mCoordinator);
            mContractsList = mViewModel.GetContractsList(mContracts);
            
            InitializeComponent();

            contractsList.ItemsSource = mContractsList;
        }

        public void ShowEditerWindow(Object sender, RoutedEventArgs e)
        {
            mViewModel.ShowEditerWindow(new Contract("Test Contract"));
        }

        public void LaunchEditerWindow(Object sender, RoutedEventArgs e)
        {
            //int index = contractsList.Items.IndexOf(e.Source);
            //var t = contractsList.Items.SourceCollection;
            //Contract selectedContract = mContractsList[index];
            //mViewModel.ShowEditerWindow(selectedContract);
            
        }

        public void NewContractClicked(Object sender, RoutedEventArgs e)
        {
            mViewModel.NewContract();
        }

        public void RefreshItems()
        {
            contractsList.ItemsSource = mViewModel.GetContractsList(mCoordinator.GetContracts());
            contractsList.Items.Refresh();
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

    }
}
