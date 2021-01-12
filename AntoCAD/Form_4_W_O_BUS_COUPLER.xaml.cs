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
        public AcadApplication AcadApp { get; private set; }
        public AcadCircle Circle { get; private set; }

        string incomer;
        int noOfOutgoings;

        public Form_4_W_O_BUS_COUPLER()
        {
            InitializeComponent();
        }

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            incomer = this.comboBox.SelectedValue.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //AcadApp = (AcadApplication)Marshal.GetActiveObject("AutoCAD.Application.23"); // OPENING AUTOCAD 2020 //Reference file is in c/programfiles/commonfiles/autodeskshared
            //string template = "acad.dwt";
            //AcadDocument dwg = AcadApp.Documents.Add(template);

            //AcadApp = (AcadApplication)Activator.CreateInstance(Type.GetTypeFromProgID("AutoCAD.Application.23"), true);
            //AcadApp.Visible = true;

            AcadApp = (AcadApplication)Marshal.GetActiveObject("AutoCAD.Application.23");


            if (incomer.Contains("2500 4P ACB"))
            {
                double RadiusOfCircle = 50;
                double[] CenterOfCircle = new double[3];
                CenterOfCircle[0] = 0;
                CenterOfCircle[1] = 0;
                CenterOfCircle[2] = 0;
                Circle = AcadApp.ActiveDocument.ModelSpace.AddCircle(CenterOfCircle, RadiusOfCircle);


                //double[] CenterOfBlock = new double[3];
                //CenterOfBlock[0] = 0;
                //CenterOfBlock[1] = 0;
                //CenterOfBlock[2] = 0;
                //AcadApp.ActiveDocument.ModelSpace.InsertBlock(CenterOfBlock, "D:\\Block\\250A_MCCB_3P.dwg", 1, 1, 1, 0);
            }
        }

        //Get no of outgoings and store it to a variable.
        private void outgoings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                noOfOutgoings = Convert.ToInt32(this.outgoings.Text);
            }
        }
    }
}
