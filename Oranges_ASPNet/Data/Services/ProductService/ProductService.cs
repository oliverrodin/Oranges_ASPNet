using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Data.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProductsAsync() =>
            await _context.Products.Include(b => b.Brand).ToListAsync();


        public async Task<Product> GetProductsByIdAsync(int id)
        {
            return await _context.Products.Include(p => p.Brand).FirstOrDefaultAsync(p => p.Id == id);

        }

        public async Task AddAsync(ProductViewModel product)
        {
            var newProduct = new Product()
            {
                Id = product.Id,
                Model = product.Model,
                Description = product.Description,
                BrandId = product.BrandId,
                Price = product.Price,
                Category = product.Category,
                ImgUrl = product.ImgUrl,
            };

            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, ProductViewModel product)
        {
            var item = await _context.Products.FirstOrDefaultAsync(n => n.Id == product.Id);



            if (item != null)
            {
                item.Id = product.Id;
                item.Model = product.Model;
                item.Description = product.Description;
                item.BrandId = product.BrandId;
                item.Price = product.Price;
                item.Category = product.Category;
                item.ImgUrl = product.ImgUrl;

                await _context.SaveChangesAsync();
            }

            //Remove existing actors
            //var existingActorsDb = _context.Actors_Movies.Where(n => n.MovieId == data.Id).ToList();
            //_context.Actors_Movies.RemoveRange(existingActorsDb);
            //await _context.SaveChangesAsync();



            //Add Movie Actors
            //foreach (var id in data.ActorId)
            //{
            //    var newActorMovie = new Actor_Movie()
            //    {
            //        MovieId = data.Id,
            //        ActorId = id
            //    };
            //    await _context.Actors_Movies.AddAsync(newActorMovie);
            //}



            //await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(product => product.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Brand>> GetBrandDropdownValueAsync()
        {
            return await _context.Brands.OrderBy(b => b.Name).ToListAsync();
        }
    }
}
