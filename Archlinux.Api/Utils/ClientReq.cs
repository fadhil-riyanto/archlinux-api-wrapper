// SPDX-License-Identifier: GPL-2.0

/*
*  Copyright (C) 2022 Fadhil Riyanto
*
*  github.com/fadhil-riyanto/archlinux-api-wrapper.git
*/

using Archlinux.Api.Constant;

namespace Archlinux.Api.Utils
{
    public class HttpInstance
    {
        private HttpClient _HttpClient;
        private HttpResponseMessage _HttpResponseMessage;
        public HttpInstance()
        {
            this._HttpClient = new HttpClient() 
            {
                BaseAddress = new Uri(Endpoint.Url)
            };
        }

        public async Task<HttpInstance> createReq(string path)
        {
            this._HttpResponseMessage = await this._HttpClient.GetAsync(path);
            return this;
        }

        public System.Net.HttpStatusCode StatusCode()
        {
            return this._HttpResponseMessage.StatusCode;
        }

        public async Task<string> GetString()
        {
            return await this._HttpResponseMessage.Content.ReadAsStringAsync();
        }


    }
}