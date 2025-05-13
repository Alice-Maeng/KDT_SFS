using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Class_4_
{
    /*
     * #1. 인터페이스 선언
     *      ㄴ why? 1) 공통 기능을 강제하기 위하여 2) 다형성을 가능하게 하기 위하여 3) 유연한 구조
     *      ㄴ 메서드만 정의하고 기느은 없음
     *
     */

    public interface IReadable
    {
        void Read();    // 문서를 읽는 기능
    }

    public interface IWritable
    {
        void Write();   // 문서를 쓰는 기능 
    }

    public interface IPrintable 
    {
        void Print();   // 문서를 인쇄하는 기능 
    }
    public class Document : IReadable, IWritable, IPrintable
    {
        public void Read() 
        {
            Console.WriteLine("문서를 읽고 있습니다.");
        }

        public void Write()
        {
            Console.WriteLine("문서에 내용을 쓰고 있습니다.");
        }

        public void Print()
        {
            Console.WriteLine("문서를 프린터로 출력합니다.");
        }


    }
}
