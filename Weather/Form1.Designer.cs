namespace Weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            enterLabel = new Label();
            cityTextBox = new TextBox();
            searchButton = new Button();
            conditionText = new Label();
            pictureBox = new PictureBox();
            tempLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            humidityLabel = new Label();
            pressureLabel = new Label();
            windSpeedLabel = new Label();
            windDirectionLabel = new Label();
            sunriseLabel = new Label();
            sunsetLabel = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            convertToFarentheitToolStripMenuItem = new ToolStripMenuItem();
            dayForecastToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // enterLabel
            // 
            enterLabel.AutoSize = true;
            enterLabel.BackColor = Color.Transparent;
            enterLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            enterLabel.ForeColor = SystemColors.Control;
            enterLabel.Location = new Point(28, 32);
            enterLabel.Name = "enterLabel";
            enterLabel.Size = new Size(142, 28);
            enterLabel.TabIndex = 0;
            enterLabel.Text = "Enter your city:";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(191, 37);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(142, 23);
            cityTextBox.TabIndex = 1;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(339, 26);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(82, 47);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // conditionText
            // 
            conditionText.AutoSize = true;
            conditionText.BackColor = Color.Transparent;
            conditionText.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            conditionText.ForeColor = Color.White;
            conditionText.Location = new Point(390, 281);
            conditionText.Name = "conditionText";
            conditionText.Size = new Size(0, 31);
            conditionText.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.ErrorImage = null;
            pictureBox.Location = new Point(332, 173);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(89, 82);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.BackColor = Color.Transparent;
            tempLabel.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            tempLabel.ForeColor = Color.White;
            tempLabel.Location = new Point(442, 186);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(0, 52);
            tempLabel.TabIndex = 5;
            tempLabel.Click += tempLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(105, 333);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 6;
            label2.Text = "Humidity:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(105, 392);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 7;
            label3.Text = "Pressure:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(339, 333);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 8;
            label4.Text = "Wind Speed:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(339, 392);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 9;
            label5.Text = "Wind Direction:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(599, 333);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 10;
            label6.Text = "Sunrise:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(599, 392);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 11;
            label7.Text = "Sunset:";
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.BackColor = Color.Transparent;
            humidityLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            humidityLabel.ForeColor = Color.White;
            humidityLabel.Location = new Point(203, 333);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new Size(45, 25);
            humidityLabel.TabIndex = 12;
            humidityLabel.Text = "N/A";
            // 
            // pressureLabel
            // 
            pressureLabel.AutoSize = true;
            pressureLabel.BackColor = Color.Transparent;
            pressureLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pressureLabel.ForeColor = Color.White;
            pressureLabel.Location = new Point(203, 392);
            pressureLabel.Name = "pressureLabel";
            pressureLabel.Size = new Size(45, 25);
            pressureLabel.TabIndex = 13;
            pressureLabel.Text = "N/A";
            // 
            // windSpeedLabel
            // 
            windSpeedLabel.AutoSize = true;
            windSpeedLabel.BackColor = Color.Transparent;
            windSpeedLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            windSpeedLabel.ForeColor = Color.White;
            windSpeedLabel.Location = new Point(463, 333);
            windSpeedLabel.Name = "windSpeedLabel";
            windSpeedLabel.Size = new Size(45, 25);
            windSpeedLabel.TabIndex = 14;
            windSpeedLabel.Text = "N/A";
            // 
            // windDirectionLabel
            // 
            windDirectionLabel.AutoSize = true;
            windDirectionLabel.BackColor = Color.Transparent;
            windDirectionLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            windDirectionLabel.ForeColor = Color.White;
            windDirectionLabel.Location = new Point(488, 392);
            windDirectionLabel.Name = "windDirectionLabel";
            windDirectionLabel.Size = new Size(45, 25);
            windDirectionLabel.TabIndex = 15;
            windDirectionLabel.Text = "N/A";
            // 
            // sunriseLabel
            // 
            sunriseLabel.AutoSize = true;
            sunriseLabel.BackColor = Color.Transparent;
            sunriseLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sunriseLabel.ForeColor = Color.White;
            sunriseLabel.Location = new Point(683, 333);
            sunriseLabel.Name = "sunriseLabel";
            sunriseLabel.Size = new Size(45, 25);
            sunriseLabel.TabIndex = 16;
            sunriseLabel.Text = "N/A";
            // 
            // sunsetLabel
            // 
            sunsetLabel.AutoSize = true;
            sunsetLabel.BackColor = Color.Transparent;
            sunsetLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sunsetLabel.ForeColor = Color.White;
            sunsetLabel.Location = new Point(683, 392);
            sunsetLabel.Name = "sunsetLabel";
            sunsetLabel.Size = new Size(45, 25);
            sunsetLabel.TabIndex = 17;
            sunsetLabel.Text = "N/A";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(846, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertToFarentheitToolStripMenuItem, dayForecastToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // convertToFarentheitToolStripMenuItem
            // 
            convertToFarentheitToolStripMenuItem.Name = "convertToFarentheitToolStripMenuItem";
            convertToFarentheitToolStripMenuItem.Size = new Size(180, 22);
            convertToFarentheitToolStripMenuItem.Text = "Convert to Imperial";
            convertToFarentheitToolStripMenuItem.Click += convertToFarentheitToolStripMenuItem_Click;
            // 
            // dayForecastToolStripMenuItem
            // 
            dayForecastToolStripMenuItem.Name = "dayForecastToolStripMenuItem";
            dayForecastToolStripMenuItem.Size = new Size(180, 22);
            dayForecastToolStripMenuItem.Text = "7 Day Forecast";
            dayForecastToolStripMenuItem.Click += dayForecastToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(846, 461);
            Controls.Add(sunsetLabel);
            Controls.Add(sunriseLabel);
            Controls.Add(windDirectionLabel);
            Controls.Add(windSpeedLabel);
            Controls.Add(pressureLabel);
            Controls.Add(humidityLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tempLabel);
            Controls.Add(pictureBox);
            Controls.Add(conditionText);
            Controls.Add(searchButton);
            Controls.Add(cityTextBox);
            Controls.Add(enterLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterLabel;
        private TextBox cityTextBox;
        private Button searchButton;
        private Label conditionText;
        private PictureBox pictureBox;
        private Label tempLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label humidityLabel;
        private Label pressureLabel;
        private Label windSpeedLabel;
        private Label windDirectionLabel;
        private Label sunriseLabel;
        private Label sunsetLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem convertToFarentheitToolStripMenuItem;
        private ToolStripMenuItem dayForecastToolStripMenuItem;
    }
}