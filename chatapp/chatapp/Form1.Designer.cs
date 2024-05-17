namespace chatapp
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
            listBox_messages = new ListBox();
            text_Name = new TextBox();
            text_Message = new TextBox();
            text_Group = new TextBox();
            Name = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_send = new Button();
            btn_join = new Button();
            btn_group = new Button();
            SuspendLayout();
            // 
            // listBox_messages
            // 
            listBox_messages.BackColor = SystemColors.InactiveCaption;
            listBox_messages.FormattingEnabled = true;
            listBox_messages.Location = new Point(33, 218);
            listBox_messages.Name = "listBox_messages";
            listBox_messages.Size = new Size(676, 204);
            listBox_messages.TabIndex = 0;
            // 
            // text_Name
            // 
            text_Name.Location = new Point(110, 29);
            text_Name.Name = "text_Name";
            text_Name.Size = new Size(125, 27);
            text_Name.TabIndex = 1;
            // 
            // text_Message
            // 
            text_Message.Location = new Point(110, 90);
            text_Message.Name = "text_Message";
            text_Message.Size = new Size(125, 27);
            text_Message.TabIndex = 2;
            // 
            // text_Group
            // 
            text_Group.Location = new Point(110, 156);
            text_Group.Name = "text_Group";
            text_Group.Size = new Size(125, 27);
            text_Group.TabIndex = 3;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(33, 32);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 4;
            Name.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 159);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Group";
            // 
            // btn_send
            // 
            btn_send.Location = new Point(277, 27);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(94, 29);
            btn_send.TabIndex = 7;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_join
            // 
            btn_join.Location = new Point(277, 88);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(94, 29);
            btn_join.TabIndex = 8;
            btn_join.Text = "Join";
            btn_join.UseVisualStyleBackColor = true;
            btn_join.Click += btn_join_Click;
            // 
            // btn_group
            // 
            btn_group.Location = new Point(277, 156);
            btn_group.Name = "btn_group";
            btn_group.Size = new Size(94, 29);
            btn_group.TabIndex = 9;
            btn_group.Text = "Group";
            btn_group.UseVisualStyleBackColor = true;
            btn_group.Click += btn_group_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_group);
            Controls.Add(btn_join);
            Controls.Add(btn_send);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Name);
            Controls.Add(text_Group);
            Controls.Add(text_Message);
            Controls.Add(text_Name);
            Controls.Add(listBox_messages);
            //Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_messages;
        private TextBox text_Name;
        private TextBox text_Message;
        private TextBox text_Group;
        private Label Name;
        private Label label2;
        private Label label3;
        private Button btn_send;
        private Button btn_join;
        private Button btn_group;
    }
}
