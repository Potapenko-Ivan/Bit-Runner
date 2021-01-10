﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Events {
    public class EventListener : MonoBehaviour {

        [SerializeField]
        private Event _someEvent;

        public event Action ActionToDo = delegate { };

        private void OnEnable() {
            _someEvent.AddListener(OnEventHappend);
        }

        private void OnDisable() {
            _someEvent.RemoveListener(OnEventHappend);
        }

        private void OnEventHappend() {
            ActionToDo.Invoke();
        }

    }
}
