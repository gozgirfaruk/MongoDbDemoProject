using AutoMapper;
using MongoDB.Driver;
using MongoDbDemoProject.Dtos.CategoryDtos;
using MongoDbDemoProject.Entities;
using MongoDbDemoProject.Settings;

namespace MongoDbDemoProject.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _categoryCollection=database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }
        public async Task CreateCategoryAsycn(CreateCategoryDto categoryDto)
        {
           var value = _mapper.Map<Category>(categoryDto);
            await _categoryCollection.InsertOneAsync(value);
        }

        public Task DeleteCategoryAsycn(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            var value = await _categoryCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(value); 
        }

        public Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsycn(UpdateCategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
