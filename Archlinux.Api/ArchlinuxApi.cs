// SPDX-License-Identifier: GPL-2.0

/*
*  Copyright (C) 2022 Fadhil Riyanto
*
*  github.com/fadhil-riyanto/archlinux-api-wrapper.git
*/

using Archlinux.Api.Utils;
using Archlinux.Api.Methods;

namespace Archlinux.Api;
public class ArchlinuxApi
{
    public HttpInstance http;
    public ArchlinuxApi()
    {
        this.http = new HttpInstance();
    }
}
