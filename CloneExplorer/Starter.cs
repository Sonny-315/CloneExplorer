using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneExplorer
{
    internal class Starter
    {
        // - 프로그램 시작 진입점 역할
        // - App 인스턴스를 생성하고 실행하는 것이 주 목적!
        // - 프로그램의 시작 지점을 만들기 위해서는 STAThread 어트리뷰트가 포함된 메서드를 만들면 됨.
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App().Run();
        }


    }
}
