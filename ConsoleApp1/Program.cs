//n個の品物があり、i番目の品物のそれぞれ重さと価値が weight[i], value[i]となっている (i=0,1,..., n−1)。
//これらの品物から重さの総和がWを超えないように選んだときの、価値の総和の最大値を求めよ。
//※実装言語はお任せします。
//※テストコードも実装してください。
//※開発にかかった所要時間も提出してください。

//[制約]
//・1 < n <= 100
//・weight[i],value[i]は整数
//・1 <= weight[i],value[i] <= 1000
//・1 <= W <= 10000

namespace example;

public class Example
{
    private readonly int n = 100;
    private readonly double W = 10000;
    private readonly double maxNum = 1000;

    public class Product
    {
        public double weight;
        public double value;
    }

    public List<Product> GetProducts()
    {
        // サンプルデータ作成
        var products = new List<Product>();
        foreach (var item in Enumerable.Range(1, n))
        {
            products.Add(new Product() { weight = item, value = item * 10 });
        }

        // 判定
        foreach (var item in products)
        {
            for (int i = 1; i <= this.maxNum; i++)
            {
                if (item.weight * i <= this.W)
                {
                    item.value = i;
                }
                else
                {
                    break;
                }
            }
        }
        return products;
    }

    public static void Main(string[] args)
    {
        var e = new Example();
        var prod = e.GetProducts();
        prod.ForEach(p => Console.WriteLine($"weight = {p.weight} value = {p.value}"));
    }
}

