using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_LESSONS : ProMng, OpreationProject
    {
        private string _ID_Lessons;
        private string _ID_Courses;
        private string _Lesson_Title;
        private int _Lesson_Order;
        private string _Content;
        private string _Video_URL;
        private string _Material_URL;
        private int _Duration;
        private System.DateTime _Created_At;

        public string ID_Lessons
        {
            get
            {
                return _ID_Lessons;
            }
            set
            {
                _ID_Lessons = value;
            }
        }

        public string ID_Courses
        {
            get => default;
            set
            {
            }
        }

        public string Lesson_Title
        {
            get => default;
            set
            {
            }
        }

        public int Lesson_Order
        {
            get => default;
            set
            {
            }
        }

        public string Content
        {
            get => default;
            set
            {
            }
        }

        public string Video_URL
        {
            get => default;
            set
            {
            }
        }

        public string Material_URL
        {
            get => default;
            set
            {
            }
        }

        public int Duration
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