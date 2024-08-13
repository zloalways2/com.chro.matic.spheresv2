using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FDHHDH.DFHFDGH
{
    public class dfgjdf : FGDFH
    {
        [SerializeField, FormerlySerializedAs("_playButton")] private Button _dfsgf;
        [SerializeField, FormerlySerializedAs("_settingsButton")] private Button _settingsButton;
        [SerializeField] private Button _rulesButton;
        [SerializeField] private Button _privacyButton;

        protected override void adfsghdfh()
        {
            void asdhdfshdsh()
            {
                _rulesButton?.onClick.AddListener(dfhgsdfh);
                _privacyButton?.onClick.AddListener(fdhsdfghd);
            }

            _dfsgf?.onClick.AddListener(dafshsadfhdsfhdsf);
            _settingsButton?.onClick.AddListener(dfasgsdfghf);
            asdhdfshdsh();
        }

        protected override void dsfhdshjdfgsj()
        {
            var dfhsdfhd = dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<fghjdfghj>();
            dfhsdfhd.DFHGDFHDFH(this);
            Doer.Appr();


            dsafghsadfhdsh();
        }

        private void dfasgsdfghf()
        {
            SDCCXVXCGF();
            Doer.Appr();
            dsafghsadfhdsh();
        }

        private void SDCCXVXCGF()
        {
            var dfgsdfgsd = dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<dsfghsdfghjfg>();
            dfgsdfgsd.dsfhdsh(this);
        }

        private void fdhsdfghd()
        {
            fghjsdfghj dfhsdfdsg = dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<fghjsdfghj>();
            asdfhdsafhdfgshfgd(dfhsdfdsg);

            dsafghsadfhdsh();
        }

        private void asdfhdsafhdfgshfgd(fghjsdfghj dfhsdfdsg)
        {
            dfhsdfdsg.Label = dfgshsd.dfghdfshfgdhjd<sdfghsdfghj>().Map
                .First(text => text.TypeId == sdfghsdfghj.TextType.Privacy).Label;
            dfhsdfdsg.Text = dfgshsd.dfghdfshfgdhjd<sdfghsdfghj>().Map
                .First(text => text.TypeId == sdfghsdfghj.TextType.Privacy).Text;
            dfhsdfdsg.adsfasdfas(this);
        }

        private void dfhgsdfh()
        {
            void adfhsdfghj(fghjsdfghj fghjsdfghj)
            {
                fghjsdfghj.Text = dfgshsd.dfghdfshfgdhjd<sdfghsdfghj>().Map.First(text => text.TypeId == sdfghsdfghj.TextType.Rules)
                    .Text;
                fghjsdfghj.adsfasdfas(this);
            }

            fghjsdfghj dfghsddfshsdfgh = dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<fghjsdfghj>();
            dfghsddfshsdfgh.Label = dfgshsd.dfghdfshfgdhjd<sdfghsdfghj>().Map.First(text => text.TypeId == sdfghsdfghj.TextType.Rules).Label;
            adfhsdfghj(dfghsddfshsdfgh);

            dsafghsadfhdsh();
        }

        private void dafshsadfhdsfhdsf()
        {
            dfgshsd.dfghdfshfgdhjd<DFHDHDFHDF>().dsfhdfhdf<dfhsdfh>();
            Doer.Appr();
            dsafghsadfhdsh();
        }

        private void dsafghsadfhdsh()
        {
            Doer.Appr();

            gameObject.SetActive(false);
        }
    }
}