using contractMaker.Utils.DataTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace contractMaker.Utils.DataTypes
{
    public class Contract
    {
        
        public String mTitle { get; set; }
        
        public float mTotalAmount { get; set; }
       
        public String mDateCreated { get; set; }
        
        public String mDateLastModified { get; set; }

        [JsonProperty]
        private List<ItemEntry> mItemEntries;

        public Contract(String title)
        {
            mTitle = title;
            mTotalAmount = 0;
            mDateCreated = DateTime.Now.ToString("MM/dd/yyyy");
            mDateLastModified = DateTime.Now.ToString("MM/dd/yyyy");
            mItemEntries = new List<ItemEntry>();
        }
        public void SetTotal(float amount)
        {
            mTotalAmount = amount;
        }
        public void SetItemEntries(List<ItemEntry> itemEntries)
        {
            mItemEntries = itemEntries;
        }

        public List<ItemEntry> GetItemEntries()
        {
            return mItemEntries;
        }

        public void AddItemEntry(String date, String title, float amount)
        {
            ItemEntry newItem = new ItemEntry();
            newItem.SaveItem(amount, title, date);
            mItemEntries.Add(newItem);
        }

        public float GetTotalAmount()
        {
            return mTotalAmount;
        }

        public String getTitle()
        {
            return mTitle;
        }
    }
}
