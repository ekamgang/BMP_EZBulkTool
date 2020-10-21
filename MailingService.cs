
using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using System.Linq;
using System.Text;

namespace BMP_EZBulkTool
{
    class MailingService
    {

        private static readonly byte[] NoSuchThingExists = { };
        private static readonly char[] preIV = Convert.ToBase64String(Encoding.ASCII.GetBytes(""),Base64FormattingOptions.None).ToCharArray();
        private static readonly byte[] IV = Convert.FromBase64CharArray(preIV, 0, preIV.Length);
        private static readonly string ResumeReceivedEmail = @"<html><head xmlns='http://www.w3.org/1999/xhtml'><base href='https://email05.secureserver.net/'><meta http-equiv='Content-Type' content='text/html; charset=UTF-8'><script>View=window.top.View;</script><link rel='stylesheet' mce_href='https://email05.secureserver.net/js/tinymce/themes/advanced/skins/default/content.css' href='https://email05.secureserver.net/js/tinymce/themes/advanced/skins/default/content.css'><link rel='stylesheet' mce_href='https://email05.secureserver.net/js/tinymce/plugins/spellchecker/css/subject_style.css' href='https://email05.secureserver.net/js/tinymce/plugins/spellchecker/css/subject_style.css'></head><body id='tinymce' class='mceContentBody ' spellcheck='true' dir='ltr' style='color: rgb(0, 0, 0); font-size: 10pt; font-family: verdana, geneva; zoom: 1; background-image: none; background-repeat: repeat; background-position: center center; background-attachment: fixed; height: 279px;'><div><div id='view_body' width='100%' style=''><table cellpadding='0' cellspacing='0' border='0' class='border0_bottom_only wbgContent' width='100%' style=''><tbody style=''><tr style=''><td align='left' style=''><div class='mMessage_user_text_special' style=''><span style=''><div style=''><span style=''><div style=''><span mce_style='font-family: verdana, geneva;' style=''>Hi {0},</span></div><div style=''><span mce_style='font-family: verdana, geneva;' style=''><br style=''></span></div><div style=''><span mce_style='font-family: verdana, geneva;' style=''>Thank you for your interest in Blackmore Partners (BMP); your resume has been received. Given your background and expertise, you are a match for the Private Equity (PE) world. Therefore,&nbsp;</span>your resume will be shared with PE firms.&nbsp;To further understand your area and depth of expertise, BMP will like to invite you to enter on our PE database. Thereafter, BMP will work with you to determine how we can&nbsp;help you transition into the PE industry</div><div style=''><span mce_style='font-family: verdana, geneva;' style=''><br style=''></span></div><div style=''><span mce_style='font-family: verdana, geneva;' style=''>Please, follow the link below to enter into our PE database:</span></div><div style=''><a target='_blank' href='https://bit.ly/36Fxn1C' style=''><span mce_style='font-family: verdana, geneva;' style=''>https://bit.ly/36Fxn1C</span></a></div><div style=''><br style=''></div><div style=''>Check your email, Inbox or Spam junk folder, within 24 hours of entering your information in our system. The confirmation email’s subject is&nbsp;<b style=''><i style=''>Please confirm your email with Blackmore Partners, Inc</i></b><i style=''>.<b style=''>”</b></i></div><div style=''><div class='MsoNormal' style=''><i style=''><b style=''><br style=''></b></i></div><div class='MsoNormal' style=''><span mce_style='font-family: verdana, geneva;' style=''><b style=''>Make sure you click the link to verify your email or we will not be able to move forward in our process.</b><o:p style=''></o:p></span></div><div class='MsoNormal' style=''><span mce_style='font-family: verdana, geneva;' style=''>&nbsp;</span></div><div class='MsoNormal' style=''><span mce_style='font-family: verdana, geneva;' style=''>We look forward to working with you and your transition into the PE industry!</span></div></div><div style=''><br style=''></div><div style=''>Best regards,</div><div style=''><br style=''></div><div style=''>Gerald O'Dwyer</div><div style=''>Managing Director<br style=''>Blackmore Partners</div><div style=''>4802 N. Broadway, Suite 200<br style=''>Chicago, IL 60640<br style=''><a title='www.blackmorepartnersinc.com' href='http://www.blackmorepartnersinc.com/' mce_href='http://www.blackmorepartnersinc.com' target='_blank' style=''>www.blackmorepartnersinc.com</a></div><div style=''><br style=''></div><div style=''><a href='http://blackmorepartnersinc.com/' mce_href='http://blackmorepartnersinc.com/' target='_blank' style=''></a>&nbsp;<a href='https://www.linkedin.com/company/51231/' mce_href='https://www.linkedin.com/company/51231/' target='_blank' style=''></a>&nbsp;<a href='https://www.facebook.com/Blackmore-Partners-Inc-345979222453/?fref=ts' mce_href='https://www.facebook.com/Blackmore-Partners-Inc-345979222453/?fref=ts' target='_blank' style=''></a>&nbsp;<a href='https://www.youtube.com/channel/UC4T-pHQc9v53WTWcp7BzXzw' mce_href='https://www.youtube.com/channel/UC4T-pHQc9v53WTWcp7BzXzw' target='_blank' style=''></a></div></span></div></span></div></td></tr></tbody></table></div><a target='_blank' name='attachments' style=''></a><span style=''></span><table cellpadding='0' cellspacing='0' border='0' class='border0_top_only wbgContent' width='100%' style=''><tbody style=''><tr style=''><td style=''><form target='_blank' name='frm_sendoff' id='frm_sendoff' style=''></form></td></tr></tbody></table></div><div style=''><a href='http://blackmorepartnersinc.com/' mce_href='http://blackmorepartnersinc.com/' target='_blank' style=''></a>&nbsp;<a href='https://www.linkedin.com/company/51231/' mce_href='https://www.linkedin.com/company/51231/' target='_blank' style=''></a>&nbsp;<a href='https://www.facebook.com/Blackmore-Partners-Inc-345979222453/?fref=ts' mce_href='https://www.facebook.com/Blackmore-Partners-Inc-345979222453/?fref=ts' target='_blank' style=''></a>&nbsp;<a href='https://www.youtube.com/channel/UC4T-pHQc9v53WTWcp7BzXzw' mce_href='https://www.youtube.com/channel/UC4T-pHQc9v53WTWcp7BzXzw' target='_blank' style=''></a></div> </body></html>";


        private static readonly string PEGoalsEmail = @"<html><head xmlns='http://www.w3.org/1999/xhtml'><base href='https://email05.secureserver.net/'><meta http-equiv='Content-Type' content='text/html; charset=UTF-8'><script>View=window.top.View;</script><link rel='stylesheet' mce_href='https://email05.secureserver.net/js/tinymce/themes/advanced/skins/default/content.css' href='https://email05.secureserver.net/js/tinymce/themes/advanced/skins/default/content.css'><link rel='stylesheet' mce_href='https://email05.secureserver.net/js/tinymce/plugins/spellchecker/css/subject_style.css' href='https://email05.secureserver.net/js/tinymce/plugins/spellchecker/css/subject_style.css'></head><body id='tinymce' class='mceContentBody ' spellcheck='true' dir='ltr' style='color: rgb(0, 0, 0); font-size: 10pt; font-family: verdana, geneva; zoom: 1; background-image: none; background-repeat: repeat; background-position: center center; background-attachment: fixed; height: 279px;'><div style=''><font face='verdana, geneva' style=''>Dear {0}</font>,</div><div style=''><font face='verdana, geneva' style=''><br style=''></font></div><div style=''><font face='verdana, geneva' style=''>We have reviewed your qualifications and you are an ideal candidate to position yourself as a highly valuable asset with private equity decision makers. I am eager to engage in a conversation to discuss your goals and how Blackmore Partners, Inc. can drive you forward in the realization of those goals.</font></div><div style=''><font face='verdana, geneva' style=''><br style=''></font></div><div style=''>Please use&nbsp;<a target='_blank' href='https://is-tracking-link-api-prod.appspot.com/api/v1/click/5816670688378880/5840830282072064' style=''>this link</a>&nbsp;to select an optimal date &amp; time for us to have a conversation.</div><div style=''><br></div><div>Best regards,</div><div><br></div><div>Gerald O'Dwyer</div><div>Managing Director <br>Blackmore Partners</div><div>4802 N. Broadway, Suite 200<br>Chicago, IL 60640 <br><a title='www.blackmorepartnersinc.com' href='http://www.blackmorepartnersinc.com' mce_href='http://www.blackmorepartnersinc.com' target='_blank'>www.blackmorepartnersinc.com</a></div><div><br></div><div><a href='http://blackmorepartnersinc.com/' mce_href='http://blackmorepartnersinc.com/' target='_blank'><img onload='View.inlineImageLoaded(this,undefined,false)' id='sigimg0' title='signature image' src='/compose.php?inline_key=5f906e6f00ecd' mce_src='/compose.php?inline_key=5f906e6f00ecd' border='0' alt='' wbeuser='geraldodwyer@blackmorepartnersinc.com'></a>&nbsp;<a href='https://www.linkedin.com/company/51231/' mce_href='https://www.linkedin.com/company/51231/' target='_blank'><img onload='View.inlineImageLoaded(this,undefined,false)' id='sigimg1' title='signature image' src='/compose.php?inline_key=5f906e6f0bffa' mce_src='/compose.php?inline_key=5f906e6f0bffa' border='0' alt='' wbeuser='geraldodwyer@blackmorepartnersinc.com'></a>&nbsp;<a href='https://www.facebook.com/Blackmore-Partners-Inc-345979222453/?fref=ts' mce_href='https://www.facebook.com/Blackmore-Partners-Inc-345979222453/?fref=ts' target='_blank'><img onload='View.inlineImageLoaded(this,undefined,false)' id='sigimg2' title='signature image' src='/compose.php?inline_key=5f906e6f16e99' mce_src='/compose.php?inline_key=5f906e6f16e99' border='0' alt='' wbeuser='geraldodwyer@blackmorepartnersinc.com'></a>&nbsp;<a href='https://www.youtube.com/channel/UC4T-pHQc9v53WTWcp7BzXzw' mce_href='https://www.youtube.com/channel/UC4T-pHQc9v53WTWcp7BzXzw' target='_blank'><img onload='View.inlineImageLoaded(this,undefined,false)' id='sigimg3' title='signature image' src='/compose.php?inline_key=5f906e6f219e7' mce_src='/compose.php?inline_key=5f906e6f219e7' border='0' alt='' wbeuser='geraldodwyer@blackmorepartnersinc.com'></a></div></body></html>";


        private static readonly string FromAddress = "geraldodwyer@blackmorepartnersinc.com";
        private static readonly string outGoingServer = "smtpout.secureserver.net";
        private static readonly int outGoingPort = 465;
        private static string specialKey; //For later
        private static readonly char[] PreCombined = Convert.ToBase64String(Encoding.ASCII.GetBytes(""), Base64FormattingOptions.None).ToCharArray();
        private static readonly byte[] Combined = Convert.FromBase64CharArray(PreCombined, 0, PreCombined.Length);


        private ListView.ListViewItemCollection Items;
        private string pass;
        /// <summary>
        /// Constructor
        /// </summary>
        public MailingService()
        {
            //var ret = this.EncryptStringToBytes("$!#REFchi28", Combined, IV);

            var ret2 = this.DecryptStringFromBytes_Aes(NoSuchThingExists, Combined, IV);
            this.pass = ret2;
            return;
        }

        /*
        public byte[] EncryptStringToBytes(string plaintext, byte[] key, byte[] IV)
        {
            byte[] encrypted;
            using (AesCryptoServiceProvider aesalg = new AesCryptoServiceProvider())
            {
                aesalg.IV = IV;
                aesalg.Key = key;
                
                ICryptoTransform encrypto  = aesalg.CreateEncryptor(aesalg.Key, aesalg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt,encrypto,CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }
        */

        public string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an AesCryptoServiceProvider object
            // with the specified key and IV.
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        public void loadListViewItems(ListView.ListViewItemCollection items)
        {
            this.Items = items;
            return;
        }

        public async Task SendEmails()
        {
            foreach (ListViewItem item in Items)
            {
                switch(item.SubItems[2].Text)
                {
                    case "Resume":
                        await SendResumeEmail(item);
                        break;
                    case "Meeting":
                        await SendPEEmail(item);
                        break;
                    case "BOTH":
                        await SendBothEmails(item);
                        break;
                }
            }
        }


        private async Task<bool> SendResumeEmail(ListViewItem item)
        {
            try
            {
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        var MailMessage = new MimeMessage();
                        MailMessage.From.Add(new MailboxAddress("Gerald O'Dwyer", FromAddress));
                        MailMessage.To.Add(new MailboxAddress(item.Name, item.SubItems[1].Text));
                        MailMessage.Subject = "Blackmore Partners- Resume Received";

                        MailMessage.Body = new TextPart("html")
                        {
                            Text = String.Format(ResumeReceivedEmail, item.Text)
                        };

                        using (var smtpClient = new SmtpClient())
                        {
                            smtpClient.Connect(outGoingServer, outGoingPort, true);
                            smtpClient.Authenticate(FromAddress, pass);
                            smtpClient.Send(MailMessage);
                            smtpClient.Disconnect(true);
                        }
                        return;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                });



                thread.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        private async Task<bool> SendPEEmail(ListViewItem item)
        {
            try
            {
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        var MailMessage = new MimeMessage();
                        MailMessage.From.Add(new MailboxAddress("Gerald O'Dwyer", FromAddress));
                        MailMessage.To.Add(new MailboxAddress(item.Name, item.SubItems[1].Text));
                        MailMessage.Subject = "Discuss Your PE Goals";

                        MailMessage.Body = new TextPart("html")
                        {
                            Text = String.Format(PEGoalsEmail, item.Text)
                        };

                        using (var smtpClient = new SmtpClient())
                        {
                            smtpClient.Connect(outGoingServer, outGoingPort, true);
                            smtpClient.Authenticate(FromAddress, pass);
                            smtpClient.Send(MailMessage);
                            smtpClient.Disconnect(true);
                        }
                        return;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                    
                });



                thread.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        private async Task<bool> SendBothEmails(ListViewItem item)
        {
            return (await SendPEEmail(item)) && (await SendResumeEmail(item));

        }
    }
}
