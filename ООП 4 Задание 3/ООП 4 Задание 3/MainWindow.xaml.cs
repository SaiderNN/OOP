using System;
using System.CodeDom.Compiler;
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

namespace ООП_4_Задание_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        // Enumerations Exercise 1
            /// <summary>
            /// Enumeration of girder material types
            /// </summary>
        public enum Material { StainlessSteel, Aluminium, ReinforcedConcrete, Composite, Titanium }
        /// <summary>
        /// Enumeration of girder cross-sections
        /// </summary>
        public enum CrossSection { IBeam, Box, ZShaped, CShaped }
        /// <summary>
        /// Enumeration of test results
        /// </summary>
        public enum TestResult { Pass, Fail }
        // Structures Exercise 2
        /// <summary>
        /// Structure containing test results
        /// </summary>
        public struct TestCaseResult
        {
            /// <summary>
            /// Test result (enumeration type)
            /// </summary>
            public TestResult Result;
            /// <summary>
            /// Description of reason for failure
            /// </summary>
            public string ReasonForFailure;
        }

        private static Random rnd = new Random();

        public static TestCaseResult GenerateResult()
        {

            TestCaseResult result;
            TestResult testResult = (TestResult)rnd.Next(0, 2);
            result.Result = testResult;

            if (testResult == TestResult.Pass) 
            {
                result.ReasonForFailure = string.Empty;
            }
            else
            {
                result.ReasonForFailure = GetRandomReasonForFailure();
            }
            return result;
        }

        private static string GetRandomReasonForFailure()
        {
            Material selectedMaterial = (Material)rnd.Next(0, 5);
            CrossSection selectedCrossSection = (CrossSection)rnd.Next(0, 4);

            StringBuilder selectionStringBuilder = new StringBuilder();
            switch (selectedMaterial)
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

            switch (selectedCrossSection)
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

            selectionStringBuilder.Append("Result: Fail");
            return selectionStringBuilder.ToString();

        }

        private TestCaseResult[] results;
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            ResList.Items.Clear();
            int passes = 0;
            int fails = 0;
            results = new TestCaseResult[20];
            for ( int i = 0; i < results.Length; i++)
            {
                results[i] = GenerateResult();
            }
            foreach (var result in results)
            {
                if(result.Result == TestResult.Pass)
                {
                    passes++;
                }
                if(result.Result == TestResult.Fail)
                {
                    fails++;
                    ResList.Items.Add(result.ReasonForFailure);
                }

            }
            passlb.Content = "Passed :" + passes.ToString();
            faillb.Content = "Failed :" + fails.ToString();
        }

    }
}
