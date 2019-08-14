using System;

namespace MyVet.Web.Controllers
{
    internal class AutorizeAttribute : Attribute
    {
        public string Roles { get; set; }
    }
}