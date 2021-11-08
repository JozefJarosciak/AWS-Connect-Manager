
namespace AWS_Connect_Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.select_profile_comboBox = new System.Windows.Forms.ComboBox();
            this.aws_instance_list = new System.Windows.Forms.ListView();
            this.InstanceTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InstanceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrivateIpAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InstanceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlatformDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvailabilityZone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connect_button = new System.Windows.Forms.Button();
            this.instance_count = new System.Windows.Forms.Label();
            this.copy_instance_id_textBox = new System.Windows.Forms.TextBox();
            this.copy_ip_address_textBox = new System.Windows.Forms.TextBox();
            this.show_running_checkBox = new System.Windows.Forms.CheckBox();
            this.winscp_radio_button = new System.Windows.Forms.RadioButton();
            this.aws_ssm_radio_button = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.app__tabControl = new System.Windows.Forms.TabControl();
            this.app_tabPage_aws = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.sli_ssm_command = new System.Windows.Forms.TextBox();
            this.app_tabPage_configuration = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.path_config_header = new System.Windows.Forms.Label();
            this.prerequisites_header = new System.Windows.Forms.Label();
            this.rdp_header = new System.Windows.Forms.Label();
            this.rdp_password_header = new System.Windows.Forms.Label();
            this.rdp_password = new System.Windows.Forms.TextBox();
            this.rdp_username = new System.Windows.Forms.TextBox();
            this.rdp_username_header = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.conemu_install_location = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.winscp_install_location = new System.Windows.Forms.TextBox();
            this.environment_config_location = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.region_comboBox = new System.Windows.Forms.ComboBox();
            this.app__tabControl.SuspendLayout();
            this.app_tabPage_aws.SuspendLayout();
            this.app_tabPage_configuration.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_profile_comboBox
            // 
            this.select_profile_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.select_profile_comboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.select_profile_comboBox.FormattingEnabled = true;
            this.select_profile_comboBox.Items.AddRange(new object[] {
            "Select Environment"});
            this.select_profile_comboBox.Location = new System.Drawing.Point(6, 6);
            this.select_profile_comboBox.Name = "select_profile_comboBox";
            this.select_profile_comboBox.Size = new System.Drawing.Size(272, 28);
            this.select_profile_comboBox.TabIndex = 1;
            this.select_profile_comboBox.Text = "Select Environment";
            this.select_profile_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // aws_instance_list
            // 
            this.aws_instance_list.BackColor = System.Drawing.SystemColors.Control;
            this.aws_instance_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aws_instance_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InstanceTag,
            this.InstanceId,
            this.PrivateIpAddress,
            this.InstanceType,
            this.PlatformDetails,
            this.AvailabilityZone});
            this.aws_instance_list.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aws_instance_list.FullRowSelect = true;
            this.aws_instance_list.HideSelection = false;
            this.aws_instance_list.Location = new System.Drawing.Point(5, 41);
            this.aws_instance_list.Name = "aws_instance_list";
            this.aws_instance_list.Size = new System.Drawing.Size(1087, 515);
            this.aws_instance_list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.aws_instance_list.TabIndex = 2;
            this.aws_instance_list.UseCompatibleStateImageBehavior = false;
            this.aws_instance_list.View = System.Windows.Forms.View.Details;
            this.aws_instance_list.SelectedIndexChanged += new System.EventHandler(this.Instance_SelectedIndexChanged);
            this.aws_instance_list.Click += new System.EventHandler(this.Instance_Click);
            this.aws_instance_list.DoubleClick += new System.EventHandler(this.Instance_DoubleClick);
            // 
            // InstanceTag
            // 
            this.InstanceTag.Text = "Instance Tag";
            this.InstanceTag.Width = 141;
            // 
            // InstanceId
            // 
            this.InstanceId.Text = "Instance Id";
            this.InstanceId.Width = 145;
            // 
            // PrivateIpAddress
            // 
            this.PrivateIpAddress.Text = "Private IP Address";
            this.PrivateIpAddress.Width = 215;
            // 
            // InstanceType
            // 
            this.InstanceType.Text = "Instance Type";
            this.InstanceType.Width = 152;
            // 
            // PlatformDetails
            // 
            this.PlatformDetails.Text = "Platform Details";
            this.PlatformDetails.Width = 170;
            // 
            // AvailabilityZone
            // 
            this.AvailabilityZone.Text = "Availability Zone";
            this.AvailabilityZone.Width = 208;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(6, 562);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(1086, 53);
            this.connect_button.TabIndex = 3;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // instance_count
            // 
            this.instance_count.AutoSize = true;
            this.instance_count.Location = new System.Drawing.Point(1273, 11);
            this.instance_count.Name = "instance_count";
            this.instance_count.Size = new System.Drawing.Size(16, 13);
            this.instance_count.TabIndex = 4;
            this.instance_count.Text = "...";
            // 
            // copy_instance_id_textBox
            // 
            this.copy_instance_id_textBox.Location = new System.Drawing.Point(8, 659);
            this.copy_instance_id_textBox.Name = "copy_instance_id_textBox";
            this.copy_instance_id_textBox.Size = new System.Drawing.Size(191, 20);
            this.copy_instance_id_textBox.TabIndex = 5;
            this.copy_instance_id_textBox.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // copy_ip_address_textBox
            // 
            this.copy_ip_address_textBox.Location = new System.Drawing.Point(218, 658);
            this.copy_ip_address_textBox.Name = "copy_ip_address_textBox";
            this.copy_ip_address_textBox.Size = new System.Drawing.Size(192, 20);
            this.copy_ip_address_textBox.TabIndex = 6;
            this.copy_ip_address_textBox.Click += new System.EventHandler(this.textBox2_Click);
            this.copy_ip_address_textBox.TextChanged += new System.EventHandler(this.copy_ip_address_textBox_TextChanged);
            // 
            // show_running_checkBox
            // 
            this.show_running_checkBox.AutoSize = true;
            this.show_running_checkBox.Checked = true;
            this.show_running_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.show_running_checkBox.Location = new System.Drawing.Point(581, 13);
            this.show_running_checkBox.Name = "show_running_checkBox";
            this.show_running_checkBox.Size = new System.Drawing.Size(120, 17);
            this.show_running_checkBox.TabIndex = 7;
            this.show_running_checkBox.Text = "Show Running Only";
            this.show_running_checkBox.UseVisualStyleBackColor = true;
            this.show_running_checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // winscp_radio_button
            // 
            this.winscp_radio_button.AutoSize = true;
            this.winscp_radio_button.Location = new System.Drawing.Point(883, 621);
            this.winscp_radio_button.Name = "winscp_radio_button";
            this.winscp_radio_button.Size = new System.Drawing.Size(65, 17);
            this.winscp_radio_button.TabIndex = 10;
            this.winscp_radio_button.Text = "WinSCP";
            this.winscp_radio_button.UseVisualStyleBackColor = true;
            this.winscp_radio_button.Visible = false;
            this.winscp_radio_button.CheckedChanged += new System.EventHandler(this.winscp_radio_button_CheckedChanged);
            this.winscp_radio_button.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // aws_ssm_radio_button
            // 
            this.aws_ssm_radio_button.AutoSize = true;
            this.aws_ssm_radio_button.Checked = true;
            this.aws_ssm_radio_button.Location = new System.Drawing.Point(989, 621);
            this.aws_ssm_radio_button.Name = "aws_ssm_radio_button";
            this.aws_ssm_radio_button.Size = new System.Drawing.Size(76, 17);
            this.aws_ssm_radio_button.TabIndex = 11;
            this.aws_ssm_radio_button.TabStop = true;
            this.aws_ssm_radio_button.Text = "AWS SSM";
            this.aws_ssm_radio_button.UseVisualStyleBackColor = true;
            this.aws_ssm_radio_button.Visible = false;
            this.aws_ssm_radio_button.CheckedChanged += new System.EventHandler(this.aws_ssm_radio_button_CheckedChanged);
            this.aws_ssm_radio_button.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Instance ID (click to copy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "IP Address (click to copy)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 21;
            this.toolTip1.SetToolTip(this.label11, "Prerequisites");
            // 
            // app__tabControl
            // 
            this.app__tabControl.Controls.Add(this.app_tabPage_aws);
            this.app__tabControl.Controls.Add(this.app_tabPage_configuration);
            this.app__tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app__tabControl.Location = new System.Drawing.Point(0, 0);
            this.app__tabControl.Name = "app__tabControl";
            this.app__tabControl.SelectedIndex = 0;
            this.app__tabControl.Size = new System.Drawing.Size(1108, 729);
            this.app__tabControl.TabIndex = 14;
            // 
            // app_tabPage_aws
            // 
            this.app_tabPage_aws.BackColor = System.Drawing.SystemColors.Control;
            this.app_tabPage_aws.Controls.Add(this.region_comboBox);
            this.app_tabPage_aws.Controls.Add(this.label6);
            this.app_tabPage_aws.Controls.Add(this.sli_ssm_command);
            this.app_tabPage_aws.Controls.Add(this.aws_instance_list);
            this.app_tabPage_aws.Controls.Add(this.label2);
            this.app_tabPage_aws.Controls.Add(this.select_profile_comboBox);
            this.app_tabPage_aws.Controls.Add(this.label1);
            this.app_tabPage_aws.Controls.Add(this.aws_ssm_radio_button);
            this.app_tabPage_aws.Controls.Add(this.show_running_checkBox);
            this.app_tabPage_aws.Controls.Add(this.winscp_radio_button);
            this.app_tabPage_aws.Controls.Add(this.instance_count);
            this.app_tabPage_aws.Controls.Add(this.copy_ip_address_textBox);
            this.app_tabPage_aws.Controls.Add(this.connect_button);
            this.app_tabPage_aws.Controls.Add(this.copy_instance_id_textBox);
            this.app_tabPage_aws.Location = new System.Drawing.Point(4, 22);
            this.app_tabPage_aws.Name = "app_tabPage_aws";
            this.app_tabPage_aws.Padding = new System.Windows.Forms.Padding(3);
            this.app_tabPage_aws.Size = new System.Drawing.Size(1100, 703);
            this.app_tabPage_aws.TabIndex = 0;
            this.app_tabPage_aws.Text = "AWS Instances";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 636);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CLI SSM Command";
            // 
            // sli_ssm_command
            // 
            this.sli_ssm_command.Location = new System.Drawing.Point(416, 659);
            this.sli_ssm_command.Name = "sli_ssm_command";
            this.sli_ssm_command.Size = new System.Drawing.Size(676, 20);
            this.sli_ssm_command.TabIndex = 14;
            this.sli_ssm_command.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // app_tabPage_configuration
            // 
            this.app_tabPage_configuration.BackColor = System.Drawing.SystemColors.Control;
            this.app_tabPage_configuration.Controls.Add(this.statusStrip1);
            this.app_tabPage_configuration.Controls.Add(this.linkLabel4);
            this.app_tabPage_configuration.Controls.Add(this.linkLabel3);
            this.app_tabPage_configuration.Controls.Add(this.linkLabel2);
            this.app_tabPage_configuration.Controls.Add(this.linkLabel1);
            this.app_tabPage_configuration.Controls.Add(this.path_config_header);
            this.app_tabPage_configuration.Controls.Add(this.label11);
            this.app_tabPage_configuration.Controls.Add(this.prerequisites_header);
            this.app_tabPage_configuration.Controls.Add(this.rdp_header);
            this.app_tabPage_configuration.Controls.Add(this.rdp_password_header);
            this.app_tabPage_configuration.Controls.Add(this.rdp_password);
            this.app_tabPage_configuration.Controls.Add(this.rdp_username);
            this.app_tabPage_configuration.Controls.Add(this.rdp_username_header);
            this.app_tabPage_configuration.Controls.Add(this.button4);
            this.app_tabPage_configuration.Controls.Add(this.conemu_install_location);
            this.app_tabPage_configuration.Controls.Add(this.label5);
            this.app_tabPage_configuration.Controls.Add(this.save_button);
            this.app_tabPage_configuration.Controls.Add(this.button2);
            this.app_tabPage_configuration.Controls.Add(this.button1);
            this.app_tabPage_configuration.Controls.Add(this.winscp_install_location);
            this.app_tabPage_configuration.Controls.Add(this.environment_config_location);
            this.app_tabPage_configuration.Controls.Add(this.label4);
            this.app_tabPage_configuration.Controls.Add(this.label3);
            this.app_tabPage_configuration.Location = new System.Drawing.Point(4, 22);
            this.app_tabPage_configuration.Name = "app_tabPage_configuration";
            this.app_tabPage_configuration.Padding = new System.Windows.Forms.Padding(3);
            this.app_tabPage_configuration.Size = new System.Drawing.Size(1100, 703);
            this.app_tabPage_configuration.TabIndex = 1;
            this.app_tabPage_configuration.Text = "Configuration";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1094, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "© Jozef Jarosciak";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(20, 75);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(188, 13);
            this.linkLabel4.TabIndex = 28;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "AWS Credential File (.aws/credentials)";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(20, 115);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(47, 13);
            this.linkLabel3.TabIndex = 26;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "WinSCP";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(20, 95);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(200, 13);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Session Manager plugin for the AWS CLI";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(20, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "AWS CLI";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // path_config_header
            // 
            this.path_config_header.AutoSize = true;
            this.path_config_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_config_header.Location = new System.Drawing.Point(8, 173);
            this.path_config_header.Name = "path_config_header";
            this.path_config_header.Size = new System.Drawing.Size(159, 20);
            this.path_config_header.TabIndex = 23;
            this.path_config_header.Text = "Path Configuration";
            // 
            // prerequisites_header
            // 
            this.prerequisites_header.AutoSize = true;
            this.prerequisites_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prerequisites_header.Location = new System.Drawing.Point(8, 21);
            this.prerequisites_header.Name = "prerequisites_header";
            this.prerequisites_header.Size = new System.Drawing.Size(114, 20);
            this.prerequisites_header.TabIndex = 20;
            this.prerequisites_header.Text = "Prerequisites";
            // 
            // rdp_header
            // 
            this.rdp_header.AutoSize = true;
            this.rdp_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_header.Location = new System.Drawing.Point(8, 422);
            this.rdp_header.Name = "rdp_header";
            this.rdp_header.Size = new System.Drawing.Size(139, 20);
            this.rdp_header.TabIndex = 18;
            this.rdp_header.Text = "RDP Auto-Login";
            // 
            // rdp_password_header
            // 
            this.rdp_password_header.AutoSize = true;
            this.rdp_password_header.Location = new System.Drawing.Point(397, 452);
            this.rdp_password_header.Name = "rdp_password_header";
            this.rdp_password_header.Size = new System.Drawing.Size(53, 13);
            this.rdp_password_header.TabIndex = 17;
            this.rdp_password_header.Text = "Password";
            // 
            // rdp_password
            // 
            this.rdp_password.Location = new System.Drawing.Point(401, 475);
            this.rdp_password.Name = "rdp_password";
            this.rdp_password.PasswordChar = '*';
            this.rdp_password.Size = new System.Drawing.Size(342, 20);
            this.rdp_password.TabIndex = 16;
            // 
            // rdp_username
            // 
            this.rdp_username.Location = new System.Drawing.Point(8, 475);
            this.rdp_username.Name = "rdp_username";
            this.rdp_username.Size = new System.Drawing.Size(342, 20);
            this.rdp_username.TabIndex = 15;
            // 
            // rdp_username_header
            // 
            this.rdp_username_header.AutoSize = true;
            this.rdp_username_header.Location = new System.Drawing.Point(8, 452);
            this.rdp_username_header.Name = "rdp_username_header";
            this.rdp_username_header.Size = new System.Drawing.Size(55, 13);
            this.rdp_username_header.TabIndex = 14;
            this.rdp_username_header.Text = "Username";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(749, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 26);
            this.button4.TabIndex = 13;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // conemu_install_location
            // 
            this.conemu_install_location.Location = new System.Drawing.Point(10, 360);
            this.conemu_install_location.Name = "conemu_install_location";
            this.conemu_install_location.ReadOnly = true;
            this.conemu_install_location.Size = new System.Drawing.Size(733, 20);
            this.conemu_install_location.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ConEmu - Path to ConEmu64.exe is auto-prefilled";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 566);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(110, 38);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(749, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // winscp_install_location
            // 
            this.winscp_install_location.Location = new System.Drawing.Point(10, 293);
            this.winscp_install_location.Name = "winscp_install_location";
            this.winscp_install_location.ReadOnly = true;
            this.winscp_install_location.Size = new System.Drawing.Size(733, 20);
            this.winscp_install_location.TabIndex = 7;
            // 
            // environment_config_location
            // 
            this.environment_config_location.Location = new System.Drawing.Point(10, 229);
            this.environment_config_location.Name = "environment_config_location";
            this.environment_config_location.ReadOnly = true;
            this.environment_config_location.Size = new System.Drawing.Size(733, 20);
            this.environment_config_location.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "WinSCP - Path to Executable (e.g. C:\\Program Files (x86)\\WinSCP\\WinSCP.exe)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "AWS - Environment Config (e.g. C:\\Users\\user_id\\.aws\\credentials)";
            // 
            // region_comboBox
            // 
            this.region_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.region_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.region_comboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.region_comboBox.FormattingEnabled = true;
            this.region_comboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.region_comboBox.Items.AddRange(new object[] {
            "US East (Ohio)",
            "US East (N. Virginia)",
            "US West (N. California)",
            "US West (Oregon)",
            "Africa (Cape Town)",
            "Asia Pacific (Hong Kong)",
            "Asia Pacific (Mumbai)",
            "Asia Pacific (Osaka)",
            "Asia Pacific (Seoul)",
            "Asia Pacific (Singapore)",
            "Asia Pacific (Sydney)",
            "Asia Pacific (Tokyo)",
            "Canada (Central)",
            "China (Beijing)",
            "China (Ningxia)",
            "Europe (Frankfurt)",
            "Europe (Ireland)",
            "Europe (London)",
            "Europe (Milan)",
            "Europe (Paris)",
            "Europe (Stockholm)",
            "Middle East (Bahrain)",
            "South America (São Paulo)"});
            this.region_comboBox.Location = new System.Drawing.Point(284, 6);
            this.region_comboBox.Name = "region_comboBox";
            this.region_comboBox.Size = new System.Drawing.Size(272, 28);
            this.region_comboBox.TabIndex = 16;
            this.region_comboBox.SelectedIndexChanged += new System.EventHandler(this.region_comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AccessibleName = "Form1";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1108, 729);
            this.Controls.Add(this.app__tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1124, 768);
            this.MinimumSize = new System.Drawing.Size(1124, 768);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AWS Connect Manager for Windows";
            this.app__tabControl.ResumeLayout(false);
            this.app_tabPage_aws.ResumeLayout(false);
            this.app_tabPage_aws.PerformLayout();
            this.app_tabPage_configuration.ResumeLayout(false);
            this.app_tabPage_configuration.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox select_profile_comboBox;
        private System.Windows.Forms.ListView aws_instance_list;
        private System.Windows.Forms.ColumnHeader InstanceTag;

        private System.Windows.Forms.ColumnHeader InstanceId;
        private System.Windows.Forms.ColumnHeader PrivateIpAddress;
        private System.Windows.Forms.ColumnHeader InstanceType;
        private System.Windows.Forms.ColumnHeader PlatformDetails;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label instance_count;
        private System.Windows.Forms.TextBox copy_instance_id_textBox;
        private System.Windows.Forms.ColumnHeader AvailabilityZone;
        private System.Windows.Forms.TextBox copy_ip_address_textBox;
        private System.Windows.Forms.CheckBox show_running_checkBox;
        private System.Windows.Forms.RadioButton winscp_radio_button;
        private System.Windows.Forms.RadioButton aws_ssm_radio_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl app__tabControl;
        private System.Windows.Forms.TabPage app_tabPage_aws;
        private System.Windows.Forms.TabPage app_tabPage_configuration;
        private System.Windows.Forms.TextBox winscp_install_location;
        private System.Windows.Forms.TextBox environment_config_location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox conemu_install_location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rdp_username;
        private System.Windows.Forms.Label rdp_username_header;
        private System.Windows.Forms.Label rdp_password_header;
        private System.Windows.Forms.TextBox rdp_password;
        private System.Windows.Forms.Label rdp_header;
        private System.Windows.Forms.Label path_config_header;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label prerequisites_header;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox sli_ssm_command;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox region_comboBox;
    }
}

