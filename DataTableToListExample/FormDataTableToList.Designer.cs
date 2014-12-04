namespace DataTableToListExample
{
    partial class FormDataTableToList
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
            this.btnDatatableToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDatatableToList
            // 
            this.btnDatatableToList.Location = new System.Drawing.Point(140, 115);
            this.btnDatatableToList.Name = "btnDatatableToList";
            this.btnDatatableToList.Size = new System.Drawing.Size(75, 23);
            this.btnDatatableToList.TabIndex = 0;
            this.btnDatatableToList.Text = "Get List Count";
            this.btnDatatableToList.UseVisualStyleBackColor = true;
            this.btnDatatableToList.Click += new System.EventHandler(this.btnDatatableToList_Click);
            // 
            // FormDataTableToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.btnDatatableToList);
            this.Name = "FormDataTableToList";
            this.Text = "DataTable To List Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatatableToList;
    }
}

