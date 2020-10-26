using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
    class MyUniqueList
    {
        List<int> list = new List<int>();

        public MyUniqueList()
        {

        }

        public bool Add(int item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            throw new ItemAlreadyExistException();
        }

        public bool Remove(int item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }

            throw new ItemNotFoundException();
        }

        public int Peek(int index)
        {
            if (IsBetween(index, 0, list.Count))
                return list[index];

            throw new IndexOutOfRangeException();
        }

        public int this[int index]
        {
            get
            {
                if (IsBetween(index, 0, list.Count))
                    return this.list[index];

                throw new IndexOutOfRangeException();
            }
            set
            {
                if (!IsBetween(index, 0, list.Count))
                    throw new IndexOutOfRangeException();
                if (list[index] == value)
                    throw new ItemAlreadyExistException();
                if (list.Contains(value))
                    throw new ItemAlreadyExistException();
                list[index] = value;
            }
        }

        private bool IsBetween(int index, int min, int max)
        {
            return min < index && index < max;
        }
    }
}
