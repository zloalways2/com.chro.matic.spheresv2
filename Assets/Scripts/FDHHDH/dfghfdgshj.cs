using System;
using System.Collections.Generic;
using FDHHDH.ASFDHFD;
using UnityEngine;

namespace FDHHDH
{
    [Serializable]
    public struct TargetScoreDFHDGFHDF
    {
        public CellAtlas.CellType Key;
        public int Score;
    }

    [CreateAssetMenu(fileName = "dfghfdgshj", menuName = "Game/SDFDS")]
    public class dfghfdgshj : ScriptableObject, ISFGHFDS
    {

        [Serializable]
        public struct LevelDFHDFScorePair
        {
            public int LevelId;
            public int LevelidSec;
            public int Score;
        }

        public List<LevelDFHDFScorePair> Map;
    }
}