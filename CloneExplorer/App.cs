using Jamesnet.Wpf.Controls;
using System.Windows;

namespace CloneExplorer
{
    // internal => 해당 클래스가 프로젝트 내부에서만 사용되며, 외부 접근 허용 X
    // App Class는 해당 애플리케이션의 핵심 구성 및 동작 담당
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new Window();
        }



    }
}
