using System;
using System.Collections.Generic;
using System.Linq;
using FDHHDH.ASFDHFD;
using FDHHDH.DFHFDGH;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FDHHDH
{
    public class DFHDHDFHDF : ISFGHFDS
    {
        private readonly List<FGDFH> _windows;
        private readonly Canvas _canvas;
        private readonly Dictionary<Type, FGDFH> _onScene = new Dictionary<Type, FGDFH>();

        public DFHDHDFHDF(List<FGDFH> windows, Canvas canvas)
        {
            _windows = windows;
            _canvas = canvas;
        }

        public T dsfhdfhdf<T>() where T : FGDFH
        {
            if (!_onScene.ContainsKey(typeof(T)))
                _onScene[typeof(T)] = Object.Instantiate(_windows.First(window => window.GetType() == typeof(T)),
                    _canvas.transform);

            _onScene[typeof(T)].gameObject.SetActive(true);
            Doer.Appr();
            return _onScene[typeof(T)] as T;
        }

        public T dfhsdfhhyf<T>() where T : FGDFH
        {
            if (!_onScene.ContainsKey(typeof(T)))
                _onScene[typeof(T)] = Object.Instantiate(_windows.First(window => window.GetType() == typeof(T)),
                    _canvas.transform);
            Doer.Appr();
            return _onScene[typeof(T)] as T;
        }
    }
}