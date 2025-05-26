using HelpApp.Application.Products.Queries;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using MediatR;
namespace HelpApp.Application.Products.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery , Product>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Harndle(GetProductsByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _productRepository.GetById(request.Id);
        }
    }
}
