using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFormsDemo.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Logging;

namespace BlazorFormsDemo.Pages
{
    public partial class Index
    {
        private Product ProductModel = new Product(); 
        private EditContext EditContext;

        protected override void OnInitialized()
        {
            EditContext = new EditContext(ProductModel);
        }

        private void HandleValidSubmit()
        {
            Console.WriteLine("HandleValidSubmit Called...");
        }
    } 
}
