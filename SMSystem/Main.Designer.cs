
namespace SMSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
            buttonhome = new System.Windows.Forms.Button();
            buttonMaterails = new System.Windows.Forms.Button();
            buttonIncome = new System.Windows.Forms.Button();
            buttonOutCome = new System.Windows.Forms.Button();
            buttonSuppliers = new System.Windows.Forms.Button();
            buttonCustomers = new System.Windows.Forms.Button();
            buttonAnalysis = new System.Windows.Forms.Button();
            buttonHelp = new System.Windows.Forms.Button();
            panelContainer = new System.Windows.Forms.Panel();
            buttonStore = new System.Windows.Forms.Button();
            buttonUsers = new System.Windows.Forms.Button();
            flowLayoutPanelNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanelNavBar.Controls.Add(buttonhome);
            flowLayoutPanelNavBar.Controls.Add(buttonStore);
            flowLayoutPanelNavBar.Controls.Add(buttonMaterails);
            flowLayoutPanelNavBar.Controls.Add(buttonIncome);
            flowLayoutPanelNavBar.Controls.Add(buttonOutCome);
            flowLayoutPanelNavBar.Controls.Add(buttonUsers);
            flowLayoutPanelNavBar.Controls.Add(buttonSuppliers);
            flowLayoutPanelNavBar.Controls.Add(buttonCustomers);
            flowLayoutPanelNavBar.Controls.Add(buttonAnalysis);
            flowLayoutPanelNavBar.Controls.Add(buttonHelp);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(166, 673);
            flowLayoutPanelNavBar.TabIndex = 0;
            // 
            // buttonhome
            // 
            buttonhome.Image = Properties.Resources.home_32px;
            buttonhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonhome.Location = new System.Drawing.Point(5, 6);
            buttonhome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonhome.Name = "buttonhome";
            buttonhome.Size = new System.Drawing.Size(140, 60);
            buttonhome.TabIndex = 0;
            buttonhome.Text = "الرئيسة";
            buttonhome.UseVisualStyleBackColor = true;
            buttonhome.Click += buttonhome_Click;
            // 
            // buttonMaterails
            // 
            buttonMaterails.Image = Properties.Resources.open_box_32px;
            buttonMaterails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonMaterails.Location = new System.Drawing.Point(5, 150);
            buttonMaterails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonMaterails.Name = "buttonMaterails";
            buttonMaterails.Size = new System.Drawing.Size(140, 60);
            buttonMaterails.TabIndex = 2;
            buttonMaterails.Text = "المنتجات";
            buttonMaterails.UseVisualStyleBackColor = true;
            buttonMaterails.Click += buttonMaterails_Click;
            // 
            // buttonIncome
            // 
            buttonIncome.Image = Properties.Resources.icons8_internal_32px_1;
            buttonIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonIncome.Location = new System.Drawing.Point(5, 222);
            buttonIncome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonIncome.Name = "buttonIncome";
            buttonIncome.Size = new System.Drawing.Size(140, 60);
            buttonIncome.TabIndex = 9;
            buttonIncome.Text = "المشتريات";
            buttonIncome.UseVisualStyleBackColor = true;
            buttonIncome.Click += buttonIncome_Click;
            // 
            // buttonOutCome
            // 
            buttonOutCome.Image = Properties.Resources.icons8_external_32px;
            buttonOutCome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOutCome.Location = new System.Drawing.Point(5, 294);
            buttonOutCome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonOutCome.Name = "buttonOutCome";
            buttonOutCome.Size = new System.Drawing.Size(140, 60);
            buttonOutCome.TabIndex = 10;
            buttonOutCome.Text = "المبيعات";
            buttonOutCome.UseVisualStyleBackColor = true;
            buttonOutCome.Click += buttonOutCome_Click;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.Image = Properties.Resources.supplier_32px;
            buttonSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSuppliers.Location = new System.Drawing.Point(5, 366);
            buttonSuppliers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Size = new System.Drawing.Size(140, 60);
            buttonSuppliers.TabIndex = 3;
            buttonSuppliers.Text = "  الموردين";
            buttonSuppliers.UseVisualStyleBackColor = true;
            buttonSuppliers.Click += buttonSuppliers_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Image = Properties.Resources.users_32px;
            buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCustomers.Location = new System.Drawing.Point(5, 438);
            buttonCustomers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new System.Drawing.Size(140, 60);
            buttonCustomers.TabIndex = 7;
            buttonCustomers.Text = "  العملاء";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // buttonAnalysis
            // 
            buttonAnalysis.Image = Properties.Resources.chart_32px;
            buttonAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAnalysis.Location = new System.Drawing.Point(5, 510);
            buttonAnalysis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonAnalysis.Name = "buttonAnalysis";
            buttonAnalysis.Size = new System.Drawing.Size(140, 60);
            buttonAnalysis.TabIndex = 4;
            buttonAnalysis.Text = "التحليل";
            buttonAnalysis.UseVisualStyleBackColor = true;
            buttonAnalysis.Click += buttonAnalysis_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.settings_32px;
            buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonHelp.Location = new System.Drawing.Point(5, 654);
            buttonHelp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new System.Drawing.Size(140, 60);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "  الاعدادات";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(166, 0);
            panelContainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(896, 673);
            panelContainer.TabIndex = 1;
            // 
            // buttonStore
            // 
            buttonStore.Image = Properties.Resources.department_store_32px;
            buttonStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonStore.Location = new System.Drawing.Point(5, 78);
            buttonStore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new System.Drawing.Size(140, 60);
            buttonStore.TabIndex = 1;
            buttonStore.Text = "الاصناف";
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += buttonStore_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonUsers.Image = Properties.Resources.icons8_select_users_32px;
            buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonUsers.Location = new System.Drawing.Point(5, 582);
            buttonUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new System.Drawing.Size(140, 60);
            buttonUsers.TabIndex = 12;
            buttonUsers.Text = "العمال";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1062, 673);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "مخزن";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            flowLayoutPanelNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Button buttonMaterails;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonAnalysis;
        private System.Windows.Forms.Button buttonHelp;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonOutCome;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonUsers;
    }
}

