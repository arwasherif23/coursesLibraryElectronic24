using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_QUIZZES : ProMng, OpreationProject
    {
        private string _ID_Quiz;
        private string _ID_Courses;
        private string _Quiz_Name;
        private int _Duration_Minutes;
        private decimal _Pass_Score;
        private decimal _Total_Score;
        private int _Max_Attempts;
        private System.DateTime _Available_Form;
        private System.DateTime _Available_Until;
        private bool _Ia_Active;
        private System.DateTime _Created_At;

        public string ID_Quiz
        {
            get
            {
                return _ID_Quiz;
            }

            set
            {
                _ID_Quiz = value;
            }
        }

        public string ID_Courses
        {
            get => default;
            set
            {
            }
        }

        public string Quiz_Name
        {
            get => default;
            set
            {
            }
        }

        public int Duration_Minutes
        {
            get => default;
            set
            {
            }
        }

        public decimal Pass_Score
        {
            get => default;
            set
            {
            }
        }

        public decimal Total_Score
        {
            get => default;
            set
            {
            }
        }

        public int Max_Attempts
        {
            get => default;
            set
            {
            }
        }

        public DateTime Available_Form
        {
            get => default;
            set
            {
            }
        }

        public DateTime Available_Until
        {
            get => default;
            set
            {
            }
        }

        public bool Ia_Active
        {
            get => default;
            set
            {
            }
        }

        public DateTime Created_At
        {
            get => default;
            set
            {
            }
        }

        public C_RESULTS C_RESULTS
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