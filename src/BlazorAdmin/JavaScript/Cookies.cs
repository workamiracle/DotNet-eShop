﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorAdmin.JavaScript
{
    public class Cookies
    {
        private readonly IJSRuntime _jsRuntime;

        public Cookies(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task DeleteCookie(string name)
        {
            await _jsRuntime.InvokeAsync<string>("deleteCookie", name);
        }

        public async Task<string> GetCookie(string name)
        {
            return await _jsRuntime.InvokeAsync<string>("getCookie", name);
        }
    }
}
