#pragma checksum "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\Pages\Registro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ed8a41fe78088fa276102e19dc5ab2d854f497b"
// <auto-generated/>
#pragma warning disable 1591
namespace BreadGiver.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using BreadGiver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaqu\Documents\GitHub\BreadGiver\BreadGiver\_Imports.razor"
using BreadGiver.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registro")]
    public partial class Registro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center font-weight-bold\" style=\"font-family:Arial;\">Formulario de registro</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-row\">\r\n    <div class=\"col\">\r\n\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        \r\n        <form action onsubmit>\r\n            <div class=\"row form-group\">\r\n                <div class=\"col\">\r\n                    <p class=\"text-center\">Nombre</p>\r\n                    <input class=\"form-control\" type=\"text\" placeholder=\"Ingresa tu nombre\" required>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"text-center\">Apellido</p>\r\n                    <input class=\"form-control\" type=\"text\" placeholder=\"Ingresa tu apellido\" required>\r\n                </div>\r\n            </div>\r\n            <div class=\"row form-group\">\r\n                <div class=\"col\">\r\n                    <p class=\"text-center\">Dirección</p>\r\n                    <input class=\"form-control\" type=\"text\" name=\"direccion\" placeholder=\"Ingresa tu dirección\" required>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p class=\"text-center\">Ingresa tu RUT</p>\r\n                    <input class=\"form-control\" type=\"text\" name=\"rut\" placeholder=\"Ingresa tu rut\" required>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <p class=\"text-center\">Correo</p>\r\n                <input class=\"form-control\" type=\"email\" placeholder=\"Ingresa tu correo\" required>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <p class=\"text-center\">Contraseña</p>\r\n                    <input class=\"form-control\" type=\"password\" placeholder=\"Escribe tu contraseña\" required>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <p class=\"text-center\">Confirmar contraseña</p>\r\n                    <input class=\"form-control\" type=\"password\" placeholder=\"Confirma tu contraseña\" required>\r\n            </div>\r\n            <div class=\"custom-control custom-checkbox mb-3\">\r\n                <input type=\"checkbox\" class=\"custom-control-input\" id=\"terminos\" required>\r\n                <label class=\"custom-control-label\" for=\"customControlValidation1\"><a href=\"#\" style=\"color: blue;\">Terminos y condiciones</a></label>\r\n                <div class=\"invalid-feedback\">Example invalid feedback text</div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <button type=\"submit\" class=\"btn btn-primary w-100\">Continuar</button>\r\n            </div>\r\n        \r\n        \r\n        </form>\r\n        \r\n    </div>\r\n    <div class=\"col\">\r\n\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
