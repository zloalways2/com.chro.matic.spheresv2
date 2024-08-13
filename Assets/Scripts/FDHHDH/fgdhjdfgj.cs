using System.Collections.Generic;
using FDHHDH.HBGDFHDFH;
using FDHHDH.DFHFDGH;
using UnityEngine;
using UnityEngine.Serialization;

namespace FDHHDH
{
    [DefaultExecutionOrder(-10000)]
    public class fgdhjdfgj : MonoBehaviour
    {
        [SerializeField, FormerlySerializedAs("_ui")] private List<FGDFH> _dfgsdfg;
        [SerializeField, FormerlySerializedAs("_canvas")] private Canvas _dfgsdfgds;
        [SerializeField, FormerlySerializedAs("_fieldParent")] private GameObject _fdfsgsdfg;
        [SerializeField, FormerlySerializedAs("_fieldBg")] private GameObject _dfsgsdfgds;
        [SerializeField, FormerlySerializedAs("_drsfhdfgsjhfghjdfReference")] private drsfhdfgsjhfghjdf _drsfhdfgsjhfghjdfReference;
        [SerializeField, FormerlySerializedAs("_cellAtlas")] private CellAtlas _fdgsdfg;
        [SerializeField, FormerlySerializedAs("_sdfghsdfghj")] private sdfghsdfghj _sdfghsdfghj;
        [SerializeField, FormerlySerializedAs("_levelConstraints")] private dfghfdgshj _sdfgasdfgdf;
        [SerializeField, FormerlySerializedAs("_sound")] private AudioSource _dfsgadsfgz;
        [SerializeField, FormerlySerializedAs("_clickSound")] private AudioSource _dfsagadsfxg;

        private dafhsdfhdf _dafhsdfhdf;


        public StatusCode Status => CurrentStatus.AA();

        private void Awake()
        {
            _dafhsdfhdf = GetComponent<dafhsdfhdf>();

            Fhsfgdhdfhsdfh();
        }

        private void Start()
        {
            //dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<dfgjdf>();
            dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<fghdfgj>();

            Doer.Appr();
            dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>().fgjhdfghj(false);
        }

        private void Fhsfgdhdfhsdfh()
        {
            dfgshsd.sdgsdfghbdfsh<CellAtlas>(_fdgsdfg);
            dfgshsd.sdgsdfghbdfsh<sdfghsdfghj>(_sdfghsdfghj);

            afhsdfgh();

            Doer.Appr();

            dfgshsd.sdgsdfghbdfsh<aFDHDFGHDF>(new aFDHDFGHDF());
            dfgshsd.sdgsdfghbdfsh<FGDHDFGHDFVB>(new FGDHDFGHDFVB());
            Doer.Appr();
            var dfshgdfhsdfhsd = new aAHDFHDFGH();
            dfgshsd.sdgsdfghbdfsh<aAHDFHDFGH>(dfshgdfhsdfhsd);
            dfgshsd.sdgsdfghbdfsh<FDHDFGFDHD>(new FDHDFGFDHD(dfshgdfhsdfhsd));
            dfshgdfhsdfhsd.fdgjdfghkjdgh(dfgshsd.dfghdfshfgdhjd<FDHDFGFDHD>());
            Doer.Appr();
            DGSSGDS();

            _dafhsdfhdf.dfshsdfh(dfgshsd.dfghdfshfgdhjd<FGDHDFGHDFVB>()).sdfgjhfgj();
            _dafhsdfhdf.dfshsdfh(dfgshsd.dfghdfshfgdhjd<sdfgjdfgjdfj>()).sdfgjhfgj();
            _dafhsdfhdf.dfshsdfh(dfgshsd.dfghdfshfgdhjd<FDHDFGFDHD>()).sdfgjhfgj();
        }

        private void afhsdfgh()
        {
            Doer.Appr();
            dfgshsd.sdgsdfghbdfsh<dfghfdgshj>(_sdfgasdfgdf);
            dfgshsd.sdgsdfghbdfsh<dafhsdfhdf>(_dafhsdfhdf);
            dfgshsd.sdgsdfghbdfsh<dfgjdfhgj>(new dfgjdfhgj(_fdfsgsdfg, _drsfhdfgsjhfghjdfReference, _dfsgsdfgds));
            dfgshsd.sdgsdfghbdfsh<sdfgjdfgjdfj>(new sdfgjdfgjdfj());
            dfgshsd.sdgsdfghbdfsh<GFDGHDFNH>(new GFDGHDFNH());
            Doer.Appr();
        }

        private void DGSSGDS()
        {
            dfgshsd.sdgsdfghbdfsh<GFDDSFGDVNDBN>(new GFDDSFGDVNDBN(_drsfhdfgsjhfghjdfReference));
            dfgshsd.sdgsdfghbdfsh<DFHDHDFHDF>(new DFHDHDFHDF(_dfgsdfg, _dfgsdfgds));
            dfgshsd.sdgsdfghbdfsh<dsSFGHFDH>(new dsSFGHFDH());
            dfgshsd.sdgsdfghbdfsh<SDFGBDFVBV>(new SDFGBDFVBV());

            Doer.Appr();
            dfgshsd.sdgsdfghbdfsh<SDFGDFGFFGG>(new SDFGDFGFFGG(_dfsgadsfgz));
            dfgshsd.sdgsdfghbdfsh<FHDHFVXCVVVV>(new FHDHFVXCVVVV(_dfsagadsfxg));
        }
    }
}