using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class MyList<T> : Collection<T>
    {
        //Get Count Items
        public new int Count
        {
            get { return this.Items.Count; }
        }

        //Add 
        public new void Add(T item)
        {
            //items.Add(item); 
            base.Add(item);
        }

        //Get Value by index
        public T GetValue(int item)
        {
            return this.ElementAt<T>(item);
        }

        //Remove Item by index
        public new void RemoveItem(int index)
        {
            //items.RemoveAt(index);
            this.RemoveItem(index);
        }

        //GetArray
        //public void GetArray<T>()
        //{

        //}
    }
}
