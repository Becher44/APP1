using APP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1.Services
{
    public interface IRestService
    {
        Task SaveSignUpAsync(ToSignUp toSignUp);
    }
}
