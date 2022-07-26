using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbFirstApp.DBContext;
using DbFirstApp.Extensions;
using DbFirstApp.Models;
using DbFirstApp.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbFirstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnersController :  ControllerBase
    {
        private readonly AlifShopContext _context;

        public PartnersController(AlifShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<GetListOffer>> GetPartnerOffers(string slug,[FromQuery]PaginateParameters parameters)
        {
            var partner = await _context.Partners.FirstOrDefaultAsync(x => x.Slug!.Equals(slug) && x.IsActive.Equals(true));
            var offers =  _context.Offers.Where(o => o.PartnerId == partner!.Id && o.Price>0 && o.Quantity>0&&o.IsVisible.Equals(true)).Select(x=>new GetListOffer()
            {
                Id = x.Id,
                Partner = partner,
                Condition = partner.Conditions.FirstOrDefault()
            });
            return await offers.ToListAsync();
        }
    }
}
