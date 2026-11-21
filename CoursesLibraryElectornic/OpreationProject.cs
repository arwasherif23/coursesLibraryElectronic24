using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace CoursesLibraryElectornic
{
    public interface OpreationProject
    {
        string AddData();
        string DeleteData();
        string UpdateData();
        DataTable SearshData();
    }
}