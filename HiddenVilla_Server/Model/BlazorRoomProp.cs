﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace HiddenVilla_Server.Model
{
    public class BlazorRoomProp
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public List<BlazorRoomProp> RoomProps { get; set; }


    }
}
