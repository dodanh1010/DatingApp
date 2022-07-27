using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{   //may cai ve interface nen them chu I o dau idk why lul
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}