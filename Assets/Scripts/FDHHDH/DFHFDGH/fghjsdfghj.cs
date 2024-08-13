using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace FDHHDH.DFHFDGH
{
    public class fghjsdfghj : FGDFH
    {
        [SerializeField, FormerlySerializedAs("_text")] private TMP_Text _fgdgsdfg;
        [SerializeField, FormerlySerializedAs("_label")] private TMP_Text _adsfghdfsh;
        
        private FGDFH _dfsghbsdfh;

        public string Text
        {
            get { return _fgdgsdfg.text; }
            set { _fgdgsdfg.text = value; }
        }

        public string Label
        {
            get { return _adsfghdfsh.text; }
            set { _adsfghdfsh.text = value; }
        }

        public void adsfasdfas(FGDFH dfsgdfsghh)
        {
            _dfsghbsdfh = dfsgdfsghh;
            Doer.Appr();
        }

        protected override void dsfhdshjdfgsj()
        {
            asghadfghd();
            Doer.Appr();
            base.dsfhdshjdfgsj();
        }

        private void asghadfghd()
        {
            _dfsghbsdfh.gameObject.SetActive(true);
            asdfhgdsfghfgdsb();
        }

        private void asdfhgdsfghfgdsb()
        {
            if (_dfsghbsdfh is jkhjklm dfgsdfh)
            {
                dfgsdfh.dfhsdfghsd();
            }
        }
    }
}