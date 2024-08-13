using System;
using FDHHDH.ASFDHFD;
using FDHHDH.DFHFDGH;

namespace FDHHDH
{
    public class SDFGBDFVBV : ISFGHFDS
    {
        private readonly dfghfdgshj _fgsdfxcgconstraints;
        private readonly aAHDFHDFGH _fdgsdfg;
        private readonly dsSFGHFDH _dfgsdfg;
        private readonly DFHDHDFHDF _dfgsdfgd;
        private readonly aFDHDFGHDF _aFdhdfghdf;
        private bool[] _dfsgsdfgd;

        public bool[] Dfsgsdfgd => _dfsgsdfgd;
        public event Action GSDFGfdgdsfgdfg;

        public SDFGBDFVBV()
        {
            _fgsdfxcgconstraints = dfgshsd.dfghdfshfgdhjd<dfghfdgshj>();
            _fdgsdfg = dfgshsd.dfghdfshfgdhjd<aAHDFHDFGH>();
            _dfgsdfg = dfgshsd.dfghdfshfgdhjd<dsSFGHFDH>();
            _dfgsdfgd = dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>();
            _aFdhdfghdf = dfgshsd.dfghdfshfgdhjd<aFDHDFGHDF>();
            _dfsgsdfgd = new bool[_fgsdfxcgconstraints.Map.Count];
            _dfsgsdfgd[0] = true;

            _dfgsdfg.sdfgasdfgadsfg += dfsghsdfgh;
        }

        private void dfsghsdfgh(dsSFGHFDH.GameResult result)
        {
            dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>().fgjhdfghj(false);
            HDFH dfsgdfgd = _dfgsdfgd.dsfhdfhdf<HDFH>();
            dfsgdfgd.SetPrev(_dfgsdfgd.dsfhdfhdf<jkhjklm>());
            dfsgdfgd.SetResult(result);

            if (result == dsSFGHFDH.GameResult.Win)
            {
                if (_fdgsdfg.asDFHDFHDH + 1 >= _fgsdfxcgconstraints.Map.Count)
                {
                    dfsgdfgd.ButtonText = "To level menu";
                    dfsgdfgd.Init(dsSFGHFDH.GameResult.Win, true);
                }
                else
                {
                    dfsgdfgd.Init(dsSFGHFDH.GameResult.Win, false);
                    _dfsgsdfgd[_fdgsdfg.asDFHDFHDH + 1] = true;
                    GSDFGfdgdsfgdfg?.Invoke();
                }

                dfsgdfgd.Score = _aFdhdfghdf.DFHDHDFH.ToString();
                return;
            }

            dfsgdfgd.Init(dsSFGHFDH.GameResult.Lose, false);
        }
    }
}