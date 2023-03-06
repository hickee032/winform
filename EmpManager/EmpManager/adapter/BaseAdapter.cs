using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform1219.dao;

namespace winform1219.adapter
{
    internal class BaseAdapter
    {
        DaoOra ora;

        public BaseAdapter() 
        { 
            ora = new DaoOra();
        }

        public DaoOra Ora { get => ora; set => ora = value; }
    }
}
