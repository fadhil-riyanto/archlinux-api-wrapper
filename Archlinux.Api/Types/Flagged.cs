// SPDX-License-Identifier: GPL-2.0

/*
*  Copyright (C) 2022 Fadhil Riyanto
*
*  github.com/fadhil-riyanto/archlinux-api-wrapper.git
*/

namespace Archlinux.Api.Types
{
    public class flagged
    {
        private readonly Dictionary<string, flagged> ins = new Dictionary<string, flagged>();
        private string isflagged;

        internal flagged(string flagged)
        {
            isflagged = flagged;
            ins[flagged] = this;
        }

        public override string ToString()
        {
            return this.isflagged;
        }

        public static readonly flagged Flagged = new flagged("Flagged");
        public static readonly flagged Not_Flagged = new flagged("Not+Flagged");
    }
}