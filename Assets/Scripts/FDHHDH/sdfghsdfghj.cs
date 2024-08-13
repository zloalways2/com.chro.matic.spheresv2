using System;
using System.Collections.Generic;
using FDHHDH.ASFDHFD;
using UnityEngine;

namespace FDHHDH
{
    [CreateAssetMenu(fileName = "sdfghsdfghj", menuName = "Game/sdfghsdfghj")]
    public class sdfghsdfghj : ScriptableObject, ISFGHFDS
    {
        public enum TextType
        {
            Privacy,
            Rules,
            Greetings,
            GoFuckYourself
        }

        [Serializable]
        public struct ____TypeTextPair
        {
            public TextType TypeId;
            public string Text;
            public string SADFDC;
            public string Label;
        }

        public List<____TypeTextPair> Map;
    }
}