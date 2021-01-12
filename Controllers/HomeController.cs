using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ProjectLibri.Config;
using ProjectLibri.Service;
using ProjectLibri.Specification;

namespace ProjectLibri.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly AppConfig _config;
        private readonly IUserService _userService;

        public HomeController(IUserService userService, IOptions<AppConfig> config)
        {
            _userService = userService;
            _config = config.Value;
        }

        public async Task<IActionResult> Index()
        {
            var actualUser = await _userService.GetUser(HttpContext);
            if(actualUser != null)
                Debug.WriteLine(actualUser.ToString());

            Debug.WriteLine(_config.isDev);

            ExampleSpecification spec = new ExampleSpecification();
            spec.value2 = "VALUE2";
            spec.value3 = "VALUE3";
            Debug.WriteLine(spec.GetSql());

            return View();
        }

    }
}

/*
json:
{
    "businessPhones": [],
  "displayName": "Dmitry Leshchinskiy (student C3b)",
  "givenName": "Dmitry",
  "mail": "leshchinskiy@spsejecna.cz",
  "surname": "Leshchinskiy",
  "userPrincipalName": "leshchinskiy@spsejecna.cz",
  "id": "0665515c-ba24-41a2-96fc-00742d00de59",
  "@odata.type": "microsoft.graph.user",
  "@odata.context": "https://graph.microsoft.com/v1.0/$metadata#users/$entity",
  "jobTitle": null,
  "mobilePhone": null,
  "officeLocation": null,
  "preferredLanguage": null,
  "responseHeaders": {
        "Cache-Control": [
          "private"
    ],
    "Vary": [
      "Accept-Encoding"
    ],
    "request-id": [
      "d311b1fd-13b7-4683-9185-34000d0fb9a9"
    ],
    "client-request-id": [
      "d311b1fd-13b7-4683-9185-34000d0fb9a9"
    ],
    "x-ms-ags-diagnostic": [
      "{\"ServerInfo\":{\"DataCenter\":\"West Europe\",\"Slice\":\"SliceC\",\"Ring\":\"5\",\"ScaleUnit\":\"003\",\"RoleInstance\":\"AGSFE_IN_37\"}}"
    ],
    "x-ms-resource-unit": [
      "1"
    ],
    "OData-Version": [
      "4.0"
    ],
    "Strict-Transport-Security": [
      "max-age=31536000"
    ],
    "Date": [
      "Mon, 11 Jan 2021 20:09:39 GMT"
    ]
  },
  "statusCode": "OK"
}
*/