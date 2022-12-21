// SPDX-License-Identifier: GPL-2.0

/*
*  Copyright (C) 2022 Fadhil Riyanto
*
*  github.com/fadhil-riyanto/archlinux-api-wrapper.git
*/

using Archlinux.Api.Constant;

namespace Archlinux.Api.Utils.ClientReq
{
    public class HttpInstance
    {
        private HttpClient HttpClient;
        public HttpInstance()
        {
            this.HttpClient = new HttpClient() 
            {
                BaseAddress = new Uri(Endpoint.Url)
            };
        }

        public async Task createReq(string path)
        {
            Console.WriteLine(await this.HttpClient.GetStringAsync(path));
        }
    }
}