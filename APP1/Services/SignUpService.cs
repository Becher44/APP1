using APP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1.Services
{
    public class SignUpService: ISignUpService
    {

        IRestService _restService;

        public SignUpService(IRestService service)
        {
            _restService = service;
        }

        public Task SaveTaskAsync(ToSignUp signup)
        {
            return _restService.SaveSignUpAsync(signup);
        }

    }
}
