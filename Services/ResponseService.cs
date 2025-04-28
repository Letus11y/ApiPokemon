using PokeApi.Services.Interfaces;

namespace PokeApi.Services;

 public class ResponseService : IResponseService
 {
    public ApiService<T> GetClient<T>()
    {
        return new ApiService<T>("https://pokeapi.co/api/v2/pokemon?/");
        
    }
 }

