﻿using System;
using System.Web;
using SimpleSocialAuth.Core;

namespace SimpleSocialAuth.MVC3
{
    /// <summary>
    /// Takes a request and adapts it to our authentication framework.
    /// </summary>
    internal class RequestAdapter : IHttpRequest
    {
        private readonly HttpRequestBase _request;

        public RequestAdapter(HttpRequestBase request)
        {
            _request = request;
        }

        #region IHttpRequest Members

        public Uri Url
        {
            get { return _request.Url; }
        }

        #endregion
    }
}