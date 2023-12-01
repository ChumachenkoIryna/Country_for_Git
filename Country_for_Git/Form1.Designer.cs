using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Country_for_Git
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
            groupBox2 = new GroupBox();
            textBoxGr = new TextBox();
            label5 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            comboBoxCountry = new ComboBox();
            textBoxArea = new TextBox();
            label3 = new Label();
            textBoxPopulation = new TextBox();
            label4 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxCapital = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            comboBoxWorldPart = new ComboBox();
            textBoxWorldPart = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            minText = new TextBox();
            maxText = new TextBox();
            numberText = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxGr);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(comboBoxCountry);
            groupBox2.Controls.Add(textBoxArea);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxPopulation);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxCapital);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(485, 5);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(509, 260);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Страны";
            // 
            // textBoxGr
            // 
            textBoxGr.Location = new Point(118, 203);
            textBoxGr.Margin = new Padding(5, 4, 5, 4);
            textBoxGr.Name = "textBoxGr";
            textBoxGr.ReadOnly = true;
            textBoxGr.Size = new Size(162, 27);
            textBoxGr.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 209);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 12;
            label5.Text = "Часть мира:";
            // 
            // button6
            // 
            button6.Location = new Point(288, 157);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(161, 36);
            button6.TabIndex = 11;
            button6.Text = "Изменить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += EditCountryClick;
            // 
            // button5
            // 
            button5.Location = new Point(287, 113);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(161, 36);
            button5.TabIndex = 10;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += RemoveCountryClick;
            // 
            // button4
            // 
            button4.Location = new Point(287, 71);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(161, 36);
            button4.TabIndex = 9;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AddCountryClick;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(287, 28);
            comboBoxCountry.Margin = new Padding(5, 4, 5, 4);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(159, 28);
            comboBoxCountry.TabIndex = 8;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(118, 160);
            textBoxArea.Margin = new Padding(5, 4, 5, 4);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(162, 27);
            textBoxArea.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 167);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Площадь:";
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(118, 116);
            textBoxPopulation.Margin = new Padding(5, 4, 5, 4);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(162, 27);
            textBoxPopulation.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 119);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 4;
            label4.Text = "Население:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(117, 72);
            textBoxName.Margin = new Padding(5, 4, 5, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(162, 27);
            textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 76);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 2;
            label2.Text = "Наименование :";
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(117, 29);
            textBoxCapital.Margin = new Padding(5, 4, 5, 4);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(162, 27);
            textBoxCapital.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 31);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Столица:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBoxWorldPart);
            groupBox1.Controls.Add(textBoxWorldPart);
            groupBox1.Location = new Point(253, 13);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(213, 233);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Части мира";
            // 
            // button3
            // 
            button3.Location = new Point(11, 189);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(161, 36);
            button3.TabIndex = 4;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += EditGroupClick;
            // 
            // button1
            // 
            button1.Location = new Point(9, 104);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(161, 36);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddGroupClick;
            // 
            // button2
            // 
            button2.Location = new Point(11, 147);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(161, 36);
            button2.TabIndex = 3;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RemoveGroupClick;
            // 
            // comboBoxWorldPart
            // 
            comboBoxWorldPart.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWorldPart.FormattingEnabled = true;
            comboBoxWorldPart.Location = new Point(9, 68);
            comboBoxWorldPart.Margin = new Padding(5, 4, 5, 4);
            comboBoxWorldPart.Name = "comboBoxWorldPart";
            comboBoxWorldPart.Size = new Size(159, 28);
            comboBoxWorldPart.TabIndex = 2;
            comboBoxWorldPart.SelectedIndexChanged += comboBoxWorldPart_SelectedIndexChanged;
            // 
            // textBoxWorldPart
            // 
            textBoxWorldPart.Location = new Point(10, 33);
            textBoxWorldPart.Margin = new Padding(5, 4, 5, 4);
            textBoxWorldPart.Name = "textBoxWorldPart";
            textBoxWorldPart.Size = new Size(162, 27);
            textBoxWorldPart.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(12, 272);
            button7.Name = "button7";
            button7.Size = new Size(282, 29);
            button7.TabIndex = 4;
            button7.Text = "Информация о всех странах";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 307);
            button8.Name = "button8";
            button8.Size = new Size(282, 29);
            button8.TabIndex = 5;
            button8.Text = "Названия всех стран ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 342);
            button9.Name = "button9";
            button9.Size = new Size(282, 29);
            button9.TabIndex = 6;
            button9.Text = "Название всех столиц";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(11, 377);
            button10.Name = "button10";
            button10.Size = new Size(283, 29);
            button10.TabIndex = 7;
            button10.Text = "Название европейских стран";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(11, 587);
            button11.Name = "button11";
            button11.Size = new Size(282, 54);
            button11.TabIndex = 8;
            button11.Text = "Название стран с площадью, больше заданной";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(11, 647);
            button12.Name = "button12";
            button12.Size = new Size(282, 46);
            button12.TabIndex = 9;
            button12.Text = "Cтраны с буквой \"а\" или \"е\"";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(11, 416);
            button13.Name = "button13";
            button13.Size = new Size(283, 29);
            button13.TabIndex = 10;
            button13.Text = "Cтраны, которые начинаются на \"а\"";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(11, 451);
            button14.Name = "button14";
            button14.Size = new Size(282, 64);
            button14.TabIndex = 11;
            button14.Text = "Cтраны, у которых площадь находится в указанном диапазоне";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(11, 517);
            button15.Name = "button15";
            button15.Size = new Size(283, 64);
            button15.TabIndex = 12;
            button15.Text = "Cтраны, у которых  население больше указанного числа";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(671, 421);
            dataGridView1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 33);
            label7.Name = "label7";
            label7.Size = new Size(183, 20);
            label7.TabIndex = 15;
            label7.Text = "Минимальное значение:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 91);
            label8.Name = "label8";
            label8.Size = new Size(187, 20);
            label8.TabIndex = 16;
            label8.Text = "Максимальное значение:";
            // 
            // minText
            // 
            minText.Location = new Point(16, 61);
            minText.Name = "minText";
            minText.Size = new Size(125, 27);
            minText.TabIndex = 18;
            // 
            // maxText
            // 
            maxText.Location = new Point(16, 114);
            maxText.Name = "maxText";
            maxText.Size = new Size(125, 27);
            maxText.TabIndex = 19;
            // 
            // numberText
            // 
            numberText.Location = new Point(16, 34);
            numberText.Name = "numberText";
            numberText.Size = new Size(125, 27);
            numberText.TabIndex = 20;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(maxText);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(minText);
            groupBox3.Location = new Point(21, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(206, 156);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Задайте диапазон";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numberText);
            groupBox4.Location = new Point(21, 172);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(206, 80);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Задайте число:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 694);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Часть мира";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox textBoxGr;
        private Label label5;
        private Button button6;
        private Button button5;
        private Button button4;
        private ComboBox comboBoxCountry;
        private TextBox textBoxArea;
        private Label label3;
        private TextBox textBoxPopulation;
        private Label label4;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxCapital;
        private Label label1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBoxWorldPart;
        private TextBox textBoxWorldPart;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox minText;
        private TextBox maxText;
        private TextBox numberText;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}