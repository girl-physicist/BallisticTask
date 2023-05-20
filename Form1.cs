using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;


namespace BallisticTask
{
    public partial class Form1 : Form
    {
        private const double GRAVITY = 9.81;
        private static double initialHeight;
        private static double initialSpeed;
        private static double angle;
        private static double airResistanceCoefficient;
        private static double timeInterval;
        private double hMax;
        private double lMax;
        private double tMax;
        private double hMaxTeor;
        private double lMaxTeor;
        private double tMaxTeor;
        bool flag = true;
       

        public List<double> Xcoordinate { get; private set; } = new List<double>();
        public List<double> Ycoordinate { get; private set; } = new List<double>();
        public List<double> Time { get; private set; } = new List<double>();

        public Form1()
        {
            InitializeComponent();
            
        }

        public void InputData()
        {
            try
            {
                initialHeight = double.Parse(textBoxH.Text);
                initialSpeed = double.Parse(textBoxV0.Text);
                angle = double.Parse(textBoxAlpha.Text);
                airResistanceCoefficient = double.Parse(textBoxR.Text);
                timeInterval = double.Parse(textBoxT.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InitChart()
        {
            CalcInitialData();
            chart1.ChartAreas[0].AxisX.Maximum = lMaxTeor + 5;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = hMaxTeor + 1;


        }
        public double[] CalcInitialData()
        {
            InputData();
            lMaxTeor = initialSpeed * initialSpeed * Sin(2 * angle * PI / 180) / GRAVITY;
            hMaxTeor = initialSpeed * initialSpeed * Sin(angle * PI / 180) * Sin(angle * PI / 180) / 2 / GRAVITY + initialHeight;
            double _angleRadians = angle * PI / 180;
            double _horizontalSpeed = initialSpeed * Cos(_angleRadians);
            double _verticalSpeed = initialSpeed * Sin(_angleRadians);
            double[] _initialState = { 0, initialHeight, _horizontalSpeed, _verticalSpeed }; // x, y, vx, vy
            return _initialState;
        }

        public void ClearChart()
        {
            chart1.Series[0].Points.Clear();
        }
        private async Task RungeKuttaSimulation(double[] _initialState, double _dt, double _airResistanceCoefficient)
        {
            flag = true;
            double _currentTime = 0;
            double[] _currentState = _initialState;// {x, y, vx, vy}
            while (_currentState[1] >= 0 && flag == true)
            {
                double[] k1 = Derivative(_currentState, _airResistanceCoefficient); // Derivate { vx, vy, ax, ay }
                double[] k2 = Derivative(AddScaledVectors(_currentState, k1, 0.5 * _dt), _airResistanceCoefficient);
                double[] k3 = Derivative(AddScaledVectors(_currentState, k2, 0.5 * _dt), _airResistanceCoefficient);
                double[] k4 = Derivative(AddScaledVectors(_currentState, k3, _dt), _airResistanceCoefficient);
                for (int i = 0; i < _currentState.Length; i++)
                {
                    _currentState[i] += _dt * (k1[i] + 2 * k2[i] + 2 * k3[i] + k4[i]) / 6;

                }
                _currentTime += _dt;
                CreateDataList(_currentTime, _currentState);
                DrawInChart(_currentState);
              
                await Task.Delay(1);
            }
        }

        public void CreateDataList(double _currentTime, double[] _currentState)
        {
            Ycoordinate.Add(_currentState[1]);
            Xcoordinate.Add(_currentState[0]);
            Time.Add(_currentTime);
        }
       
        private void FindMax ()
        {
            hMax = Ycoordinate.Max();
            lMax = Xcoordinate.Max();
            tMax = Time.Max();
        }
        private void DrawInChart(double[] _currentState)
        {
            chart1.Series[0].Points.AddXY(_currentState[0], _currentState[1]);
        }
        private static double[] Derivative(double[] state, double airResistanceCoefficient)
        {
            double vx = state[2];
            double vy = state[3];

            double ax = -airResistanceCoefficient * vx * Math.Sqrt(vx * vx + vy * vy);
            double ay = -GRAVITY - airResistanceCoefficient * vy * Math.Sqrt(vx * vx + vy * vy);

            return new double[] { vx, vy, ax, ay };
        }

        private static double[] AddScaledVectors(double[] v1, double[] v2, double scaleFactor)
        {
            double[] result = new double[v1.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = v1[i] + scaleFactor * v2[i];
            }

            return result;
        }


        private async void buttonStart_Click(object sender, EventArgs e)
        {
            InitChart();
            await RungeKuttaSimulation(CalcInitialData(), timeInterval, airResistanceCoefficient);
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearChart();
        }
        private void DisableInput(KeyPressEventArgs _e)
        {
            if (Char.IsNumber(_e.KeyChar) | Char.IsControl(_e.KeyChar) | (Char.IsPunctuation(_e.KeyChar))) return;
            else
                _e.Handled = true;
        }
        private void textBoxH_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableInput(e);
        }
        private void textBoxV0_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableInput(e);
        }

        private void textBoxAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableInput(e);
        }

        private void textBoxR_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableInput(e);
        }

        private void textBoxT_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableInput(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindMax();
            textBoxHMax.Text = hMax.ToString();
            textBoxLMax.Text = lMax.ToString();
            textBoxTMax.Text = tMax.ToString();

            textBoxLMaxTeor.Text = lMaxTeor.ToString();
            textBoxHMaxTeor.Text = hMaxTeor.ToString();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputDataForm outputData = new OutputDataForm(this);
            outputData.Show();
            
        }
    }

}

