using System;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ООП_4_Задание_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    /// <summary>
    /// Enumeration of girder material types
    /// </summary>
    public enum Material
    {
        StainlessSteel,
        Aluminium,
        ReinforcedConcrete,
        Composite,
        Titanium
    }
    /// <summary>
    /// Enumeration of girder cross-sections
    /// </summary>
    public enum CrossSection
    {
        IBeam,
        Box,
        ZShaped,
        CShaped
    }
    /// <summary>
    /// Enumeration of test results
    /// </summary>
    public enum TestResult
    {
        Pass,
        Fail
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Material[] arr1 = (Material[])Enum.GetValues(typeof(Material));
            CrossSection[] arr2 = (CrossSection[])Enum.GetValues(typeof(CrossSection));
            TestResult[] arr3 = (TestResult[])Enum.GetValues(typeof(TestResult));
            fill_in(MaterialBox, arr1);
            fill_in(CrossSectionBox, arr2);
            fill_in(TestResultBox, arr3);

        }
        private void fill_in(ListBox lb, Array arr)
        {
            foreach(object obj in arr )
            {
                lb.Items.Add(obj);
            }
        }
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ( MaterialBox.SelectedItem == null || CrossSectionBox.SelectedItem == null || TestResultBox.SelectedItem == null) { return; }
            {
                Material selectedMaterial = (Material)MaterialBox.SelectedItem;
                CrossSection selectedCrossSection = (CrossSection)CrossSectionBox.SelectedItem;
                TestResult selectedTestResult = (TestResult)TestResultBox.SelectedItem;

                StringBuilder selectionStringBuilder = new StringBuilder();

                switch(selectedMaterial) 
                {
                    case Material.StainlessSteel:
                        selectionStringBuilder.Append("Material: StainlessSteel\n");
                        break;
                    case Material.Aluminium:
                        selectionStringBuilder.Append("Material: Aluminium\n");
                        break;
                    case Material.ReinforcedConcrete:
                        selectionStringBuilder.Append("Material: ReinforcedConcrete\n");
                        break;
                    case Material.Composite:
                        selectionStringBuilder.Append("Material: Composite\n");
                        break;
                    case Material.Titanium:
                        selectionStringBuilder.Append("Material: Titanium\n");
                        break;
                }

                switch(selectedCrossSection)
                {
                    case CrossSection.IBeam:
                        {
                            selectionStringBuilder.Append("CrossSection: IBeam\n");
                            break;
                        }
                    case CrossSection.Box:
                        {
                            selectionStringBuilder.Append("CrossSection: Box\n");
                            break;
                        }
                    case CrossSection.ZShaped:
                        {
                            selectionStringBuilder.Append("CrossSection: ZShaped\n");
                            break;
                        }
                    case CrossSection.CShaped:
                        {
                            selectionStringBuilder.Append("CrossSection: CShaped\n");
                            break;
                        }
                }
                
                switch(selectedTestResult)
                {
                    case TestResult.Pass:
                        {
                            selectionStringBuilder.Append("TestResult: Pass\n");
                            break;
                        }
                    case TestResult.Fail:
                        {
                            selectionStringBuilder.Append("TestResult: Fail\n");
                            break;
                        }
                }

                Answer.Content = selectionStringBuilder;
            }
        }
    }
}
