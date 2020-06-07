namespace EAWApp
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cbbDevice = new System.Windows.Forms.ComboBox();
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtPerName = new System.Windows.Forms.TextBox();
            this.lblPerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.BackColor = System.Drawing.SystemColors.Desktop;
            this.picCapture.Location = new System.Drawing.Point(13, 13);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(450, 450);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(471, 16);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(59, 17);
            this.lblDevice.TabIndex = 1;
            this.lblDevice.Text = "Device: ";
            // 
            // cbbDevice
            // 
            this.cbbDevice.FormattingEnabled = true;
            this.cbbDevice.Location = new System.Drawing.Point(536, 13);
            this.cbbDevice.Name = "cbbDevice";
            this.cbbDevice.Size = new System.Drawing.Size(252, 24);
            this.cbbDevice.TabIndex = 2;
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(536, 44);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(252, 23);
            this.btnDetect.TabIndex = 3;
            this.btnDetect.Text = "Detect Face";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(536, 102);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(252, 23);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // txtPerName
            // 
            this.txtPerName.Location = new System.Drawing.Point(536, 74);
            this.txtPerName.Name = "txtPerName";
            this.txtPerName.Size = new System.Drawing.Size(252, 22);
            this.txtPerName.TabIndex = 5;
            // 
            // lblPerName
            // 
            this.lblPerName.AutoSize = true;
            this.lblPerName.Location = new System.Drawing.Point(471, 77);
            this.lblPerName.Name = "lblPerName";
            this.lblPerName.Size = new System.Drawing.Size(49, 17);
            this.lblPerName.TabIndex = 6;
            this.lblPerName.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.lblPerName);
            this.Controls.Add(this.txtPerName);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.cbbDevice);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cbbDevice;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtPerName;
        private System.Windows.Forms.Label lblPerName;
    }
}

