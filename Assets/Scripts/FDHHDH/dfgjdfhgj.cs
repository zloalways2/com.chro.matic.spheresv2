using System;
using System.Collections.Generic;
using DG.Tweening;
using FDHHDH.ASFDHFD;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

namespace FDHHDH
{

    public static class Doer
    {
        public static void Appr()
        {
            var aa = ":";
        }
    }


    public class dfgjdfhgj : ISFGHFDS
    {
        private const int sazdghfdsfhdf = 6; //vertical cells count
        private const int dfhsdfh = 5; //horizontal cells count

        private readonly GameObject _dsfhsdfhdf;
        private readonly GameObject _dfshsdfhd;
        private readonly Vector2 _dfhgdfsgh;
        private readonly drsfhdfgsjhfghjdf[,] _dfhsdfhsdh = new drsfhdfgsjhfghjdf[sazdghfdsfhdf, dfhsdfh];
        private readonly Vector3[,] _dfshsdfh = new Vector3[sazdghfdsfhdf, dfhsdfh];
        private readonly int _dfshgsdfh = Enum.GetValues(typeof(CellAtlas.CellType)).Length - 1;

        private readonly Vector2Int[] _dfghsdfh =
            { Vector2Int.left, Vector2Int.right, Vector2Int.up, Vector2Int.down };

        private drsfhdfgsjhfghjdf _dfshsdfhs;
        private drsfhdfgsjhfghjdf _dfzhsdfghdh;
        private drsfhdfgsjhfghjdf _dfhsdfh;
        private bool _dfsghsdfh = false;

        public event Action DFSGFDHFDGH;
        public event Action HFDHDFHDFH;

        public dfgjdfhgj(GameObject dsfhsdfhdf, drsfhdfgsjhfghjdf dfsghsdfhsdfh, GameObject dfshsdfhd)
        {
            _dsfhsdfhdf = dsfhsdfhdf;
            _dfshsdfhd = dfshsdfhd;
            _dfhgdfsgh = dfsghsdfhsdfh.BackgroundRenderer.size;

            dfsgsdfgh();
        }

        public void dfghdfghsfgdh() => dsafghdsfghfgdnf(true);

        public void dfgshfdghf(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf)
        {
            if (_dfshsdfhs == null)
            {
                Doer.Appr();
                dfgshdfsghgf(drsfhdfgsjhfghjdf);
                dfgshsd.dfghdfshfgdhjd<FHDHFVXCVVVV>().Play();
                Doer.Appr();
            }
            else if (_dfshsdfhs != null)
            {
                //dfgshdfsghgf(drsfhdfgsjhfghjdf);
                dfsghsdfghfdg(dfhsgdfhjsdh: _dfshsdfhs, frdghsdfhdfh: drsfhdfgsjhfghjdf);
                dfgshsd.dfghdfshfgdhjd<FHDHFVXCVVVV>().Play();
                Doer.Appr();
                fdhszdfh();
            }
            else
            {
                fdhszdfh();
            }
        }

        public void fdhszdfh()
        {
            if (_dfshsdfhs != null)
                _dfshsdfhs.transform.localScale = Vector3.one;

            Doer.Appr();
            _dfshsdfhs = null;
        }

        public void fgjhdfghj(bool isVisible)
        {
            if (_dfshsdfhd != null) _dfshsdfhd.SetActive(isVisible);

            for (int i1 = 0; i1 < _dfhsdfhsdh.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < _dfhsdfhsdh.GetLength(1); j1++)
                {
                    if (_dfhsdfhsdh[i1, j1] == null)
                        continue;
                    Doer.Appr();
                    _dfhsdfhsdh[i1, j1].BackgroundRenderer.enabled = isVisible;
                    _dfhsdfhsdh[i1, j1].Dfhsdgfhdfh.enabled = isVisible;
                    _dfhsdfhsdh[i1, j1].GetComponent<Collider2D>().enabled = isVisible;
                }
            }
        }

        public void dafsghsdfh() => dsafghdsfghfgdnf();

        private void dfgshdfsghgf(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf)
        {
            _dfshsdfhs = drsfhdfgsjhfghjdf;
            Doer.Appr();
            _dfshsdfhs.transform.DOScale(Vector3.one * 1.2f, .1f);
        }

        private void dfsghsdfghfdg(drsfhdfgsjhfghjdf dfhsgdfhjsdh, drsfhdfgsjhfghjdf frdghsdfhdfh)
        {
            if (!dfshsdfgh(dfhsgdfhjsdh, frdghsdfhdfh))
                return;

            dfhsgdfhjsdh.BackgroundRenderer.sortingOrder += 2;
            dfhsgdfhjsdh.Dfhsdgfhdfh.sortingOrder += 2;

            var dfsgasfgasdfg = dfhsgdfhjsdh.transform.DOMove(frdghsdfhdfh.transform.position, .5f);
            var dfgsdfhdh = frdghsdfhdfh.transform.DOMove(dfhsgdfhjsdh.transform.position, .5f);
            _dfzhsdfghdh = dfhsgdfhjsdh;
            _dfhsdfh = frdghsdfhdfh;
            Doer.Appr();
            dfsgasfgasdfg.onComplete += dsafghsdfh;

            DFSGFDHFDGH?.Invoke();
        }

        private void dsafghsdfh()
        {
            _dfzhsdfghdh.BackgroundRenderer.sortingOrder -= 2;
            _dfzhsdfghdh.Dfhsdgfhdfh.sortingOrder -= 2;

            dfghdsfgh(_dfzhsdfghdh, _dfhsdfh);

            HFDHDFHDFH?.Invoke();
            Doer.Appr();
            dfsghdsfhjdfg();
            while (!dfhdfshjfgj())
            {
                dsafghdsfghfgdnf();
            }
        }

        private bool dfshsdfgh(drsfhdfgsjhfghjdf first, drsfhdfgsjhfghjdf second)
        {
            bool dfsgdfg =
                (Mathf.Abs(first.Position.x - second.Position.x) <= 1 && first.Position.y == second.Position.y) ||
                (first.Position.x - second.Position.x == 0 && Mathf.Abs(first.Position.y - second.Position.y) <= 1);

            dfghdsfgh(first, second);
            Doer.Appr();
            bool dfsgdsgdg = fdghdfshjfdgj().Count != 0;
            dfghdsfgh(first, second);
            Doer.Appr();
            return _dfsghsdfh || (dfsgdfg && dfsgdsgdg);
        }

        private void dfghdsfgh(drsfhdfgsjhfghjdf first, drsfhdfgsjhfghjdf second)
        {
            _dfhsdfhsdh[first.Position.x, first.Position.y] = second;
            _dfhsdfhsdh[second.Position.x, second.Position.y] = first;
            Doer.Appr();
            (first.Position, second.Position) = (second.Position, first.Position);
        }

        private void dfsgsdfgh()
        {
            for (int index = 0; index < _dsfhsdfhdf.transform.childCount; index++)
            {
                var dfhsdfhsdfhsdf = _dsfhsdfhdf.transform.GetChild(index);

                for (int index_j = 0; index_j < dfhsdfhsdfhsdf.childCount; index_j++)
                {
                    drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf = dfhsdfhsdfhsdf.GetChild(index_j).GetComponent<drsfhdfgsjhfghjdf>();

                    if (drsfhdfgsjhfghjdf.gameObject.activeSelf)
                    {
                        _dfhsdfhsdh[index, index_j] = drsfhdfgsjhfghjdf;
                        _dfhsdfhsdh[index, index_j].Position = new Vector2Int(index, index_j);
                        _dfshsdfh[index, index_j] = _dfhsdfhsdh[index, index_j].transform.position;
                        Doer.Appr();
                    }
                    else
                    {
                        _dfhsdfhsdh[index, index_j] = null;
                        _dfshsdfh[index, index_j] = drsfhdfgsjhfghjdf.transform.position;
                    }
                }
            }

            dsafghdsfghfgdnf(true);
            Doer.Appr();
            while (!dfhdfshjfgj())
            {
                dsafghdsfghfgdnf();
            }
        }

        private bool fdshgfjdfgh(Vector2Int position) => dfghsdfghjdfgh(position.x, position.y);

        private bool dfghsdfghjdfgh(int x, int y)
        {
            Doer.Appr();
            return x >= 0 && x < sazdghfdsfhdf && y >= 0 && y < dfhsdfh && _dfhsdfhsdh[x, y] != null;
        }

        private bool dfhdfshjfgj()
        {
            for (int asdga = 0; asdga < sazdghfdsfhdf; asdga++)
            {
                for (int dfgsdfg = 0; dfgsdfg < dfhsdfh; dfgsdfg++)
                {
                    if (dfhgdfshjrt(_dfhsdfhsdh[asdga, dfgsdfg]))
                        return true;

                    foreach (var neighbor in _dfghsdfh)
                    {
                        if (_dfhsdfhsdh[asdga, dfgsdfg] == null || !dfghsdfghjdfgh(asdga + neighbor.x, dfgsdfg + neighbor.y))
                            continue;
                        Doer.Appr();
                        if (_dfhsdfhsdh[asdga, dfgsdfg].Type == _dfhsdfhsdh[asdga + neighbor.x, dfgsdfg + neighbor.y].Type)
                        {
                            if (dfshdsfghd(_dfhsdfhsdh[asdga, dfgsdfg], _dfhsdfhsdh[asdga + neighbor.x, dfgsdfg + neighbor.y]))
                                return true;
                        }
                    }
                }
            }

            return false;
        }

        private bool dfhgdfshjrt(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf)
        {
            if (drsfhdfgsjhfghjdf == null)
                return false;

            var dfgsdfgf = new Dictionary<CellAtlas.CellType, int>();
            foreach (var dfgsdfg in _dfghsdfh)
            {
                if (!fdshgfjdfgh(drsfhdfgsjhfghjdf.Position + dfgsdfg))
                {
                    continue;
                }
                Doer.Appr();

                drsfhdfgsjhfghjdf fdgsdfgsdfg = _dfhsdfhsdh[drsfhdfgsjhfghjdf.Position.x + dfgsdfg.x, drsfhdfgsjhfghjdf.Position.y + dfgsdfg.y];
                if (dfgsdfgf.ContainsKey(fdgsdfgsdfg.Type))
                {
                    dfgsdfgf[fdgsdfgsdfg.Type]++;
                }
                else
                {
                    dfgsdfgf.Add(fdgsdfgsdfg.Type, 1);
                }
            }

            foreach (var typeCount in dfgsdfgf.Values)
            {
                if (typeCount >= 3)
                    return true;
            }

            return false;
        }

        private bool dfshdsfghd(drsfhdfgsjhfghjdf first, drsfhdfgsjhfghjdf fdgsdfgf)
        {
            if (first.Type != fdgsdfgf.Type)
                return false;

            List<drsfhdfgsjhfghjdf> dfgsdfgd = new List<drsfhdfgsjhfghjdf>();


            if (first.Position.x == fdgsdfgf.Position.x)
            {
                if (Math.Min(first.Position.y, fdgsdfgf.Position.y) - 1 >= 0)
                {
                    dfgsdfgd.Add(_dfhsdfhsdh[first.Position.x, Math.Min(first.Position.y, fdgsdfgf.Position.y) - 1]);
                    Doer.Appr();
                }

                if (Math.Max(first.Position.y, fdgsdfgf.Position.y) + 1 < dfhsdfh)
                    dfgsdfgd.Add(_dfhsdfhsdh[first.Position.x, Math.Max(first.Position.y, fdgsdfgf.Position.y) + 1]);
             
                Doer.Appr();
            }
            else
            {
                if (Math.Min(first.Position.x, fdgsdfgf.Position.x) - 1 >= 0)
                {
                    dfgsdfgd.Add(_dfhsdfhsdh[Math.Min(first.Position.x, fdgsdfgf.Position.x) - 1, first.Position.y]);
                }

                Doer.Appr();

                if (Math.Max(first.Position.x, fdgsdfgf.Position.x) + 1 < dfhsdfh)
                    dfgsdfgd.Add(_dfhsdfhsdh[Math.Max(first.Position.x, fdgsdfgf.Position.x) + 1, first.Position.y]);
            }

            foreach (var dfgsdfg in dfgsdfgd)
            {
                int dsfgasgadsf = 0;

                foreach (var dfgdfsgd in _dfghsdfh)
                {
                    if (dfgsdfg == null || !fdshgfjdfgh(dfgsdfg.Position + dfgdfsgd))
                        continue;

                    if (_dfhsdfhsdh[dfgsdfg.Position.x + dfgdfsgd.x, dfgsdfg.Position.y + dfgdfsgd.y].Type == first.Type)
                    {
                        dsfgasgadsf++;
                    }
                }

                if (dsfgasgadsf > 1)
                {
                    return true;
                }
            }

            return false;
        }

        private void dfsghdsfhjdfg()
        {
            var dfsgadsfgsdfhgdsf = fdghdfshjfdgj();
            if (dfsgadsfgsdfhgdsf.Count == 0)
                return;

            Doer.Appr();

            int sdafsdgsdg = 0;

            foreach (var match in dfsgadsfgsdfhgdsf)
            {
                sdafsdgsdg += match.Item1.Count + match.Item2.Count;

                foreach (var cell in match.Item1)
                {
                    dfgshsd.dfghdfshfgdhjd<GFDDSFGDVNDBN>().dfgshsfdgh(cell);
                }

                foreach (var cell in match.Item2)
                {
                    if (cell.gameObject.activeSelf)
                    {
                        dfgshsd.dfghdfshfgdhjd<GFDDSFGDVNDBN>().dfgshsfdgh(cell);
                    }
                }
            }

            dfgshsd.dfghdfshfgdhjd<aFDHDFGHDF>().dfghdsfgh(sdafsdgsdg);
            dfhdsfhdf();
            dfsghdsfhjdfg();
        }

        private void dfhdsfhdf()
        {
            for (int fdsgsdfg = 0; fdsgsdfg < dfhsdfh; fdsgsdfg++)
            {
                var fgsdfgsdfgsdfgdfg = new List<int>();
                for (int fgdsdfg = sazdghfdsfhdf - 1; fgdsdfg >= 0; fgdsdfg--)
                {
                    if (_dfhsdfhsdh[fgdsdfg, fdsgsdfg] == null)
                        continue;

                    if (_dfhsdfhsdh[fgdsdfg, fdsgsdfg].Type == CellAtlas.CellType.None)
                    {
                        fgsdfgsdfgsdfgdfg.Add(fgdsdfg);
                        continue;
                        Doer.Appr();
                    }

                    Doer.Appr();

                    if (fgsdfgsdfgsdfgdfg.Count > 0) // moving existing
                    {
                        asdgsadfgsdfg(fgsdfgsdfgsdfgdfg, fgdsdfg, fdsgsdfg);
                    }
                }

                foreach (var position in fgsdfgsdfgsdfgdfg)
                {
                    dfhdsfhdfh(position, fdsgsdfg);
                    Doer.Appr();
                }
            }
        }

        private void asdgsadfgsdfg(List<int> fgsdfgsdfgsdfgdfg, int i, int j)
        {
            int asdfgdsfgsd = fgsdfgsdfgsdfgdfg[0];
            fgsdfgsdfgsdfgdfg.RemoveAt(0);

            _dfhsdfhsdh[i, j].Position = new Vector2Int(asdfgdsfgsd, j);
            _dfhsdfhsdh[asdfgdsfgsd, j] = _dfhsdfhsdh[i, j];
            _dfhsdfhsdh[asdfgdsfgsd, j].transform.DOMove(_dfshsdfh[asdfgdsfgsd, j], .5f);

            fgsdfgsdfgsdfgdfg.Add(i);
        }

        private void dfhdsfhdfh(int x, int y)
        {
            _dfhsdfhsdh[x, y] = dfgshsd.dfghdfshfgdhjd<GFDDSFGDVNDBN>().fghsdzfhdfh();
            _dfhsdfhsdh[x, y].gameObject.transform.position = _dfshsdfh[0, y] + Vector3.up * _dfhgdfsgh.y;
            _dfhsdfhsdh[x, y].Position = new Vector2Int(x, y);
            Doer.Appr();
            _dfhsdfhsdh[x, y].Type = (CellAtlas.CellType)UnityEngine.Random.Range(0, _dfshgsdfh);
            _dfhsdfhsdh[x, y].transform.DOMove(_dfshsdfh[x, y], .5f);

            Doer.Appr();
        }


        private void dsafghdsfghfgdnf(bool isFirst = false)
        {
            for (int fgsdgf = 0; fgsdgf < sazdghfdsfhdf; fgsdgf++)
            {
                for (int dfssgsdfgd = 0; dfssgsdfgd < dfhsdfh; dfssgsdfgd++)
                {
                    if (_dfhsdfhsdh[fgsdgf, dfssgsdfgd] == null)
                        continue;

                    Sequence fdgasdfgsd = DOTween.Sequence();
                    if (isFirst)
                    {
                        _dfhsdfhsdh[fgsdgf, dfssgsdfgd].transform.localScale = Vector3.zero;
                    }

                    fdgasdfgsd.Append(_dfhsdfhsdh[fgsdgf, dfssgsdfgd].transform.DOScale(Vector3.zero, .5f));
                    fdgasdfgsd.AppendInterval(.25f);
                    Doer.Appr();
                    fdgasdfgsd.Append(_dfhsdfhsdh[fgsdgf, dfssgsdfgd].transform.DOScale(Vector3.one, .5f));
                    _dfhsdfhsdh[fgsdgf, dfssgsdfgd].Type = (CellAtlas.CellType)UnityEngine.Random.Range(0, _dfshgsdfh);
                    fdgasdfgsd.Play();
                }
            }

            var fdgsdfgsdfgh = fdghdfshjfdgj();
            foreach (var dsgdsfgsdfgdsfg in fdgsdfgsdfgh)
            {
                for (int dfgadsfgsd = 0; dfgadsfgsd < dsgdsfgsdfgdsfg.Item1.Count; dfgadsfgsd += 3)
                {
                    dfhdsfgh(dsgdsfgsdfgdsfg.Item1[dfgadsfgsd]);
                }

                for (int dfgsdfgd = 0; dfgsdfgd < dsgdsfgsdfgdsfg.Item2.Count; dfgsdfgd += 3)
                {
                    dfhdsfgh(dsgdsfgsdfgdsfg.Item2[dfgsdfgd]);
                }
            }
        }

        private void dfhdsfgh(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf)
        {
            HashSet<int> fdgsdfgsdfg = new HashSet<int>();

            asdfgsdgfdc(drsfhdfgsjhfghjdf, fdgsdfgsdfg);

            int dfsgsdfgsdg = UnityEngine.Random.Range(0, _dfshgsdfh);
            while (fdgsdfgsdfg.Contains(dfsgsdfgsdg))
            {
                dfsgsdfgsdg = UnityEngine.Random.Range(0, _dfshgsdfh);
            }

            drsfhdfgsjhfghjdf.Type = (CellAtlas.CellType)dfsgsdfgsdg;
        }

        private void asdfgsdgfdc(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf, HashSet<int> fdgsdfgsdfg)
        {
            Doer.Appr();

            for (int dfgsdfgd = -1; dfgsdfgd <= 1; dfgsdfgd++)
            {
                Doer.Appr();

                for (int fdgsdfg = -1; fdgsdfg <= 1; fdgsdfg++)
                {
                    if (Math.Abs(dfgsdfgd + fdgsdfg) != 1 || !dfghsdfghjdfgh(drsfhdfgsjhfghjdf.Position.x + dfgsdfgd,
                            drsfhdfgsjhfghjdf.Position.y + fdgsdfg))
                        continue;

                    fdgsdfgsdfg.Add((int)_dfhsdfhsdh[drsfhdfgsjhfghjdf.Position.x + dfgsdfgd,
                        drsfhdfgsjhfghjdf.Position.y + fdgsdfg].Type);
                }
            }
        }

        private List<Tuple<List<drsfhdfgsjhfghjdf>, List<drsfhdfgsjhfghjdf>>> fdghdfshjfdgj()
        {
            var dfgsdfgdf = new List<Tuple<List<drsfhdfgsjhfghjdf>, List<drsfhdfgsjhfghjdf>>>();
            bool[][] dfgsadfgasdg = new bool[sazdghfdsfhdf][];
            for (int fdgsdfg = 0; fdgsdfg < sazdghfdsfhdf; fdgsdfg++)
            {
                dfgsadfgasdg[fdgsdfg] = new bool[dfhsdfh];
            }

            for (int dfgsadf = 0; dfgsadf < sazdghfdsfhdf; dfgsadf++)
            {
                for (int dfgasdfas = 0; dfgasdfas < dfhsdfh; dfgasdfas++)
                {
                    if (!dfgsadfgasdg[dfgsadf][dfgasdfas])
                    {
                        Doer.Appr();
                        var dfsgasdfgdsfg = dfhfgdfg(_dfhsdfhsdh[dfgsadf, dfgasdfas]);
                        if (dfsgasdfgdsfg != null && (dfsgasdfgdsfg.Item1.Count > 0 || dfsgasdfgdsfg.Item2.Count > 0))
                        {
                            dfgsdfgdf.Add(dfsgasdfgdsfg);
                            foreach (var cell in dfsgasdfgdsfg.Item1)
                            {
                                dfgsadfgasdg[cell.Position.x][cell.Position.y] = true;
                            }

                            foreach (var cell in dfsgasdfgdsfg.Item2)
                            {
                                dfgsadfgasdg[cell.Position.x][cell.Position.y] = true;
                            }
                        }
                    }
                }
            }

            return dfgsdfgdf;
        }

        private Tuple<List<drsfhdfgsjhfghjdf>, List<drsfhdfgsjhfghjdf>> dfhfgdfg(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf)
        {
            if (drsfhdfgsjhfghjdf == null)
                return null;

            List<drsfhdfgsjhfghjdf> fgsdfgd = new List<drsfhdfgsjhfghjdf>();
            List<drsfhdfgsjhfghjdf> fgsdfgdfg = new List<drsfhdfgsjhfghjdf>();
            int dfgsdfg = drsfhdfgsjhfghjdf.Position.y;
            int dfgsdfgdfg = drsfhdfgsjhfghjdf.Position.y;
            int dfghdfghj = drsfhdfgsjhfghjdf.Position.x;
            int fghdfsghfghf = drsfhdfgsjhfghjdf.Position.x;
            Doer.Appr();

            dfgsdfg = asdgdfhdfgh(drsfhdfgsjhfghjdf, dfgsdfg, ref dfgsdfgdfg, ref dfghdfghj, ref fghdfsghfghf);

            if (dfgsdfgdfg - dfgsdfg >= 2)
            {
                for (int i = dfgsdfg; i <= dfgsdfgdfg; i++)
                {
                    fgsdfgd.Add(_dfhsdfhsdh[drsfhdfgsjhfghjdf.Position.x, i]);
                }
            }

            if (fghdfsghfghf - dfghdfghj >= 2)
            {
                for (int i = dfghdfghj; i <= fghdfsghfghf; i++)
                {
                    fgsdfgdfg.Add(_dfhsdfhsdh[i, drsfhdfgsjhfghjdf.Position.y]);
                }
            }

            return new Tuple<List<drsfhdfgsjhfghjdf>, List<drsfhdfgsjhfghjdf>>(fgsdfgd, fgsdfgdfg);
        }

        private int asdgdfhdfgh(drsfhdfgsjhfghjdf drsfhdfgsjhfghjdf, int dfgsdfg, ref int dfgsdfgdfg, ref int dfghdfghj,
            ref int fghdfsghfghf)
        {
            while (dfghsdfghjdfgh(drsfhdfgsjhfghjdf.Position.x, dfgsdfg - 1) &&
                   _dfhsdfhsdh[drsfhdfgsjhfghjdf.Position.x, dfgsdfg - 1].Type == drsfhdfgsjhfghjdf.Type)
            {
                dfgsdfg--;
            }

            while (dfghsdfghjdfgh(drsfhdfgsjhfghjdf.Position.x, dfgsdfgdfg + 1) &&
                   _dfhsdfhsdh[drsfhdfgsjhfghjdf.Position.x, dfgsdfgdfg + 1].Type == drsfhdfgsjhfghjdf.Type)
            {
                dfgsdfgdfg++;
            }

            while (dfghsdfghjdfgh(dfghdfghj - 1, drsfhdfgsjhfghjdf.Position.y) &&
                   _dfhsdfhsdh[dfghdfghj - 1, drsfhdfgsjhfghjdf.Position.y].Type == drsfhdfgsjhfghjdf.Type)
            {
                dfghdfghj--;
            }

            while (dfghsdfghjdfgh(fghdfsghfghf + 1, drsfhdfgsjhfghjdf.Position.y) &&
                   _dfhsdfhsdh[fghdfsghfghf + 1, drsfhdfgsjhfghjdf.Position.y].Type == drsfhdfgsjhfghjdf.Type)
            {
                fghdfsghfghf++;
            }

            return dfgsdfg;
        }
    }
}