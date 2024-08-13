using System;
using System.Collections.Generic;
using FDHHDH.ASFDHFD;

namespace FDHHDH
{
    public static class dfgshsd
    {
        private static Dictionary<Type, ISFGHFDS> _dfghsdfhdfhdfh = new Dictionary<Type, ISFGHFDS>();

        public static void sdgsdfghbdfsh<T>(T service) where T : class, ISFGHFDS
        {
            if (_dfghsdfhdfhdfh.ContainsKey(typeof(T)))
                return;

            adsfhdfgshd(service);
        }

        private static void adsfhdfgshd<T>(T service) where T : class, ISFGHFDS
        {
            _dfghsdfhdfhdfh[typeof(T)] = service;
        }

        public static T dfghdfshfgdhjd<T>() where T : class, ISFGHFDS
        {
            return _dfghsdfhdfhdfh.ContainsKey(typeof(T)) ? (T)_dfghsdfhdfhdfh[typeof(T)] : null;
        }
    }
}