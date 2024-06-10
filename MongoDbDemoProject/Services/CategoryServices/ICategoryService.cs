using MongoDbDemoProject.Dtos.CategoryDtos;

namespace MongoDbDemoProject.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsycn(CreateCategoryDto categoryDto);
        Task UpdateCategoryAsycn(UpdateCategoryDto categoryDto);
        Task DeleteCategoryAsycn(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
    }
}
