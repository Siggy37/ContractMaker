using contractMaker.Utils.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace contractMaker.Test.TestClasses
{
    class TestItemEntry
    {
        private int mTestAmount = 10;
        private String mTestTitle = "Test Entry";
        private String mTestDate = "2020-09-03";
        public ItemEntry mItem;
        
        public TestItemEntry()
        {
            mItem = new ItemEntry();
            mItem.SetAmount(mTestAmount);
            mItem.SetTitle(mTestTitle);
            mItem.SetDate(mTestDate);
        }

        public ItemEntry ToItemEntry()
        {
            return mItem;
        }

    }
}
