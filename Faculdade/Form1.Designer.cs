
namespace Faculdade
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
            this.Nome = new System.Windows.Forms.Label();
            this.NomeTXT = new System.Windows.Forms.TextBox();
            this.CelularTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.TableUsers = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(19, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(50, 20);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // NomeTXT
            // 
            this.NomeTXT.Location = new System.Drawing.Point(19, 53);
            this.NomeTXT.Name = "NomeTXT";
            this.NomeTXT.Size = new System.Drawing.Size(357, 27);
            this.NomeTXT.TabIndex = 1;
            // 
            // CelularTXT
            // 
            this.CelularTXT.Location = new System.Drawing.Point(19, 169);
            this.CelularTXT.Name = "CelularTXT";
            this.CelularTXT.Size = new System.Drawing.Size(357, 27);
            this.CelularTXT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Celular";
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(19, 285);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(357, 27);
            this.EmailTXT.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(19, 395);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(342, 29);
            this.Adicionar.TabIndex = 6;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.Location = new System.Drawing.Point(404, 53);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.Size = new System.Drawing.Size(357, 27);
            this.PasswordTXT.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(404, 9);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 20);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // TableUsers
            // 
            this.TableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email});
            this.TableUsers.Location = new System.Drawing.Point(417, 169);
            this.TableUsers.Name = "TableUsers";
            this.TableUsers.RowHeadersWidth = 51;
            this.TableUsers.RowTemplate.Height = 29;
            this.TableUsers.Size = new System.Drawing.Size(371, 241);
            this.TableUsers.TabIndex = 9;

            // 
            // Email
            // 
            this.Email.HeaderText = "EmailTXT";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableUsers);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.EmailTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CelularTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeTXT);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox NomeTXT;
        private System.Windows.Forms.TextBox CelularTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.DataGridView TableUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

