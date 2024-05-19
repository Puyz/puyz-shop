using AutoMapper;
using MongoDB.Driver;
using PuyzShop.Catalog.Dtos.ProductDtos;
using PuyzShop.Catalog.Entities;
using PuyzShop.Catalog.Settings;

namespace PuyzShop.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            await _productCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(p => p.ProductId.Equals(id));
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var values = await _productCollection.Find(p => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);

        }

        public async Task<GetByIdProductDto> GetByIdProductAsync(string id)
        {
            var value = await _productCollection.Find(p => p.ProductId.Equals(id)).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDto>(value);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var value = _mapper.Map<Product>(updateProductDto));
            await _productCollection.FindOneAndReplaceAsync(p => p.ProductId.Equals(updateProductDto.ProductId), value);
        }
    }
}
