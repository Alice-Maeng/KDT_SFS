using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Delegate
{
    public delegate bool ProductCondition(Product p);
    public class ProductFilter
    {
        // 정적 메서드 정의
        public static List<Product> Filter(List<Product> products, ProductCondition condition)
        {
            List<Product> result = new List<Product> (); //조건을 만족하는 제품만 따로 저장할 리스트 생성
            foreach (var p in products)
            {
                if (condition(p))
                    result.Add(p);
            }

            return result;

        }
    }
}
