using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    //11. Iterator tasarım deseni koleksiyonlar üzerinde gezinmeyi kolaylaştır
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    public class MyList<T> : IIterator<T>
    {
        private List<T> items;
        private int position;

        public MyList(List<T> items)
        {
            this.items = items;
            position = 0;
        }

        public bool HasNext()
        {
            return position < items.Count;
        }

        public T Next()
        {
            T currentItem = items[position];
            position++;
            return currentItem;
        }
    }

}
