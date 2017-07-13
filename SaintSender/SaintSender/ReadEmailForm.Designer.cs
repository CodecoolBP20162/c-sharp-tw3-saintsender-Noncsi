namespace SaintSender
{
    partial class ReadEmailForm
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMailbox = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.Label();
            this.lstMailbox = new System.Windows.Forms.ListView();
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(381, 61);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(520, 472);
            this.txtMessage.TabIndex = 0;
            // 
            // lblMailbox
            // 
            this.lblMailbox.AutoSize = true;
            this.lblMailbox.Location = new System.Drawing.Point(12, 45);
            this.lblMailbox.Name = "lblMailbox";
            this.lblMailbox.Size = new System.Drawing.Size(46, 13);
            this.lblMailbox.TabIndex = 6;
            this.lblMailbox.Text = "Mailbox:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(378, 45);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Message:";
            // 
            // txtFrom
            // 
            this.txtFrom.AutoSize = true;
            this.txtFrom.Location = new System.Drawing.Point(497, 32);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(0, 13);
            this.txtFrom.TabIndex = 8;
            // 
            // txtSubject
            // 
            this.txtSubject.AutoSize = true;
            this.txtSubject.Location = new System.Drawing.Point(497, 61);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(0, 13);
            this.txtSubject.TabIndex = 9;
            // 
            // lstMailbox
            // 
            this.lstMailbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.From,
            this.Subject});
            this.lstMailbox.Location = new System.Drawing.Point(12, 61);
            this.lstMailbox.Name = "lstMailbox";
            this.lstMailbox.Size = new System.Drawing.Size(353, 472);
            this.lstMailbox.TabIndex = 10;
            this.lstMailbox.UseCompatibleStateImageBehavior = false;
            this.lstMailbox.View = System.Windows.Forms.View.Details;
            this.lstMailbox.DoubleClick += new System.EventHandler(this.lstMailbox_DoubleClick);
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 176;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 172;
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ReadEmailForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(913, 545);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstMailbox);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMailbox);
            this.Controls.Add(this.txtMessage);
            this.Name = "ReadEmailForm";
            this.Text = "Saint Sender";
            this.Shown += new System.EventHandler(this.ReadEmailForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMailbox;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label txtFrom;
        private System.Windows.Forms.Label txtSubject;
        private System.Windows.Forms.ListView lstMailbox;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSend;
    }
}

