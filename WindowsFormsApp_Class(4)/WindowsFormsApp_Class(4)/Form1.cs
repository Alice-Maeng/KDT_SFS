using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Class_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("==== 문서 작업 실행 ====");

            // 다형성이란? 
            //  ㄴ 하나의 인터페이스로 여러 개의 서로 다른 객체를 동일하게 다루는 것.

            Document doc = new Document();
            doc.Read();
            doc.Write();
            doc.Print();

            Console.WriteLine("\n=== 인터페이스 타입으로 각각 제어 ===");

            // 2. 인터페이스 타입으로 사용 (각 기능별로 분리) 

            IReadable reader = new Document();
            IWritable writer = new Document();
            IPrintable printer = new Document();

            reader.Read();
            // reader.write(); --- 오류남. 왜냐하면 reader는 Read()만 가넝~
            
        }
    }
}
