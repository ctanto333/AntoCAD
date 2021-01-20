using System;
using AutoCAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;

namespace AntoCAD
{
    /// <summary>
    /// Interaction logic for Form_4_W_O_BUS_COUPLER.xaml
    /// </summary>
    public partial class Form_4_W_O_BUS_COUPLER : Page
    {
        
        public Form_4_W_O_BUS_COUPLER()
        {
            InitializeComponent();
        }

        public AcadApplication AcadApp { get; private set; }
        public AcadCircle Circle { get; private set; }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Getting running AutoCAD instance by Marshalling by passing Programmatic ID as a string, AutoCAD.Application is the Programmatic ID for AutoCAD.
            AcadApp = (AcadApplication)Marshal.GetActiveObject("AutoCAD.Application");
            string template = "acad.dwt";
            _ = AcadApp.Documents.Add(template);

            // Now AcadApp has the reference to the running AutoCAD instance, AcadApp object acts as a port for accessing running instance of AutoCAD.

            // Syntax for creating circle in AutoCAD
            // AcadApp.ActiveDocument.ModelSpace.AddCircle(CenterOfCircle, RadiusOfCircle);
            //
            // AcadApp        - Reference to the running instance of AutoCAD.
            // ActiveDocument - Represents the current working drawing in AutoCAD.
            // ModelSpace     - Work Area in the current drawing.
            // AddCricle      - Method, which adds a circle to the modelspace of the current drawing using the CenterPoint and Radius.
            // CenterOfCircle - 3 Dimensional double array variable holds the center point of the circle in the X, Y and Z axis.
            // RadiusOfCircle - Double variable holds the radius of circle.

            // Definfing the center point for the circle, in this example, we are using origin(0,0,0) as the center of circle.
            double[] CenterOfCircle = new double[3];
            CenterOfCircle[0] = 0;
            CenterOfCircle[1] = 0;
            CenterOfCircle[2] = 0;

            // Defining radius of circle.
            double RadiusOfCircle = 50;

            // Adding Circle to the modelspace and getting reference to the circle created.
            Circle = AcadApp.ActiveDocument.ModelSpace.AddCircle(CenterOfCircle, RadiusOfCircle);
        }
    }
}
