namespace VSP_238sz_MyProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxLastChange = new TextBox();
            textBoxCurrentKm = new TextBox();
            buttonCalculate = new Button();
            buttonSave = new Button();
            checkBoxOil = new CheckBox();
            checkBoxGearbox = new CheckBox();
            checkBoxTimingBelt = new CheckBox();
            checkBoxPads = new CheckBox();
            checkBoxBrakesDiscs = new CheckBox();
            buttonClear = new Button();
            richTextBoxOutput = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 0;
            label1.Text = "Километри последна смяна:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 19);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 1;
            label2.Text = "Текущи километри:";
            // 
            // textBoxLastChange
            // 
            textBoxLastChange.Location = new Point(40, 51);
            textBoxLastChange.Name = "textBoxLastChange";
            textBoxLastChange.Size = new Size(303, 27);
            textBoxLastChange.TabIndex = 2;
            // 
            // textBoxCurrentKm
            // 
            textBoxCurrentKm.Location = new Point(369, 51);
            textBoxCurrentKm.Name = "textBoxCurrentKm";
            textBoxCurrentKm.Size = new Size(303, 27);
            textBoxCurrentKm.TabIndex = 3;
            textBoxCurrentKm.Validating += textBoxCurrentKm_Validating;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(40, 281);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(96, 45);
            buttonCalculate.TabIndex = 7;
            buttonCalculate.Text = "Пресметни";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(142, 281);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(96, 45);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Запази";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // checkBoxOil
            // 
            checkBoxOil.AutoSize = true;
            checkBoxOil.Location = new Point(40, 96);
            checkBoxOil.Name = "checkBoxOil";
            checkBoxOil.Size = new Size(212, 24);
            checkBoxOil.TabIndex = 10;
            checkBoxOil.Text = "Смяна на масло и филтри";
            checkBoxOil.UseVisualStyleBackColor = true;
            // 
            // checkBoxGearbox
            // 
            checkBoxGearbox.AutoSize = true;
            checkBoxGearbox.Location = new Point(40, 126);
            checkBoxGearbox.Name = "checkBoxGearbox";
            checkBoxGearbox.Size = new Size(281, 24);
            checkBoxGearbox.TabIndex = 11;
            checkBoxGearbox.Text = "Смяна на масло на скоростна кутия";
            checkBoxGearbox.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimingBelt
            // 
            checkBoxTimingBelt.AutoSize = true;
            checkBoxTimingBelt.Location = new Point(40, 156);
            checkBoxTimingBelt.Name = "checkBoxTimingBelt";
            checkBoxTimingBelt.Size = new Size(303, 24);
            checkBoxTimingBelt.TabIndex = 12;
            checkBoxTimingBelt.Text = "Смяна на комплект ангренажен ремък";
            checkBoxTimingBelt.UseVisualStyleBackColor = true;
            // 
            // checkBoxPads
            // 
            checkBoxPads.AutoSize = true;
            checkBoxPads.Location = new Point(40, 186);
            checkBoxPads.Name = "checkBoxPads";
            checkBoxPads.Size = new Size(165, 24);
            checkBoxPads.TabIndex = 13;
            checkBoxPads.Text = "Смяна на накладки";
            checkBoxPads.UseVisualStyleBackColor = true;
            // 
            // checkBoxBrakesDiscs
            // 
            checkBoxBrakesDiscs.AutoSize = true;
            checkBoxBrakesDiscs.Location = new Point(40, 216);
            checkBoxBrakesDiscs.Name = "checkBoxBrakesDiscs";
            checkBoxBrakesDiscs.Size = new Size(229, 24);
            checkBoxBrakesDiscs.TabIndex = 14;
            checkBoxBrakesDiscs.Text = "Смяна на спирачни дискове";
            checkBoxBrakesDiscs.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(247, 281);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(96, 45);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Изчисти";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Location = new Point(369, 96);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.ReadOnly = true;
            richTextBoxOutput.Size = new Size(303, 230);
            richTextBoxOutput.TabIndex = 16;
            richTextBoxOutput.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 354);
            Controls.Add(richTextBoxOutput);
            Controls.Add(buttonClear);
            Controls.Add(checkBoxBrakesDiscs);
            Controls.Add(checkBoxPads);
            Controls.Add(checkBoxTimingBelt);
            Controls.Add(checkBoxGearbox);
            Controls.Add(checkBoxOil);
            Controls.Add(buttonSave);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxCurrentKm);
            Controls.Add(textBoxLastChange);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(710, 401);
            MinimumSize = new Size(710, 401);
            Name = "Form1";
            Text = " Навременна поддръжка на кола";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLastChange;
        private TextBox textBoxCurrentKm;
        private Button buttonCalculate;
        private Button buttonSave;
        private CheckBox checkBoxOil;
        private CheckBox checkBoxGearbox;
        private CheckBox checkBoxTimingBelt;
        private CheckBox checkBoxPads;
        private CheckBox checkBoxBrakesDiscs;
        private Button buttonClear;
        const string MyFile = "CalculatingHistory.rtf";
        private RichTextBox richTextBoxOutput;
    }
}
