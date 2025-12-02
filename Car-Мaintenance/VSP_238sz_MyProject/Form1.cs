namespace VSP_238sz_MyProject
{
    public partial class Form1 : Form
    {
        private const int OilChange = 10000;
        private const int gearboxOilChange = 60000;
        private const int timingBeltKitChange = 80000;
        private const int padsChange = 50000;
        private const int brakeDiscsChange = 100000;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string output = "";

            if (this.checkBoxOil.Checked)
            {
                output = $"Следващата смяна на масло и филтри трябва да се извърши на {CalculateFutureChange(OilChange)} км, а до тогава остават {CalculateKmLeftToNextChange(OilChange)} км.";

                this.richTextBoxOutput.Text = output;

                this.checkBoxOil.Checked = false;
            }
            else if (this.checkBoxGearbox.Checked)
            {
                output = $"Следващата смяна на маслото на скоростната кутия трябва да се извърши на {CalculateFutureChange(gearboxOilChange)} км, а до тогава остават {CalculateKmLeftToNextChange(gearboxOilChange)} км.";

                this.richTextBoxOutput.Text = output;

                this.checkBoxGearbox.Checked = false;
            }
            else if (this.checkBoxTimingBelt.Checked)
            {
                output = $"Следващата смяна на комплект ангренажен ремък трябва да се извърши на {CalculateFutureChange(timingBeltKitChange)} км, а до тогава остават {CalculateKmLeftToNextChange(timingBeltKitChange)} км.";

                this.richTextBoxOutput.Text = output;

                this.checkBoxTimingBelt.Checked = false;
            }
            else if (this.checkBoxPads.Checked)
            {
                output = $"Следващата смяна на накладките трябва да се извърши на {CalculateFutureChange(padsChange)} км, а до тогава остават {CalculateKmLeftToNextChange(padsChange)} км.";

                this.richTextBoxOutput.Text = output;

                this.checkBoxPads.Checked = false;
            }
            else if (this.checkBoxBrakesDiscs.Checked)
            {
                output = $"Следващата смяна на спирачните дискове трябва да се извърши на {CalculateFutureChange(brakeDiscsChange)} км, а до тогава остават {CalculateKmLeftToNextChange(brakeDiscsChange)} км.";

                this.richTextBoxOutput.Text = output;

                this.checkBoxBrakesDiscs.Checked = false;
            }
        }

       
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxLastChange.Text = "";
            this.textBoxCurrentKm.Text = "";
            this.richTextBoxOutput.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.richTextBoxOutput.SaveFile(MyFile);
            MessageBox.Show($"Информацията е запазена успешно в {MyFile}.");
        }

        private int CalculateFutureChange(int partToChange)
        {
            int lastChange = int.Parse(this.textBoxLastChange.Text);

            int futureChange = lastChange + partToChange;

            return futureChange;
        }

        private int CalculateKmLeftToNextChange(int partToChange)
        {
            int currentKm = int.Parse(this.textBoxCurrentKm.Text);

            int kmLeft = CalculateFutureChange(partToChange) - currentKm;

            return kmLeft;
        }

        private void textBoxCurrentKm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int lastChange = int.Parse(this.textBoxLastChange.Text); 
            int currentKm = int.Parse(this.textBoxCurrentKm.Text);

            if (currentKm < lastChange)
            {
                throw new ArgumentOutOfRangeException("Текущите километри няма как да са по - малко от километрите при последната смяна!");
            }
        }
    }
}
