using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheCashier
{
    internal class Calculator
    {
        private List<Item> listItem;
        private double total = 0;

        public Calculator()
        {
            this.listItem = new List<Item>();
        }
        public void addItem(Item Item)
        {
            this.listItem.Add(Item);
            this.total += Item.getSubTotal();
        }
        public double getTotal()
        {
            return total;
        }

        public List<Item> getListItem()
        {
            return listItem;
        }
    }
}
