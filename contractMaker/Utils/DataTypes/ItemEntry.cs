using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.RightsManagement;
using System.Text;

namespace contractMaker.Utils.DataTypes
{
    public class ItemEntry
    {

        public float mAmount { get; set; }
       
        public String mTitle { get; set; }

        public String mNotes { get; set; }

        public String mDate { get; set; }

        public ItemEntry()
        {
        }

        public ItemEntry(ItemEntry item)
        {
            mAmount = item.mAmount;
            mTitle = item.mTitle;
            mNotes = item.mNotes;
            mDate = item.mDate;
        }

        public void SaveItem(float amount, String title, String date)
        {
            mAmount = amount;
            mTitle = title;
            mDate = date;
        }
        
        public void SetAmount(float amount)
        {
            mAmount = amount;
        }

        public void SetTitle(String title)
        {
            mTitle = title;
        }

        public void SetDate(String date)
        {
            mDate = date;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ItemEntry;
            if (null == other)
            {
                return base.Equals(obj);
            }
            
            if (this.mAmount != other.mAmount)
            {
                return false;
            }
            if (this.mDate != other.mDate)
            {
                return false;
            }
            if (this.mNotes != other.mNotes)
            {
                return false;
            }
            if (this.mTitle != other.mTitle)
            {
                return false;
            }
            return true;
        }
    }
}
