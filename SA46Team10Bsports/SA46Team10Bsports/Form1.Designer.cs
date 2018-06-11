namespace SA46Team10Bsports
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.miniBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.hamburgerBtn = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.crCourtBtn = new System.Windows.Forms.Button();
            this.delCourtBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.viewBookBtn = new System.Windows.Forms.Button();
            this.rptCustList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.crbookBtn = new System.Windows.Forms.Button();
            this.delAcctBtn = new System.Windows.Forms.Button();
            this.updCourtBtn = new System.Windows.Forms.Button();
            this.updAcctBtn = new System.Windows.Forms.Button();
            this.crAcctBtn = new System.Windows.Forms.Button();
            this.cancelBookBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucWallpaper1 = new SA46Team10Bsports.ucWallpaper();
            this.ucUpdAcct1 = new SA46Team10Bsports.ucUpdAcct();
            this.ucCrAcct1 = new SA46Team10Bsports.ucCrAcct();
            this.ucDelAcct1 = new SA46Team10Bsports.ucDelAcct();
            this.ucUpdFacilities1 = new SA46Team10Bsports.uc.ucFacilities.ucUpdFacilities();
            this.ucDelFacilities1 = new SA46Team10Bsports.uc.ucFacilities.ucDelFacilities();
            this.ucViewCourt1 = new SA46Team10Bsports.uc.ucBook.ucViewCourt();
            this.ucBookCourt1 = new SA46Team10Bsports.uc.ucBook.ucBookCourt();
            this.ucCancelCourt1 = new SA46Team10Bsports.uc.ucBook.ucCancelCourt();
            this.ucCrFacilities1 = new SA46Team10Bsports.uc.ucFacilities.ucCrFacilities();
            this.panel1.SuspendLayout();
            this.panelSlide.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.hamburgerBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 42);
            this.panel1.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(57, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(45, 38);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // miniBtn
            // 
            this.miniBtn.FlatAppearance.BorderSize = 0;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Location = new System.Drawing.Point(1093, 3);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(45, 38);
            this.miniBtn.TabIndex = 1;
            this.miniBtn.Text = "__";
            this.miniBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.miniBtn.UseVisualStyleBackColor = true;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(1135, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 38);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sports Hub";
            // 
            // hamburgerBtn
            // 
            this.hamburgerBtn.FlatAppearance.BorderSize = 0;
            this.hamburgerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hamburgerBtn.Image = ((System.Drawing.Image)(resources.GetObject("hamburgerBtn.Image")));
            this.hamburgerBtn.Location = new System.Drawing.Point(4, 3);
            this.hamburgerBtn.Name = "hamburgerBtn";
            this.hamburgerBtn.Size = new System.Drawing.Size(45, 38);
            this.hamburgerBtn.TabIndex = 1;
            this.hamburgerBtn.UseVisualStyleBackColor = true;
            this.hamburgerBtn.Click += new System.EventHandler(this.hamburgerBtn_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Controls.Add(this.button5);
            this.panelSlide.Controls.Add(this.crCourtBtn);
            this.panelSlide.Controls.Add(this.delCourtBtn);
            this.panelSlide.Controls.Add(this.button3);
            this.panelSlide.Controls.Add(this.viewBookBtn);
            this.panelSlide.Controls.Add(this.rptCustList);
            this.panelSlide.Controls.Add(this.label4);
            this.panelSlide.Controls.Add(this.crbookBtn);
            this.panelSlide.Controls.Add(this.delAcctBtn);
            this.panelSlide.Controls.Add(this.updCourtBtn);
            this.panelSlide.Controls.Add(this.updAcctBtn);
            this.panelSlide.Controls.Add(this.crAcctBtn);
            this.panelSlide.Controls.Add(this.cancelBookBtn);
            this.panelSlide.Controls.Add(this.label3);
            this.panelSlide.Controls.Add(this.label2);
            this.panelSlide.Controls.Add(this.label1);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 42);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(237, 708);
            this.panelSlide.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(7, 616);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 34);
            this.button5.TabIndex = 1;
            this.button5.Text = "Customer Usage";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // crCourtBtn
            // 
            this.crCourtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.crCourtBtn.FlatAppearance.BorderSize = 0;
            this.crCourtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crCourtBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crCourtBtn.Image = ((System.Drawing.Image)(resources.GetObject("crCourtBtn.Image")));
            this.crCourtBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crCourtBtn.Location = new System.Drawing.Point(7, 391);
            this.crCourtBtn.Name = "crCourtBtn";
            this.crCourtBtn.Size = new System.Drawing.Size(220, 34);
            this.crCourtBtn.TabIndex = 1;
            this.crCourtBtn.Text = "Create Facilities";
            this.crCourtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.crCourtBtn.UseVisualStyleBackColor = false;
            this.crCourtBtn.Click += new System.EventHandler(this.crCourtBtn_Click);
            // 
            // delCourtBtn
            // 
            this.delCourtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.delCourtBtn.FlatAppearance.BorderSize = 0;
            this.delCourtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCourtBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCourtBtn.Image = ((System.Drawing.Image)(resources.GetObject("delCourtBtn.Image")));
            this.delCourtBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delCourtBtn.Location = new System.Drawing.Point(7, 459);
            this.delCourtBtn.Name = "delCourtBtn";
            this.delCourtBtn.Size = new System.Drawing.Size(220, 34);
            this.delCourtBtn.TabIndex = 1;
            this.delCourtBtn.Text = "Delete Facilities";
            this.delCourtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delCourtBtn.UseVisualStyleBackColor = false;
            this.delCourtBtn.Click += new System.EventHandler(this.delCourtBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(7, 582);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Facility Usage";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewBookBtn
            // 
            this.viewBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.viewBookBtn.FlatAppearance.BorderSize = 0;
            this.viewBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBookBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewBookBtn.Image")));
            this.viewBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewBookBtn.Location = new System.Drawing.Point(7, 259);
            this.viewBookBtn.Name = "viewBookBtn";
            this.viewBookBtn.Size = new System.Drawing.Size(220, 34);
            this.viewBookBtn.TabIndex = 1;
            this.viewBookBtn.Text = "View Booking";
            this.viewBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewBookBtn.UseVisualStyleBackColor = false;
            this.viewBookBtn.Click += new System.EventHandler(this.viewBookBtn_Click);
            // 
            // rptCustList
            // 
            this.rptCustList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.rptCustList.FlatAppearance.BorderSize = 0;
            this.rptCustList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rptCustList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptCustList.Image = ((System.Drawing.Image)(resources.GetObject("rptCustList.Image")));
            this.rptCustList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rptCustList.Location = new System.Drawing.Point(7, 548);
            this.rptCustList.Name = "rptCustList";
            this.rptCustList.Size = new System.Drawing.Size(220, 34);
            this.rptCustList.TabIndex = 1;
            this.rptCustList.Text = "Customer List";
            this.rptCustList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rptCustList.UseVisualStyleBackColor = false;
            this.rptCustList.Click += new System.EventHandler(this.rptCustList_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "REPORT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crbookBtn
            // 
            this.crbookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.crbookBtn.FlatAppearance.BorderSize = 0;
            this.crbookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crbookBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbookBtn.Image = ((System.Drawing.Image)(resources.GetObject("crbookBtn.Image")));
            this.crbookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crbookBtn.Location = new System.Drawing.Point(7, 225);
            this.crbookBtn.Name = "crbookBtn";
            this.crbookBtn.Size = new System.Drawing.Size(220, 34);
            this.crbookBtn.TabIndex = 1;
            this.crbookBtn.Text = "Book Facilities";
            this.crbookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.crbookBtn.UseVisualStyleBackColor = false;
            this.crbookBtn.Click += new System.EventHandler(this.crbookBtn_Click);
            // 
            // delAcctBtn
            // 
            this.delAcctBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.delAcctBtn.FlatAppearance.BorderSize = 0;
            this.delAcctBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delAcctBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAcctBtn.Image = ((System.Drawing.Image)(resources.GetObject("delAcctBtn.Image")));
            this.delAcctBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delAcctBtn.Location = new System.Drawing.Point(7, 126);
            this.delAcctBtn.Name = "delAcctBtn";
            this.delAcctBtn.Size = new System.Drawing.Size(220, 34);
            this.delAcctBtn.TabIndex = 1;
            this.delAcctBtn.Text = "Delete Account";
            this.delAcctBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delAcctBtn.UseVisualStyleBackColor = false;
            this.delAcctBtn.Click += new System.EventHandler(this.delAcctBtn_Click);
            // 
            // updCourtBtn
            // 
            this.updCourtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.updCourtBtn.FlatAppearance.BorderSize = 0;
            this.updCourtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updCourtBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updCourtBtn.Image = ((System.Drawing.Image)(resources.GetObject("updCourtBtn.Image")));
            this.updCourtBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updCourtBtn.Location = new System.Drawing.Point(7, 425);
            this.updCourtBtn.Name = "updCourtBtn";
            this.updCourtBtn.Size = new System.Drawing.Size(220, 34);
            this.updCourtBtn.TabIndex = 1;
            this.updCourtBtn.Text = "Update Facilities";
            this.updCourtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updCourtBtn.UseVisualStyleBackColor = false;
            this.updCourtBtn.Click += new System.EventHandler(this.updCourtBtn_Click);
            // 
            // updAcctBtn
            // 
            this.updAcctBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.updAcctBtn.FlatAppearance.BorderSize = 0;
            this.updAcctBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updAcctBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updAcctBtn.Image = ((System.Drawing.Image)(resources.GetObject("updAcctBtn.Image")));
            this.updAcctBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updAcctBtn.Location = new System.Drawing.Point(7, 92);
            this.updAcctBtn.Name = "updAcctBtn";
            this.updAcctBtn.Size = new System.Drawing.Size(220, 34);
            this.updAcctBtn.TabIndex = 1;
            this.updAcctBtn.Text = "Update Account";
            this.updAcctBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updAcctBtn.UseVisualStyleBackColor = false;
            this.updAcctBtn.Click += new System.EventHandler(this.updAcctBtn_Click);
            // 
            // crAcctBtn
            // 
            this.crAcctBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.crAcctBtn.FlatAppearance.BorderSize = 0;
            this.crAcctBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crAcctBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crAcctBtn.Image = ((System.Drawing.Image)(resources.GetObject("crAcctBtn.Image")));
            this.crAcctBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crAcctBtn.Location = new System.Drawing.Point(7, 58);
            this.crAcctBtn.Name = "crAcctBtn";
            this.crAcctBtn.Size = new System.Drawing.Size(220, 34);
            this.crAcctBtn.TabIndex = 1;
            this.crAcctBtn.Text = "Create Account";
            this.crAcctBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.crAcctBtn.UseVisualStyleBackColor = false;
            this.crAcctBtn.Click += new System.EventHandler(this.crAcctBtn_Click);
            // 
            // cancelBookBtn
            // 
            this.cancelBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.cancelBookBtn.FlatAppearance.BorderSize = 0;
            this.cancelBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBookBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBookBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBookBtn.Image")));
            this.cancelBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBookBtn.Location = new System.Drawing.Point(7, 293);
            this.cancelBookBtn.Name = "cancelBookBtn";
            this.cancelBookBtn.Size = new System.Drawing.Size(220, 34);
            this.cancelBookBtn.TabIndex = 1;
            this.cancelBookBtn.Text = "Cancel Booking";
            this.cancelBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBookBtn.UseVisualStyleBackColor = false;
            this.cancelBookBtn.Click += new System.EventHandler(this.cancelBookBtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "FACILITIES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "BOOKING";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucWallpaper1);
            this.panel2.Controls.Add(this.ucUpdAcct1);
            this.panel2.Controls.Add(this.ucCrAcct1);
            this.panel2.Controls.Add(this.ucDelAcct1);
            this.panel2.Controls.Add(this.ucUpdFacilities1);
            this.panel2.Controls.Add(this.ucDelFacilities1);
            this.panel2.Controls.Add(this.ucViewCourt1);
            this.panel2.Controls.Add(this.ucBookCourt1);
            this.panel2.Controls.Add(this.ucCancelCourt1);
            this.panel2.Controls.Add(this.ucCrFacilities1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(237, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 708);
            this.panel2.TabIndex = 2;
            // 
            // ucWallpaper1
            // 
            this.ucWallpaper1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucWallpaper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucWallpaper1.Location = new System.Drawing.Point(3, 3);
            this.ucWallpaper1.Name = "ucWallpaper1";
            this.ucWallpaper1.Size = new System.Drawing.Size(943, 705);
            this.ucWallpaper1.TabIndex = 5;
            // 
            // ucUpdAcct1
            // 
            this.ucUpdAcct1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucUpdAcct1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUpdAcct1.ForeColor = System.Drawing.Color.White;
            this.ucUpdAcct1.Location = new System.Drawing.Point(3, 3);
            this.ucUpdAcct1.Name = "ucUpdAcct1";
            this.ucUpdAcct1.Size = new System.Drawing.Size(943, 705);
            this.ucUpdAcct1.TabIndex = 10;
            // 
            // ucCrAcct1
            // 
            this.ucCrAcct1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucCrAcct1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCrAcct1.ForeColor = System.Drawing.Color.White;
            this.ucCrAcct1.Location = new System.Drawing.Point(2, 2);
            this.ucCrAcct1.Name = "ucCrAcct1";
            this.ucCrAcct1.Size = new System.Drawing.Size(944, 706);
            this.ucCrAcct1.TabIndex = 11;
            // 
            // ucDelAcct1
            // 
            this.ucDelAcct1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucDelAcct1.ForeColor = System.Drawing.Color.White;
            this.ucDelAcct1.Location = new System.Drawing.Point(0, 0);
            this.ucDelAcct1.Name = "ucDelAcct1";
            this.ucDelAcct1.Size = new System.Drawing.Size(946, 708);
            this.ucDelAcct1.TabIndex = 12;
            // 
            // ucUpdFacilities1
            // 
            this.ucUpdFacilities1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucUpdFacilities1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUpdFacilities1.ForeColor = System.Drawing.Color.White;
            this.ucUpdFacilities1.Location = new System.Drawing.Point(3, 2);
            this.ucUpdFacilities1.Name = "ucUpdFacilities1";
            this.ucUpdFacilities1.Size = new System.Drawing.Size(943, 706);
            this.ucUpdFacilities1.TabIndex = 13;
            // 
            // ucDelFacilities1
            // 
            this.ucDelFacilities1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucDelFacilities1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDelFacilities1.ForeColor = System.Drawing.Color.White;
            this.ucDelFacilities1.Location = new System.Drawing.Point(1, 2);
            this.ucDelFacilities1.Name = "ucDelFacilities1";
            this.ucDelFacilities1.Size = new System.Drawing.Size(945, 706);
            this.ucDelFacilities1.TabIndex = 14;
            // 
            // ucViewCourt1
            // 
            this.ucViewCourt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucViewCourt1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucViewCourt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucViewCourt1.Location = new System.Drawing.Point(3, 2);
            this.ucViewCourt1.Name = "ucViewCourt1";
            this.ucViewCourt1.Size = new System.Drawing.Size(943, 706);
            this.ucViewCourt1.TabIndex = 21;
            // 
            // ucBookCourt1
            // 
            this.ucBookCourt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucBookCourt1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBookCourt1.ForeColor = System.Drawing.Color.White;
            this.ucBookCourt1.Location = new System.Drawing.Point(2, 2);
            this.ucBookCourt1.Name = "ucBookCourt1";
            this.ucBookCourt1.Size = new System.Drawing.Size(941, 703);
            this.ucBookCourt1.TabIndex = 15;
            // 
            // ucCancelCourt1
            // 
            this.ucCancelCourt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucCancelCourt1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCancelCourt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucCancelCourt1.Location = new System.Drawing.Point(2, 2);
            this.ucCancelCourt1.Name = "ucCancelCourt1";
            this.ucCancelCourt1.Size = new System.Drawing.Size(944, 706);
            this.ucCancelCourt1.TabIndex = 22;
            // 
            // ucCrFacilities1
            // 
            this.ucCrFacilities1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucCrFacilities1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCrFacilities1.ForeColor = System.Drawing.Color.White;
            this.ucCrFacilities1.Location = new System.Drawing.Point(1, 2);
            this.ucCrFacilities1.Name = "ucCrFacilities1";
            this.ucCrFacilities1.Size = new System.Drawing.Size(942, 703);
            this.ucCrFacilities1.TabIndex = 18;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1183, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSlide.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hamburgerBtn;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button viewBookBtn;
        private System.Windows.Forms.Button crbookBtn;
        private System.Windows.Forms.Button delAcctBtn;
        private System.Windows.Forms.Button updAcctBtn;
        private System.Windows.Forms.Button crAcctBtn;
        private System.Windows.Forms.Button cancelBookBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crCourtBtn;
        private System.Windows.Forms.Button delCourtBtn;
        private System.Windows.Forms.Button updCourtBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button rptCustList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homeBtn;
        private ucWallpaper ucWallpaper1;
        private ucUpdAcct ucUpdAcct1;
        private ucCrAcct ucCrAcct1;
        private ucDelAcct ucDelAcct1;
        private uc.ucFacilities.ucUpdFacilities ucUpdFacilities1;
        private uc.ucFacilities.ucDelFacilities ucDelFacilities1;
        private uc.ucBook.ucBookCourt ucBookCourt1;
        private uc.ucFacilities.ucCrFacilities ucCrFacilities1;
        private uc.ucBook.ucViewCourt ucViewCourt1;
        private uc.ucBook.ucCancelCourt ucCancelCourt1;
    }
}

