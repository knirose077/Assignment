using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg1
{
    public class Class1
    {

        private int _catid;

        public int CatId
        {
            get { return _catid; }
            set { _catid = value; }
        }

        private string _catname;

        public string CatName
        {
            get { return _catname; }
            set { _catname = value; }
        }

        private string _desc;

        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }
        private List<product> _prodlist;

        public List<product> productList
        {
            get { return _prodlist; }
            set { _prodlist = value; }
        }
    }
}

