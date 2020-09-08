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
    }
}
