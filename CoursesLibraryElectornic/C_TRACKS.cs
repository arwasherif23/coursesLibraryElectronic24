using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_TRACKS : ProMng, OpreationProject
    {
        private string _ID_Tracks;
        private string _Track_Name;
        private string _Description;
        private string _Level;
        private int _Estimated_Duration;
        private bool _Is_Active;
        private string _Track_Image;

        public string ID_Tracks
        {
            get
            {
                return _ID_Tracks;
            }
            set
            {
                _ID_Tracks = value;
            }
        }

        public string Track_Name
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

        public string Level
        {
            get => default;
            set
            {
            }
        }

        public int Estimated_Duration
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

        public string Track_Image
        {
            get => default;
            set
            {
            }
        }

        public C_COURSES C_COURSES
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