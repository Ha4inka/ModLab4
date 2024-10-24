using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KolmogorovGaborApp
{
    public partial class MainForm : Form
    {
        private List<double> inputData;
        private List<List<double>> harmonicsModels; // ������ ������� ��� ����� �������
        private List<double> forecastData;
        private int numModels; // ʳ������ �������

        public MainForm()
        {
            InitializeComponent();
            harmonicsModels = new List<List<double>>();
            numModels = 1; // ��������� ������� �������
        }

        private void InitializeComponent()
        {
            dataGridViewInput = new DataGridView();
            dataGridViewForecast = new DataGridView();
            btnCalculateHarmonics = new Button();
            btnForecast = new Button();
            numericUpDownHarmonics = new NumericUpDown();
            numericUpDownForecastSteps = new NumericUpDown();
            numericUpDownModels = new NumericUpDown(); // ����������� ������ NumericUpDown ��� �������
            labelHarmonics = new Label();
            labelForecastSteps = new Label();
            labelModels = new Label(); // ����������� ���� ��� �������
            harmonicsModels = new List<List<double>>();

            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForecast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHarmonics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForecastSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownModels).BeginInit(); // ������ �����������

            SuspendLayout();

            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.Location = new System.Drawing.Point(30, 50);
            this.dataGridViewInput.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewInput.ColumnCount = 1;
            this.dataGridViewInput.Columns[0].Name = "����� ���";
            this.Controls.Add(this.dataGridViewInput);

            // 
            // dataGridViewForecast
            // 
            this.dataGridViewForecast.Location = new System.Drawing.Point(400, 50);
            this.dataGridViewForecast.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewForecast.ColumnCount = 1;
            this.dataGridViewForecast.Columns[0].Name = "����������� ��������";
            this.Controls.Add(this.dataGridViewForecast);

            // 
            // btnCalculateHarmonics
            // 
            btnCalculateHarmonics.Location = new Point(30, 220);
            btnCalculateHarmonics.Name = "btnCalculateHarmonics";
            btnCalculateHarmonics.Size = new Size(186, 35);
            btnCalculateHarmonics.TabIndex = 2;
            btnCalculateHarmonics.Text = "��������� ��������";
            btnCalculateHarmonics.Click += BtnCalculateHarmonics_Click;

            // 
            // btnForecast
            // 
            btnForecast.Location = new Point(400, 220);
            btnForecast.Name = "btnForecast";
            btnForecast.Size = new Size(133, 35);
            btnForecast.TabIndex = 3;
            btnForecast.Text = "������������";
            btnForecast.Click += BtnForecast_Click;

            // 
            // numericUpDownHarmonics
            // 
            numericUpDownHarmonics.Location = new Point(30, 300);
            numericUpDownHarmonics.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHarmonics.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHarmonics.Name = "numericUpDownHarmonics";
            numericUpDownHarmonics.Size = new Size(120, 27);
            numericUpDownHarmonics.TabIndex = 4;
            numericUpDownHarmonics.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // numericUpDownForecastSteps
            // 
            numericUpDownForecastSteps.Location = new Point(400, 300);
            numericUpDownForecastSteps.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownForecastSteps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownForecastSteps.Name = "numericUpDownForecastSteps";
            numericUpDownForecastSteps.Size = new Size(120, 27);
            numericUpDownForecastSteps.TabIndex = 6;
            numericUpDownForecastSteps.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // numericUpDownModels
            // 
            numericUpDownModels.Location = new Point(30, 350);
            numericUpDownModels.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownModels.Maximum = new decimal(new int[] { 5, 0, 0, 0 }); // �������� �� 5 �������
            numericUpDownModels.Name = "numericUpDownModels";
            numericUpDownModels.Size = new Size(120, 27);
            numericUpDownModels.TabIndex = 7;
            numericUpDownModels.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // labelHarmonics
            // 
            labelHarmonics.Location = new Point(30, 270);
            labelHarmonics.Name = "labelHarmonics";
            labelHarmonics.Size = new Size(186, 23);
            labelHarmonics.TabIndex = 5;
            labelHarmonics.Text = "ʳ������ �������";

            // 
            // labelForecastSteps
            // 
            labelForecastSteps.Location = new Point(400, 270);
            labelForecastSteps.Name = "labelForecastSteps";
            labelForecastSteps.Size = new Size(202, 23);
            labelForecastSteps.TabIndex = 8;
            labelForecastSteps.Text = "����� ��� �������������";

            // 
            // labelModels
            // 
            labelModels.Location = new Point(30, 320);
            labelModels.Name = "labelModels";
            labelModels.Size = new Size(186, 23);
            labelModels.TabIndex = 9;
            labelModels.Text = "ʳ������ �������";

            // 
            // MainForm
            // 
            ClientSize = new Size(782, 553);
            Controls.Add(dataGridViewInput);
            Controls.Add(dataGridViewForecast);
            Controls.Add(btnCalculateHarmonics);
            Controls.Add(btnForecast);
            Controls.Add(numericUpDownHarmonics);
            Controls.Add(labelHarmonics);
            Controls.Add(numericUpDownForecastSteps);
            Controls.Add(labelForecastSteps);
            Controls.Add(numericUpDownModels); // ������ ����� NumericUpDown ��� �������
            Controls.Add(labelModels); // ������ ���� ��� �������
            Name = "MainForm";
            Text = "������ �����������-������";

            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForecast).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHarmonics).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForecastSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownModels).EndInit(); // ������ �����������
            ResumeLayout(false);
        }

        // ���������� ���������� ���������� �� ����� ������� �����
        private void BtnCalculateHarmonics_Click(object sender, EventArgs e)
        {
            inputData = new List<double>();
            harmonicsModels.Clear(); // �������� ��������� �������

            foreach (DataGridViewRow row in dataGridViewInput.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    inputData.Add(Convert.ToDouble(row.Cells[0].Value));
                }
            }

            int numHarmonics = (int)numericUpDownHarmonics.Value;
            numModels = (int)numericUpDownModels.Value; // �������� ������� �������

            for (int modelIndex = 0; modelIndex < numModels; modelIndex++)
            {
                var harmonics = KolmogorovGaborFilter.CalculateHarmonics(inputData, numHarmonics);
                harmonicsModels.Add(harmonics);
            }

            MessageBox.Show($"{numModels} ����� ������� ������ ��������!");
        }

        // ������������� �� ����� ���������� ����������
        private void BtnForecast_Click(object sender, EventArgs e)
        {
            if (harmonicsModels.Count == 0 || harmonicsModels[0].Count == 0)
            {
                MessageBox.Show("�������� �������� �������� ����������!");
                return;
            }

            int forecastSteps = (int)numericUpDownForecastSteps.Value;
            forecastData = new List<double>();

            foreach (var harmonics in harmonicsModels)
            {
                var forecast = KolmogorovGaborFilter.Forecast(harmonics, forecastSteps);
                forecastData.AddRange(forecast);
            }

            // ��������� ���������� � �������
            dataGridViewForecast.Rows.Clear();
            foreach (var value in forecastData)
            {
                dataGridViewForecast.Rows.Add(value);
            }

            // ���������� �� ����������� ����������� �������������
            ShowComparisonCharacteristics();
        }

        // ³���������� ������������� ��� ��������� �������
        private void ShowComparisonCharacteristics()
        {
            // ���������� ������������� ��� ������������� �����
            double average = CalculateAverage(forecastData);
            double stddev = CalculateStandardDeviation(forecastData, average);
            MessageBox.Show($"������: {average}, ���������� ���������: {stddev}");
        }


        private double CalculateAverage(List<double> data)
        {
            double sum = 0;
            foreach (var value in data)
            {
                sum += value;
            }
            return sum / data.Count;
        }

        private double CalculateStandardDeviation(List<double> data, double average)
        {
            double sumOfSquares = 0;
            foreach (var value in data)
            {
                sumOfSquares += Math.Pow(value - average, 2);
            }
            return Math.Sqrt(sumOfSquares / data.Count);
        }

        private DataGridView dataGridViewInput;
        private DataGridView dataGridViewForecast;
        private Button btnCalculateHarmonics;
        private Button btnForecast;
        private NumericUpDown numericUpDownHarmonics;
        private NumericUpDown numericUpDownForecastSteps;
        private NumericUpDown numericUpDownModels; // ������ ��� ������ ������� �������
        private Label labelHarmonics;
        private Label labelForecastSteps;
        private Label labelModels; // ������ ��� ����������� ������� �������

        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }
    }

    public static class KolmogorovGaborFilter
    {
        public static List<double> CalculateHarmonics(List<double> data, int numHarmonics)
        {
            List<double> harmonics = new List<double>();

            for (int i = 0; i < numHarmonics; i++)
            {
                double harmonic = 0;
                for (int j = 0; j < data.Count; j++)
                {
                    harmonic += data[j] * Math.Cos(2 * Math.PI * i * j / data.Count);
                }
                harmonics.Add(harmonic);
            }

            return harmonics;
        }

        public static List<double> Forecast(List<double> harmonics, int forecastSteps)
        {
            List<double> forecast = new List<double>();

            for (int i = 0; i < forecastSteps; i++)
            {
                double prediction = 0;
                for (int j = 0; j < harmonics.Count; j++)
                {
                    prediction += harmonics[j] * Math.Cos(2 * Math.PI * j * i / forecastSteps);
                }
                forecast.Add(prediction);
            }

            return forecast;
        }
    }
}
