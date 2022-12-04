namespace example;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var e = new Example();
        var prod = e.GetProducts();
        Assert.IsNotNull(prod);
        //・1 < n <= 100
        Assert.IsTrue(1 < prod.Count || prod.Count <= 100);
        
        foreach (var p in prod)
        {
            //・weight[i],value[i]は整数
            Assert.AreEqual(p.weight, Math.Floor(p.weight));
            Assert.AreEqual(p.value, Math.Floor(p.value));
            //・1 <= weight[i],value[i] <= 1000
            Assert.IsTrue(1 <= p.weight && p.weight <= 1000);
            Assert.IsTrue(1 <= p.value && p.value <= 1000);
            //・1 <= W <= 10000
            var v = p.weight * p.value;
            Assert.IsTrue(1 <= v && v <= 10000);
        }
    }
}