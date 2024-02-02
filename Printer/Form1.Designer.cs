namespace Printer
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
            NumeroDeCaixasTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            ClientesComboBox = new MaterialSkin.Controls.MaterialComboBox();
            UpdateClientesButton = new MaterialSkin.Controls.MaterialButton();
            OFFSET1Textbox = new MaterialSkin.Controls.MaterialTextBox();
            OFFSET2Textbox = new MaterialSkin.Controls.MaterialTextBox();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            PrintButton = new MaterialSkin.Controls.MaterialButton();
            Printer1Checkbox = new CheckBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            Printer2Checkbox = new CheckBox();
            StatusImpressora1Text = new Label();
            label1 = new Label();
            Printer1Name = new MaterialSkin.Controls.MaterialTextBox();
            Printer2Name = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // NumeroDeCaixasTextBox
            // 
            NumeroDeCaixasTextBox.AnimateReadOnly = false;
            NumeroDeCaixasTextBox.BackgroundImageLayout = ImageLayout.None;
            NumeroDeCaixasTextBox.CharacterCasing = CharacterCasing.Normal;
            NumeroDeCaixasTextBox.Depth = 0;
            NumeroDeCaixasTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NumeroDeCaixasTextBox.HelperText = "100";
            NumeroDeCaixasTextBox.HideSelection = true;
            NumeroDeCaixasTextBox.Hint = "Número de caixas";
            NumeroDeCaixasTextBox.LeadingIcon = null;
            NumeroDeCaixasTextBox.Location = new Point(12, 20);
            NumeroDeCaixasTextBox.MaxLength = 32767;
            NumeroDeCaixasTextBox.MouseState = MaterialSkin.MouseState.OUT;
            NumeroDeCaixasTextBox.Name = "NumeroDeCaixasTextBox";
            NumeroDeCaixasTextBox.PasswordChar = '\0';
            NumeroDeCaixasTextBox.PrefixSuffixText = null;
            NumeroDeCaixasTextBox.ReadOnly = false;
            NumeroDeCaixasTextBox.RightToLeft = RightToLeft.No;
            NumeroDeCaixasTextBox.SelectedText = "";
            NumeroDeCaixasTextBox.SelectionLength = 0;
            NumeroDeCaixasTextBox.SelectionStart = 0;
            NumeroDeCaixasTextBox.ShortcutsEnabled = true;
            NumeroDeCaixasTextBox.Size = new Size(198, 48);
            NumeroDeCaixasTextBox.TabIndex = 4;
            NumeroDeCaixasTextBox.TabStop = false;
            NumeroDeCaixasTextBox.TextAlign = HorizontalAlignment.Left;
            NumeroDeCaixasTextBox.TrailingIcon = null;
            NumeroDeCaixasTextBox.UseSystemPasswordChar = false;
            // 
            // ClientesComboBox
            // 
            ClientesComboBox.AutoResize = false;
            ClientesComboBox.BackColor = Color.FromArgb(255, 255, 255);
            ClientesComboBox.Depth = 0;
            ClientesComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            ClientesComboBox.DropDownHeight = 174;
            ClientesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClientesComboBox.DropDownWidth = 121;
            ClientesComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ClientesComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ClientesComboBox.FormattingEnabled = true;
            ClientesComboBox.Hint = "Cliente";
            ClientesComboBox.IntegralHeight = false;
            ClientesComboBox.ItemHeight = 43;
            ClientesComboBox.Location = new Point(12, 74);
            ClientesComboBox.MaxDropDownItems = 4;
            ClientesComboBox.MouseState = MaterialSkin.MouseState.OUT;
            ClientesComboBox.Name = "ClientesComboBox";
            ClientesComboBox.Size = new Size(198, 49);
            ClientesComboBox.StartIndex = 0;
            ClientesComboBox.TabIndex = 6;
            // 
            // UpdateClientesButton
            // 
            UpdateClientesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UpdateClientesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            UpdateClientesButton.Depth = 0;
            UpdateClientesButton.HighEmphasis = true;
            UpdateClientesButton.Icon = null;
            UpdateClientesButton.Location = new Point(217, 79);
            UpdateClientesButton.Margin = new Padding(4, 6, 4, 6);
            UpdateClientesButton.MouseState = MaterialSkin.MouseState.HOVER;
            UpdateClientesButton.Name = "UpdateClientesButton";
            UpdateClientesButton.NoAccentTextColor = Color.Empty;
            UpdateClientesButton.Size = new Size(99, 36);
            UpdateClientesButton.TabIndex = 7;
            UpdateClientesButton.Text = "Atualizar";
            UpdateClientesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            UpdateClientesButton.UseAccentColor = false;
            UpdateClientesButton.UseVisualStyleBackColor = true;
            // 
            // OFFSET1Textbox
            // 
            OFFSET1Textbox.AnimateReadOnly = false;
            OFFSET1Textbox.BorderStyle = BorderStyle.None;
            OFFSET1Textbox.Depth = 0;
            OFFSET1Textbox.Font = new Font("Microsoft Sans Serif", 12F);
            OFFSET1Textbox.Hint = "Offset Impressora #01(mm)";
            OFFSET1Textbox.LeadingIcon = null;
            OFFSET1Textbox.Location = new Point(12, 191);
            OFFSET1Textbox.MaxLength = 50;
            OFFSET1Textbox.MouseState = MaterialSkin.MouseState.OUT;
            OFFSET1Textbox.Multiline = false;
            OFFSET1Textbox.Name = "OFFSET1Textbox";
            OFFSET1Textbox.Size = new Size(198, 50);
            OFFSET1Textbox.TabIndex = 2;
            OFFSET1Textbox.Text = "-10";
            OFFSET1Textbox.TrailingIcon = null;
            OFFSET1Textbox.Visible = false;
            // 
            // OFFSET2Textbox
            // 
            OFFSET2Textbox.AnimateReadOnly = false;
            OFFSET2Textbox.BorderStyle = BorderStyle.None;
            OFFSET2Textbox.Depth = 0;
            OFFSET2Textbox.Font = new Font("Microsoft Sans Serif", 12F);
            OFFSET2Textbox.Hint = "Offset Impressora #02(mm)";
            OFFSET2Textbox.LeadingIcon = null;
            OFFSET2Textbox.Location = new Point(12, 247);
            OFFSET2Textbox.MaxLength = 50;
            OFFSET2Textbox.MouseState = MaterialSkin.MouseState.OUT;
            OFFSET2Textbox.Multiline = false;
            OFFSET2Textbox.Name = "OFFSET2Textbox";
            OFFSET2Textbox.Size = new Size(198, 50);
            OFFSET2Textbox.TabIndex = 12;
            OFFSET2Textbox.Text = "0";
            OFFSET2Textbox.TrailingIcon = null;
            OFFSET2Textbox.Visible = false;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(12, 135);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(106, 37);
            materialCheckbox1.TabIndex = 13;
            materialCheckbox1.Text = "Avançado";
            materialCheckbox1.UseVisualStyleBackColor = true;
            materialCheckbox1.CheckedChanged += materialCheckbox1_CheckedChanged;
            // 
            // PrintButton
            // 
            PrintButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PrintButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PrintButton.Depth = 0;
            PrintButton.HighEmphasis = true;
            PrintButton.Icon = null;
            PrintButton.Location = new Point(290, 136);
            PrintButton.Margin = new Padding(4, 6, 4, 6);
            PrintButton.MouseState = MaterialSkin.MouseState.HOVER;
            PrintButton.Name = "PrintButton";
            PrintButton.NoAccentTextColor = Color.Empty;
            PrintButton.Size = new Size(87, 36);
            PrintButton.TabIndex = 14;
            PrintButton.Text = "Imprimir";
            PrintButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PrintButton.UseAccentColor = false;
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButton_Click_1;
            // 
            // Printer1Checkbox
            // 
            Printer1Checkbox.AutoSize = true;
            Printer1Checkbox.Location = new Point(226, 31);
            Printer1Checkbox.Name = "Printer1Checkbox";
            Printer1Checkbox.Size = new Size(93, 19);
            Printer1Checkbox.TabIndex = 15;
            Printer1Checkbox.Text = "Impressora 1";
            Printer1Checkbox.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(217, 9);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(88, 19);
            materialLabel1.TabIndex = 16;
            materialLabel1.Text = "Impressoras";
            // 
            // Printer2Checkbox
            // 
            Printer2Checkbox.AutoSize = true;
            Printer2Checkbox.Location = new Point(226, 49);
            Printer2Checkbox.Name = "Printer2Checkbox";
            Printer2Checkbox.Size = new Size(93, 19);
            Printer2Checkbox.TabIndex = 17;
            Printer2Checkbox.Text = "Impressora 2";
            Printer2Checkbox.UseVisualStyleBackColor = true;
            // 
            // StatusImpressora1Text
            // 
            StatusImpressora1Text.AutoSize = true;
            StatusImpressora1Text.Location = new Point(314, 31);
            StatusImpressora1Text.Name = "StatusImpressora1Text";
            StatusImpressora1Text.Size = new Size(29, 15);
            StatusImpressora1Text.TabIndex = 18;
            StatusImpressora1Text.Text = "| OK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 19;
            label1.Text = "| OK";
            // 
            // Printer1Name
            // 
            Printer1Name.AnimateReadOnly = false;
            Printer1Name.BorderStyle = BorderStyle.None;
            Printer1Name.Depth = 0;
            Printer1Name.Font = new Font("Microsoft Sans Serif", 12F);
            Printer1Name.Hint = "Nome da impressora 1";
            Printer1Name.LeadingIcon = null;
            Printer1Name.Location = new Point(226, 191);
            Printer1Name.MaxLength = 50;
            Printer1Name.MouseState = MaterialSkin.MouseState.OUT;
            Printer1Name.Multiline = false;
            Printer1Name.Name = "Printer1Name";
            Printer1Name.Size = new Size(151, 50);
            Printer1Name.TabIndex = 20;
            Printer1Name.Text = "Plotter1";
            Printer1Name.TrailingIcon = null;
            // 
            // Printer2Name
            // 
            Printer2Name.AnimateReadOnly = false;
            Printer2Name.BorderStyle = BorderStyle.None;
            Printer2Name.Depth = 0;
            Printer2Name.Font = new Font("Microsoft Sans Serif", 12F);
            Printer2Name.Hint = "Nome da impressora 2";
            Printer2Name.LeadingIcon = null;
            Printer2Name.Location = new Point(226, 247);
            Printer2Name.MaxLength = 50;
            Printer2Name.MouseState = MaterialSkin.MouseState.OUT;
            Printer2Name.Multiline = false;
            Printer2Name.Name = "Printer2Name";
            Printer2Name.Size = new Size(151, 50);
            Printer2Name.TabIndex = 21;
            Printer2Name.Text = "Plotter2";
            Printer2Name.TrailingIcon = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DimGray;
            ClientSize = new Size(396, 313);
            Controls.Add(Printer2Name);
            Controls.Add(Printer1Name);
            Controls.Add(label1);
            Controls.Add(StatusImpressora1Text);
            Controls.Add(Printer2Checkbox);
            Controls.Add(materialLabel1);
            Controls.Add(Printer1Checkbox);
            Controls.Add(PrintButton);
            Controls.Add(materialCheckbox1);
            Controls.Add(OFFSET2Textbox);
            Controls.Add(UpdateClientesButton);
            Controls.Add(OFFSET1Textbox);
            Controls.Add(ClientesComboBox);
            Controls.Add(NumeroDeCaixasTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Printer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 NumeroDeCaixasTextBox;
        private MaterialSkin.Controls.MaterialComboBox ClientesComboBox;
        private MaterialSkin.Controls.MaterialButton UpdateClientesButton;
        private ComboBox a;
        private MaterialSkin.Controls.MaterialTextBox OFFSET1Textbox;
        private MaterialSkin.Controls.MaterialTextBox OFFSET2Textbox;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialButton PrintButton;
        private CheckBox Printer1Checkbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private CheckBox Printer2Checkbox;
        private Label StatusImpressora1Text;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox Printer1Name;
        private MaterialSkin.Controls.MaterialTextBox Printer2Name;
    }
}
