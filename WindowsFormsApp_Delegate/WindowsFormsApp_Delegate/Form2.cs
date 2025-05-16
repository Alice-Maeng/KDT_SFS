using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp_Delegate
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // 제품 목록
            List<Product> items = new List<Product>()
            {
                 new Product("노트북", 1000000, "전자기기"),          // Index : [0]
                 new Product("청소기", 1200000, "가전"),             // Index : [1]
                 new Product("커피", 5000, "식품"),                 // Index : [2]
                 new Product("책상", 500000, "가구"),
                 new Product("의자", 300000, "가구"),
                 new Product("아이폰", 1600000, "전자기기"),
            };

            /*
             * List<T> : 제네릭 컬렉션 -> 클래스 
             *  ㄴ 참조 형식 -> 힙 메모리 영역에 저장 
             *  ㄴ 리스 안에는 [0], [1] 등 인덱스마다 주소값을 가르킴 (참조형식이라서...) 
             */

            Console.WriteLine("[100,000원 이상 제품]");
            List<Product> expnesive = ProductFilter.Filter(items, p => p.Price >= 1000000);
            foreach (Product item in expnesive)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n[가구 카테고리 제품]");
            List<Product> cate = ProductFilter.Filter(items, p => p.Category == "가구");
            foreach (Product item in cate)
            {
                Console.WriteLine(item.ToString());
            }

        }
           
    }
}
