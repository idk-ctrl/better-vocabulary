using Microsoft.AspNetCore.Mvc;

namespace BetterVocabulary.Api.Controllers.Base
{
    [Produces("application/json")]
    public abstract class ApiBaseController : ControllerBase
    {
        // There should be reusable features
    }
}