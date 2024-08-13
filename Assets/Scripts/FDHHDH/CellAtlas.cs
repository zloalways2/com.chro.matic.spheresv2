using System;
using System.Collections.Generic;
using FDHHDH.ASFDHFD;
using UnityEngine;

namespace FDHHDH
{
    [CreateAssetMenu(fileName = "FDGSDFG", menuName = "Game/CeSDSDFllAtlas")]
    public class CellAtlas : ScriptableObject, ISFGHFDS
    {
        public enum CellType
        {
            One,
            Two,
            Three,
            Four,
            Five,
            None,
            None1
        }

        [Serializable]
        public struct TypeSDFGHFDCeilPair
        {
            public CellType TypeId;
            public int TypeIntId;
            public Sprite Sprite;
        }

        public List<TypeSDFGHFDCeilPair> Atlas;
    }
}