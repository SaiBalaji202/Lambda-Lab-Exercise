using System.Collections.Generic;
using System.Linq;

namespace Lamda_Lab1
{
    class Coll
    {
        private List<int> _list;
        private int _incVal;

        public Coll(List<int> _list)
        {
            this._list = _list;
            _INCVAL = 1;
        }

        public int _INCVAL { get; set; }

        public int Find(int value)
        {
            return _list.Find((val) => val.Equals(value));
        }

        public List<int> FetchEven()
        {
            return _list.FindAll((val) => val % 2 == 0);
        }

        public List<int> FetchGreaterThen(int val)
        {
            return _list.Where((value) => value > val).ToList();
        }

        public List<int> FetchLesserThen(int val)
        {
            return _list.Where((value) => value < val).ToList();
        }

        public List<int> MatchWithValue()
        {
            return _list.Where((value) => value == _INCVAL).ToList();
        }

        public List<int> MatchWithValue(int incVal)
        {
            return _list.Where((value) => value == incVal).ToList();
        }

    }
}
