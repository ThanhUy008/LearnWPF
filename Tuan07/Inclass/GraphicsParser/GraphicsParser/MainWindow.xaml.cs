
using MyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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


namespace GraphicsParser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello");
            string exePath = Assembly.GetExecutingAssembly().Location;
            string folder = System.IO.Path.GetDirectoryName(exePath);
            FileInfo[] filesDll = new DirectoryInfo(folder).GetFiles("*.dll");



            var plugins1 = new List<IShape>();
            var plugins2 = new List<IShapeToStringDataConverter>();
            var plugins3 = new List<IShapeToStringUIConverter>();

            foreach (var dllfile in filesDll)
            {
                var domain = AppDomain.CurrentDomain;
                Assembly assembly = domain.Load(AssemblyName.GetAssemblyName(dllfile.FullName));
                if (dllfile.Name != "GraphicsParser.dll" && dllfile.Name != "MyLib.dll" && dllfile.Name != "Point2D.dll")
                {
                    var types = assembly.GetTypes();
                    foreach (var type in types)
                    {
                        if (type.IsClass && typeof(IShape).IsAssignableFrom(type))
                        {
                            plugins1.Add(Activator.CreateInstance(type) as IShape);
                        }
                        else if (type.IsClass && typeof(IShapeToStringDataConverter).IsAssignableFrom(type))
                        {
                            plugins2.Add(Activator.CreateInstance(type) as IShapeToStringDataConverter);
                        }
                        else if (type.IsClass && typeof(IShapeToStringUIConverter).IsAssignableFrom(type))
                        {
                            plugins3.Add(Activator.CreateInstance(type) as IShapeToStringUIConverter);
                        }
                    }
                }
            }

            var dataConverterPrototypes = new Dictionary<string, Func<string, IShape>>() { };
            var uiConverterPrototypes = new Dictionary<string, Func<IShape, string>>() { };
            var size = plugins1.Count;
            for (int i = 0 ; i < size;i++)
            {
                dataConverterPrototypes.Add(plugins1.ElementAt(i).MagicWord, new Func<string, IShape>(plugins2.ElementAt(i).ConvertBack));
                uiConverterPrototypes.Add(plugins1.ElementAt(i).MagicWord, new Func<IShape, string>(plugins3.ElementAt(i).convert));
            }
            List<IShape> shapes = new List<IShape>();
            

            string filename = "graphics.txt";
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string buffer = reader.ReadLine();
                    int firstSpaceIndex = buffer.IndexOf(" ");
                    string firstWord = buffer.Substring(0, firstSpaceIndex);
                    if (dataConverterPrototypes[firstWord] != null)
                    {
                        IShape shape = dataConverterPrototypes[firstWord].Invoke(buffer);
                        shapes.Add(shape);
                    }

                }
            }

           
          

            foreach (var shape in shapes)
            {
                MessageBox.Show(uiConverterPrototypes[shape.MagicWord].Invoke(shape));
            }
            MessageBox.Show(
                   "Good bye");
        }
    }
}
