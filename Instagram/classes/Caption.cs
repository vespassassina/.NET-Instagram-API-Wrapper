﻿using System;

namespace Instagram.api.classes {
    [Serializable]
    public class Caption : InstagramBaseObject
    {
        public double created_time;
        public string text;
        public string id;
        public User from;
    }
}