using contractMaker.Utils.DataTypes;
using contractMaker.ViewModels;
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
using System.Windows.Shell;

namespace contractMaker.Views.PopUpWindows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class NewContractPopUpWindow : Window
    {
        private Contract mContract;
        private HomeWindowViewModel mViewModel;
        public NewContractPopUpWindow(HomeWindowViewModel viewModel)
        {
            mViewModel = viewModel;
            mContract = new Contract(null);
            InitializeComponent();
            titleEntry.DataContext = mContract;
        }

        public void CreateButtonClicked(Object sender, RoutedEventArgs e)
        {
            mViewModel.PopUpSaveButtonClicked(mContract);
            this.Close();
        }

        public void CancelButtonClicked(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public Contract GetContract()
        {
            return mContract;
        }
    }
}
