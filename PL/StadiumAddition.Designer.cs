namespace PL
{
    partial class StadiumAddition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SeatsTextBox = new System.Windows.Forms.TextBox();
            this.SeatsLabel = new System.Windows.Forms.Label();
            this.SeatPrice = new System.Windows.Forms.TextBox();
            this.SeatPriceLabel = new System.Windows.Forms.Label();
            this.StadiumAdditionLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(25, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Назва";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(25, 74);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(131, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // SeatsTextBox
            // 
            this.SeatsTextBox.Location = new System.Drawing.Point(25, 157);
            this.SeatsTextBox.Name = "SeatsTextBox";
            this.SeatsTextBox.Size = new System.Drawing.Size(131, 23);
            this.SeatsTextBox.TabIndex = 3;
            this.SeatsTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SeatsLabel
            // 
            this.SeatsLabel.AutoSize = true;
            this.SeatsLabel.Location = new System.Drawing.Point(25, 139);
            this.SeatsLabel.Name = "SeatsLabel";
            this.SeatsLabel.Size = new System.Drawing.Size(40, 15);
            this.SeatsLabel.TabIndex = 2;
            this.SeatsLabel.Text = "Місць";
            this.SeatsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SeatPrice
            // 
            this.SeatPrice.Location = new System.Drawing.Point(25, 249);
            this.SeatPrice.Name = "SeatPrice";
            this.SeatPrice.Size = new System.Drawing.Size(131, 23);
            this.SeatPrice.TabIndex = 5;
            // 
            // SeatPriceLabel
            // 
            this.SeatPriceLabel.AutoSize = true;
            this.SeatPriceLabel.Location = new System.Drawing.Point(25, 231);
            this.SeatPriceLabel.Name = "SeatPriceLabel";
            this.SeatPriceLabel.Size = new System.Drawing.Size(80, 15);
            this.SeatPriceLabel.TabIndex = 4;
            this.SeatPriceLabel.Text = "Ціна за місце";
            // 
            // StadiumAdditionLabel
            // 
            this.StadiumAdditionLabel.AutoSize = true;
            this.StadiumAdditionLabel.Location = new System.Drawing.Point(25, 18);
            this.StadiumAdditionLabel.Name = "StadiumAdditionLabel";
            this.StadiumAdditionLabel.Size = new System.Drawing.Size(115, 15);
            this.StadiumAdditionLabel.TabIndex = 6;
            this.StadiumAdditionLabel.Text = "Додавання стадіону";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(186, 249);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(118, 50);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StadiumAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 322);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StadiumAdditionLabel);
            this.Controls.Add(this.SeatPrice);
            this.Controls.Add(this.SeatPriceLabel);
            this.Controls.Add(this.SeatsTextBox);
            this.Controls.Add(this.SeatsLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "StadiumAddition";
            this.Text = "Додавання стаідону";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextBox;
        private TextBox SeatsTextBox;
        private Label SeatsLabel;
        private TextBox SeatPrice;
        private Label SeatPriceLabel;
        private Label StadiumAdditionLabel;
        private Button AddButton;
    }
}