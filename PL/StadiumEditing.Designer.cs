namespace PL
{
    partial class StadiumEditing
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SeatsTextBox = new System.Windows.Forms.TextBox();
            this.PlacesLabel = new System.Windows.Forms.Label();
            this.SeatPriceTextBox = new System.Windows.Forms.TextBox();
            this.SeatPriceLabel = new System.Windows.Forms.Label();
            this.StadiumEditingName = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
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
            // PlacesLabel
            // 
            this.PlacesLabel.AutoSize = true;
            this.PlacesLabel.Location = new System.Drawing.Point(25, 139);
            this.PlacesLabel.Name = "PlacesLabel";
            this.PlacesLabel.Size = new System.Drawing.Size(40, 15);
            this.PlacesLabel.TabIndex = 2;
            this.PlacesLabel.Text = "Місць";
            this.PlacesLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SeatPriceTextBox
            // 
            this.SeatPriceTextBox.Location = new System.Drawing.Point(25, 249);
            this.SeatPriceTextBox.Name = "SeatPriceTextBox";
            this.SeatPriceTextBox.Size = new System.Drawing.Size(131, 23);
            this.SeatPriceTextBox.TabIndex = 5;
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
            // StadiumEditingName
            // 
            this.StadiumEditingName.AutoSize = true;
            this.StadiumEditingName.Location = new System.Drawing.Point(25, 18);
            this.StadiumEditingName.Name = "StadiumEditingName";
            this.StadiumEditingName.Size = new System.Drawing.Size(124, 15);
            this.StadiumEditingName.TabIndex = 6;
            this.StadiumEditingName.Text = "Редагування стадіону";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(186, 249);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(118, 50);
            this.SaveChangesButton.TabIndex = 7;
            this.SaveChangesButton.Text = "Зберегти зміни";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StadiumEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 322);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.StadiumEditingName);
            this.Controls.Add(this.SeatPriceTextBox);
            this.Controls.Add(this.SeatPriceLabel);
            this.Controls.Add(this.SeatsTextBox);
            this.Controls.Add(this.PlacesLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StadiumEditing";
            this.Text = "Редагування стадіону";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox NameTextBox;
        private TextBox SeatsTextBox;
        private Label PlacesLabel;
        private TextBox SeatPriceTextBox;
        private Label SeatPriceLabel;
        private Label StadiumEditingName;
        private Button SaveChangesButton;
    }
}