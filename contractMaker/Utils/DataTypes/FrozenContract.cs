using System;
using System.Collections.Generic;
using System.Text;

namespace contractMaker.Utils.DataTypes
{
    public class FrozenContract
    {
        public readonly String mTitle;

        public readonly float mTotalAmount;

        public readonly String mDateCreated;

        public readonly String mDateLastModified;

        private readonly List<ItemEntry> mItemEntries;

        public FrozenContract(Contract contract)
        {
            mTitle =  new string(contract.mTitle);
            mTotalAmount = contract.mTotalAmount;
            mDateCreated = contract.mDateCreated;
            mDateLastModified = contract.mDateLastModified;
            mItemEntries = new List<ItemEntry>();
            foreach(ItemEntry item in contract.GetItemEntries())
            {
                mItemEntries.Add(new ItemEntry(item));
            }
        }

        public List<ItemEntry> GetItemEntries()
        {
            return mItemEntries;
        }

    }
}
