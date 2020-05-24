//*********************************************************************
// Programmer: Jusuk Bang
// Date: 05 May 2020
// Software: Microsoft Visual Studio 2019 Version 16.4.5
// Platform: Microsoft Windows 10 Professional 64‐bit 
// Purpose:Develop 1D array with different data type
//*********************************************************************
namespace _1D_array
{
    partial class FrmMain
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(56, 264);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(181, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Find Product Information";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Product Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(53, 114);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(131, 15);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity Remained";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(53, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Product Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(237, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(237, 104);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(354, 25);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(237, 68);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(354, 25);
            this.txtPrice.TabIndex = 9;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(56, 293);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(532, 73);
            this.txtDisplay.TabIndex = 11;
            this.txtDisplay.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(56, 203);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(181, 23);
            this.btnTotal.TabIndex = 13;
            this.btnTotal.Text = "Find Total Order Price";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(56, 232);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(532, 26);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.UseWaitCursor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(56, 384);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(104, 44);
            this.btnSort.TabIndex = 15;
            this.btnSort.Text = "Sort by Title";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(56, 434);
            this.txtSort.Multiline = true;
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(532, 124);
            this.txtSort.TabIndex = 16;
            this.txtSort.UseWaitCursor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 579);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDisplay);
            this.Name = "FrmMain";
            this.Text = "Data Structure";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtSort;
    }
}

