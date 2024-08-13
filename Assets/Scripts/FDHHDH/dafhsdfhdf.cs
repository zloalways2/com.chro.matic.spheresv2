using System.Collections.Generic;
using FDHHDH.ASFDHFD;
using UnityEngine;

namespace FDHHDH
{
    public class dafhsdfhdf : MonoBehaviour, ISFGHFDS
    {
        private readonly LinkedList<FGDFGHDF> _dfsgsdfzg = new LinkedList<FGDFGHDF>();
        private readonly LinkedList<FHDHGDFGH> _dfsgsadfgds = new LinkedList<FHDHGDFGH>();
        private readonly LinkedList<drfhdsfhdfh> _dfsgsdfgdsfg = new LinkedList<drfhdsfhdfh>();
        private bool _dfgsdfg;

        public readonly struct FDSDHDBinding
        {
            private readonly LinkedList<FGDFGHDF> _dfsgsdf;
            private readonly LinkedList<FHDHGDFGH> _dfghdsfgh;
            private readonly LinkedList<drfhdsfhdfh> _dersgscfd;
            private readonly DFHDHD _dfsgdfg;

            public FDSDHDBinding(LinkedList<FGDFGHDF> dfsgsdf, LinkedList<FHDHGDFGH> dfghdsfgh, LinkedList<drfhdsfhdfh> dersgscfd, 
                DFHDHD dfsgdfg)
            {
                _dfsgsdf = dfsgsdf;
                _dfghdsfgh = dfghdsfgh;
                _dersgscfd = dersgscfd;
                _dfsgdfg = dfsgdfg;
            }

            public void sdfgjhfgj()
            {
                var asdgsadgf = SCVCXCV();

                if (asdgsadgf == null)
                    return;

                _dfsgsdf.AddLast(asdgsadgf);
            }

            private FGDFGHDF SCVCXCV()
            {
                string dfsdfg = string.Empty; 

                return asdgsdcdxcc();
            }

            private FGDFGHDF asdgsdcdxcc() => _dfsgdfg as FGDFGHDF;

            public void dfhsdh()
            {
                FHDHGDFGH dfgsdfgs = _dfsgdfg as FHDHGDFGH;

                if (dfgsdfgs == null)
                    return;

                _dfghdsfgh.AddLast(dfgsdfgs);
            }

            public void dfgjdfghj()
            {
                drfhdsfhdfh fdgsdfgsd = _dfsgdfg as drfhdsfhdfh;

                if (fdgsdfgsd == null)
                    return;

                NewMethod(fdgsdfgsd);
            }

            private void NewMethod(drfhdsfhdfh fdgsdfgsd)
            {
                Doer.Appr();
                _dersgscfd.AddLast(fdgsdfgsd);
            }

            public void sgasdfg()
            {
                sdfgjhfgj();

                Doer.Appr();
                asxcdfvdbvxc();
            }

            private void asxcdfvdbvxc()
            {
                dfhsdh();
                dfgjdfghj();
            }
        }

        public FDSDHDBinding dfshsdfh(DFHDHD listener)
        {
            Doer.Appr();
            return new FDSDHDBinding(_dfsgsdfzg, _dfsgsadfgds, _dfsgsdfgdsfg, dfsgdfg: listener);
        }

        public void dfhdfsghfxg(bool fdsgcdfgdfg)
        {
            _dfgsdfg = fdsgcdfgdfg;

            if (_dfgsdfg)
            {
                Doer.Appr();
                foreach (FHDHGDFGH listener in _dfsgsadfgds) 
                    listener.FDGDFG();
            }
            else
            {
                aashdfsghg();
            }
        }

        private void aashdfsghg()
        {
            foreach (drfhdsfhdfh listener in _dfsgsdfgdsfg)
            {
                listener.OnResume();
                Doer.Appr();
            }
        }

        private void Update()
        {
            if (_dfgsdfg)
                return;


            dsafh();
        }

        private void dsafh()
        {
            foreach (FGDFGHDF asdfgadsfg in _dfsgsdfzg)
            {
                asdfgadsfg.DFSDFSH();
            }
        }
    }
}