using ShoppingNightMongo.Dtos.CategoryDtos;

namespace ShoppingNightMongo.Services.CategoryServices
{
    public interface ICategoryService
    {
        // Yapacağımız işlemlerin metodlarını tutuyoruz. Bu şekilde class new lemeden bağımlılık azalacak. (Dependency Injection).
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetCategoryByIdDto> GetCategoryByIdAsync(string id);
    }
}
