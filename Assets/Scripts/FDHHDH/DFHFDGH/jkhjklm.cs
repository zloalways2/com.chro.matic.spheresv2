using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FDHHDH.DFHFDGH
{
    public class jkhjklm : FGDFH
    {
        [SerializeField, FormerlySerializedAs("_pauseButton")] private Button _fdghsdgfhjdfh;
        [SerializeField, FormerlySerializedAs("_settingsButton")]private Button _fdghsdffdgsdgf;
        [SerializeField, FormerlySerializedAs("_rulesButton")]private Button _dasdf;
        [SerializeField, FormerlySerializedAs("_scoreText")]private TMP_Text _dfsgsdfgsdg;
        [SerializeField, FormerlySerializedAs("_timeText")]private TMP_Text _dfsgafdsgfd;
        [SerializeField, FormerlySerializedAs("_levelText")] private TMP_Text _dfsgadfgdsg;

        private aFDHDFGHDF _aFdhdfghdf;
        private FGDHDFGHDFVB _fgdhdfghdfvb;
        private dfghfdgshj _dfgsdfg;
        private aAHDFHDFGH _dafsghsdfh;
        private bool _dafghsdfh;

        public bool IsPaused
        {
            get { return _dafghsdfh; }
            private set
            {
                dfgshsd.dfghdfshfgdhjd<dafhsdfhdf>().dfhdfsghfxg(fdsgcdfgdfg: value);
                _dafghsdfh = value;
            }
        }

        public int LevelText
        {
            set
            {
                if (_dfsgadfgdsg != null) _dfsgadfgdsg.text = $"level {value}";
            }
        }

        public float Time
        {
            set
            {
                int adfsgsdfg = (int)value / 60;
                int dfgsdff = Mathf.Clamp((int)value % 60, 0, 59);

                asdfhdfhgdfsgh(dfgsdff, adfsgsdfg);
            }
        }

        private void asdfhdfhgdfsgh(int dfgsdff, int adfsgsdfg)
        {
            if (dfgsdff < 10)
                _dfsgafdsgfd.text = $"{adfsgsdfg}:0{dfgsdff}";
            else
                _dfsgafdsgfd.text = $"{adfsgsdfg}:{dfgsdff}";
        }

        public int Score
        {
            set
            {
                int neededScore = _dfgsdfg.Map.First(pair => pair.LevelId.Equals(_dafsghsdfh.asDFHDFHDH)).Score;
                _dfsgsdfgsdg.text = $"{value}/{neededScore}";
            }
        }

        public void dfhsdfghsd()
        {
            IsPaused = false;
            dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>().fgjhdfghj(true);
        }

        protected override void adfsghdfh()
        {
            base.adfsghdfh();
            _fdghsdffdgsdgf?.onClick.AddListener(dfshsdfhdfh);
            asdfghdfshfgdshg();
        }

        private void asdfghdfshfgdshg()
        {
            _fdghsdgfhjdfh?.onClick.AddListener(dsfhdfsgjhfgj);
            _dasdf?.onClick.AddListener(dfgshsdfgjfdgj);
            _aFdhdfghdf = dfgshsd.dfghdfshfgdhjd<aFDHDFGHDF>();
            _fgdhdfghdfvb = dfgshsd.dfghdfshfgdhjd<FGDHDFGHDFVB>();
            _aFdhdfghdf.dfshgbdfghsdfgh += SetAFdhdfghdf;
            _dfgsdfg = dfgshsd.dfghdfshfgdhjd<dfghfdgshj>();
            _dafsghsdfh = dfgshsd.dfghdfshfgdhjd<aAHDFHDFGH>();
            Score = 0;
        }

        protected override void dfshdfsh()
        {
            base.dfshdfsh();

            Time = _fgdhdfghdfvb.Current;
        }

        protected override void dsfhdshjdfgsj()
        {
            dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<dfhsdfh>();
            dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>().fgjhdfghj(false);

            gameObject.SetActive(false);
        }

        private void dsfhdfsgjhfgj()
        {
            IsPaused = true;

            dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<fgsdhsfgh>();
            dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>().fgjhdfghj(false);

            SADCCC();
        }

        private void dfshsdfhdfh()
        {
            IsPaused = true;

            asfhdsfghdfgh();

            gameObject.SetActive(false);
        }

        private void asfhdsfghdfgh()
        {
            dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<dsfghsdfghjfg>();
            dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dfhsdfhhyf<dsfghsdfghjfg>().dsfhdsh(this);
            dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>().fgjhdfghj(false);
        }

        private void SADCCC()
        {
            dfhdss();
        }

        private void dfhdss() => gameObject.SetActive(false);

        private void dfgshsdfgjfdgj()
        {
            IsPaused = true;

            asfhdsfh();

            dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>().fgjhdfghj(false);
            gameObject.SetActive(false);
        }

        private void asfhdsfh()
        {
            var dfszhdfgh = dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<fghjsdfghj>();
            dfszhdfgh.Label = dfgshsd.dfghdfshfgdhjd<sdfghsdfghj>().Map
                .First(text => text.TypeId == sdfghsdfghj.TextType.Rules).Label;
            dfszhdfgh.Text = dfgshsd.dfghdfshfgdhjd<sdfghsdfghj>().Map
                .First(text => text.TypeId == sdfghsdfghj.TextType.Rules).Text;
            dfszhdfgh.adsfasdfas(this);
        }

        private void SetAFdhdfghdf(int val)
        {
            Score = val;
        }
    }
}