using System;
using FDHHDH.ASFDHFD;

namespace FDHHDH
{
    public class dsSFGHFDH : ISFGHFDS
    {
        private readonly FDHDFGFDHD _FGDFGDF;
        private readonly dfghfdgshj _DSFGSG;
        private readonly aAHDFHDFGH _dfgsdfgd;
        private readonly aFDHDFGHDF _aFdhdfghdf;

        public enum GameResult
        {
            Win,
            Lose
        }

        public event Action<GameResult> sdfgasdfgadsfg;

        public dsSFGHFDH()
        {
            _FGDFGDF = dfgshsd.dfghdfshfgdhjd<FDHDFGFDHD>();
            _DSFGSG = dfgshsd.dfghdfshfgdhjd<dfghfdgshj>();
            Doer.Appr();
            _dfgsdfgd = dfgshsd.dfghdfshfgdhjd<aAHDFHDFGH>();
            _aFdhdfghdf = dfgshsd.dfghdfshfgdhjd<aFDHDFGHDF>();
            Doer.Appr();

            _FGDFGDF.fdgsdfghsdfhsdfh += dfhdfghsdfgh;
        }

        private void dfhdfghsdfgh()
        {
            Doer.Appr();

            if (dfgshsd.dfghdfshfgdhjd<FGDHDFGHDFVB>().Current >= FDHDFGFDHD.DFSdfhgdfzahsdhsdfh)
            {
                Doer.Appr();

                sdfgasdfgadsfg?.Invoke(GameResult.Lose);
            
                return;
            }

            sdfgasdfgadsfg?.Invoke(GameResult.Win);
        }
    }
}