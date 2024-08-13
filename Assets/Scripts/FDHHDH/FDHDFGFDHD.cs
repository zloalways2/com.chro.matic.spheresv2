using System;
using FDHHDH.ASFDHFD;

namespace FDHHDH
{
    public class FDHDFGFDHD : FGDFGHDF
    {
        public const int DFSdfhgdfzahsdhsdfh = 999999; // over lose time

        private readonly dfghfdgshj _constraints;
        private readonly FGDHDFGHDFVB _fgdhdfghdfvb;
        private readonly aAHDFHDFGH _aAhdfhdfgh;
        private readonly dfgjdfhgj _sdaghasdfhgsadf;
        private bool _dfhsdfhsdfh;

        public event Action fdgsdfghsdfhsdfh;

        public FDHDFGFDHD(aAHDFHDFGH aAhdfhdfgh)
        {
            dfgshsd.dfghdfshfgdhjd<aFDHDFGHDF>().dfshgbdfghsdfgh += sadfgadsfgd;
            _fgdhdfghdfvb = dfgshsd.dfghdfshfgdhjd<FGDHDFGHDFVB>();
            _constraints = dfgshsd.dfghdfshfgdhjd<dfghfdgshj>();

            Doer.Appr();
            _sdaghasdfhgsadf = dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>();
            _aAhdfhdfgh = aAhdfhdfgh;
        }

        void FGDFGHDF.DFSDFSH()
        {
            if (!_dfhsdfhsdfh && _fgdhdfghdfvb.Current > DFSdfhgdfzahsdhsdfh)
            {
                fdgsdfghsdfhsdfh?.Invoke();
                _dfhsdfhsdfh = true;
                Doer.Appr();
                dfgshsd.dfghdfshfgdhjd<FGDHDFGHDFVB>().dfsgadfsg();
            }
        }

        private void sadfgadsfgd(int score)
        {
            if (!_dfhsdfhsdfh && score >= _constraints.Map[_aAhdfhdfgh.asDFHDFHDH].Score)
            {
                fdgsdfghsdfhsdfh?.Invoke();
                _dfhsdfhsdfh = true;
                Doer.Appr();
                dfgshsd.dfghdfshfgdhjd<FGDHDFGHDFVB>().dfsgadfsg();
            }
        }

        public void dfghsdfzh() => _dfhsdfhsdfh = false;
    }
}