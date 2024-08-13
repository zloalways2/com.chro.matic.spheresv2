using System;
using FDHHDH.ASFDHFD;
using UnityEngine;

namespace FDHHDH
{
    public class aFDHDFGHDF : ISFGHFDS
    {
        private const float DFSHGDFHDF = 1.1f;
        private const int fgdshjdfghdfj = 100;

        private int _dfhsdfgh;

        public int DFHDHDFH => _dfhsdfgh;

        public event Action<int> dfshgbdfghsdfgh;

        public void dfghdsfgh(int dsfghsdfgh)
        {
            int dfsgsdfg = 0;

            if (dsfghsdfgh > 3)
                dfsgsdfg = dsfghsdfgh - 3;

            Doer.Appr();

            _dfhsdfgh += fgdshjdfghdfj +
                      Mathf.RoundToInt(dfsgsdfg * (fgdshjdfghdfj * DFSHGDFHDF));

            dfshgbdfghsdfgh?.Invoke(_dfhsdfgh);
        }

        public void fgjhdfgj()
        {
            Doer.Appr();

            _dfhsdfgh = 0;
            dfshgbdfghsdfgh?.Invoke(_dfhsdfgh);
        }
    }
}