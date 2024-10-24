using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KolmogorovGaborApp
{
    public partial class MainForm : Form
    {
        private List<double> inputData;
        private List<double> harmonics;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private List<double> forecastData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            dataGridViewInput = new DataGridView();
            dataGridViewForecast = new DataGridView();
            btnCalculateHarmonics = new Button();
            btnForecast = new Button();
            numericUpDownHarmonics = new NumericUpDown();
            numericUpDownForecastSteps = new NumericUpDown();
            labelHarmonics = new Label();
            labelForecastSteps = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForecast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHarmonics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForecastSteps).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.Location = new System.Drawing.Point(30, 50);
            this.dataGridViewInput.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewInput.ColumnCount = 1;
            this.dataGridViewInput.Columns[0].Name = "Вхідні дані";
            this.Controls.Add(this.dataGridViewInput);
            // 
            // dataGridViewForecast
            // 
            this.dataGridViewForecast.Location = new System.Drawing.Point(400, 50);
            this.dataGridViewForecast.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewForecast.ColumnCount = 1;
            this.dataGridViewForecast.Columns[0].Name = "Прогнозовані значення";
            this.Controls.Add(this.dataGridViewForecast);
            // 
            // btnCalculateHarmonics
            // 
            btnCalculateHarmonics.Location = new Point(30, 220);
            btnCalculateHarmonics.Name = "btnCalculateHarmonics";
            btnCalculateHarmonics.Size = new Size(186, 35);
            btnCalculateHarmonics.TabIndex = 2;
            btnCalculateHarmonics.Text = "Обчислити гармоніки";
            btnCalculateHarmonics.Click += BtnCalculateHarmonics_Click;
            // 
            // btnForecast
            // 
            btnForecast.Location = new Point(400, 220);
            btnForecast.Name = "btnForecast";
            btnForecast.Size = new Size(133, 35);
            btnForecast.TabIndex = 3;
            btnForecast.Text = "Прогнозувати";
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
            // labelHarmonics
            // 
            labelHarmonics.Location = new Point(30, 270);
            labelHarmonics.Name = "labelHarmonics";
            labelHarmonics.Size = new Size(186, 23);
            labelHarmonics.TabIndex = 5;
            labelHarmonics.Text = "Кількість гармонік";
            // 
            // labelForecastSteps
            // 
            labelForecastSteps.Location = new Point(400, 270);
            labelForecastSteps.Name = "labelForecastSteps";
            labelForecastSteps.Size = new Size(202, 23);
            labelForecastSteps.TabIndex = 7;
            labelForecastSteps.Text = "Кроки для прогнозування";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
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
            Name = "MainForm";
            Text = "Модель Колмогорова-Габора";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForecast).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHarmonics).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForecastSteps).EndInit();
            ResumeLayout(false);
        }

        // Обчислення гармонічних компонентів на основі вхідних даних
        private void BtnCalculateHarmonics_Click(object sender, EventArgs e)
        {
            inputData = new List<double>();

            // Отримання вхідних даних з таблиці
            foreach (DataGridViewRow row in dataGridViewInput.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    inputData.Add(Convert.ToDouble(row.Cells[0].Value));
                }
            }

            int numHarmonics = (int)numericUpDownHarmonics.Value;

            harmonics = KolmogorovGaborFilter.CalculateHarmonics(inputData, numHarmonics);

            MessageBox.Show("Гармонічні компоненти успішно обчислені!");
        }

        // Прогнозування на основі гармонічних компонентів
        private void BtnForecast_Click(object sender, EventArgs e)
        {
            if (harmonics == null || harmonics.Count == 0)
            {
                MessageBox.Show("Спочатку обчисліть гармонічні компоненти!");
                return;
            }

            int forecastSteps = (int)numericUpDownForecastSteps.Value;

            forecastData = KolmogorovGaborFilter.Forecast(harmonics, forecastSteps);

            // Виведення результатів у таблицю
            dataGridViewForecast.Rows.Clear();
            foreach (var value in forecastData)
            {
                dataGridViewForecast.Rows.Add(value);
            }
        }

        private DataGridView dataGridViewInput;
        private DataGridView dataGridViewForecast;
        private Button btnCalculateHarmonics;
        private Button btnForecast;
        private NumericUpDown numericUpDownHarmonics;
        private NumericUpDown numericUpDownForecastSteps;
        private Label labelHarmonics;
        private Label labelForecastSteps;

        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }
    }

    public static class KolmogorovGaborFilter
    {
        // Метод для розрахунку гармонічних компонентів
        public static List<double> CalculateHarmonics(List<double> data, int numHarmonics)
        {
            List<double> harmonics = new List<double>();

            // Простий приклад побудови гармонічних компонентів
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

        // Метод для прогнозування на основі гармонічних компонентів
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
