using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace b8c217db_ede2_4676_857c_1ec01327e1b3
{
    public class Class1
    {
        public string Nom
        {
            get;
            set;
        }
    }

    public class Manager
    {
        public void Insert(string nom)
        {

        }

        public void Update(string nom)
        {

        }

        public Class1[] GetManager()
        {
            return new Class1[]
            {
                new Class1() { Nom = "Toto" },
                new Class1() { Nom = "Prout" },
            };
        }
    }
}