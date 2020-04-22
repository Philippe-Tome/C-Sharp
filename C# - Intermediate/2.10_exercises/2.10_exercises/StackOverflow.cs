using System;
using System.Collections.Generic;

namespace _2._10_exercises
{
    public class StackOverflow
    {
        private string _title;
        private string _description;
        private DateTime _timeStamp;
        private int _score;

        public StackOverflow(string title, string description)
        {
            _title = title;
            _description = description;
            _timeStamp = DateTime.Now;
            _score = 0;
        }

        public int UpVote()
        {
            return _score++; 
        }

        public int DownVote()
        {
            if (_score > 0)
                _score--;
            return _score;
        }

        public int GetLikeCounter()
        {
            return _score;
        }

        public string GetTitle()
        {
            return _title;
        }
        public string GetDescription()
        {
            return _description;
        }

        public DateTime GetDateCreated()
        {
            return _timeStamp;
        }
    }
}
