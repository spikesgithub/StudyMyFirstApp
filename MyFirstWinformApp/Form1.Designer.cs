namespace MyFirstWinformApp
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
            txtUserName = new TextBox();
            btnCheckName = new Button();
            btn_array = new Button();
            anliyi = new Button();
            btnVoid = new Button();
            btnSub = new Button();
            btnRef = new Button();
            btnParams = new Button();
            btnClassDesigne = new Button();
            btnInherit = new Button();
            btnInterface = new Button();
            btnDuoTai = new Button();
            btnOrgStr = new Button();
            btnArrayList = new Button();
            btnList = new Button();
            btn_List2 = new Button();
            btnListShow = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(569, 295);
            txtUserName.Margin = new Padding(2, 3, 2, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(98, 23);
            txtUserName.TabIndex = 0;
            // 
            // btnCheckName
            // 
            btnCheckName.Location = new Point(569, 354);
            btnCheckName.Margin = new Padding(2, 3, 2, 3);
            btnCheckName.Name = "btnCheckName";
            btnCheckName.Size = new Size(73, 25);
            btnCheckName.TabIndex = 1;
            btnCheckName.Text = "button1";
            btnCheckName.UseVisualStyleBackColor = true;
            btnCheckName.Click += btnCheckName_Click;
            // 
            // btn_array
            // 
            btn_array.Location = new Point(569, 399);
            btn_array.Margin = new Padding(2, 3, 2, 3);
            btn_array.Name = "btn_array";
            btn_array.Size = new Size(73, 25);
            btn_array.TabIndex = 2;
            btn_array.Text = "shuzu";
            btn_array.UseVisualStyleBackColor = true;
            btn_array.Click += button1_Click;
            // 
            // anliyi
            // 
            anliyi.Location = new Point(567, 453);
            anliyi.Name = "anliyi";
            anliyi.Size = new Size(75, 23);
            anliyi.TabIndex = 3;
            anliyi.Text = "btn_anli";
            anliyi.UseVisualStyleBackColor = true;
            anliyi.Click += anliyi_Click;
            // 
            // btnVoid
            // 
            btnVoid.Location = new Point(759, 356);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(75, 23);
            btnVoid.TabIndex = 4;
            btnVoid.Text = "voidorother";
            btnVoid.UseVisualStyleBackColor = true;
            btnVoid.Click += btnVoid_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(759, 401);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 5;
            btnSub.Text = "btnSub";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnRef
            // 
            btnRef.Location = new Point(759, 453);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(75, 23);
            btnRef.TabIndex = 6;
            btnRef.Text = "ref";
            btnRef.UseVisualStyleBackColor = true;
            btnRef.Click += btnRef_Click;
            // 
            // btnParams
            // 
            btnParams.Location = new Point(923, 356);
            btnParams.Name = "btnParams";
            btnParams.Size = new Size(75, 23);
            btnParams.TabIndex = 7;
            btnParams.Text = "Params";
            btnParams.UseVisualStyleBackColor = true;
            btnParams.Click += btnParams_Click;
            // 
            // btnClassDesigne
            // 
            btnClassDesigne.Location = new Point(923, 399);
            btnClassDesigne.Name = "btnClassDesigne";
            btnClassDesigne.Size = new Size(75, 23);
            btnClassDesigne.TabIndex = 8;
            btnClassDesigne.Text = "类设计";
            btnClassDesigne.UseVisualStyleBackColor = true;
            btnClassDesigne.Click += btnClassDesigne_Click;
            // 
            // btnInherit
            // 
            btnInherit.Location = new Point(923, 453);
            btnInherit.Name = "btnInherit";
            btnInherit.Size = new Size(75, 23);
            btnInherit.TabIndex = 9;
            btnInherit.Text = "btnInherit";
            btnInherit.UseVisualStyleBackColor = true;
            btnInherit.Click += btnInherit_Click;
            // 
            // btnInterface
            // 
            btnInterface.Location = new Point(331, 356);
            btnInterface.Name = "btnInterface";
            btnInterface.Size = new Size(75, 23);
            btnInterface.TabIndex = 10;
            btnInterface.Text = "Interface接口";
            btnInterface.UseVisualStyleBackColor = true;
            btnInterface.Click += button1_Click_1;
            // 
            // btnDuoTai
            // 
            btnDuoTai.Location = new Point(331, 399);
            btnDuoTai.Name = "btnDuoTai";
            btnDuoTai.Size = new Size(75, 23);
            btnDuoTai.TabIndex = 11;
            btnDuoTai.Text = "多态";
            btnDuoTai.UseVisualStyleBackColor = true;
            btnDuoTai.Click += btnDuoTai_Click;
            // 
            // btnOrgStr
            // 
            btnOrgStr.Location = new Point(331, 453);
            btnOrgStr.Name = "btnOrgStr";
            btnOrgStr.Size = new Size(75, 23);
            btnOrgStr.TabIndex = 12;
            btnOrgStr.Text = "原始字符串";
            btnOrgStr.UseVisualStyleBackColor = true;
            btnOrgStr.Click += btnOrgStr_Click;
            // 
            // btnArrayList
            // 
            btnArrayList.Location = new Point(197, 354);
            btnArrayList.Name = "btnArrayList";
            btnArrayList.Size = new Size(75, 23);
            btnArrayList.TabIndex = 13;
            btnArrayList.Text = "集合";
            btnArrayList.UseVisualStyleBackColor = true;
            btnArrayList.Click += btnArrayList_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(197, 401);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 14;
            btnList.Text = "List集合";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btn_List2
            // 
            btn_List2.Location = new Point(200, 451);
            btn_List2.Name = "btn_List2";
            btn_List2.Size = new Size(75, 23);
            btn_List2.TabIndex = 15;
            btn_List2.Text = "List2";
            btn_List2.UseVisualStyleBackColor = true;
            btn_List2.Click += btn_List2_Click;
            // 
            // btnListShow
            // 
            btnListShow.ImageAlign = ContentAlignment.MiddleRight;
            btnListShow.Location = new Point(91, 354);
            btnListShow.Name = "btnListShow";
            btnListShow.Size = new Size(75, 23);
            btnListShow.TabIndex = 16;
            btnListShow.Text = "btnListShow";
            btnListShow.UseVisualStyleBackColor = true;
            btnListShow.Click += btnListShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 613);
            Controls.Add(btnListShow);
            Controls.Add(btn_List2);
            Controls.Add(btnList);
            Controls.Add(btnArrayList);
            Controls.Add(btnOrgStr);
            Controls.Add(btnDuoTai);
            Controls.Add(btnInterface);
            Controls.Add(btnInherit);
            Controls.Add(btnClassDesigne);
            Controls.Add(btnParams);
            Controls.Add(btnRef);
            Controls.Add(btnSub);
            Controls.Add(btnVoid);
            Controls.Add(anliyi);
            Controls.Add(btn_array);
            Controls.Add(btnCheckName);
            Controls.Add(txtUserName);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Button btnCheckName;
        private Button btn_array;
        private Button anliyi;
        private Button btnVoid;
        private Button btnSub;
        private Button btnRef;
        private Button btnParams;
        private Button btnClassDesigne;
        private Button btnInherit;
        private Button btnInterface;
        private Button btnDuoTai;
        private Button btnOrgStr;
        private Button btnArrayList;
        private Button btnList;
        private Button btn_List2;
        private Button btnListShow;
    }
}
