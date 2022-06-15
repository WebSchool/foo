using Frontend.Models;

namespace Frontend.Tests;

public class MyModel_BarShould
{
    [Fact]
    public void Bar_InputIs1_ReturnFalse()
    {
        var myModel = new MyModel();
        bool result = myModel.Bar(1);

        Assert.False(result, "1 не должно быть простым числом");
    }
}