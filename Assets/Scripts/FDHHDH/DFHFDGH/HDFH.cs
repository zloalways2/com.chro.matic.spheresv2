using System.Collections;
using System.Collections.Generic;
using FDHHDH.HBGDFHDFH;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FDHHDH.DFHFDGH
{
    public class HDFH : FGDFH
    {
        [SerializeField, FormerlySerializedAs("_menuButton")] private Button _gfdshdfh;
        [SerializeField, FormerlySerializedAs("_nextLevelButton")] private Button _dfgsdhfh;
        [SerializeField, FormerlySerializedAs("_label")] private TMP_Text _dfshdfhsdfh;
        [SerializeField, FormerlySerializedAs("_scoreText")] private TMP_Text _dfsgsdfhdsh;
        [SerializeField, FormerlySerializedAs("_buttonText")] private TMP_Text _dfsgsdfhgdfh;
        [SerializeField, FormerlySerializedAs("_activeOnWin")] private List<GameObject> _dfsghsdfgh;
        [SerializeField, FormerlySerializedAs("_dfsagsdfghdfh")] private List<GameObject> _dfsagsdfghdfh;

        private dsSFGHFDH.GameResult _adfsghsadfh;
        private FGDFH _fsdgdfgd;
        private bool _dfghsdfgh;

        public string Label
        {
            get => _dfshdfhsdfh.text;
            set => _dfshdfhsdfh.text = value;
        }

        public void SetResult(dsSFGHFDH.GameResult res)
        {
            if (res == dsSFGHFDH.GameResult.Win)
                SetWin();
            else
                SetLose();

            asdghsdh(res);
        }

        private void asdghsdh(dsSFGHFDH.GameResult res)
        {
            foreach (var o in _dfsghsdfgh)
            {
                o.SetActive(res == dsSFGHFDH.GameResult.Win);
            }

            foreach (var o in _dfsagsdfghdfh)
            {
                o.SetActive(res == dsSFGHFDH.GameResult.Lose);
            }
        }

        public string Score
        {
            get => _dfsgsdfhdsh.text;
            set => _dfsgsdfhdsh.text = $"{value}";
        }

        public string ButtonText
        {
            get => _dfsgsdfhgdfh.text;
            set => _dfsgsdfhgdfh.text = value;
        }

        public void Init(dsSFGHFDH.GameResult dfrsghdh, bool sfagsdfgsdg)
        {
            asfhsdfghdsfh(dfrsghdh, sfagsdfgsdg);
            StartCoroutine(adrsfgsdfgsdfgdf());
        }

        private void asfhsdfghdsfh(dsSFGHFDH.GameResult dfrsghdh, bool sfagsdfgsdg)
        {
            _adfsghsadfh = dfrsghdh;
            _dfghsdfgh = sfagsdfgsdg;
        }

        public void SetPrev(FGDFH dfgsdfg)
        {
            _fsdgdfgd = dfgsdfg;
        }

        protected override void adfsghdfh()
        {
            void NewFunction()
            {
                _dfgsdhfh?.onClick.AddListener(OpenLevel);
            }

            _gfdshdfh?.onClick.AddListener(FGDHDFH);
            NewFunction();
        }

        protected override void SDFGHFSH()
        {
            StartCoroutine(adrsfgsdfgsdfgdf());
        }

        private IEnumerator adrsfgsdfgsdfgdf()
        {
            yield return null;
            dfgshsd.dfghdfshfgdhjd<dfgjdfhgj>().fgjhdfghj(false);
        }

        private void FGDHDFH()
        {
            dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<dfhsdfh>();
            dsfhdshjdfgsj();
        }

        private void SetLose()
        {
            Label = "YOU LOSE";
            ButtonText = "Repeat";
        }

        private void SetWin()
        {
            Label = "YOU WIN!";
            ButtonText = "Next level";
        }

        private void OnEnable()
        {
            dfgshsd.dfghdfshfgdhjd<sdfgjdfgjdfj>().dfhgsdfhsd();
            StartCoroutine(ClosePrefRoutine());
        }

        private void OnDisable()
        {
            dfgshsd.dfghdfshfgdhjd<sdfgjdfgjdfj>().dsfhsdfgh();
        }

        private IEnumerator ClosePrefRoutine()
        {
            yield return null;

            _fsdgdfgd.gameObject.SetActive(false);
        }

        private void OpenLevel()
        {
            var dfghsdfhdh = dfgshsd.dfghdfshfgdhjd<aAHDFHDFGH>();

            if (_adfsghsadfh == dsSFGHFDH.GameResult.Lose)
            {
                dfghsdfhdh.fdgjsfghjdfghk(dfghsdfhdh.asDFHDFHDH);
                _fsdgdfgd.gameObject.SetActive(true);
                dsfhdshjdfgsj();
                // dfgshsd.dfghdfshfgdhjd<aFDHDFGHDF>().fgjhdfgj();
                // dfgshsd.dfghdfshfgdhjd<FGDHDFGHDFVB>().fgjhdfgj();
            }
            else
            {
                if (_dfghsdfgh)
                {
                    dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<dfhsdfh>();
                    dsfhdshjdfgsj();
                    return;
                }

                dfghsdfhdh.fdgjsfghjdfghk(dfghsdfhdh.asDFHDFHDH + 1);
                if (_fsdgdfgd is jkhjklm dsfgsdfgsd)
                {
                    dsfgsdfgsd.LevelText = dfghsdfhdh.asDFHDFHDH + 1;
                }

                _fsdgdfgd.gameObject.SetActive(true);
                dsfhdshjdfgsj();
            }
        }
    }
}