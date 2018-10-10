using System.Windows.Forms;

namespace ConstructorInheritance
{
    public class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show($@"This is the base class: {baseClassNeedsThis}");
        }
    }
}