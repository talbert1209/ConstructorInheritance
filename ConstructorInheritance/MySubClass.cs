using System.Windows.Forms;

namespace ConstructorInheritance
{
    public class MySubClass : MyBaseClass
    {
        public MySubClass(string baseClassNeedsThis, int anotherValue)
            :base(baseClassNeedsThis)
        {
            MessageBox.Show($@"This is the subclass: {baseClassNeedsThis} and {anotherValue}");
        }
    }
}