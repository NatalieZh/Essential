﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    class XMLHandler : AbstractHandler
    {
        public const string Type = "XML Document";

        public XMLHandler(string name) : base(name)
        {
            _name += ".xml";
        }

        public override string Change()
        {
            return $"{Type} with name {Name} is changed";
        }

        public override string Create()
        {
            return $"{Type} with name {Name} is created";
        }

        public override string Delete()
        {
            return $"{Type} with name {Name} is deleted";
        }

        public override string Open()
        {
            return $"{Type} with name {Name} is opened";
        }

        public override string Save()
        {
            return $"{Type} with name {Name} is saved";
        }
    }
}
