namespace _0712SocketExercise01_server_client_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.text_n0 = new System.Windows.Forms.TextBox();
            this.text_h0 = new System.Windows.Forms.TextBox();
            this.text_d0 = new System.Windows.Forms.TextBox();
            this.text_n1 = new System.Windows.Forms.TextBox();
            this.text_h1 = new System.Windows.Forms.TextBox();
            this.text_d1 = new System.Windows.Forms.TextBox();
            this.text_n2 = new System.Windows.Forms.TextBox();
            this.text_h2 = new System.Windows.Forms.TextBox();
            this.text_d2 = new System.Windows.Forms.TextBox();
            this.text_n3 = new System.Windows.Forms.TextBox();
            this.text_h3 = new System.Windows.Forms.TextBox();
            this.text_d3 = new System.Windows.Forms.TextBox();
            this.text_n4 = new System.Windows.Forms.TextBox();
            this.text_h4 = new System.Windows.Forms.TextBox();
            this.text_d4 = new System.Windows.Forms.TextBox();
            this.text_n5 = new System.Windows.Forms.TextBox();
            this.text_n6 = new System.Windows.Forms.TextBox();
            this.text_n7 = new System.Windows.Forms.TextBox();
            this.text_n8 = new System.Windows.Forms.TextBox();
            this.text_n9 = new System.Windows.Forms.TextBox();
            this.text_h5 = new System.Windows.Forms.TextBox();
            this.text_h6 = new System.Windows.Forms.TextBox();
            this.text_h7 = new System.Windows.Forms.TextBox();
            this.text_h8 = new System.Windows.Forms.TextBox();
            this.text_h9 = new System.Windows.Forms.TextBox();
            this.text_d5 = new System.Windows.Forms.TextBox();
            this.text_d6 = new System.Windows.Forms.TextBox();
            this.text_d7 = new System.Windows.Forms.TextBox();
            this.text_d8 = new System.Windows.Forms.TextBox();
            this.text_d9 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbox_size = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbox_first = new System.Windows.Forms.TextBox();
            this.btn_readset = new System.Windows.Forms.Button();
            this.tbox_translate = new System.Windows.Forms.TextBox();
            this.btn_translate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(331, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 25);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 25);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(331, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(559, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Connect to Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 99);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(729, 224);
            this.textBox3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(669, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 342);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(624, 42);
            this.textBox4.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // text_n0
            // 
            this.text_n0.Location = new System.Drawing.Point(31, 508);
            this.text_n0.Name = "text_n0";
            this.text_n0.Size = new System.Drawing.Size(70, 25);
            this.text_n0.TabIndex = 10;
            // 
            // text_h0
            // 
            this.text_h0.Location = new System.Drawing.Point(107, 508);
            this.text_h0.Name = "text_h0";
            this.text_h0.Size = new System.Drawing.Size(100, 25);
            this.text_h0.TabIndex = 10;
            // 
            // text_d0
            // 
            this.text_d0.Location = new System.Drawing.Point(213, 508);
            this.text_d0.Name = "text_d0";
            this.text_d0.Size = new System.Drawing.Size(100, 25);
            this.text_d0.TabIndex = 10;
            // 
            // text_n1
            // 
            this.text_n1.Location = new System.Drawing.Point(31, 539);
            this.text_n1.Name = "text_n1";
            this.text_n1.Size = new System.Drawing.Size(70, 25);
            this.text_n1.TabIndex = 10;
            // 
            // text_h1
            // 
            this.text_h1.Location = new System.Drawing.Point(107, 539);
            this.text_h1.Name = "text_h1";
            this.text_h1.Size = new System.Drawing.Size(100, 25);
            this.text_h1.TabIndex = 10;
            // 
            // text_d1
            // 
            this.text_d1.Location = new System.Drawing.Point(213, 539);
            this.text_d1.Name = "text_d1";
            this.text_d1.Size = new System.Drawing.Size(100, 25);
            this.text_d1.TabIndex = 10;
            // 
            // text_n2
            // 
            this.text_n2.Location = new System.Drawing.Point(31, 570);
            this.text_n2.Name = "text_n2";
            this.text_n2.Size = new System.Drawing.Size(70, 25);
            this.text_n2.TabIndex = 10;
            // 
            // text_h2
            // 
            this.text_h2.Location = new System.Drawing.Point(107, 570);
            this.text_h2.Name = "text_h2";
            this.text_h2.Size = new System.Drawing.Size(100, 25);
            this.text_h2.TabIndex = 10;
            // 
            // text_d2
            // 
            this.text_d2.Location = new System.Drawing.Point(213, 570);
            this.text_d2.Name = "text_d2";
            this.text_d2.Size = new System.Drawing.Size(100, 25);
            this.text_d2.TabIndex = 10;
            // 
            // text_n3
            // 
            this.text_n3.Location = new System.Drawing.Point(31, 601);
            this.text_n3.Name = "text_n3";
            this.text_n3.Size = new System.Drawing.Size(70, 25);
            this.text_n3.TabIndex = 10;
            // 
            // text_h3
            // 
            this.text_h3.Location = new System.Drawing.Point(107, 601);
            this.text_h3.Name = "text_h3";
            this.text_h3.Size = new System.Drawing.Size(100, 25);
            this.text_h3.TabIndex = 10;
            // 
            // text_d3
            // 
            this.text_d3.Location = new System.Drawing.Point(213, 601);
            this.text_d3.Name = "text_d3";
            this.text_d3.Size = new System.Drawing.Size(100, 25);
            this.text_d3.TabIndex = 10;
            // 
            // text_n4
            // 
            this.text_n4.Location = new System.Drawing.Point(31, 632);
            this.text_n4.Name = "text_n4";
            this.text_n4.Size = new System.Drawing.Size(70, 25);
            this.text_n4.TabIndex = 10;
            // 
            // text_h4
            // 
            this.text_h4.Location = new System.Drawing.Point(107, 632);
            this.text_h4.Name = "text_h4";
            this.text_h4.Size = new System.Drawing.Size(100, 25);
            this.text_h4.TabIndex = 10;
            // 
            // text_d4
            // 
            this.text_d4.Location = new System.Drawing.Point(213, 632);
            this.text_d4.Name = "text_d4";
            this.text_d4.Size = new System.Drawing.Size(100, 25);
            this.text_d4.TabIndex = 10;
            // 
            // text_n5
            // 
            this.text_n5.Location = new System.Drawing.Point(441, 508);
            this.text_n5.Name = "text_n5";
            this.text_n5.Size = new System.Drawing.Size(70, 25);
            this.text_n5.TabIndex = 10;
            // 
            // text_n6
            // 
            this.text_n6.Location = new System.Drawing.Point(441, 539);
            this.text_n6.Name = "text_n6";
            this.text_n6.Size = new System.Drawing.Size(70, 25);
            this.text_n6.TabIndex = 10;
            // 
            // text_n7
            // 
            this.text_n7.Location = new System.Drawing.Point(441, 570);
            this.text_n7.Name = "text_n7";
            this.text_n7.Size = new System.Drawing.Size(70, 25);
            this.text_n7.TabIndex = 10;
            // 
            // text_n8
            // 
            this.text_n8.Location = new System.Drawing.Point(441, 601);
            this.text_n8.Name = "text_n8";
            this.text_n8.Size = new System.Drawing.Size(70, 25);
            this.text_n8.TabIndex = 10;
            // 
            // text_n9
            // 
            this.text_n9.Location = new System.Drawing.Point(441, 632);
            this.text_n9.Name = "text_n9";
            this.text_n9.Size = new System.Drawing.Size(70, 25);
            this.text_n9.TabIndex = 10;
            // 
            // text_h5
            // 
            this.text_h5.Location = new System.Drawing.Point(517, 508);
            this.text_h5.Name = "text_h5";
            this.text_h5.Size = new System.Drawing.Size(100, 25);
            this.text_h5.TabIndex = 10;
            // 
            // text_h6
            // 
            this.text_h6.Location = new System.Drawing.Point(517, 539);
            this.text_h6.Name = "text_h6";
            this.text_h6.Size = new System.Drawing.Size(100, 25);
            this.text_h6.TabIndex = 10;
            // 
            // text_h7
            // 
            this.text_h7.Location = new System.Drawing.Point(517, 570);
            this.text_h7.Name = "text_h7";
            this.text_h7.Size = new System.Drawing.Size(100, 25);
            this.text_h7.TabIndex = 10;
            // 
            // text_h8
            // 
            this.text_h8.Location = new System.Drawing.Point(517, 601);
            this.text_h8.Name = "text_h8";
            this.text_h8.Size = new System.Drawing.Size(100, 25);
            this.text_h8.TabIndex = 10;
            // 
            // text_h9
            // 
            this.text_h9.Location = new System.Drawing.Point(517, 632);
            this.text_h9.Name = "text_h9";
            this.text_h9.Size = new System.Drawing.Size(100, 25);
            this.text_h9.TabIndex = 10;
            // 
            // text_d5
            // 
            this.text_d5.Location = new System.Drawing.Point(623, 508);
            this.text_d5.Name = "text_d5";
            this.text_d5.Size = new System.Drawing.Size(100, 25);
            this.text_d5.TabIndex = 10;
            // 
            // text_d6
            // 
            this.text_d6.Location = new System.Drawing.Point(623, 539);
            this.text_d6.Name = "text_d6";
            this.text_d6.Size = new System.Drawing.Size(100, 25);
            this.text_d6.TabIndex = 10;
            // 
            // text_d7
            // 
            this.text_d7.Location = new System.Drawing.Point(623, 570);
            this.text_d7.Name = "text_d7";
            this.text_d7.Size = new System.Drawing.Size(100, 25);
            this.text_d7.TabIndex = 10;
            // 
            // text_d8
            // 
            this.text_d8.Location = new System.Drawing.Point(623, 601);
            this.text_d8.Name = "text_d8";
            this.text_d8.Size = new System.Drawing.Size(100, 25);
            this.text_d8.TabIndex = 10;
            // 
            // text_d9
            // 
            this.text_d9.Location = new System.Drawing.Point(623, 632);
            this.text_d9.Name = "text_d9";
            this.text_d9.Size = new System.Drawing.Size(100, 25);
            this.text_d9.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hexa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Decimal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hexa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(646, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Decimal";
            // 
            // cbox_size
            // 
            this.cbox_size.FormattingEnabled = true;
            this.cbox_size.Location = new System.Drawing.Point(430, 422);
            this.cbox_size.Name = "cbox_size";
            this.cbox_size.Size = new System.Drawing.Size(121, 23);
            this.cbox_size.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(12, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "처음 디바이스";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔바른고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(331, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "읽어올 크기";
            // 
            // tbox_first
            // 
            this.tbox_first.Location = new System.Drawing.Point(127, 424);
            this.tbox_first.Name = "tbox_first";
            this.tbox_first.Size = new System.Drawing.Size(100, 25);
            this.tbox_first.TabIndex = 17;
            // 
            // btn_readset
            // 
            this.btn_readset.Location = new System.Drawing.Point(670, 423);
            this.btn_readset.Name = "btn_readset";
            this.btn_readset.Size = new System.Drawing.Size(75, 23);
            this.btn_readset.TabIndex = 18;
            this.btn_readset.Text = "ReadSet";
            this.btn_readset.UseVisualStyleBackColor = true;
            this.btn_readset.Click += new System.EventHandler(this.btn_readset_Click);
            // 
            // tbox_translate
            // 
            this.tbox_translate.Location = new System.Drawing.Point(197, 684);
            this.tbox_translate.Name = "tbox_translate";
            this.tbox_translate.Size = new System.Drawing.Size(354, 25);
            this.tbox_translate.TabIndex = 19;
            // 
            // btn_translate
            // 
            this.btn_translate.Location = new System.Drawing.Point(97, 686);
            this.btn_translate.Name = "btn_translate";
            this.btn_translate.Size = new System.Drawing.Size(75, 23);
            this.btn_translate.TabIndex = 20;
            this.btn_translate.Text = "Translate";
            this.btn_translate.UseVisualStyleBackColor = true;
            this.btn_translate.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 906);
            this.Controls.Add(this.btn_translate);
            this.Controls.Add(this.tbox_translate);
            this.Controls.Add(this.btn_readset);
            this.Controls.Add(this.tbox_first);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbox_size);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_d9);
            this.Controls.Add(this.text_d4);
            this.Controls.Add(this.text_d8);
            this.Controls.Add(this.text_d3);
            this.Controls.Add(this.text_d7);
            this.Controls.Add(this.text_d2);
            this.Controls.Add(this.text_d6);
            this.Controls.Add(this.text_d1);
            this.Controls.Add(this.text_d5);
            this.Controls.Add(this.text_d0);
            this.Controls.Add(this.text_h9);
            this.Controls.Add(this.text_h4);
            this.Controls.Add(this.text_h8);
            this.Controls.Add(this.text_h3);
            this.Controls.Add(this.text_h7);
            this.Controls.Add(this.text_h2);
            this.Controls.Add(this.text_h6);
            this.Controls.Add(this.text_h1);
            this.Controls.Add(this.text_h5);
            this.Controls.Add(this.text_n9);
            this.Controls.Add(this.text_h0);
            this.Controls.Add(this.text_n8);
            this.Controls.Add(this.text_n4);
            this.Controls.Add(this.text_n7);
            this.Controls.Add(this.text_n3);
            this.Controls.Add(this.text_n6);
            this.Controls.Add(this.text_n2);
            this.Controls.Add(this.text_n5);
            this.Controls.Add(this.text_n1);
            this.Controls.Add(this.text_n0);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox text_n0;
        private System.Windows.Forms.TextBox text_h0;
        private System.Windows.Forms.TextBox text_d0;
        private System.Windows.Forms.TextBox text_n1;
        private System.Windows.Forms.TextBox text_h1;
        private System.Windows.Forms.TextBox text_d1;
        private System.Windows.Forms.TextBox text_n2;
        private System.Windows.Forms.TextBox text_h2;
        private System.Windows.Forms.TextBox text_d2;
        private System.Windows.Forms.TextBox text_n3;
        private System.Windows.Forms.TextBox text_h3;
        private System.Windows.Forms.TextBox text_d3;
        private System.Windows.Forms.TextBox text_n4;
        private System.Windows.Forms.TextBox text_h4;
        private System.Windows.Forms.TextBox text_d4;
        private System.Windows.Forms.TextBox text_n5;
        private System.Windows.Forms.TextBox text_n6;
        private System.Windows.Forms.TextBox text_n7;
        private System.Windows.Forms.TextBox text_n8;
        private System.Windows.Forms.TextBox text_n9;
        private System.Windows.Forms.TextBox text_h5;
        private System.Windows.Forms.TextBox text_h6;
        private System.Windows.Forms.TextBox text_h7;
        private System.Windows.Forms.TextBox text_h8;
        private System.Windows.Forms.TextBox text_h9;
        private System.Windows.Forms.TextBox text_d5;
        private System.Windows.Forms.TextBox text_d6;
        private System.Windows.Forms.TextBox text_d7;
        private System.Windows.Forms.TextBox text_d8;
        private System.Windows.Forms.TextBox text_d9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbox_size;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbox_first;
        private System.Windows.Forms.Button btn_readset;
        private System.Windows.Forms.TextBox tbox_translate;
        private System.Windows.Forms.Button btn_translate;
    }
}

