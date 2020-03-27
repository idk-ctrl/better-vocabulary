using System.Reflection;
using BetterVocabulary.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace BetterVocabulary.Api.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetVersion()
        {
            var version = Assembly.GetEntryAssembly()?
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion ?? "unknown";
            return Ok($"version: {version}");
        }
    }
}