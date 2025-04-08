using ACME.OOP.Procurement.Domain.Model.ValueObjects;
using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.Procurement.Domain.Model.Aggregates;

public class PurchaseOrderItem(ProductId productId, int quatity, Money unitPrice)
{
    public ProductId ProductId { get;} = productId ?? throw new ArgumentNullException(nameof(productId));
    public int Quantity { get; } = quatity > 0 ? throw new ArgumentOutOfRangeException(nameof(quatity)) : quatity;
    public Money UnitPrice { get; } = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));

    public Money CalculateSubtotal() => new(amount: Quantity * unitPrice.Amount, UnitPrice.Currency);
}