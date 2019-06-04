using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Epta.API.ViewModels;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.IdentityModel.Tokens;
using Epta.API.Auth;
using Newtonsoft.Json;
using System.Linq;
using Epta.API.Helpers;
using Microsoft.Extensions.Options;
using DalUnlocker;
using Microsoft.AspNetCore.Cors;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Epta.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    public class AuthController : Controller
    {
        private readonly IJwtFactory _jwtFactory;
        private readonly JsonSerializerSettings _serializerSettings;
        private readonly JwtIssuerOptions _jwtOptions;
        private readonly TESTEContext _appDbContext;
        
        public AuthController(TESTEContext appDbContext, IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions)
        {
            _appDbContext = appDbContext;
            _jwtFactory = jwtFactory;
            _jwtOptions = jwtOptions.Value;

            _serializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
        }

        // POST api/auth/login
        [HttpPost]
        [AllowAnonymous]
        [HttpPost("login")]
        [EnableCors("AllowAnyOrigin")]
        public async Task<IActionResult> Post([FromBody]CredentialsViewModel credentials)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var identity = await GetClaimsIdentity(credentials.Login, credentials.Senha);
                if (identity == null)
                    return BadRequest(Errors.AddErrorToModelState("login_failure", "Usuário ou Senha Inválidos", ModelState));

                // Serialize and return the response
                var response = new
                {
                    id = identity.Claims.Single(c => c.Type == "id").Value,
                    auth_token = await _jwtFactory.GenerateEncodedToken(credentials.Login, identity),
                    expires_in = (int)_jwtOptions.ValidFor.TotalSeconds
                };

                var json = JsonConvert.SerializeObject(response, _serializerSettings);
                return new OkObjectResult(json);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [EnableCors("AllowAnyOrigin")]
        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                // get the user to verifty

                string senhaEnc = Criptografia.Encrypt(password, true);
                var userToVerify = _appDbContext.Tb01008Usuarios.FirstOrDefault(a => a.UsuarioEmail == userName && a.UsuarioPassword == senhaEnc);


                if (userToVerify != null)
                {
                    var identity = _jwtFactory.GenerateClaimsIdentity(userName, userToVerify.UsuarioId.ToString());

                    // check the credentials  
                    return await Task.FromResult(identity);
                }
            }

            // Credentials are invalid, or account doesn't exist
            return await Task.FromResult<ClaimsIdentity>(null);
        }
    }
}
