using System.Xml.Linq;

namespace projekt1
{
    public partial class Form1 : Form
    {   
        private Dictionary<string, float> _rates = new Dictionary<string, float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("https://api.nbp.pl/api/exchangerates/tables/a/?format=xml");
            var rates = api.Descendants("Rate");
            //czyszczenie slownika
            _rates.Clear(); 
            //parsujemy api
            foreach (var rate in rates)
            {
                
                if(rate.Element("Code") != null && rate.Element("Mid") != null)
                {
                    //wyciagnij sobie skrot nazwy waluty z api 
                    string code = rate.Element("Code").Value;
                    //wyciagnij sobie kurs waluty z api i przekonwertuj na float
                    float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);
                    //dodaj do slownika kurs waluty
                    _rates.Add(code, mid);
                }    
            }
            //wypisujemy kursy na ekranie 
            rateUSDTextBox.Text = _rates["USD"].ToString();
            rateEURTextBox.Text = _rates["EUR"].ToString();
            rateCHFTextBox.Text = _rates["CHF"].ToString();
        }

        private void debugTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void USDRadioButton_Click(object sender, EventArgs e)
        {
            string currency = (sender as RadioButton).Text;
            float ammountPLN = float.Parse(AmountPLNTextBox.Text, System.Globalization.CultureInfo.InvariantCulture);

            switch(currency) {
                case "USD":
                    calculatedAmountTextBox.Text = (ammountPLN / _rates["USD"]).ToString();
                    break;
                case "EUR":
                    calculatedAmountTextBox.Text = (ammountPLN / _rates["EUR"]).ToString();
                    break;
            }

        private void USDRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}