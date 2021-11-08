using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.SimpleNotificationService;


namespace AWS_Connect_Manager
{

    public partial class Form1 : Form
    {
        public string region_short = "";

        private string[] aws_name = new string[1000];
        private string[] aws_key = new string[1000];
        private string[] aws_psw = new string[1000];
        private string conemu_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\cmder_mini\\vendor\\conemu-maximus5\\ConEmu64.exe";
        private string ini_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini";
        private string start_bat_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\start.bat";

        private void UpdateRegion()
        {
            // update_region
            if (region_comboBox.Text == "US East (Ohio)") { region_short = "us-east-2"; }
            if (region_comboBox.Text == "US East (N. Virginia)") { region_short = "us-east-1"; }
            if (region_comboBox.Text == "US West (N. California)") { region_short = "us-west-1"; }
            if (region_comboBox.Text == "US West (Oregon)") { region_short = "us-west-2"; }
            if (region_comboBox.Text == "Africa (Cape Town)") { region_short = "af-south-1"; }
            if (region_comboBox.Text == "Asia Pacific (Hong Kong)") { region_short = "ap-east-1"; }
            if (region_comboBox.Text == "Asia Pacific (Mumbai)") { region_short = "ap-south-1"; }
            if (region_comboBox.Text == "Asia Pacific (Osaka)") { region_short = "ap-northeast-3"; }
            if (region_comboBox.Text == "Asia Pacific (Seoul)") { region_short = "ap-northeast-2"; }
            if (region_comboBox.Text == "Asia Pacific (Singapore)") { region_short = "ap-southeast-1"; }
            if (region_comboBox.Text == "Asia Pacific (Sydney)") { region_short = "ap-southeast-2"; }
            if (region_comboBox.Text == "Asia Pacific (Tokyo)") { region_short = "ap-northeast-1"; }
            if (region_comboBox.Text == "Canada (Central)") { region_short = "ca-central-1"; }
            if (region_comboBox.Text == "China (Beijing)") { region_short = "cn-north-1"; }
            if (region_comboBox.Text == "China (Ningxia)") { region_short = "cn-northwest-1"; }
            if (region_comboBox.Text == "Europe (Frankfurt)") { region_short = "eu-central-1"; }
            if (region_comboBox.Text == "Europe (Ireland)") { region_short = "eu-west-1"; }
            if (region_comboBox.Text == "Europe (London)") { region_short = "eu-west-2"; }
            if (region_comboBox.Text == "Europe (Milan)") { region_short = "eu-south-1"; }
            if (region_comboBox.Text == "Europe (Paris)") { region_short = "eu-west-3"; }
            if (region_comboBox.Text == "Europe (Stockholm)") { region_short = "eu-north-1"; }
            if (region_comboBox.Text == "Middle East (Bahrain)") { region_short = "me-south-1"; }
            if (region_comboBox.Text == "South America (São Paulo)") { region_short = "sa-east-1"; }
        }

        public Form1()
        {
            InitializeComponent();
            this.select_profile_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_profile_comboBox.Items.Clear();

           

            string path = ini_path;
            int counter = 1;
            if (File.Exists(path))
            {
                foreach (string line in System.IO.File.ReadLines(path))
                {
                    if (counter == 1) { environment_config_location.Text = line; }
                    if (counter == 2) { winscp_install_location.Text = line; }
                    if (counter == 3) { conemu_install_location.Text = line; }
                    if (counter == 4) { rdp_username.Text = line; }
                    if (counter == 5) { rdp_password.Text = line; }

                    counter++;
                }

            }


            if (conemu_install_location.Text.Length == 0)
            {
                conemu_install_location.Text = conemu_path;
            }

            counter = 1;
            if (File.Exists(environment_config_location.Text))
            {
                foreach (string line in System.IO.File.ReadLines(environment_config_location.Text))
                {

                    if (line.StartsWith("[") == true)
                    {
                        select_profile_comboBox.Items.Add(line.Replace("[", "").Replace("]", "").Replace(" ", ""));
                        aws_name[counter] = line.Replace("[", "").Replace("]", "").Replace(" ", "");

                    }
                    else if (line.StartsWith("aws_access_key_id") == true)
                    {
                        aws_key[counter - 1] = line.Replace("aws_access_key_id", "").Replace("=", "").Replace(" ", "");
                    }
                    else if (line.StartsWith("aws_secret_access_key") == true)
                    {
                        aws_psw[counter - 2] = line.Replace("aws_secret_access_key", "").Replace("=", "").Replace(" ", "");
                    }
                    counter++;
                }
            }

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItem = new ListViewItem();
            if (aws_instance_list.SelectedItems.Count > 0)
            {
                selectedItem = aws_instance_list.SelectedItems[0];

            }
            else
            {
                return;
            }


            string path = start_bat_path;
            if (File.Exists(path))
            {
                File.Delete(path);
            }


            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            


            if (selectedItem.SubItems[4].Text.StartsWith("Windows"))
            {
              
                var strCmdText = " -run aws --region "+ region_short + " --profile " + select_profile_comboBox.Text + " ssm start-session --target " + selectedItem.SubItems[1].Text + " --document-name AWS-StartPortForwardingSession --parameters localPortNumber=54322,portNumber=3389";
                System.Diagnostics.Process.Start(conemu_path, strCmdText);
                System.Threading.Thread.Sleep(3000);
                Process rdcProcess = new Process();
                sli_ssm_command.Text = "";
                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                rdcProcess.StartInfo.Arguments = "/generic:TERMSRV/localhost:54322 /user:" + rdp_username.Text + " /pass:" + rdp_password.Text;
                rdcProcess.Start();

                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
                rdcProcess.StartInfo.Arguments = "/v localhost:54322"; // ip or name of computer to connect
                rdcProcess.Start();
            }
            else
            {
                
                    if (winscp_radio_button.Checked == true)
                    {
                     
                        var strCmdText = " -run aws --region " + region_short + " --profile " + select_profile_comboBox.Text + " ssm start-session --target " + selectedItem.SubItems[1].Text + " --document-name AWS-StartPortForwardingSession --parameters localPortNumber=54321,portNumber=22";
                        System.Diagnostics.Process.Start(conemu_path, strCmdText);
                    // process.Start();
                    sli_ssm_command.Text = "";
                    strCmdText = " -run \"" + winscp_install_location.Text + "\" /mysession AWS";
                        System.Diagnostics.Process.Start(conemu_path, strCmdText);
                        //process.Start();



                    }
                    else {

                        if ((conemu_install_location.Text.Contains("ConEmu") || (conemu_install_location.Text.Contains("Cmder"))))
                        {
                        var strCmdText = " -run aws --region " + region_short + " --profile " + select_profile_comboBox.Text + " ssm start-session --target " + selectedItem.SubItems[1].Text;
                        sli_ssm_command.Text = strCmdText.Replace(" -run ","");
                        System.Diagnostics.Process.Start(conemu_path, strCmdText);
                        //process.Start();

                    } else
                    {
                        MessageBox.Show("ConEmu path is missing in the configuration!");
                    }
                        

                        
                    }
                }
                
            
        }

        private void Instance_DoubleClick(object sender, EventArgs e)
        {
            connect_button.PerformClick();
            sli_ssm_command.Text = "";
        }


        private void Instance_Click(object sender, EventArgs e)
        {

            var selectedItem = aws_instance_list.SelectedItems[0];

            if (selectedItem.SubItems[4].Text.StartsWith("Windows"))
            {

                sli_ssm_command.Text = "";
            }
            else
            {

                if (winscp_radio_button.Checked == true)
                {

                    sli_ssm_command.Text = "";
                } else
                {
                   
                    var strCmdText = "aws --region " + region_short + " --profile " + select_profile_comboBox.Text + " ssm start-session --target " + selectedItem.SubItems[1].Text;
                    sli_ssm_command.Text = strCmdText;
                }

            }
        }

        private void Instance_SelectedIndexChanged(object sender, EventArgs e)
        {
            sli_ssm_command.Text = "";
            if (aws_instance_list.SelectedItems.Count > 0)
            {
                var selectedItem = aws_instance_list.SelectedItems[0];

                var msg = "";

                if (selectedItem.SubItems[4].Text.StartsWith("Windows"))
                {
                    msg = "RDP to ";
                    winscp_radio_button.Visible = false;
                    aws_ssm_radio_button.Visible = false;
                } else
                {
                    if (aws_ssm_radio_button.Checked) { 
                    msg = "AWS SSM to ";
                    winscp_radio_button.Visible = true;
                    aws_ssm_radio_button.Visible = true;
                    } else
                    {
                        msg = "WinSCP to ";
                        winscp_radio_button.Visible = true;
                        aws_ssm_radio_button.Visible = true;
                    }
                }
                
                connect_button.Text = msg + selectedItem.SubItems[0].Text;
                copy_instance_id_textBox.Text = selectedItem.SubItems[1].Text;
                copy_ip_address_textBox.Text = selectedItem.SubItems[2].Text;
            }
            else
            {
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var selectedItem = new ListViewItem();
            if (aws_instance_list.SelectedItems.Count > 0)
            {
                selectedItem = aws_instance_list.SelectedItems[0];
                Clipboard.SetText(selectedItem.SubItems[1].Text);
            }
            else
            {
                return;
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2_SelectedIndexChanged(select_profile_comboBox, EventArgs.Empty);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           

            copy_instance_id_textBox.SelectionStart = 0;
            copy_instance_id_textBox.SelectionLength = copy_instance_id_textBox.Text.Length;
            Clipboard.SetText(copy_instance_id_textBox.Text);
            toolTip1.Show(copy_instance_id_textBox.Text + " - Copied to Clipboard", copy_instance_id_textBox);
            toolTip1.Hide(copy_instance_id_textBox);

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            copy_ip_address_textBox.SelectionStart = 0;
            copy_ip_address_textBox.SelectionLength = copy_ip_address_textBox.Text.Length;
            Clipboard.SetText(copy_ip_address_textBox.Text);
            toolTip1.Show(copy_ip_address_textBox.Text + " - Copied to Clipboard", copy_ip_address_textBox);
            toolTip1.Hide(copy_ip_address_textBox);
        }


        private void region_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sli_ssm_command.Text = "";
            comboBox2_SelectedIndexChanged(select_profile_comboBox, EventArgs.Empty);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRegion();
            copy_instance_id_textBox.Text = "";
            copy_ip_address_textBox.Text = "";
            string key = "";
            string secret = "";

            for (var xy = 0; xy < aws_name.Length; xy++)
            {
                if (aws_name[xy] == select_profile_comboBox.Text)
                {
                    key = aws_key[xy];
                    secret = aws_psw[xy];
                    break;
                }                
            }
        


            if (!select_profile_comboBox.Text.Equals(""))
                        {
                var awsCredentials = new Amazon.Runtime.BasicAWSCredentials(key, secret);
                var region = Amazon.RegionEndpoint.CACentral1;
                

                if (region_comboBox.Text == "US East (Ohio)") { region = Amazon.RegionEndpoint.USEast2; }
                if (region_comboBox.Text == "US East (N. Virginia)") { region = Amazon.RegionEndpoint.USEast1; }
                if (region_comboBox.Text == "US West (N. California)") { region = Amazon.RegionEndpoint.USWest1; }
                if (region_comboBox.Text == "US West (Oregon)") { region = Amazon.RegionEndpoint.USWest2; }
                if (region_comboBox.Text == "Africa (Cape Town)") { region = Amazon.RegionEndpoint.AFSouth1; }
                if (region_comboBox.Text == "Asia Pacific (Hong Kong)") { region = Amazon.RegionEndpoint.APEast1;}
                if (region_comboBox.Text == "Asia Pacific (Mumbai)") { region = Amazon.RegionEndpoint.APSouth1; }
                if (region_comboBox.Text == "Asia Pacific (Osaka)") { region = Amazon.RegionEndpoint.APNortheast3; }
                if (region_comboBox.Text == "Asia Pacific (Seoul)") { region = Amazon.RegionEndpoint.APNortheast2; }
                if (region_comboBox.Text == "Asia Pacific (Singapore)") { region = Amazon.RegionEndpoint.APSoutheast1; }
                if (region_comboBox.Text == "Asia Pacific (Sydney)") { region = Amazon.RegionEndpoint.APSoutheast2; }
                if (region_comboBox.Text == "Asia Pacific (Tokyo)") { region = Amazon.RegionEndpoint.APNortheast1; }
                if (region_comboBox.Text == "Canada (Central)") { region = Amazon.RegionEndpoint.CACentral1; }
                if (region_comboBox.Text == "China (Beijing)") { region = Amazon.RegionEndpoint.CNNorth1; }
                if (region_comboBox.Text == "China (Ningxia)") { region = Amazon.RegionEndpoint.CNNorthWest1; }
                if (region_comboBox.Text == "Europe (Frankfurt)") { region = Amazon.RegionEndpoint.EUCentral1; }
                if (region_comboBox.Text == "Europe (Ireland)") { region = Amazon.RegionEndpoint.EUWest1; }
                if (region_comboBox.Text == "Europe (London)") { region = Amazon.RegionEndpoint.EUWest2; }
                if (region_comboBox.Text == "Europe (Milan)") { region = Amazon.RegionEndpoint.EUSouth1; }
                if (region_comboBox.Text == "Europe (Paris)") { region = Amazon.RegionEndpoint.EUWest3; }
                if (region_comboBox.Text == "Europe (Stockholm)") { region = Amazon.RegionEndpoint.EUNorth1; }
                if (region_comboBox.Text == "Middle East (Bahrain)") { region = Amazon.RegionEndpoint.MESouth1; }
                if (region_comboBox.Text == "South America (São Paulo)") { region = Amazon.RegionEndpoint.SAEast1; }


                var ec2Client = new Amazon.EC2.AmazonEC2Client(awsCreden‌​tials, region);
                List<Reservation> listReservations = ec2Client.DescribeInstances().Reservations;
                connect_button.Enabled = false;

                var count = listReservations.Count;
                aws_instance_list.Items.Clear();
                // continue if more than one instance available
                if (count>0) {
                
                instance_count.Text = count + " instances";
                var ins = listReservations.ElementAt(0);

                

                for (var i = 0; i < count; i++)
                {
                    var finname = "";
                   

                    for (var ii = 0; ii < listReservations.ElementAt(i).Instances[0].Tags.Count; ii++)
                    {
                        if (listReservations.ElementAt(i).Instances[0].Tags[ii].Key.Equals("Name")) {
                            finname = listReservations.ElementAt(i).Instances[0].Tags[ii].Value;
                        }
                    }

                    if (show_running_checkBox.Checked == true)
                    {
                        if (listReservations.ElementAt(i).Instances[0].State.Name.Value.Equals("running"))
                        {
                            aws_instance_list.Font = new Font(aws_instance_list.Font, FontStyle.Bold);
                            ListViewItem item = new ListViewItem(finname);
                            item.Font = new Font(item.Font, FontStyle.Regular);
                            item.SubItems.Add(listReservations.ElementAt(i).Instances[0].InstanceId);
                            item.SubItems.Add(listReservations.ElementAt(i).Instances[0].PrivateIpAddress);
                           // item.SubItems.Add(listReservations.ElementAt(i).Instances[0].PublicIpAddress);
                            item.SubItems.Add(listReservations.ElementAt(i).Instances[0].InstanceType);
                            item.SubItems.Add(listReservations.ElementAt(i).Instances[0].PlatformDetails);
                            item.SubItems.Add(listReservations.ElementAt(i).Instances[0].Placement.AvailabilityZone);
                            if (listReservations.ElementAt(i).Instances[0].State.Name.Value.Equals("running"))
                            {
                                item.SubItems.Add("Running");
                            }
                            else
                            {
                                item.SubItems.Add("Stopped");
                            }
                            aws_instance_list.Items.Add(item);
                        }
                    }
                    else
                    {
                        aws_instance_list.Font = new Font(aws_instance_list.Font, FontStyle.Bold);
                        ListViewItem item = new ListViewItem(finname);
                        item.Font = new Font(item.Font, FontStyle.Regular);
                        item.SubItems.Add(listReservations.ElementAt(i).Instances[0].InstanceId);
                        item.SubItems.Add(listReservations.ElementAt(i).Instances[0].PrivateIpAddress);
                       // item.SubItems.Add(listReservations.ElementAt(i).Instances[0].PublicIpAddress);
                        item.SubItems.Add(listReservations.ElementAt(i).Instances[0].InstanceType);
                        item.SubItems.Add(listReservations.ElementAt(i).Instances[0].PlatformDetails);
                        item.SubItems.Add(listReservations.ElementAt(i).Instances[0].Placement.AvailabilityZone);
                        if (listReservations.ElementAt(i).Instances[0].State.Name.Value.Equals("running"))
                        {
                            item.SubItems.Add("Running");
                        }
                        else
                        {
                            item.SubItems.Add("Stopped");
                        }
                        aws_instance_list.Items.Add(item);
                    }



                }
                aws_instance_list.Columns[0].Width = -2;
                aws_instance_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                aws_instance_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                
                }
                connect_button.Enabled = true;
            }




            




            //instance.Sort();
        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            var selectedItem = new ListViewItem();
            if (aws_instance_list.SelectedItems.Count > 0)
            {
                selectedItem = aws_instance_list.SelectedItems[0];

            }
            else
            {
                return;
            }
            winscp_radio_button.Checked = true;
            aws_ssm_radio_button.Checked = false;            
            connect_button.Text = "WinSCP to " + selectedItem.SubItems[0].Text;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            var selectedItem = new ListViewItem();
            if (aws_instance_list.SelectedItems.Count > 0)
            {
                selectedItem = aws_instance_list.SelectedItems[0];

            }
            else
            {
                return;
            }
            winscp_radio_button.Checked = false;
            aws_ssm_radio_button.Checked = true;
            connect_button.Text = "AWS SSM to " + selectedItem.SubItems[0].Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true
                environment_config_location.Text = sFileName;
            }
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*exe*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true
                winscp_install_location.Text = sFileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            select_profile_comboBox.Items.Clear();
            aws_instance_list.Items.Clear();

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(environment_config_location.Text);
                writer.WriteLine(winscp_install_location.Text);
                writer.WriteLine(conemu_install_location.Text);
                writer.WriteLine(rdp_username.Text);
                writer.WriteLine(rdp_password.Text);
                
            }


            var counter = 1;
            if (File.Exists(environment_config_location.Text))
            {
                foreach (string line in System.IO.File.ReadLines(environment_config_location.Text))
                {
                    //comboBox2.Items.Clear();
                    if (line.StartsWith("[") == true)
                    {
                        select_profile_comboBox.Items.Add(line.Replace("[", "").Replace("]", "").Replace(" ", ""));
                        aws_name[counter] = line.Replace("[", "").Replace("]", "").Replace(" ", "");

                    }
                    else if (line.StartsWith("aws_access_key_id") == true)
                    {
                        aws_key[counter - 1] = line.Replace("aws_access_key_id", "").Replace("=", "").Replace(" ", "");
                    }
                    else if (line.StartsWith("aws_secret_access_key") == true)
                    {
                        aws_psw[counter - 2] = line.Replace("aws_secret_access_key", "").Replace("=", "").Replace(" ", "");
                    }
                    counter++;
                }
            }

            MessageBox.Show("Saved!");

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-install.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html");
        
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://winscp.net/eng/download.php");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-files.html");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://joe0.com");
        }

        private void aws_ssm_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            sli_ssm_command.Text = "";
        }

        private void winscp_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            sli_ssm_command.Text = "";
        }

        private void copy_ip_address_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
