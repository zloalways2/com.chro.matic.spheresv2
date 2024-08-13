using System;
using FDHHDH.ASFDHFD;
using UnityEngine;

namespace FDHHDH.HBGDFHDFH
{
    public class sdfgjdfgjdfj : FGDFGHDF
    {
        private bool _dfghsdfh;
        public event Action<drsfhdfgsjhfghjdf> DFGHHDFH;
        public event Action GFDSGDFGHDG;

        void FGDFGHDF.DFSDFSH() => asdfhgadsfh();

        private void asdfhgadsfh()
        {
            void asdfhdfgsgfbv()
            {
                dghsdfgj();
            }

            if (_dfghsdfh)
                return;

            asdfhdfgsgfbv();
        }

        public void dfhgsdfhsd()
        {
            _dfghsdfh = true;
            Doer.Appr();
        }

        public void dsfhsdfgh()
        {
            _dfghsdfh = false;

            Doer.Appr();

            Doer.Appr();
        }

        private void dghsdfgj()
        {
            void asdfgadfshdf(RaycastHit2D dfsgsdfgdf)
            {
                if (dfsgsdfgdf.collider != null && dfsgsdfgdf.collider.TryGetComponent<drsfhdfgsjhfghjdf>(out drsfhdfgsjhfghjdf cell))
                {
                    DFGHHDFH?.Invoke(cell);
                }
                else
                {
                    GFDSGDFGHDG?.Invoke();

                    Doer.Appr();
                }
            }

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),  Camera.main.ScreenToWorldPoint(Input.mousePosition), Mathf.Infinity);

                asdfgadfshdf(hit);
            }
        }
    }
}