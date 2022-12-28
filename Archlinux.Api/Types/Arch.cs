// SPDX-License-Identifier: GPL-2.0

/*
*  Copyright (C) 2022 Fadhil Riyanto
*
*  github.com/fadhil-riyanto/archlinux-api-wrapper.git
*/

namespace Archlinux.Api.Types
{
    public class Arch
    {
        private readonly Dictionary<string, Arch> ins = new Dictionary<string, Arch>();
        private string architecture;

        internal Arch(string architecture)
        {
            this.architecture = architecture;
            ins[architecture] = this;
        }

        public override string ToString()
        {
            return this.architecture;
        }

        public static readonly Arch x86_64 = new Arch("x86_64");
        public static readonly Arch i686 = new Arch("i686");
        public static readonly Arch any = new Arch("any");
    }
}