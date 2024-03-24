namespace CleanArchitecture.Application.ViewModels;

public class ProductViewModel
{
    public ProductViewModel(string? productName, string? productDescription)
    {
        ProductName = productName;
        ProductDescription = productDescription;
    }

    public string? ProductName { get;private set; }
    public string? ProductDescription { get; private set; }

    }
