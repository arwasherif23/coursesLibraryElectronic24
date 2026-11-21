using System.Data;

namespace CoursesLibraryElectornic
{
    public class C_SUBMISSION : ProMng, OpreationProject
    {
        private string _ID_Submission;
        private string _ID_Task;
        private string _ID_User;
        private System.DateTime _Submission_Date;
        private string _Answer_File_URL;
        private decimal _Score;
        private string _Feedback;
        private string _Status;
        private System.DateTime? _Greaded_At;

        public string ID_Submission
        {
            get
            {
                return _ID_Submission;
            }

            set
            {
                _ID_Submission = value;
            }
        }

        public string ID_Task
        {
            get => default;
            set
            {
            }
        }

        public string ID_User
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Submission_Date
        {
            get => default;
            set
            {
            }
        }

        public string Answer_File_URL
        {
            get => default;
            set
            {
            }
        }

        public decimal Score
        {
            get => default;
            set
            {
            }
        }

        public string Feedback
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

        public System.DateTime? Greaded_At
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