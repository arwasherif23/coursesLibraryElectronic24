using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_SYSTEMPREMISSION : ProMng, OpreationProject
    {
        private string _ID_Prem;
        private string _ID_PremName;

        public string ID_Prem
        {
            get
            {
                return _ID_Prem;
            }

            set
            {
                _ID_Prem = value;
            }
        }

        public string ID_PremName
        {
            get => default;
            set
            {
            }
        }

        public string AddData()
        {
            throw new NotImplementedException();
        }

        public string DeleteData()
        {
            throw new NotImplementedException();
        }

        public DataTable SearshData()
        {
            throw new NotImplementedException();
        }

        public string UpdateData()
        {
            throw new NotImplementedException();
        }
    }
}