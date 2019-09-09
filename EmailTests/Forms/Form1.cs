/*----------------------------------------------------------------------------
 * Programmer: Andrew Stobart (Microsoft)
 * Initial release date: March 2014
 * 
 * Description:  This program can be used to send test email messages to an
 *               Office 365 tenant before the MX record for the domain is changed.
 *               This allows for mail flow testing for messages originating from the 
 *               Internet and destined to the customer. The Server variable is the MX
 *               record that Office 365 provides for the domain.
 *               
 * 
 * Versions:
 *   1.0.0 (March 2014):      - Andrew's initial release of the program.
 *   
 *   1.1.0 (March 31, 2014):  - Ability to remove an added attachment
 *   
 *   1.4.0 (April 1, 2014):   - Added ability to toggle TLS on or off
 *                            - Disable "send" button to prevent clicking while app is sending message
 *                          
 *   1.5.0 (April 8, 2014):   - Added the ability to set a custom port
 *   
 *   1.8.1 (October 7, 2014): - Initial release on CodeBox
 *                            - Added the ability to set both a P1 and P2 from address
 *                            - Added ability to add a custom x-header
 *                            - Added ability to attach multiple attachments. Previously you could just attach one.
 *                            - Added an about box
 *                            
 *   1.8.2 (Oct 23, 2014):    - Added a change log to the about box
 *                            - Added a ToolTip to the TO text box
 *                             
 *   2.0.2 (Oct 28, 2014):    - Added checkbox to show and hide advanced options
 *                            - Program now has ability to do an MX lookup
 *                            - Tabbing through text boxes now moves in order from top to bottom                           
 *                             
 *   2.1.2 (January 8, 2015): - Check box to enable a log that will always keep track of sent messages. The check box will 
 *                              just show and hide it, but it will always be active.
 *                            - Added a button to clear the log
 *                            - App will test connection to recipient server before attempting to send mail. This check takes 3 seconds.
 *                            
 *   2.2.2 (January 16, 2015) - multiple custom headers can now be added to a sent message
 *                            - MX lookups should now be more robust. If the first query does not return an MX record, the app will
 *                              query a second time before giving up.
 *                            - The above additions need to be tested. Use Wireshark to very MX Record lookups are happening the correct
 *                              number of times
 *                            - Individual rows can now be deleted from the log
 *                            
 *   2.3.1 (Feb 23, 2015)     - App adds it's own message-id to outbound messages and stamps this value in the log so it can be copied out.
 *                            - Can right click any cell in the log to copy its contents
 *                            - Window width reduced when log is visible
 *                            - Can export the log to a CSV file
 *                            - Clear Log button will now prompt for confirmation
 *                            
 *   2.3.4 (June 22, 2015)    - TCP connection to see if recipient server exists did not close after it was established. This connection
 *                              now properly closes.
 *                            - Previously, when app would open a test connection to see if the recipients was reachable, it would always use
 *                              port 25, regardless of what was entered in the app. This test now uses the entered port in the app.
 *                            - Button style on About form changed to be white and flat to match the UI in the main form  
 *                            - Changed the log text box background changed to be white to match the UI in the main form 
 *                            - Publising settings - Publisher name changed from Andrew to Mail Flow Tester. This will update
 *                              the name of the folder in the Start Menu. I also changed the app name in publishing settings to
 *                              "Mail Flow Tester v2." Without doing this, a reboot was required fœr thee snort cut to work.
 *                              put this in the about form notes but high level
 *                              
 *   2.3.5 (July 23, 2015)    - Previously, you would see RST (reset) in the WireShark capture after the server socket test, and after the app
 *                              was closed. This was becuase the socket test and message send didn't gracefully teardown the connection. When the
 *                              app was closed, it would send a RST (reset) to pull down the connection. App now properly closes the connection 
 *                              and you'll see the proer [FIN, ACK} sequence in a WireShark capture.
 *                              The following lines were added:
 *                                - socket.Disconnect(true); //close this socket in the case where a connection was made
 *                                - message.Dispose();
 *                                - client.Dispose();
 *                                
 *   2.4.1 (Sep 28, 2015)     - When the log is visible, form width can now be changed. The width the log opens at is the mimimum width that can be set, and the height cannot be changed
 *                            - link to the applications instructions have been added to the About form 
 *                            - UI updates for consistency across the application (ex. Change log text box is taller, changed wording on the P2 address check box)
 *                            - DNS resolution errors now appear in the log
 *                            - message send failures no longer add a MessageID to their corresponding log entry
 *                            - removed unesessary "using" statements as recommended by Visual Studio
 *                            
 *   2.4.3 (October 15, 2015) - new option added to GUI called "Append date to subject." This will cause the current date and time to be appended to the subject that has been
 *                              entered into the Subject field
 *                            - application gets the current date and time as soon as the Submit button is pressed (currentDateTime). This variable is then used in both the log, and
 *                              to append behind the subject if the "Append Date to subject" check box is checked. This ensures that the appended date and time matches the date and time
 *                              stamped in the log exactly. Previously, the log time would be a second ahead of the time that was appended to the subject due to when I was pulling the
 *                              current time for the various parts of the application.
 *                            - changed log column Server to Recipient server. Changed label "receiving server" to "recipient server"
 *                            - the option "manually specify recipient server" is now unchecked by default
 *                            
 *   2.5.0 (Dec 3, 2015)      - Border colour changed for both Log buttons to match the rest of the UI (changed from Black to Gray)
 *                            - Reply-To address can now be set
 *                            
 *   2.5.1 (June 30, 2016)    - when the recipient domain is Microsoft.com, the MX will manually be set with a hard coded string. This is because
 *                              you cannot lookup with MX for microsoft.com from on the corporate network.
 *                              
 *   2.6.0 (June 27, 2018)    - Done: When there is an error, app now pops a new form with a text box so the error can easily be copied out. Previous a message box had the error and you
 *                              can't copy text from a message box
 *                            - Done:From tag changed to MailFrom
 *                            - Done: When the success messgae box pops up, change the OK wording on the button to be "Nice!"
 *                            - Done: Some MessageBoxes had typos. Corrected
 *                            - Done: MessageBox that says the following when DNS lookup fails: "DNS resolution error, no MX record found. You may need to manually specify the recipient server."
 *                            
 *   2.6.1 (August 24, 2018)  - The last update broke the ability to set a P2 (From) address. This update fixes that                          
 *   
 *   2.7.0 (Nov 30, 2018)     - When there is an error, the full error will now appear in the log for ease of access later, or for export to a CSV file.
 *   
 *   2.8.0 (March 21, 2019)   - double clicking on a cell in the log now pops up a new window with a text box which contains the contents of that cell. This allows text that may be cut off in the   
 *                              cell to be easily viewed without needing to copy the cell and then paste it into another program like notepad. The title of the popup will match the header
 *                              cell of the cell that was double clicked on
 *                            - build version updated on .exe file. If you right click the EXE and look at properties, the version now properly matches
 *                              the application version. Previously it was showing version 2.5.1.
 *                            - Port can now always be changed, regardless of the setting of the text box "Manually specify recipient server"
 *                            - Cleaned up some text boxes that did not have a header on them (I added "Input Validation" as the header on them)
 *                            - Hitting tab now allows you to move focus in order to all of the available controls. This includes those that appear when you select "advanced options"
 *                            - Text validation is now performed on the Port text box. An error will appear if this box contains anything other than an integer 
 *                            - Due to processing order, a non-sensical error (Error: A request to send or receive data was disallowed because the socket is not connected and (when sending on 
 *                              a datagram socket using a sendto call) no address was supplied) would previously appear if you could not reach the recipient server on port 25. This error has 
 *                              now been cleaned up.
 *                            - the code that detects if an end point is reachable has been optimized and better calls out a connection issue if the end point cannot be reached  
 *                             
 *   3.0.0 (May 16, 2019)     - launch on Github!
 *                            - code cleanup
 *                            - Added check box to disable the "is recipient server reachable" test
 *                            - "sending message timeout" is now configurable
 *                            - input validation test for timeout text box (ensures value is a number)
 *                            - with server test not enabled, test app at home
 *                            - if "recipient server" was checked but nothing was entered in the text box the error would not trigger properly. This is now fixed.
 *                            - application currently does not check for updates
 *                              
 *   3.1.0 (July 2019)        - migrating the app from SmtpClient Class in DotNet (https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient?view=netframework-4.7.2), which 
 *                            - has been depreciated, to MailKit and MimeKit (https://github.com/jstedfast/MailKit and https://github.com/jstedfast/MimeKit)
 *                            - http://www.mimekit.net/docs/html/N_MailKit.htm
 *                            - https://csharp.hotexamples.com/examples/MailKit.Net.Smtp/SmtpClient/Send/php-smtpclient-send-method-examples.html
 *                            - https://stackoverflow.com/questions/37853903/can-i-send-files-via-email-using-mailkit
 *                            - https://github.com/jstedfast/MailKit
 *                            - with the move to MailKit & MimeKit, code related to the SmtpClient Class in DotNet has now been removed
 *                            - application now creates an SMTP log (smtp.log) in the same directory where the executable resides
 *                            - a new button called "Open SMTP log" has been added to the log view. This will open the smtp.log file in Notepad for easy access.
 *                            
 *   3.1.2 (Sept 9, 2019)     - the "Open SMTP log" button (viewable when "View Log" is selected) did not move when "Advanced Options" was selected. This has now been fixed.
 *                            - I was unable to edit the text in the text box on the about window. The form would continually flash and visual studio would stop responding.
 *                              To fix this, I had to expand AboutForm.cs, and then edit AboutForm.resx. On that page you'll see the content of the text box on the about form
 *                              and I was able to edit it there. Not sure what's going on with that.
 * Future  
 *        - clear SMTP log on app close? Not sure.
 *        - have SMTP log output to a window? Maybe make a new log checkbox which will show the SMTP log in an attached window? Or just have a link that will open up 
 *          the folder where the smtp log file exists?
 *        - with the move to github the application no longer checks for updates. I need to figure out where to host the install so I can have it check
 *          for updates again
 *        - Have app link directly in Start Menu, as opposed to being in a folder which is in the Start Menu. I don't know if this is possible with click to run
 *        - When adding a different P2 address, is there any way to tell the app to not add the header, "Sender," which casuses the (sent on behalf of) name in Outlook?
 *        - when opening the log, should the initial width be that of the datagrid? Currently the log always opens to the same width, which is the initial datagrid view
 *          width with no content present
 *        - Have up lookup MX records. Maybe pop a status window when the lookup is happening? Or a status bar at the bottom of the window? I like the pop window better.
 *        - Drag and drop attachements to the attachments window
 *        - option to have the app send x number of messages when Send is clicked (would need to have some sort of progress window appear when this is happening). Maybe change subject
 *          slightly for all sent messages (prepend with the message number. ex. 1, 2, 3)
 *----------------------------------------------------------------------------*/
//original form size = 355, 333 (470, 445 on home monitor with 125% scaling)
//Nov 28/14 update: When sending mail from home and I select to do a DNS lookup, the program never times out. If I
//manually specify the server then it does timeout after 20 seconds. See http://stackoverflow.com/questions/10467476/smtpclient-timeout-doesnt-work


using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using MailKit;
using System.Diagnostics;

namespace EmailTests
{
    public partial class Form1 : Form
    {
        //global variables
        int startingHeight = 0; //form height
        int startingWidth = 0;
        int initialViewLogWidth = 0;
        int initialDataGridHeight = 0;
        int initialDataGridWidth = 0;
        int sendButtonStartingLocation = 0; //sendButton Y position
        int clearLogButtonStartingLocation = 0; //clearLogButton Y position
        int exportLogButtonStartingLocation = 0; //ExportLogButton Y position
        int smtpLogButtonStartingLocation = 0;
        
        public Form1()
        {
            InitializeComponent();
            startingHeight = this.Height;
            startingWidth = this.Width;
            initialViewLogWidth = dataGridView1.Location.X + dataGridView1.Width + (this.Width - this.ClientSize.Width) + (dataGridView1.Location.X - (textTo.Location.X + textTo.Width));
            initialDataGridHeight = dataGridView1.Height;
            initialDataGridWidth = dataGridView1.Width;
            sendButtonStartingLocation = buttonSend.Location.Y;
            clearLogButtonStartingLocation = buttonClearLog.Location.Y;
            exportLogButtonStartingLocation = buttonExportLog.Location.Y;
            smtpLogButtonStartingLocation = buttonSmtpLog.Location.Y;
            this.ActiveControl = checkBoxServerName; //sets the active control
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string textSubjectFinal = "";

            //this was used to loop through the code to have the app send a large amount of messages. I may add this as an option int he UI in the future.
            //for (int x = 0; x < 600; x++ )
            //{

            //Disable the send button so it can't be clicked multiple times
            buttonSend.Enabled = false;
                
                
            //Generate a Message-ID. This is generated outside the Try so that the value of "gui" can be used in the "catch" 
            Guid gui = new Guid();
            gui = Guid.NewGuid();
            String messageId = "<" + gui.ToString() + "@mft.local>";

            
                

            try
            {
                //smtp.log file will be created in the same directly that the executable is launched from
                SmtpClient client = new SmtpClient(new ProtocolLogger("smtp.log"));
                MimeMessage mail = new MimeMessage();
                string[] row = new string[] {"bogus"};

                /*Input validation for Port*/
                int n = 0;
                bool isNumber = int.TryParse(textPort.Text, out n);
                if (!isNumber)
                {
                    throw new ApplicationException("The port is set to \"" + textPort.Text + "\" but must be an integer.");
                }

                /*Input validation for time out*/
                n = 0;
                isNumber = int.TryParse(textTimeOut.Text, out n);
                if (!isNumber)
                {
                    throw new ApplicationException("The time out is set to \"" + textPort.Text + "\" but must be an integer.");
                }
                                    

                /* -----------------------------------
                 * RECEIVING SERVER SETTINGS
                 * -----------------------------------*/
                client.Timeout = 60000;  //time-out in milliseconds (if 100,000 is entered, that is 100 seconds)

                //this does a DNS lookup if the checkbox is not checked
                if (checkBoxServerName.Checked == false)
                {
                    if (textTo.Text == "")
                    {
                        MessageBox.Show("Please enter a single recipient address.", "Input Validation", MessageBoxButtons.OK);
                        buttonSend.Enabled = true;
                        return;
                    }
                        
                    //detects the number of @ symbols in the textTo text box. We only want one for a DNS lookup.
                    string mySubString = "@";
                    int multipleRecipients = (textTo.Text.Length - textTo.Text.ToLower().Replace(mySubString.ToLower(), string.Empty).Length) / mySubString.Length;

                    //validates that only a single recipinet has been entered
                    if (multipleRecipients != 1)
                    {
                        MessageBox.Show("Please enter ONLY a single recipient address.", "Input Validation", MessageBoxButtons.OK);
                        buttonSend.Enabled = true;
                        return;
                    }

                    string toAddy = textTo.Text;
                    string[] toAddySplit = toAddy.Split('@');

                    string mx = getMX(toAddySplit[1]);


                    if (mx == "")
                    {
                        //maybe put more in here. Maybe even a window of the nslookup results?
                        MessageBox.Show("DNS resolution error, no MX record found for " + toAddySplit[1] + ". You may need to manually specify the recipient server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonSend.Enabled = true;
                            
                        //add a log entry noting the DNS resolution error
                        dataGridView1.Rows.Add(currentDateTime, textFrom.Text, textTo.Text, textSubject.Text, getOptions(), "DNS resolution error", textServer.Text, "");
                        columnResize();

                        return;
                    }
                    else
                    {
                        textServer.Text = mx;
                    }
                }

                else
                {
                    if (textServer.Text == "")
                    {
                        MessageBox.Show("Please ensure a recipient server has been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonSend.Enabled = true;
                        return;
                    }
                }



                /* ----------------------------------- 
                 * IS SERVER REACHABLE?
                 * If server is not rechable, the timeout period in the Windows network stack can sometimes take excessive
                 * time to return an error. This code will check the server before attempting to send a message to it. I can
                 * manually set the timeout here.
                 * -----------------------------------*/

                //Mar 2019 note: If I enter 123 for server name, the success variable below is True, even though the socket doesn't connect. Maybe I need to put a socked
                //check in after Socket socket = new.... ?
                //https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.socket.beginconnect?view=netframework-4.7.2https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.socket.beginconnect?view=netframework-4.7.2

                /*==============================
                 * The following code was commented out and replace on Mar 20 2019. Success would be True if a non existing server was entered. Ex. "microsoft com" or "1234". 
                 * I have re-written it to instead look to see if the socket connected to know if the end point is alive or not
                 * ==============================*/
                //Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IAsyncResult result = socket.BeginConnect(textServer.Text, Convert.ToInt32(textPort.Text), null, null);
                //// Two second timeout
                //bool success = result.AsyncWaitHandle.WaitOne(3000, true); //wait 3 seconds
                //if (!success)
                //{

                //    /* the following line is not needed as the socket could not be connected in the first place if we are in this block of code. With this here, the ApplicationException 
                //     * below would not be hit as this would generate an exception that was passed to the Catch, causing the error text to be as follows:
                //     * Error: A request to send or receive data was disallowed because the socket is not connected and (when sending on a datagram socket using a sendto call) no address 
                //     * was supplied
                //     */
                //    //socket.Disconnect(true); 

                //    throw new ApplicationException("Failed to connect to " + textServer.Text + " on port " + textPort.Text + ".");
                //}

                //The bellow replaced the above code in the Mar 21, 2019 release (version 2.8.0). See the comments on the above block which talks about the problem with it.
                //https://stackoverflow.com/questions/1062035/how-to-configure-socket-connect-timeout


                if (checkServerReachable.Checked == true)
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IAsyncResult result = socket.BeginConnect(textServer.Text, Convert.ToInt32(textPort.Text), null, null);
                    bool success = result.AsyncWaitHandle.WaitOne(3000, true); //wait 3 seconds

                    if (socket.Connected == false)
                    {
                        socket.Close();
                        throw new ApplicationException("Failed to connect to " + textServer.Text + " on port " + textPort.Text + ".");
                    }
                    else
                    {
                        socket.Disconnect(true);  //close this socket - this line is new in version 2.3.5
                    }
                }

                /* -----------------------------------
                 * EMAIL PROPERTIES
                 * -----------------------------------*/
                //mail.To.Add(textTo.Text);
                mail.To.Add(new MailboxAddress(textTo.Text));

                if (checkSpecifyP2.Checked == false)
                {
                    mail.From.Add(new MailboxAddress(textFrom.Text));
                }
                else
                {
                    mail.Sender = new MailboxAddress(textFrom.Text);
                    mail.From.Add(new MailboxAddress(textFromP2.Text));
                }

                if (checkSpecifyReplyTo.Checked == true)
                {
                    mail.ReplyTo.Add(new MailboxAddress(textReplyTo.Text));
                }

                if (checkDateAppend.Checked == true)
                {
                    textSubjectFinal = textSubject.Text + " <" + currentDateTime + ">";
                }
                else
                {
                    textSubjectFinal = textSubject.Text;
                }

                mail.Subject = textSubjectFinal;
                mail.MessageId = messageId; //Add the generated GUID as a message ID
                BodyBuilder builder = new BodyBuilder();
                builder.TextBody = textBody.Text;


                //Handle custom header additions
                if (checkAddCustomHeader.Checked == true)
                {
                    //ensure both text boxes contain the same number of lines. If not throw an exception
                    if ((textBoxHeaderX.Lines.Length.ToString()) != (textBoxHeaderValue.Lines.Length.ToString()))
                    {
                        throw new ApplicationException("Ensure the Custom Header and Value text boxes have the same number of lines.");
                    }
                    else
                    {
                        //http://stackoverflow.com/questions/75401/uses-of-using-in-c-sharp
                        using (StringReader readerXHeader = new StringReader(textBoxHeaderX.Text), readerXValue = new StringReader(textBoxHeaderValue.Text))
                        {
                            string lineXHeader = string.Empty;
                            string lineXValue = string.Empty;
                            do
                            {
                                lineXHeader = readerXHeader.ReadLine();
                                lineXValue = readerXValue.ReadLine();
                                if (lineXHeader != null & lineXValue != null)
                                {
                                    mail.Headers.Add(lineXHeader, lineXValue);                                     
                                }

                            } while (lineXHeader != null);
                        }
                    }
                }

                /* -----------------------------------
                 * ATTACHMENT HANDLING
                 * -----------------------------------*/
                //If EICAR testing is selected
                if (rbEICAR.Checked == true)
                {
                    //The attachment is created right in the app. This means we don't need to first create it locally 
                    //on the machine and then worry about deleting it when the message is sent.

                    byte[] data = GetData();
                    builder.Attachments.Add("eicar.txt", data);
                }
                
                //If EICAR testing is not selected, lets check to see if an attachment has been added                
                else if (listBoxAttachment.Items.Count != 0)
                {
                    foreach (string spidey in listBoxAttachment.Items)
                    {
                        builder.Attachments.Add(spidey);
                    }
                }

                mail.Body = builder.ToMessageBody();
                
                if (checkForceTLS.Checked == true)
                {
                    client.Connect(textServer.Text, Convert.ToInt32(textPort.Text), SecureSocketOptions.StartTls);
                }
                else
                {
                    client.Connect(textServer.Text, Convert.ToInt32(textPort.Text), SecureSocketOptions.None);
                }
                client.Send(mail);

                client.Disconnect(true);
                client.ProtocolLogger.Dispose(); //without this, smtp.log will remain open by the process and subsequent mail sends will be unable to write to the file

                dataGridView1.Rows.Add(currentDateTime, textFrom.Text, textTo.Text, textSubjectFinal, getOptions(), "Success", textServer.Text, messageId);
                columnResize();
                    
                MessageBox.Show("The message was sent to " + textServer.Text + ".", "Sweet!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } //end of try

            catch (Exception ex)
            {
                dataGridView1.Rows.Add(currentDateTime, textFrom.Text, textTo.Text, textSubjectFinal, getOptions(), "Error: " + ex.Message, textServer.Text, "");
                columnResize();

                string errorMessage = "Error: " + ex.Message;
                MessagesForm mf = new MessagesForm(errorMessage, "Error (╯°□°)╯︵ ┻━┻", "Close");
                //mf.Show(); //will allow the form to lose focus
                mf.ShowDialog(); //will prevent the form from losing focus
                
            }

            //enable our send button again
            buttonSend.Enabled = true;

            //}
            //MessageBox.Show("done sending all messages");
        }

        private void buttonAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Title = "Browse for attachment";
            browseFile.InitialDirectory = @"c:\";
            browseFile.Filter = "All files (*.*)|*.*";
            browseFile.FilterIndex = 2;
            browseFile.RestoreDirectory = true;

            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                listBoxAttachment.Enabled = true;
                listBoxAttachment.Items.Add(browseFile.FileName);
            }
        }

        private void rbGtube_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbGtube.Checked == true)
            {
                textBody.Text = "XJS*C4JDBQADN1.NSBN3*2IDNEN*GTUBE-STANDARD-ANTI-UBE-TEST-EMAIL*C.34X";
                textBody.Enabled = false;
            }
            else
            {
                textBody.Text = "";
                textBody.Enabled = true;
            }
        }

        private void rbEICAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEICAR.Checked == true)
            {
                //we don't want attachments added if EICAR test selected
                buttonBrowse.Enabled = false;
                listBoxAttachment.Items.Clear();
                listBoxAttachment.Items.Add("eicar.txt");
                groupBoxAttachments.Enabled = false;
            }
            else
            {
                buttonBrowse.Enabled = true;
                groupBoxAttachments.Enabled = true;
                listBoxAttachment.Items.Clear();
            }
        }

        static byte[] GetData()
        {
            //this method just returns some binary data
            string eicar = @"X5O!P%@AP[4\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*"; //eicar string
            byte[] data = Encoding.ASCII.GetBytes(eicar);
            return data;
        }


        private void checkSpecifyP2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSpecifyP2.Checked == true)
            {
                labelFromP2.Enabled = true;
                textFromP2.Enabled = true;
            }
            else
            {
                labelFromP2.Enabled = false;
                textFromP2.Enabled = false;
            }
        }

        private void checkSpecifyReplyTo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSpecifyReplyTo.Checked == true)
            {
                labelReplyTo.Enabled = true;
                textReplyTo.Enabled = true;
            }
            else
            {
                labelReplyTo.Enabled = false;
                textReplyTo.Enabled = false;
            }
        }

        private void checkAddCustomHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAddCustomHeader.Checked == true)
            {
                labelHeader.Enabled = true;
                labelValue.Enabled = true;
                textBoxHeaderX.Enabled = true;
                textBoxHeaderValue.Enabled = true;
            }
            else
            {
                labelHeader.Enabled = false;
                labelValue.Enabled = false;
                textBoxHeaderX.Enabled = false;
                textBoxHeaderValue.Enabled = false;
            }
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if you right click and select "Remove" without selecting an item the program will crash. Write an exception to catch this
            if (listBoxAttachment.SelectedItem != null)
            {
                listBoxAttachment.Items.Remove(listBoxAttachment.SelectedItem.ToString());
            }
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxAttachment.Items.Clear();
        }

        //if user right clicks a cell in dataGridView1, select the whole row
        public void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();

                if (hti.RowIndex != -1) //-1 means that the right click did not happen on a cell
                {
                    dataGridView1.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        //allows user to right click a log entry and delete it. You need to have the row selected,
        //which is accomplished by the above MouseDown event
        private void toolStripMenuDeleteRow_Click(object sender, EventArgs e)
        {
            //check to see if a row is selected. Don't execute this code if no row is selected
            if (dataGridView1.CurrentCell != null)
            {
                Int32 rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[rowIndex].Selected = true;

                Int32 rowToDelete = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);

                if (rowToDelete != -1) //-1 means that there is no row actually selected
                {
                    dataGridView1.Rows.RemoveAt(rowToDelete);
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void toolStripMenuCopyCell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                Clipboard.SetText(dataGridView1.CurrentCell.Value.ToString());
            }
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {            
            AboutForm af = new AboutForm();
            //af.Show(); //will allow the form to lose focus
            af.ShowDialog(); //will prevent the form from losing focus
            e.Cancel = true; //this stops the question mark on the mouse curser from showing after the about box is closed
        }

        private void checkBoxServerName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxServerName.Checked == true)
            {
                textServer.Enabled = true;
            }
            else
            {
                textServer.Enabled = false;
                textServer.Text = "";
            }
        }

        //find MX record for a domain
        public static string getMX(string domain)
        {
            //MX lookups for microsoft.com do not work from inside the Microsoft network. This code will manually set the MX if
            //the recipient is @microsoft.com
            if (domain.ToLower() == "microsoft.com")
            {
                return "microsoft-com.mail.protection.outlook.com";
            }

            string mySubString = "mail exchanger = ";
            string command = "nslookup -type=mx " + domain;
            string result = null;
            int currentRow = 0;
            int mxComingNext = 0;
            int mxPriComingNext = 0;
            int mxCount = 0;

            //Sometimes a DNS query times out the first attempt, but is succesfull after the first. If the first attempt is failed, this for
            //loop will re-run the query a second time. If succesfull the first time this loop will only run once. At most 2 attempts will be made.
            for (int theCount = 0; theCount <= 1; theCount++)
            {

                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                //Console.WriteLine(result);

                //this will count how many instances of "mail exchanger" is in the string. IE. How many MX records are we working with here.
                mxCount = (result.Length - result.ToLower().Replace(mySubString.ToLower(), string.Empty).Length) / mySubString.Length;

                if (mxCount == 0)
                {
                    System.Threading.Thread.Sleep(3000); //pause for 3 seconds and then run loop again
                }
                else
                {
                    theCount = 2; //this will cause the loop to not run a second time
                }
            }

            string[,] mxArray = new string[mxCount, 2];

            foreach (string word in result.Split(' ', '=', '\r', '\n', '\t', ','))
            {
                if (word != "")
                {
                    if (mxPriComingNext == 1)
                    {
                        mxArray[currentRow, 0] = word;
                        mxPriComingNext = 0;
                    }
                    if (mxComingNext == 1)
                    {
                        mxArray[currentRow, 1] = word;
                        mxComingNext = 0;
                        currentRow++;
                    }

                    if (word.ToLower() == "preference")
                    {
                        mxPriComingNext = 1;
                    }
                    if (word.ToLower() == "exchanger")
                    {
                        mxComingNext = 1;
                    }
                }
            }

            int priority = 5000;
            string mxLowestPriority = "";
            //find the MX with the lowest priority
            for (int x = 0; x < mxCount; x++)
            {
                if ((Convert.ToInt32(mxArray[x, 0])) < priority)
                {
                    mxLowestPriority = mxArray[x, 1];
                    priority = Convert.ToInt32(mxArray[x, 0]);
                }
            }
            return mxLowestPriority;
        }

        public string getOptions()
        {
            string selectedOptions = null;

            if (rbGtube.Checked)
            {
                selectedOptions += "Gtube; ";
            }
            if (rbEICAR.Checked)
            {
                selectedOptions += "EICAR; ";
            }
            if (checkForceTLS.Checked)
            {
                selectedOptions += "ForceTLS; ";
            }
            if (checkSpecifyP2.Checked)
            {
                selectedOptions += "Specify P2; ";
            }
            if (checkAddCustomHeader.Checked)
            {
                selectedOptions += "X header; ";
            }
            if ((listBoxAttachment.Items.Count) != 0 && (rbEICAR.Checked == false))
            {
                selectedOptions += "Attachments; ";
            }   
            if (selectedOptions != null)
            {
                //removes the trailing space and comma from the string
                selectedOptions = selectedOptions.TrimEnd(' ', ';');
            }
            else
            {
                selectedOptions = "None";
            }

            return selectedOptions;
        }

        private void checkEnableAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            int buttonLocation;

            //find the height of the title bar
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;

            if (checkEnableAdvanced.Checked == true)
            {
                panel1.Visible = true;

                buttonLocation = panel1.Location.Y + panel1.Height;
                buttonSend.Location = new Point(buttonSend.Location.X, buttonLocation);
                buttonClearLog.Location = new Point(buttonClearLog.Location.X, buttonLocation);
                buttonExportLog.Location = new Point(buttonExportLog.Location.X, buttonLocation);
                buttonSmtpLog.Location = new Point(buttonSmtpLog.Location.X, buttonLocation);

                int heightAdvancedEnabled = buttonSend.Location.Y + buttonSend.Height + titleHeight + (titleHeight / 2);
                this.MaximumSize = new Size(5000000, heightAdvancedEnabled);

                if (checkLog.Checked)
                {
                    this.MinimumSize = new Size(initialViewLogWidth, heightAdvancedEnabled);
                }
                else
                {
                    this.MinimumSize = new Size(startingWidth, heightAdvancedEnabled);
                }
                this.Height = heightAdvancedEnabled;

                dataGridView1.Height = panel1.Location.Y + groupBoxAttachments.Location.Y + groupBoxAttachments.Height - dataGridView1.Location.Y;
            }
            else
            {
                panel1.Visible = false;
                buttonSend.Location = new Point(buttonSend.Location.X, sendButtonStartingLocation);
                buttonClearLog.Location = new Point(buttonClearLog.Location.X, clearLogButtonStartingLocation);
                buttonExportLog.Location = new Point(buttonExportLog.Location.X, exportLogButtonStartingLocation);
                buttonSmtpLog.Location = new Point(buttonSmtpLog.Location.X, smtpLogButtonStartingLocation);

                this.MaximumSize = new Size(5000000, startingHeight);
                this.Height = startingHeight;     
           
                //disable advanced options
                checkSpecifyP2.Checked = false;
                checkAddCustomHeader.Checked = false;
                listBoxAttachment.Items.Clear();

                dataGridView1.Height = initialDataGridHeight;
            }
        }


        private void checkLog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLog.Checked == true)
            {
                //int borderWidth = (this.Width - this.ClientSize.Width);
                int newWidth = initialViewLogWidth;

                this.Width = newWidth;
                this.MinimumSize = new Size(newWidth, this.Height);
                this.MaximumSize = new Size(5000000, this.Height);

                dataGridView1.Width = initialDataGridWidth;
                dataGridView1.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.MinimumSize = new Size(0, 0);
                this.Width = startingWidth;

                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if ((MessageBox.Show("Are you sure you want to clear the log?", "Confirm log clear", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();
                }
            }
        }
        
        private void buttonExportLog_Click(object sender, EventArgs e)
        {            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV  File (*.csv)|*.csv";
            sfd.FileName = "log export.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(dataGridView1, sfd.FileName); 
            }  
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
            {
                if ((j + 1) == dGV.Columns.Count) //ensures there won't be a comma at the end of the row
                {
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText);
                }
                else
                {
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + ",";
                }
            }
                
            stOutput += sHeaders + "\r\n";

            // Export data.
            for (int i = 0; i < dGV.RowCount; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                {
                    if ((j + 1) == dGV.Rows[i].Cells.Count)
                    {
                        stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value);
                    }
                    else
                    {
                        stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + ",";
                    }
                    
                }
                    
                stOutput += stLine + "\r\n";
            }
            try
            {
                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create); //will crash if file exists and is locked, hence the TRY
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file
                bw.Flush();
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Oh snap...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                string errorMessage = "Error: " + ex.Message;
                MessagesForm mf = new MessagesForm(errorMessage, "Error (╯°□°)╯︵ ┻━┻", "Close");
                mf.ShowDialog(); //will prevent the form from losing focus
            }
        }

        /*
        As error messages are often long, the Result column will be made very wide to fit the text.The following code will resize any column that is larger
        than maxDataGridColumnSize, down to the size set in maxDataGridColumnSize
        https://stackoverflow.com/questions/3045805/datagridview-autosize-but-restrict-max-column-size
        */
        private void columnResize()
        {
            //used to resize columns in the DataGrid that are wider then the specified number of pixels
            int maxDataGridColumnSize = 300;

            foreach (DataGridViewColumn columnIdentifier in dataGridView1.Columns)
            {
                if (columnIdentifier.Width > maxDataGridColumnSize)
                {
                    columnIdentifier.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    columnIdentifier.Width = maxDataGridColumnSize;
                }
            }
        }

        //the following is called when a cell in the datagrid is double-clicked
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if statement prevents this code from running if the mouse was double clicked on the header row
            if (e.RowIndex >= 0)
            {

                string cellText = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                
                MessagesForm mf = new MessagesForm(cellText, "Cell contents", "Close");

                //change the window title on the message box that pops up to match the column header of the column that was double clicked
                mf.Text = dataGridView1.Columns[e.ColumnIndex].HeaderText;

                //mf.Show(); //will allow the form to lose focus
                mf.ShowDialog(); //will prevent the form from losing focus
            }
        }

        private void ButtonSmtpLog_Click(object sender, EventArgs e)
        {
            if (File.Exists("smtp.log") == true)
            {
                Process.Start("notepad.exe", "smtp.log");
            }
            else
            {
                MessageBox.Show("Log file not yet created. Please send a message first.", "SMTP Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }
    }
}