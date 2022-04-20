namespace BBMS
{
    partial class AdminHome
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
            this.btnViewStock = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.btnEditData = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // btnViewStock
            // 
            this.btnViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewStock.BackColor = System.Drawing.Color.IndianRed;
            this.btnViewStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewStock.Location = new System.Drawing.Point(172, 140);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(156, 37);
            this.btnViewStock.TabIndex = 0;
            this.btnViewStock.Text = "ViewStock";
            this.btnViewStock.UseVisualStyleBackColor = false;
            // 
            // btnAddData
            // 
            this.btnAddData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddData.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddData.Location = new System.Drawing.Point(403, 114);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(156, 37);
            this.btnAddData.TabIndex = 1;
            this.btnAddData.Text = "Add Data to  Stock Table";
            this.btnAddData.UseVisualStyleBackColor = false;
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteData.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteData.Location = new System.Drawing.Point(403, 172);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(156, 37);
            this.btnDeleteData.TabIndex = 2;
            this.btnDeleteData.Text = "Delete Data in Stock Table";
            this.btnDeleteData.UseVisualStyleBackColor = false;
            // 
            // btnEditData
            // 
            this.btnEditData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditData.BackColor = System.Drawing.Color.IndianRed;
            this.btnEditData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditData.Location = new System.Drawing.Point(403, 231);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(156, 37);
            this.btnEditData.TabIndex = 3;
            this.btnEditData.Text = "Edit Data in Stock Table";
            this.btnEditData.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Location = new System.Drawing.Point(172, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Filter by Blood Group";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnViewStock);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}