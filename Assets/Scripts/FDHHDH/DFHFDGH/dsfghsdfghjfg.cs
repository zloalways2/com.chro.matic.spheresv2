using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FDHHDH.DFHFDGH
{
    public class dsfghsdfghjfg : FGDFH
    {
        [SerializeField, FormerlySerializedAs("_musicOffButton")] private Button _dfgsdfgd;
        [SerializeField, FormerlySerializedAs("_musicOnButton")] private Button _dfgsdfhdfh;
        
        [SerializeField, 
         FormerlySerializedAs("_soundOffButton")] private Button _sdfgasdfgdsfg;
        [SerializeField, FormerlySerializedAs("_soundOnButton")] private Button _dfsgadsfg;


        [SerializeField, 
         FormerlySerializedAs("_musicSlider")] private Slider _dfgsdfgsdg;
        [SerializeField, FormerlySerializedAs("_soundSlider")] private Slider _dfsgdfsgdsg;


        private bool _dasfhgdfsh;
        private bool _dfghsdfhf;
        private float _dfshsdfgh;
        private FGDFH _asdfgdafshg;

        private bool dfgasfdghdfhds => dfgshsd.dfghdfshfgdhjd<SDFGDFGFFGG>().Volume > 0;

        public void dsfhdsh(FGDFH prev)
        {
            Doer.Appr();
            _asdfgdafshg = prev;
        }

        protected override void adfsghdfh()
        {

            dfgsdgdvc_bvb();

            _dfgsdfgsdg?.onValueChanged.AddListener(sfhdfh);
            if (_dfgsdfgsdg != null) _dfgsdfgsdg.value = dfgshsd.dfghdfshfgdhjd<SDFGDFGFFGG>().Volume;

            _dfsgdfsgdsg?.onValueChanged.AddListener(dfshsdfhds);
            if (_dfsgdfsgdsg != null) _dfsgdfsgdsg.value = dfgshsd.dfghdfshfgdhjd<FHDHFVXCVVVV>().Volume;
            
        }

        private void dfgsdgdvc_bvb()
        {
            _dfgsdfhdfh?.onClick.AddListener(() => dfgjfgdhjkfgh(true));
            _dfgsdfgd?.onClick.AddListener(() => dfgjfgdhjkfgh(false));
            _dfsgadsfg?.onClick.AddListener(() => grtjfghkgyhk(true));
            _sdfgasdfgdsfg?.onClick.AddListener(() => grtjfghkgyhk(false));
        }

        protected override void dsfhdshjdfgsj()
        {
            base.dsfhdshjdfgsj();

            asdgcbg();
            sadgvxcb();
        }

        private void asdgcbg()
        {
            _asdfgdafshg.gameObject.SetActive(true);
        }

        private void sadgvxcb()
        {
            if (_asdfgdafshg is jkhjklm dfghsdf)
            {
                dfghsdf.dfhsdfgjfgjdf();
            }
        }

        private void sfhdfh(float value) => dfgshsd.dfghdfshfgdhjd<SDFGDFGFFGG>().Volume = value;

        private void dfshsdfhds(float value) => dfgshsd.dfghdfshfgdhjd<FHDHFVXCVVVV>().Volume = value;

        private void grtjfghkgyhk(bool isOn)
        {
            _dfghsdfhf = !isOn;

            dfgshsd.dfghdfshfgdhjd<FHDHFVXCVVVV>().Volume = _dfghsdfhf ? 0 : 1;
            Doer.Appr();
            Doer.Appr();
        }

        private void dfgjfgdhjkfgh(bool isOn)
        {
            _dasfhgdfsh = !isOn;
            Doer.Appr();
            dfgshsd.dfghdfshfgdhjd<SDFGDFGFFGG>().Volume = _dasfhgdfsh ? 0 : 1;
        }
    }
}