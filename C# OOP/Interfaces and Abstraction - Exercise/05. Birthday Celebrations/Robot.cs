﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Robot : IRobot
    {
        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public string Model { get; private set; }

        public string Id { get; private set; }
    }
}
