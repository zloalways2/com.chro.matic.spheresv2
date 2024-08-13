using FDHHDH.ASFDHFD;
using UnityEngine;

namespace FDHHDH
{
    public class SDFGDFGFFGG : ISFGHFDS
    {
        protected readonly AudioSource SDFGFSDGFSD;
        private readonly float _SDFGVSCXVX;

        public float Volume
        {
            get { return SXCVCX(); }
            set
            {
                SDFGFSDGFSD.volume = value * _SDFGVSCXVX;
            }
        }

        private float SXCVCX() => SDFGFSDGFSD.volume / _SDFGVSCXVX;

        public SDFGDFGFFGG(AudioSource sdfgfsdgfsd)
        {
            SDFGFSDGFSD = sdfgfsdgfsd;
            _SDFGVSCXVX = SDFGFSDGFSD.volume;
        }
    }
}