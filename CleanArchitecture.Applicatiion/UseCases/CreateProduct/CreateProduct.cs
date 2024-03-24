using CleanArchitecture.Application.InputModels;

namespace CleanArchitecture.Application.UseCases.CreateProduct;

public class CreateProduct
{
    private readonly IProductRepository _productRepository;
    public CreateProduct(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void Add(ProductInputModel productInputModel)
    {

    }
}