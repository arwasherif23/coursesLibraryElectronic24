using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_COURSES : ProMng, OpreationProject
    {
        private string _ID_Courses;
        private string _ID_Track;
        private string _Course_Name;
        private string _Description;
        private decimal _Duration_Hours;
        private string _Language;
        private string _Course_Image;
        private bool _Is_Active;
        private System.DateTime _Created_At;

        public string ID_Courses
        {
            get
            {
                return _ID_Courses;
            }
            set
            {
                _ID_Courses = value;
            }
        }

        public string ID_Track
        {
            get => default;
            set
            {
            }
        }

        public string Course_Name
        {
            get => default;
            set
            {
            }
        }

        public string Description
        {
            get => default;
            set
            {
            }
        }

        public decimal Duration_Hours
        {
            get => default;
            set
            {
            }
        }

        public string Language
        {
            get => default;
            set
            {
            }
        }

        public string Course_Image
        {
            get => default;
            set
            {
            }
        }

        public bool Is_Active
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

        public C_LESSONS C_LESSONS
        {
            get => default;
            set
            {
            }
        }

        public C_TRAINING C_TRAINING
        {
            get => default;
            set
            {
            }
        }

        public C_QUIZZES C_QUIZZES
        {
            get => default;
            set
            {
            }
        }

        public C_TACKS C_TACKS
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