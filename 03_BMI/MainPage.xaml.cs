namespace _03_BMI
{
	public partial class MainPage : ContentPage
	{
		double mybmi;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnClear(object sender, EventArgs e)
		{
			mybmi = double.Parse(weight.Text) / double.Parse(Height.Text) / double.Parse(Height.Text) * 10000;
			lblbmi.Text = "BMI = " + mybmi.ToString("0.0000");
			if (mybmi < 20) lblresult.Text = "저체중이네요";
			else if (mybmi < 25) lblresult.Text = "정상체중이네요";
			else if (mybmi < 30) lblresult.Text = "경도비만이네요";
			else
			{
				lblresult.Text = "비만";
			}
		}
	}
}