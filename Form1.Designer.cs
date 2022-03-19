namespace Serialisation_Demo
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
            this.lLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lDeptName = new System.Windows.Forms.Label();
            this.lDeptId = new System.Windows.Forms.Label();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lLocation
            // 
            this.lLocation.AutoSize = true;
            this.lLocation.Location = new System.Drawing.Point(413, 223);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(70, 20);
            this.lLocation.TabIndex = 15;
            this.lLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(553, 217);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(201, 26);
            this.txtLocation.TabIndex = 14;
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(553, 65);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(201, 26);
            this.txtDeptId.TabIndex = 13;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(553, 146);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(201, 26);
            this.txtDeptName.TabIndex = 12;
            // 
            // lDeptName
            // 
            this.lDeptName.AutoSize = true;
            this.lDeptName.Location = new System.Drawing.Point(413, 152);
            this.lDeptName.Name = "lDeptName";
            this.lDeptName.Size = new System.Drawing.Size(90, 20);
            this.lDeptName.TabIndex = 11;
            this.lDeptName.Text = "Dept Name";
            // 
            // lDeptId
            // 
            this.lDeptId.AutoSize = true;
            this.lDeptId.Location = new System.Drawing.Point(413, 71);
            this.lDeptId.Name = "lDeptId";
            this.lDeptId.Size = new System.Drawing.Size(62, 20);
            this.lDeptId.TabIndex = 10;
            this.lDeptId.Text = "Dept Id";
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(607, 323);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(118, 30);
            this.btnBinaryRead.TabIndex = 17;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(453, 323);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(115, 30);
            this.btnBinaryWrite.TabIndex = 16;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(607, 373);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(118, 30);
            this.btnXMLRead.TabIndex = 19;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(453, 373);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(115, 30);
            this.btnXMLWrite.TabIndex = 18;
            this.btnXMLWrite.Text = "XML Write";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(607, 503);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(118, 30);
            this.btnJSONRead.TabIndex = 23;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(453, 503);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(115, 30);
            this.btnJSONWrite.TabIndex = 22;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(607, 453);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(118, 30);
            this.btnSOAPRead.TabIndex = 21;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(453, 453);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(115, 30);
            this.btnSOAPWrite.TabIndex = 20;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 611);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.lLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.lDeptName);
            this.Controls.Add(this.lDeptId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lDeptName;
        private System.Windows.Forms.Label lDeptId;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnJSONRead;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnSOAPWrite;
    }
}

