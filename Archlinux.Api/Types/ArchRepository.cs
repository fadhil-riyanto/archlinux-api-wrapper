// SPDX-License-Identifier: GPL-2.0

/*
*  Copyright (C) 2022 Fadhil Riyanto
*
*  github.com/fadhil-riyanto/archlinux-api-wrapper.git
*/

namespace Archlinux.Api.Types
{
    public class ArchRepository
    {
        private readonly Dictionary<string, ArchRepository> ins = new Dictionary<string, ArchRepository>();
        private string repo;

        internal ArchRepository(string repository)
        {
            repo = repository;
            ins[repository] = this;
        }

        public override string ToString()
        {
            return this.repo;
        }

        public static ArchRepository FromString(string reponame)
        {
            return new ArchRepository(reponame);
        }

        public string PascalCase()
        {
            return string.Join("", this.repo.Split('-')
                         .Select(w => w.Trim())
                         .Where(w => w.Length > 0)
                         .Select(w => w.Substring(0, 1).ToUpper() + w.Substring(1).ToLower()));
        }


        public static readonly ArchRepository community = new ArchRepository("community");
        public static readonly ArchRepository community_testing = new ArchRepository("community-testing");
        public static readonly ArchRepository core = new ArchRepository("core");
        public static readonly ArchRepository extra = new ArchRepository("extra");
        public static readonly ArchRepository kde_unstable = new ArchRepository("kde-unstable");
        public static readonly ArchRepository multilib = new ArchRepository("multilib");
        public static readonly ArchRepository multilib_testing = new ArchRepository("multilib-testing");
        public static readonly ArchRepository testing = new ArchRepository("testing");
    }
}