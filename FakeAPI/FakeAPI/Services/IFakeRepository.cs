using FakeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAPI.Services
{
    public interface IFakeRepository
    {
        string GetFake();
    }
}
