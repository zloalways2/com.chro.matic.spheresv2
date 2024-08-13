using UnityEngine;
using UnityEngine.Serialization;

namespace FDHHDH
{
    public class drsfhdfgsjhfghjdf : MonoBehaviour
    {
        [SerializeField, FormerlySerializedAs("_backgroundRenderer")] private SpriteRenderer _dfshdfgsj;
        [SerializeField, FormerlySerializedAs("_iconRenderer")] private SpriteRenderer _dfhsdgfhdfh;

        private CellAtlas.CellType _type;

        public CellAtlas.CellType Type
        {
            get => _type;
            set
            {
                void NewFunction()
                {
                    var adsfgdsagsdfg = dfgshsd.dfghdfshfgdhjd<CellAtlas>();
                    Doer.Appr();
                    _dfhsdgfhdfh.sprite = adsfgdsagsdfg.Atlas[(int)value].Sprite;
                    _type = value;
                }


                NewFunction();
            }
        }

        public Vector2Int Position { get; set; }

        public SpriteRenderer BackgroundRenderer => _dfshdfgsj;
        public SpriteRenderer Dfhsdgfhdfh => _dfhsdgfhdfh;
    }
}