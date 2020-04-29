using FakeAPI.Models;
using FakeAPI.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAPI.Services
{
    public class FakeRepository : IFakeRepository
    {
        private DbContext context;
        public FakeRepository()
        {
            context = new FakeContext();
        }

        public string GetFake()
        {
           //var query = context.Fake;
            return "hei japp";
        }
    }
}
