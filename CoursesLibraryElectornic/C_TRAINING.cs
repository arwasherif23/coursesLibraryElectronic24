using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_TRAINING : ProMng, OpreationProject
    {
        private string _ID_Training;
        private string _ID_Courses;
        private string _Training_Name;
        private System.DateTime _Start_Date;
        private System.DateTime _End_Date;
        private int _Capacity;
        private string _Location;
        private string _Training_Type;
        private System.DateTime _Registration_Deadline;
        private string _Status;
        private System.DateTime _Created_At;

        public string ID_Training
        {
            get
            {
                return _ID_Training;
            }
            set
            {
                _ID_Training = value;
            }
        }

        public string ID_Courses
        {
            get => default;
            set
            {
            }
        }

        public string Training_Name
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Start_Date
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime End_Date
        {
            get => default;
            set
            {
            }
        }

        public int Capacity
        {
            get => default;
            set
            {
            }
        }

        public string Location
        {
            get => default;
            set
            {
            }
        }

        public string Training_Type
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Registration_Deadline
        {
            get => default;
            set
            {
            }
        }

        public string Status
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Created_At
        {
            get => default;
            set
            {
            }
        }

        public C_ENROLLMENTS C_ENROLLMENTS
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