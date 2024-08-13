using System.Collections.Generic;
using FDHHDH.ASFDHFD;
using UnityEngine;

namespace FDHHDH
{
    public class GFDDSFGDVNDBN : ISFGHFDS
    {
        private const int dfsgasdfgsdfg = 5;

        private readonly drsfhdfgsjhfghjdf _dfgsdfg;
        private readonly List<drsfhdfgsjhfghjdf> dfghdfshsdfh = new List<drsfhdfgsjhfghjdf>();

        public GFDDSFGDVNDBN(drsfhdfgsjhfghjdf dfgsdfg)
        {
            _dfgsdfg = dfgsdfg;
            for (int i = 0; i < dfsgasdfgsdfg; i++)
            {
                drsfhdfgsjhfghjdf dfgsdfghsdh = Object.Instantiate(dfgsdfg);
                dfgsdfghsdh.gameObject.SetActive(false);

                dfghdfshsdfh.Add(dfgsdfghsdh);
            }
        }

        public void dfgshsfdgh(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf)
        {
            drsfhdfgsjhfghjdf.Type = CellAtlas.CellType.None;
            fdsgdasfgd(drsfhdfgsjhfghjdf);
        }

        private static void fdsgdasfgd(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf)
        {
            drsfhdfgsjhfghjdf.gameObject.SetActive(false);
            drsfhdfgsjhfghjdf.Position = Vector2Int.one * -10;
        }

        public drsfhdfgsjhfghjdf fghsdzfhdfh()
        {
            if (dfghdfshsdfh.Count == 0)
                return Object.Instantiate(_dfgsdfg);

            var dfsgdsfgsdf = asdgcdx();

            return dfsgdsfgsdf;
        }

        private drsfhdfgsjhfghjdf asdgcdx()
        {
            Doer.Appr();

            drsfhdfgsjhfghjdf dfsgdsfgsdf = dfghdfshsdfh[0];
            dfghdfshsdfh.RemoveAt(0);
            dfsgdsfgsdf.gameObject.SetActive(true);
            return dfsgdsfgsdf;
        }
    }
}