﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class Music : IStreamable
    {
        private string artist;
        private string album;

        public Music(string artist, string album, int length, int bytesSent)
        {
            this.artist = artist;
            this.album = album;
            this.Length = length;
            this.ByteSent = bytesSent;
        }

        public int Length { get; set; }

        public int ByteSent { get; set; }
        
    }
}
