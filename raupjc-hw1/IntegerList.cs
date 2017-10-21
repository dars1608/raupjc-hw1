using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raupjc_hw1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _count;

        public IntegerList()
        {
            _internalStorage = new int[4];
            _count = 0;
        }

        public IntegerList(int initialSize)
        {
            if (initialSize<=0)
            {
                throw new ArgumentException("List can't be resolved. Size can't be negative.");
            }
            else
            {
                _internalStorage = new int[initialSize];
                _count = 0;
            }
        }


        public int Count{
            get
            {
                return _count;
            }
        }

        public void Add(int item)
        {
            if((_count + 1) > _internalStorage.Length)
            {
                int[] temp = new int[_internalStorage.Length * 2];
                Array.Copy(_internalStorage, temp, _internalStorage.Length);
                _internalStorage = temp;
            }
            _internalStorage[_count] = item;
            _count++;
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(int item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                return true;
            }
            return false;
        }

        public int GetElement(int index)
        {
            if(index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            return _internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for(int i = 0; i<_count; i++)
            {
                if (_internalStorage[i] == item)
                    return i;
            }
            return -1;
        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return false;
            }
            return RemoveAt(index);

        }

        public bool RemoveAt(int index)
        {
            if (index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < (_count - 1); i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _count--;
            return true;
        }
    }
}
