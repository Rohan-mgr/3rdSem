
namespace Task
{
    partial class FormDB
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
            this.student_list = new System.Windows.Forms.DataGridView();
            this.std_name = new System.Windows.Forms.Label();
            this.stdName = new System.Windows.Forms.TextBox();
            this.std_address = new System.Windows.Forms.Label();
            this.stdAddress = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.stdPhone = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.PictureBox();
            this.SelectPhoto = new System.Windows.Forms.Button();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.student_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // student_list
            // 
            this.student_list.AllowUserToAddRows = false;
            this.student_list.AllowUserToDeleteRows = false;
            this.student_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.Name,
            this.Address,
            this.Contact,
            this.FilePath,
            this.Action,
            this.id});
            this.student_list.Location = new System.Drawing.Point(35, 226);
            this.student_list.Name = "student_list";
            this.student_list.ReadOnly = true;
            this.student_list.RowHeadersWidth = 62;
            this.student_list.RowTemplate.Height = 28;
            this.student_list.Size = new System.Drawing.Size(1168, 313);
            this.student_list.TabIndex = 0;
            this.student_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_list_CellClick);
            // 
            // std_name
            // 
            this.std_name.AutoSize = true;
            this.std_name.Location = new System.Drawing.Point(40, 9);
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(51, 20);
            this.std_name.TabIndex = 1;
            this.std_name.Text = "Name";
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(44, 32);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(233, 26);
            this.stdName.TabIndex = 2;
            // 
            // std_address
            // 
            this.std_address.AutoSize = true;
            this.std_address.Location = new System.Drawing.Point(40, 71);
            this.std_address.Name = "std_address";
            this.std_address.Size = new System.Drawing.Size(68, 20);
            this.std_address.TabIndex = 3;
            this.std_address.Text = "Address";
            // 
            // stdAddress
            // 
            this.stdAddress.Location = new System.Drawing.Point(44, 94);
            this.stdAddress.Name = "stdAddress";
            this.stdAddress.Size = new System.Drawing.Size(233, 26);
            this.stdAddress.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(341, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 35);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(458, 151);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(85, 37);
            this.remove.TabIndex = 6;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // stdPhone
            // 
            this.stdPhone.Location = new System.Drawing.Point(367, 32);
            this.stdPhone.Name = "stdPhone";
            this.stdPhone.Size = new System.Drawing.Size(233, 26);
            this.stdPhone.TabIndex = 7;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(363, 9);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(55, 20);
            this.phone.TabIndex = 8;
            this.phone.Text = "Phone";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(580, 151);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 37);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(685, 152);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 37);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(861, 9);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(211, 124);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 11;
            this.photo.TabStop = false;
            // 
            // SelectPhoto
            // 
            this.SelectPhoto.Location = new System.Drawing.Point(861, 151);
            this.SelectPhoto.Name = "SelectPhoto";
            this.SelectPhoto.Size = new System.Drawing.Size(211, 36);
            this.SelectPhoto.TabIndex = 12;
            this.SelectPhoto.Text = "Select Photo";
            this.SelectPhoto.UseVisualStyleBackColor = true;
            this.SelectPhoto.Click += new System.EventHandler(this.SelectPhoto_Click);
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.MinimumWidth = 8;
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 40;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 120;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.MinimumWidth = 8;
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            this.Contact.Width = 80;
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "FilePath";
            this.FilePath.MinimumWidth = 8;
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Width = 200;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 8;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 60;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 561);
            this.Controls.Add(this.SelectPhoto);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.update);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.stdPhone);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.stdAddress);
            this.Controls.Add(this.std_address);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.std_name);
            this.Controls.Add(this.student_list);
            this.Name = "FormDB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView student_list;
        private System.Windows.Forms.Label std_name;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.Label std_address;
        private System.Windows.Forms.TextBox stdAddress;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox stdPhone;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button SelectPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

