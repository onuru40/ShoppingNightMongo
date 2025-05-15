using ShoppingNightMongo.Dtos.CustomerDtos;

namespace ShoppingNightMongo.Services.CustomerServices
{
    public interface ICustomerService
    {
        // Yapacağımız işlemlerin metodlarını tutuyoruz. Bu şekilde class new lemeden bağımlılık azalacak. (Dependency Injection).
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);
        Task DeleteCustomerAsync(string customerId);
        Task<GetCustomerByIdDto> GetCustomerByIdAsync(string customerId);
    }
}
