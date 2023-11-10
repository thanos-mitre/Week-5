public class OrderCostCalculatorServiceTests
{
    public async Task GetOrderFinalCost_ReturnsCorrectFinalCost()
    {
        var orderCostService = new OrderCostCalculatorService();
        var orderId = 1;
        var noVatCost = 100m;

        await orderCostService.SaveOrderCost(orderId, noVatCost);
        var finalCost = await orderCostService.GetOrderFinalCost(orderId);

        var expectedFinalCost = noVatCost * 1.24m;
        Assert.AreEqual(expectedFinalCost, finalCost);
    }
}
