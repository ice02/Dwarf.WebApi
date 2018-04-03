using Dwarf.Database;
using Dwarf.Database.Model;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dwarf.WebApi.OData
{
    [Produces("application/json")]
    public class ProductController : ODataController
    {
        private readonly DwarfContext context;

        public ProductController(DwarfContext context) => this.context = context;

        // GET: odata/Book
        [EnableQuery]
        public IQueryable<Product> Get() => context.Products.AsQueryable();
    }
}
