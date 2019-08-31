namespace EfShop
{
    partial class Form1
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnUsersOld = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(130, 177);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(158, 124);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(420, 177);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(158, 124);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUsersOld
            // 
            this.btnUsersOld.Location = new System.Drawing.Point(701, 177);
            this.btnUsersOld.Name = "btnUsersOld";
            this.btnUsersOld.Size = new System.Drawing.Size(158, 124);
            this.btnUsersOld.TabIndex = 2;
            this.btnUsersOld.Text = "Users Old";
            this.btnUsersOld.UseVisualStyleBackColor = true;
            this.btnUsersOld.Click += new System.EventHandler(this.btnUsersOld_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(420, 365);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(158, 124);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 642);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnUsersOld);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnUser);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnUsersOld;
        private System.Windows.Forms.Button btnProducts;
    }
}

