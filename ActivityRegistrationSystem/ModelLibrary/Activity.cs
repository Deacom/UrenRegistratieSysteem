﻿using System;
using System.Collections.Generic;

namespace ModelLibrary
{
    public class Activity
    {
        public Activity()
        {
            this.Sources = new HashSet<Source.Source>();
        }

        #region Fields
        private int _id;
        private string _name;
        private DateTime _date;
        private int _minutes;

        private ICollection<Source.Source> _sources;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }

            set
            {
                _minutes = value;
            }
        }

        public virtual ICollection<Source.Source> Sources
        {
            get
            {
                return _sources;
            }

            set
            {
                _sources = value;
            }
        }
        #endregion
    }
}