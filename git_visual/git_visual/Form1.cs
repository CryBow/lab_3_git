using git_visual.user_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_visual
{
    public partial class Form1 : Form
    {
        private string filePath = "C:\\Users\\User\\Desktop\\temperature.txt";
        private List<TemperatureData> temperatureDataList;
        private ITemperatureDataPrinter dataPrinter;
        private GraphicBuilder graphicBuilder;
        private TemperatureChangeCalculator changeCalculator;
        public Form1()
        {
            InitializeComponent();

            dataPrinter = new RichTextBoxTemperatureDataPrinter();
            graphicBuilder = new GraphicBuilder(chart1);
            changeCalculator = new TemperatureChangeCalculator();
        }

        private void btn_2_user_Click(object sender, EventArgs e)
        {
            // Построение графика и вывод данных в RichTextBox при нажатии кнопки
            graphicBuilder.BuildChart(temperatureDataList);
            dataPrinter.PrintData(temperatureDataList, richTextBox1);
            changeCalculator.CalculateTemperatureChange(temperatureDataList, richTextBox1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка данных о температуре при запуске формы
            LoadTemperatureData();
        }
        private void LoadTemperatureData()
        {
            ITemperatureDataReader dataReader = new FileTemperatureDataReader();
            temperatureDataList = dataReader.ReadData(filePath);
        }
    }
}
