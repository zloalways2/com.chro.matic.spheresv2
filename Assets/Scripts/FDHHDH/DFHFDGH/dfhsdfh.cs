using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FDHHDH.DFHFDGH
{
    public class dfhsdfh : FGDFH
    {
        [SerializeField, FormerlySerializedAs("_levelsLayoutGroup")] private LayoutGroup _dfgsdfgsdf;
        [SerializeField, FormerlySerializedAs("_privacyButton")] private Button _dfgsdfgsdgf;

        private readonly List<Button> _dsfhgsdfhj = new List<Button>();
        private readonly List<TMP_Text> _dsfghdfsh = new List<TMP_Text>();
        private readonly List<TMP_Text> _dsfhsdgfhd = new List<TMP_Text>();

        // private readonly Color _starColor = new Color(172f / 255, 37f / 255, 47f / 255, 1);

        public int OpenLevels => dfgshsd.dfghdfshfgdhjd<SDFGBDFVBV>().Dfsgsdfgd.Count(val => val);

        protected override void adfsghdfh()
        {
            void NewFunction()
            {
                for (int fgsdfgdfg = 0; fgsdfgdfg < _dfgsdfgsdf.transform.childCount; fgsdfgdfg++)
                {
                    asdfgasdgxczbhgd(fgsdfgdfg);
                }
            }

            dfgshsd.dfghdfshfgdhjd<SDFGBDFVBV>().GSDFGfdgdsfgdfg += dfghjsfdgj;
            _dfgsdfgsdgf?.onClick.AddListener(dsfghsdfh);

            NewFunction();

            dfghjsfdgj();
        }

        private void asdfgasdgxczbhgd(int fgsdfgdfg)
        {
            foreach (var fdgsdfxgdfg in _dfgsdfgsdf.transform.GetChild(fgsdfgdfg).GetComponentsInChildren<Button>())
            {
                _dsfhgsdfhj.Add(fdgsdfxgdfg);
                int dfgdasfgdfg = _dsfhgsdfhj.Count - 1;
                fdgsdfxgdfg.onClick.AddListener(() => dfshsdfh(dfgdasfgdfg));

                var dfsagasdgasdg = fdgsdfxgdfg.GetComponentsInChildren<TMP_Text>();
                _dsfghdfsh.Add(dfsagasdgasdg[0]);
                _dsfghdfsh.Last().text = $"{_dsfghdfsh.Count}";
                _dsfhsdgfhd.Add(dfsagasdgasdg[1]);
            }
        }

        protected override void dsfhdshjdfgsj()
        {
            void DSG() => gameObject.SetActive(false);

            dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<dfgjdf>();
            Doer.Appr();

            DSG();
        }

        private void dsfghsdfh()
        {
            fghjsdfghj dfhsdfh = dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<fghjsdfghj>();
            dfhsdfh.Label = dfgshsd.dfghdfshfgdhjd<sdfghsdfghj>().Map
                .First(text => text.TypeId == sdfghsdfghj.TextType.Privacy).Label;
            Doer.Appr();


            adfhdfs(dfhsdfh);

            gameObject.SetActive(false);
        }

        private void adfhdfs(fghjsdfghj dfhsdfh)
        {
            Doer.Appr();
            dfhsdfh.Text = dfgshsd.dfghdfshfgdhjd<sdfghsdfghj>().Map
                .First(text => text.TypeId == sdfghsdfghj.TextType.Privacy).Text;
            dfhsdfh.adsfasdfas(this);
        }

        private void dfghjsfdgj()
        {
            void asdgsdg(int dfgsdfgds)
            {
                if (dfgsdfgds >= OpenLevels)
                {
                    _dsfghdfsh[dfgsdfgds].alpha = 0.5f;
                    _dsfhsdgfhd[dfgsdfgds].alpha = 0.5f;
                }
                else
                {
                    _dsfghdfsh[dfgsdfgds].alpha = 1;
                    _dsfhsdgfhd[dfgsdfgds].alpha = 1;
                }
            }

            for (int dfgsdfgdsfgs = 0; dfgsdfgdsfgs < _dsfhgsdfhj.Count; dfgsdfgdsfgs++)
            {
                _dsfhgsdfhj[dfgsdfgdsfgs].interactable = dfgsdfgdsfgs < OpenLevels;
                asdgsdg(dfgsdfgdsfgs);

                // if (dfgsdfgds < OpenLevels - 1)
                // {
                //     _dsfhsdgfhd[dfgsdfgds].color = _starColor;
                // }
            }
        }

        private void dfshsdfh(int dfgsdfgsdgcxz)
        {
            dfgshsd.dfghdfshfgdhjd<aAHDFHDFGH>().fdgjsfghjdfghk(dfgsdfgsdgcxz);
            jkhjklm jkhjklm = dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<jkhjklm>();
            fdghsdhdfsh(dfgsdfgsdgcxz, jkhjklm);

            gameObject.SetActive(false);
        }

        private static void fdghsdhdfsh(int dfgsdfgsdgcxz, jkhjklm jkhjklm)
        {
            jkhjklm.LevelText = dfgsdfgsdgcxz + 1;
            jkhjklm.dfhsdfgjfgjdf();
        }
    }
}