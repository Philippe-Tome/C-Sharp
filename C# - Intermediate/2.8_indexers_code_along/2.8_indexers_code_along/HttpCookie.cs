using System;
using System.Collections.Generic;

namespace _2._8_indexers_code_along
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get 
            {
                return _dictionary[key];
            }
            set  
            {
                _dictionary[key] = value;
            }
        }
    }
}
